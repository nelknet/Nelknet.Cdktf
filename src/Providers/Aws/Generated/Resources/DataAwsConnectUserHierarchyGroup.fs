namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectUserHierarchyGroupState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectUserHierarchyGroup.DataAwsConnectUserHierarchyGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_group">aws_connect_user_hierarchy_group</a>.
    /// </summary>
    type DataAwsConnectUserHierarchyGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectUserHierarchyGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectUserHierarchyGroupState<Missing>)

        member _.Zero(()) : DataAwsConnectUserHierarchyGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectUserHierarchyGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_group#instance_id-1">DataAwsConnectUserHierarchyGroup#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectUserHierarchyGroupState<Missing>, value: string) : DataAwsConnectUserHierarchyGroupState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectUserHierarchyGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_group#hierarchy_group_id-1">DataAwsConnectUserHierarchyGroup#hierarchy_group_id</a>.
        /// </summary>
        [<CustomOperation "hierarchy_group_id">]
        member _.HierarchyGroupId(state: DataAwsConnectUserHierarchyGroupState<'InstanceId>, value: string) : DataAwsConnectUserHierarchyGroupState<'InstanceId> =
            state.assignments.Add(fun config -> config.HierarchyGroupId <- value)
            state : DataAwsConnectUserHierarchyGroupState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_group#id-1">DataAwsConnectUserHierarchyGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectUserHierarchyGroupState<'InstanceId>, value: string) : DataAwsConnectUserHierarchyGroupState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectUserHierarchyGroupState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_group#name-1">DataAwsConnectUserHierarchyGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectUserHierarchyGroupState<'InstanceId>, value: string) : DataAwsConnectUserHierarchyGroupState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectUserHierarchyGroupState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_group#tags-1">DataAwsConnectUserHierarchyGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectUserHierarchyGroupState<'InstanceId>, value: seq<string * string>) : DataAwsConnectUserHierarchyGroupState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectUserHierarchyGroupState<'InstanceId>

        member _.Run(state: DataAwsConnectUserHierarchyGroupState<Present>) : aws.DataAwsConnectUserHierarchyGroup.DataAwsConnectUserHierarchyGroup =
            let config = aws.DataAwsConnectUserHierarchyGroup.DataAwsConnectUserHierarchyGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectUserHierarchyGroup.DataAwsConnectUserHierarchyGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectUserHierarchyGroup: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectUserHierarchyGroupState<_>) : aws.DataAwsConnectUserHierarchyGroup.DataAwsConnectUserHierarchyGroup =
            Unchecked.defaultof<aws.DataAwsConnectUserHierarchyGroup.DataAwsConnectUserHierarchyGroup>
