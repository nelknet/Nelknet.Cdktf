namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksNodeGroupsState<'ClusterName> = { assignments: ResizeArray<aws.DataAwsEksNodeGroups.DataAwsEksNodeGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_groups">aws_eks_node_groups</a>.
    /// </summary>
    type DataAwsEksNodeGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksNodeGroupsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksNodeGroupsState<Missing>)

        member _.Zero(()) : DataAwsEksNodeGroupsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksNodeGroupsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_groups#cluster_name-1">DataAwsEksNodeGroups#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAwsEksNodeGroupsState<Missing>, value: string) : DataAwsEksNodeGroupsState<Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAwsEksNodeGroupsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_node_groups#id-1">DataAwsEksNodeGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksNodeGroupsState<'ClusterName>, value: string) : DataAwsEksNodeGroupsState<'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksNodeGroupsState<'ClusterName>

        member _.Run(state: DataAwsEksNodeGroupsState<Present>) : aws.DataAwsEksNodeGroups.DataAwsEksNodeGroups =
            let config = aws.DataAwsEksNodeGroups.DataAwsEksNodeGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksNodeGroups.DataAwsEksNodeGroups(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksNodeGroups: missing required arguments. Must call: cluster_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksNodeGroupsState<_>) : aws.DataAwsEksNodeGroups.DataAwsEksNodeGroups =
            Unchecked.defaultof<aws.DataAwsEksNodeGroups.DataAwsEksNodeGroups>
