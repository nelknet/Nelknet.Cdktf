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

[<AutoOpen>]
module StackDsl =
    /// Entry point computation expression for defining a Terraform CDK stack.
    type StackBuilder(stackName: string) =
        member _.Return(_: unit) : (unit -> unit) = fun () -> ()
        member _.ReturnFrom(fn: unit -> unit) : (unit -> unit) = fn

        member _.Delay(generator: unit -> 'T) : (unit -> unit) =
            fun () ->
                generator() |> ignore

        member _.Combine(first: unit -> unit, second: unit -> unit) : (unit -> unit) =
            fun () ->
                first()
                second()

        member _.Zero() : (unit -> unit) = fun () -> ()

        member _.Run(body: unit -> unit) : App =
            let app = App()
            let stack = TerraformStack(app, stackName)

            StackContext.set stack
            try
                body()
            finally
                StackContext.clear()

            app

    /// Starts a new stack computation expression.
    let stack name = StackBuilder(name)

    /// Gives access to the underlying TerraformApp and TerraformStack where needed.
    module Stack =
        let current () = StackContext.get()

namespace Nelknet.Cdktf.Internal

/// Marker types used by generated builders to track required arguments.
type Present = Present
type Missing = Missing
