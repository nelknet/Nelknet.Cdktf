namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourcegroupsGroupState<'Name> = { assignments: ResizeArray<aws.ResourcegroupsGroup.ResourcegroupsGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group">aws_resourcegroups_group</a>.
    /// </summary>
    type ResourcegroupsGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourcegroupsGroupState<Missing> =
            ({ assignments = ResizeArray() } : ResourcegroupsGroupState<Missing>)

        member _.Zero(()) : ResourcegroupsGroupState<Missing> =
            ({ assignments = ResizeArray() } : ResourcegroupsGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#name-1">ResourcegroupsGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourcegroupsGroupState<Missing>, value: string) : ResourcegroupsGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourcegroupsGroupState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#configuration-1">ResourcegroupsGroup#configuration</a> Accepts: aws.IResolvable | aws.ResourcegroupsGroup.ResourcegroupsGroupConfiguration[]
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: ResourcegroupsGroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : ResourcegroupsGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#description-1">ResourcegroupsGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ResourcegroupsGroupState<'Name>, value: string) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ResourcegroupsGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#id-1">ResourcegroupsGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourcegroupsGroupState<'Name>, value: string) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourcegroupsGroupState<'Name>

        /// <summary>
        /// resource_query block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#resource_query-1">ResourcegroupsGroup#resource_query</a>
        /// </summary>
        [<CustomOperation "resource_query">]
        member _.ResourceQuery(state: ResourcegroupsGroupState<'Name>, value: aws.ResourcegroupsGroup.ResourcegroupsGroupResourceQuery) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.ResourceQuery <- value)
            state : ResourcegroupsGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#tags-1">ResourcegroupsGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ResourcegroupsGroupState<'Name>, value: seq<string * string>) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ResourcegroupsGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#tags_all-1">ResourcegroupsGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ResourcegroupsGroupState<'Name>, value: seq<string * string>) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ResourcegroupsGroupState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#timeouts-1">ResourcegroupsGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourcegroupsGroupState<'Name>, value: aws.ResourcegroupsGroup.ResourcegroupsGroupTimeouts) : ResourcegroupsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourcegroupsGroupState<'Name>

        member _.Run(state: ResourcegroupsGroupState<Present>) : aws.ResourcegroupsGroup.ResourcegroupsGroup =
            let config = aws.ResourcegroupsGroup.ResourcegroupsGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ResourcegroupsGroup.ResourcegroupsGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.resourcegroupsGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ResourcegroupsGroupState<_>) : aws.ResourcegroupsGroup.ResourcegroupsGroup =
            Unchecked.defaultof<aws.ResourcegroupsGroup.ResourcegroupsGroup>
