namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectUserHierarchyGroupState<'InstanceId, 'Name> = { assignments: ResizeArray<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group">aws_connect_user_hierarchy_group</a>.
    /// </summary>
    type ConnectUserHierarchyGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectUserHierarchyGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectUserHierarchyGroupState<Missing, Missing>)

        member _.Zero(()) : ConnectUserHierarchyGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectUserHierarchyGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group#instance_id-1">ConnectUserHierarchyGroup#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectUserHierarchyGroupState<Missing, 'Name>, value: string) : ConnectUserHierarchyGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectUserHierarchyGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group#name-1">ConnectUserHierarchyGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectUserHierarchyGroupState<'InstanceId, Missing>, value: string) : ConnectUserHierarchyGroupState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectUserHierarchyGroupState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group#id-1">ConnectUserHierarchyGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectUserHierarchyGroupState<'InstanceId, 'Name>, value: string) : ConnectUserHierarchyGroupState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectUserHierarchyGroupState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group#parent_group_id-1">ConnectUserHierarchyGroup#parent_group_id</a>.
        /// </summary>
        [<CustomOperation "parent_group_id">]
        member _.ParentGroupId(state: ConnectUserHierarchyGroupState<'InstanceId, 'Name>, value: string) : ConnectUserHierarchyGroupState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.ParentGroupId <- value)
            state : ConnectUserHierarchyGroupState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group#tags-1">ConnectUserHierarchyGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectUserHierarchyGroupState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectUserHierarchyGroupState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectUserHierarchyGroupState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_group#tags_all-1">ConnectUserHierarchyGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectUserHierarchyGroupState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectUserHierarchyGroupState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectUserHierarchyGroupState<'InstanceId, 'Name>

        member _.Run(state: ConnectUserHierarchyGroupState<Present, Present>) : aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroup =
            let config = aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectUserHierarchyGroup: missing required arguments. Must call: instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectUserHierarchyGroupState<_, _>) : aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroup =
            Unchecked.defaultof<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroup>
