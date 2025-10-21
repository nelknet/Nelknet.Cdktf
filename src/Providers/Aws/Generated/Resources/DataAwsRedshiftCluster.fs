namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftClusterState<'ClusterIdentifier> = { assignments: ResizeArray<aws.DataAwsRedshiftCluster.DataAwsRedshiftClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster">aws_redshift_cluster</a>.
    /// </summary>
    type DataAwsRedshiftClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftClusterState<Missing>)

        member _.Zero(()) : DataAwsRedshiftClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster#cluster_identifier-1">DataAwsRedshiftCluster#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: DataAwsRedshiftClusterState<Missing>, value: string) : DataAwsRedshiftClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster#id-1">DataAwsRedshiftCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftClusterState<'ClusterIdentifier>, value: string) : DataAwsRedshiftClusterState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftClusterState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_cluster#tags-1">DataAwsRedshiftCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRedshiftClusterState<'ClusterIdentifier>, value: seq<string * string>) : DataAwsRedshiftClusterState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRedshiftClusterState<'ClusterIdentifier>

        member _.Run(state: DataAwsRedshiftClusterState<Present>) : aws.DataAwsRedshiftCluster.DataAwsRedshiftCluster =
            let config = aws.DataAwsRedshiftCluster.DataAwsRedshiftClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftCluster.DataAwsRedshiftCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftCluster: missing required arguments. Must call: cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftClusterState<_>) : aws.DataAwsRedshiftCluster.DataAwsRedshiftCluster =
            Unchecked.defaultof<aws.DataAwsRedshiftCluster.DataAwsRedshiftCluster>
