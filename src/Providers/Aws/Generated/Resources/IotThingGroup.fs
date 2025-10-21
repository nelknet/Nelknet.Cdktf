namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotThingGroupState<'Name> = { assignments: ResizeArray<aws.IotThingGroup.IotThingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group">aws_iot_thing_group</a>.
    /// </summary>
    type IotThingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotThingGroupState<Missing> =
            ({ assignments = ResizeArray() } : IotThingGroupState<Missing>)

        member _.Zero(()) : IotThingGroupState<Missing> =
            ({ assignments = ResizeArray() } : IotThingGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#name-1">IotThingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotThingGroupState<Missing>, value: string) : IotThingGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotThingGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#id-1">IotThingGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotThingGroupState<'Name>, value: string) : IotThingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotThingGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#parent_group_name-1">IotThingGroup#parent_group_name</a>.
        /// </summary>
        [<CustomOperation "parent_group_name">]
        member _.ParentGroupName(state: IotThingGroupState<'Name>, value: string) : IotThingGroupState<'Name> =
            state.assignments.Add(fun config -> config.ParentGroupName <- value)
            state : IotThingGroupState<'Name>

        /// <summary>
        /// properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#properties-1">IotThingGroup#properties</a>
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: IotThingGroupState<'Name>, value: aws.IotThingGroup.IotThingGroupProperties) : IotThingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Properties <- value)
            state : IotThingGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#tags-1">IotThingGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotThingGroupState<'Name>, value: seq<string * string>) : IotThingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotThingGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#tags_all-1">IotThingGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotThingGroupState<'Name>, value: seq<string * string>) : IotThingGroupState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotThingGroupState<'Name>

        member _.Run(state: IotThingGroupState<Present>) : aws.IotThingGroup.IotThingGroup =
            let config = aws.IotThingGroup.IotThingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.IotThingGroup.IotThingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotThingGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IotThingGroupState<_>) : aws.IotThingGroup.IotThingGroup =
            Unchecked.defaultof<aws.IotThingGroup.IotThingGroup>
