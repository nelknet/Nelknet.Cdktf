namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftOrderableClusterState = { assignments: ResizeArray<aws.DataAwsRedshiftOrderableCluster.DataAwsRedshiftOrderableClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_orderable_cluster">aws_redshift_orderable_cluster</a>.
    /// </summary>
    type DataAwsRedshiftOrderableClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftOrderableClusterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRedshiftOrderableClusterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_orderable_cluster#cluster_type-1">DataAwsRedshiftOrderableCluster#cluster_type</a>.
        /// </summary>
        [<CustomOperation "cluster_type">]
        member _.ClusterType(state: DataAwsRedshiftOrderableClusterState, value: string) : DataAwsRedshiftOrderableClusterState =
            state.assignments.Add(fun config -> config.ClusterType <- value)
            state : DataAwsRedshiftOrderableClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_orderable_cluster#cluster_version-1">DataAwsRedshiftOrderableCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: DataAwsRedshiftOrderableClusterState, value: string) : DataAwsRedshiftOrderableClusterState =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            state : DataAwsRedshiftOrderableClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_orderable_cluster#id-1">DataAwsRedshiftOrderableCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftOrderableClusterState, value: string) : DataAwsRedshiftOrderableClusterState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftOrderableClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_orderable_cluster#node_type-1">DataAwsRedshiftOrderableCluster#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: DataAwsRedshiftOrderableClusterState, value: string) : DataAwsRedshiftOrderableClusterState =
            state.assignments.Add(fun config -> config.NodeType <- value)
            state : DataAwsRedshiftOrderableClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_orderable_cluster#preferred_node_types-1">DataAwsRedshiftOrderableCluster#preferred_node_types</a>.
        /// </summary>
        [<CustomOperation "preferred_node_types">]
        member _.PreferredNodeTypes(state: DataAwsRedshiftOrderableClusterState, value: seq<string>) : DataAwsRedshiftOrderableClusterState =
            state.assignments.Add(fun config -> config.PreferredNodeTypes <- (value |> Seq.toArray))
            state : DataAwsRedshiftOrderableClusterState

        member _.Run(state: DataAwsRedshiftOrderableClusterState) : aws.DataAwsRedshiftOrderableCluster.DataAwsRedshiftOrderableCluster =
            let config = aws.DataAwsRedshiftOrderableCluster.DataAwsRedshiftOrderableClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftOrderableCluster.DataAwsRedshiftOrderableCluster(StackContext.get (), logicalId, config)
