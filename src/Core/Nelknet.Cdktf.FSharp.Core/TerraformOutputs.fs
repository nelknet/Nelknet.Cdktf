namespace Nelknet.Cdktf.FSharp

open HashiCorp.Cdktf

module Terraform =
    type OutputBuilder(logicalId: string) =
        let mutable valueSetter = None
        let mutable descriptionSetter = None
        let mutable sensitiveSetter = None

        member _.Yield(()) = ()
        member _.Zero() = ()

        [<CustomOperation("value")>]
        member _.Value((), value: obj) =
            valueSetter <- Some value
            ()

        [<CustomOperation("description")>]
        member _.Description((), description: string) =
            descriptionSetter <- Some description
            ()

        [<CustomOperation("sensitive")>]
        member _.Sensitive((), sensitive: bool) =
            sensitiveSetter <- Some sensitive
            ()

        member _.Run(()) =
            let stack = StackContext.get()
            let config = TerraformOutputConfig()

            match valueSetter with
            | Some value -> config.Value <- value
            | None -> invalidArg "value" "Output requires a value."

            descriptionSetter |> Option.iter (fun v -> config.Description <- v)
            sensitiveSetter |> Option.iter (fun v -> config.Sensitive <- System.Nullable(v))

            TerraformOutput(stack, logicalId, config)

    let output logicalId = OutputBuilder(logicalId)
