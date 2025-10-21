namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotThingTypeState<'Name> = { assignments: ResizeArray<aws.IotThingType.IotThingTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type">aws_iot_thing_type</a>.
    /// </summary>
    type IotThingTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotThingTypeState<Missing> =
            ({ assignments = ResizeArray() } : IotThingTypeState<Missing>)

        member _.Zero(()) : IotThingTypeState<Missing> =
            ({ assignments = ResizeArray() } : IotThingTypeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#name-1">IotThingType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotThingTypeState<Missing>, value: string) : IotThingTypeState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotThingTypeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#deprecated-1">IotThingType#deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deprecated">]
        member _.Deprecated(state: IotThingTypeState<'Name>, value: bool) : IotThingTypeState<'Name> =
            state.assignments.Add(fun config -> config.Deprecated <- value)
            state : IotThingTypeState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#deprecated-1">IotThingType#deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deprecated">]
        member _.Deprecated(state: IotThingTypeState<'Name>, value: HashiCorp.Cdktf.IResolvable) : IotThingTypeState<'Name> =
            state.assignments.Add(fun config -> config.Deprecated <- value)
            state : IotThingTypeState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#id-1">IotThingType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotThingTypeState<'Name>, value: string) : IotThingTypeState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotThingTypeState<'Name>

        /// <summary>
        /// properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#properties-1">IotThingType#properties</a>
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: IotThingTypeState<'Name>, value: aws.IotThingType.IotThingTypeProperties) : IotThingTypeState<'Name> =
            state.assignments.Add(fun config -> config.Properties <- value)
            state : IotThingTypeState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#tags-1">IotThingType#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotThingTypeState<'Name>, value: seq<string * string>) : IotThingTypeState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotThingTypeState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_type#tags_all-1">IotThingType#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotThingTypeState<'Name>, value: seq<string * string>) : IotThingTypeState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotThingTypeState<'Name>

        member _.Run(state: IotThingTypeState<Present>) : aws.IotThingType.IotThingType =
            let config = aws.IotThingType.IotThingTypeConfig()
            for setter in state.assignments do
                setter config
            aws.IotThingType.IotThingType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotThingType: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IotThingTypeState<_>) : aws.IotThingType.IotThingType =
            Unchecked.defaultof<aws.IotThingType.IotThingType>
