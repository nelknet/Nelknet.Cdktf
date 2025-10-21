namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName> = { assignments: ResizeArray<aws.DataAwsEksNodeGroup.DataAwsEksNodeGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_group">aws_eks_node_group</a>.
    /// </summary>
    type DataAwsEksNodeGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksNodeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksNodeGroupState<Missing, Missing>)

        member _.Zero(()) : DataAwsEksNodeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksNodeGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_group#cluster_name-1">DataAwsEksNodeGroup#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAwsEksNodeGroupState<Missing, 'NodeGroupName>, value: string) : DataAwsEksNodeGroupState<Present, 'NodeGroupName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAwsEksNodeGroupState<Present, 'NodeGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_group#node_group_name-1">DataAwsEksNodeGroup#node_group_name</a>.
        /// </summary>
        [<CustomOperation "node_group_name">]
        member _.NodeGroupName(state: DataAwsEksNodeGroupState<'ClusterName, Missing>, value: string) : DataAwsEksNodeGroupState<'ClusterName, Present> =
            state.assignments.Add(fun config -> config.NodeGroupName <- value)
            ({ assignments = state.assignments } : DataAwsEksNodeGroupState<'ClusterName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_group#id-1">DataAwsEksNodeGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName>, value: string) : DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_group#tags-1">DataAwsEksNodeGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName>, value: seq<string * string>) : DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEksNodeGroupState<'ClusterName, 'NodeGroupName>

        member _.Run(state: DataAwsEksNodeGroupState<Present, Present>) : aws.DataAwsEksNodeGroup.DataAwsEksNodeGroup =
            let config = aws.DataAwsEksNodeGroup.DataAwsEksNodeGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksNodeGroup.DataAwsEksNodeGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksNodeGroup: missing required arguments. Must call: cluster_name, node_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksNodeGroupState<_, _>) : aws.DataAwsEksNodeGroup.DataAwsEksNodeGroup =
            Unchecked.defaultof<aws.DataAwsEksNodeGroup.DataAwsEksNodeGroup>
