namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotThingState<'Name> = { assignments: ResizeArray<aws.IotThing.IotThingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing">aws_iot_thing</a>.
    /// </summary>
    type IotThingBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotThingState<Missing> =
            ({ assignments = ResizeArray() } : IotThingState<Missing>)

        member _.Zero(()) : IotThingState<Missing> =
            ({ assignments = ResizeArray() } : IotThingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing#name-1">IotThing#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotThingState<Missing>, value: string) : IotThingState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotThingState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing#attributes-1">IotThing#attributes</a>.
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: IotThingState<'Name>, value: seq<string * string>) : IotThingState<'Name> =
            state.assignments.Add(fun config -> config.Attributes <- dict value)
            state : IotThingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing#id-1">IotThing#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotThingState<'Name>, value: string) : IotThingState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotThingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing#thing_type_name-1">IotThing#thing_type_name</a>.
        /// </summary>
        [<CustomOperation "thing_type_name">]
        member _.ThingTypeName(state: IotThingState<'Name>, value: string) : IotThingState<'Name> =
            state.assignments.Add(fun config -> config.ThingTypeName <- value)
            state : IotThingState<'Name>

        member _.Run(state: IotThingState<Present>) : aws.IotThing.IotThing =
            let config = aws.IotThing.IotThingConfig()
            for setter in state.assignments do
                setter config
            aws.IotThing.IotThing(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotThing: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IotThingState<_>) : aws.IotThing.IotThing =
            Unchecked.defaultof<aws.IotThing.IotThing>
