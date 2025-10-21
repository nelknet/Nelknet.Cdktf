namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcsClusterState<'ClusterName> = { assignments: ResizeArray<aws.DataAwsEcsCluster.DataAwsEcsClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_cluster">aws_ecs_cluster</a>.
    /// </summary>
    type DataAwsEcsClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcsClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsClusterState<Missing>)

        member _.Zero(()) : DataAwsEcsClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_cluster#cluster_name-1">DataAwsEcsCluster#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAwsEcsClusterState<Missing>, value: string) : DataAwsEcsClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAwsEcsClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_cluster#id-1">DataAwsEcsCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcsClusterState<'ClusterName>, value: string) : DataAwsEcsClusterState<'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcsClusterState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_cluster#tags-1">DataAwsEcsCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEcsClusterState<'ClusterName>, value: seq<string * string>) : DataAwsEcsClusterState<'ClusterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEcsClusterState<'ClusterName>

        member _.Run(state: DataAwsEcsClusterState<Present>) : aws.DataAwsEcsCluster.DataAwsEcsCluster =
            let config = aws.DataAwsEcsCluster.DataAwsEcsClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcsCluster.DataAwsEcsCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcsCluster: missing required arguments. Must call: cluster_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcsClusterState<_>) : aws.DataAwsEcsCluster.DataAwsEcsCluster =
            Unchecked.defaultof<aws.DataAwsEcsCluster.DataAwsEcsCluster>
