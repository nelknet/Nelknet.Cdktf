namespace Nelknet.Cdktf

open System
open System.Threading
open HashiCorp.Cdktf

/// Internal ambient stack storage used while the stack computation expression is running.
module StackContext =
    let private current = AsyncLocal<TerraformStack>()

    let set stack =
        current.Value <- stack

    let clear () =
        current.Value <- null

    let get () =
        match current.Value with
        | null -> invalidOp "No active Terraform stack. Make sure you're running inside the stack computation expression."
        | stack -> stack

/// Represents an effect that runs within the active Terraform stack and produces a value.
type StackAction<'T> =
    private
    | StackAction of (unit -> 'T)

/// Helpers for composing and transforming stack actions.
[<RequireQualifiedAccess>]
module StackAction =
    let ofFunc (thunk: unit -> 'T) : StackAction<'T> =
        StackAction thunk

    let effect (thunk: unit -> 'T) : StackAction<'T> =
        ofFunc thunk

    let run (action: StackAction<'T>) : 'T =
        let (StackAction invoke) = action
        invoke()

    let map (mapper: 'T -> 'U) (action: StackAction<'T>) : StackAction<'U> =
        StackAction(fun () -> action |> run |> mapper)

    let bind (binder: 'T -> StackAction<'U>) (action: StackAction<'T>) : StackAction<'U> =
        StackAction(fun () ->
            let value = action |> run
            binder value |> run)

    let ignore (action: StackAction<'T>) : StackAction<unit> =
        StackAction(fun () ->
            action |> run |> Microsoft.FSharp.Core.Operators.ignore)

    let forEach (source: seq<'T>) (body: 'T -> StackAction<'U>) : StackAction<unit> =
        StackAction(fun () ->
            for value in source do
                body value |> run |> Microsoft.FSharp.Core.Operators.ignore)

    let forEachThunk (source: seq<'T>) (body: 'T -> unit) : StackAction<unit> =
        StackAction(fun () ->
            for value in source do
                body value)

    let collect (source: seq<'T>) (factory: 'T -> StackAction<'U>) : StackAction<'U list> =
        StackAction(fun () ->
            let results = ResizeArray<'U>()
            for value in source do
                results.Add(factory value |> run)
            List.ofSeq results)

    let sequence (actions: seq<StackAction<'T>>) : StackAction<'T list> =
        StackAction(fun () ->
            let results = ResizeArray<'T>()
            for action in actions do
                results.Add(action |> run)
            List.ofSeq results)

/// Result of running a stack computation. Wraps the underlying Terraform App and Stack along with the final value.
type StackApplication<'T>(app: App, stack: TerraformStack, result: 'T) =
    member _.App = app
    member _.TerraformStack = stack
    member _.Result = result

    member _.Synth() = app.Synth()
    member _.Synthesize() = app.Synth()

[<AutoOpen>]
module StackDsl =
    /// Entry point computation expression for defining a Terraform CDK stack.
    type StackBuilder(stackName: string) =
        member _.Return(value: 'T) : StackAction<'T> =
            StackAction.ofFunc(fun () -> value)

        member _.ReturnFrom(action: StackAction<'T>) : StackAction<'T> =
            action

        member _.ReturnFrom(thunk: unit -> 'T) : StackAction<'T> =
            StackAction.ofFunc thunk

        member _.Bind(action: StackAction<'T>, binder: 'T -> StackAction<'U>) : StackAction<'U> =
            StackAction.ofFunc(fun () ->
                let value = StackAction.run action
                binder value |> StackAction.run)

        member this.Bind(thunk: unit -> 'T, binder: 'T -> StackAction<'U>) : StackAction<'U> =
            this.Bind(StackAction.ofFunc thunk, binder)

        member _.Bind(value: 'T, binder: 'T -> StackAction<'U>) : StackAction<'U> =
            binder value

        member _.Zero() : StackAction<unit> =
            StackAction.ofFunc(fun () -> ())

        member _.Delay(generator: unit -> StackAction<'T>) : StackAction<'T> =
            StackAction.ofFunc(fun () -> generator() |> StackAction.run)

        member _.Combine(first: StackAction<unit>, second: StackAction<'T>) : StackAction<'T> =
            StackAction.ofFunc(fun () ->
                first |> StackAction.run
                second |> StackAction.run)

        member _.Combine(first: StackAction<unit>, second: unit -> StackAction<'T>) : StackAction<'T> =
            StackAction.ofFunc(fun () ->
                first |> StackAction.run
                second() |> StackAction.run)

        member this.While(guard: unit -> bool, body: StackAction<unit>) : StackAction<unit> =
            StackAction.ofFunc(fun () ->
                while guard() do
                    body |> StackAction.run)

        member this.While(guard: unit -> bool, body: unit -> unit) : StackAction<unit> =
            this.While(guard, StackAction.ofFunc body)

        member this.For(source: seq<'T>, body: 'T -> StackAction<'U>) : StackAction<unit> =
            StackAction.forEach source body

        member this.For(source: seq<'T>, body: 'T -> unit) : StackAction<unit> =
            this.For(source, fun value -> StackAction.ofFunc(fun () -> body value))

        member _.Using(resource: 'T, binder: 'T -> StackAction<'U>) : StackAction<'U> when 'T :> IDisposable =
            StackAction.ofFunc(fun () ->
                match box resource with
                | null -> binder resource |> StackAction.run
                | _ ->
                    use disposable = resource
                    binder disposable |> StackAction.run)

        member _.TryFinally(body: StackAction<'T>, compensation: unit -> unit) : StackAction<'T> =
            StackAction.ofFunc(fun () ->
                try
                    body |> StackAction.run
                finally
                    compensation())

        member _.TryFinally(thunk: unit -> 'T, compensation: unit -> unit) : StackAction<'T> =
            StackAction.ofFunc(fun () ->
                try
                    thunk()
                finally
                    compensation())

        member _.TryWith(body: StackAction<'T>, handler: exn -> StackAction<'T>) : StackAction<'T> =
            StackAction.ofFunc(fun () ->
                try
                    body |> StackAction.run
                with ex ->
                    handler ex |> StackAction.run)

        member _.TryWith(thunk: unit -> 'T, handler: exn -> StackAction<'T>) : StackAction<'T> =
            StackAction.ofFunc(fun () ->
                try
                    thunk()
                with ex ->
                    handler ex |> StackAction.run)

        member _.Yield(value: 'T) : StackAction<'T> =
            StackAction.ofFunc(fun () -> value)

        member _.YieldFrom(action: StackAction<'T>) : StackAction<'T> =
            action

        member _.YieldFrom(thunk: unit -> 'T) : StackAction<'T> =
            StackAction.ofFunc thunk

        member _.Run(body: StackAction<'T>) : StackApplication<'T> =
            let app = App()
            let stack = TerraformStack(app, stackName)

            StackContext.set stack
            try
                let result = body |> StackAction.run
                StackApplication(app, stack, result)
            finally
                StackContext.clear()

    /// Starts a new stack computation expression.
    let stack name = StackBuilder(name)

    /// Gives access to helpers scoped to the active stack.
    module Stack =
        let current () = StackContext.get()

        let forEach (source: seq<'T>) (body: 'T -> StackAction<unit>) : StackAction<unit> =
            StackAction.forEach source body

        let forEachThunk (source: seq<'T>) (body: 'T -> unit) : StackAction<unit> =
            StackAction.forEachThunk source body

        let collect (source: seq<'T>) (factory: 'T -> StackAction<'U>) : StackAction<'U list> =
            StackAction.collect source factory

        let sequence (actions: seq<StackAction<'T>>) : StackAction<'T list> =
            StackAction.sequence actions

        let action (thunk: unit -> 'T) : StackAction<'T> =
            StackAction.ofFunc thunk

namespace Nelknet.Cdktf.Internal

/// Marker types used by generated builders to track required arguments.
type Present = Present
type Missing = Missing
