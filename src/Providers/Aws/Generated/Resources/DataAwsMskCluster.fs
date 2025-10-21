namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskClusterState<'ClusterName> = { assignments: ResizeArray<aws.DataAwsMskCluster.DataAwsMskClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster">aws_msk_cluster</a>.
    /// </summary>
    type DataAwsMskClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskClusterState<Missing>)

        member _.Zero(()) : DataAwsMskClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster#cluster_name-1">DataAwsMskCluster#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAwsMskClusterState<Missing>, value: string) : DataAwsMskClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAwsMskClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster#id-1">DataAwsMskCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskClusterState<'ClusterName>, value: string) : DataAwsMskClusterState<'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskClusterState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster#tags-1">DataAwsMskCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMskClusterState<'ClusterName>, value: seq<string * string>) : DataAwsMskClusterState<'ClusterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMskClusterState<'ClusterName>

        member _.Run(state: DataAwsMskClusterState<Present>) : aws.DataAwsMskCluster.DataAwsMskCluster =
            let config = aws.DataAwsMskCluster.DataAwsMskClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskCluster.DataAwsMskCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskCluster: missing required arguments. Must call: cluster_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskClusterState<_>) : aws.DataAwsMskCluster.DataAwsMskCluster =
            Unchecked.defaultof<aws.DataAwsMskCluster.DataAwsMskCluster>
