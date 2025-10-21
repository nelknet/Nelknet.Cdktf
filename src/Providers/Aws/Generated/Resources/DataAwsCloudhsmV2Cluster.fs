namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudhsmV2ClusterState<'ClusterId> = { assignments: ResizeArray<aws.DataAwsCloudhsmV2Cluster.DataAwsCloudhsmV2ClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudhsm_v2_cluster">aws_cloudhsm_v2_cluster</a>.
    /// </summary>
    type DataAwsCloudhsmV2ClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudhsmV2ClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudhsmV2ClusterState<Missing>)

        member _.Zero(()) : DataAwsCloudhsmV2ClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudhsmV2ClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudhsm_v2_cluster#cluster_id-1">DataAwsCloudhsmV2Cluster#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: DataAwsCloudhsmV2ClusterState<Missing>, value: string) : DataAwsCloudhsmV2ClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : DataAwsCloudhsmV2ClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudhsm_v2_cluster#cluster_state-1">DataAwsCloudhsmV2Cluster#cluster_state</a>.
        /// </summary>
        [<CustomOperation "cluster_state">]
        member _.ClusterState(state: DataAwsCloudhsmV2ClusterState<'ClusterId>, value: string) : DataAwsCloudhsmV2ClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.ClusterState <- value)
            state : DataAwsCloudhsmV2ClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudhsm_v2_cluster#id-1">DataAwsCloudhsmV2Cluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudhsmV2ClusterState<'ClusterId>, value: string) : DataAwsCloudhsmV2ClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudhsmV2ClusterState<'ClusterId>

        member _.Run(state: DataAwsCloudhsmV2ClusterState<Present>) : aws.DataAwsCloudhsmV2Cluster.DataAwsCloudhsmV2Cluster =
            let config = aws.DataAwsCloudhsmV2Cluster.DataAwsCloudhsmV2ClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudhsmV2Cluster.DataAwsCloudhsmV2Cluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudhsmV2Cluster: missing required arguments. Must call: cluster_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudhsmV2ClusterState<_>) : aws.DataAwsCloudhsmV2Cluster.DataAwsCloudhsmV2Cluster =
            Unchecked.defaultof<aws.DataAwsCloudhsmV2Cluster.DataAwsCloudhsmV2Cluster>
