namespace Nelknet.Cdktf.FSharp

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

module BuilderInternals =
    open System.Collections.Generic
    open System.Reflection

    let apply (assignments: ResizeArray<string * obj>) (target: 'T) =
        let targetType = typeof<'T>

        for (name, value) in assignments do
            match targetType.GetProperty(name, BindingFlags.Instance ||| BindingFlags.Public) with
            | null ->
                invalidArg (nameof name) $"Property '{name}' was not found on type '{targetType.FullName}'."
            | prop ->
                prop.SetValue(target, value)

[<AutoOpen>]
module StackDsl =
    /// Entry point computation expression for defining a Terraform CDK stack.
    type StackBuilder(stackName: string) =
        member _.Return(_: unit) = fun () -> ()
        member _.ReturnFrom(fn: unit -> unit) = fn

        member _.Delay(generator: unit -> 'T) =
            fun () ->
                generator() |> ignore

        member _.Combine(first: unit -> unit, second: unit -> unit) =
            fun () ->
                first()
                second()

        member _.Zero() = fun () -> ()

        member _.Run(body: unit -> unit) =
            let app = App()
            let stack = TerraformStack(app, stackName)

            StackContext.set stack
            try
                body()
            finally
                StackContext.clear()

            app.Synth()
            app

    /// Starts a new stack computation expression.
    let stack name = StackBuilder(name)

    /// Gives access to the underlying TerraformApp and TerraformStack where needed.
    module Stack =
        let current () = StackContext.get()
