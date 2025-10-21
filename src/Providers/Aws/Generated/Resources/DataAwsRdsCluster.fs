namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsClusterState<'ClusterIdentifier> = { assignments: ResizeArray<aws.DataAwsRdsCluster.DataAwsRdsClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_cluster">aws_rds_cluster</a>.
    /// </summary>
    type DataAwsRdsClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsClusterState<Missing>)

        member _.Zero(()) : DataAwsRdsClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_cluster#cluster_identifier-1">DataAwsRdsCluster#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: DataAwsRdsClusterState<Missing>, value: string) : DataAwsRdsClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsRdsClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_cluster#id-1">DataAwsRdsCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRdsClusterState<'ClusterIdentifier>, value: string) : DataAwsRdsClusterState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRdsClusterState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_cluster#tags-1">DataAwsRdsCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRdsClusterState<'ClusterIdentifier>, value: seq<string * string>) : DataAwsRdsClusterState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRdsClusterState<'ClusterIdentifier>

        member _.Run(state: DataAwsRdsClusterState<Present>) : aws.DataAwsRdsCluster.DataAwsRdsCluster =
            let config = aws.DataAwsRdsCluster.DataAwsRdsClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsCluster.DataAwsRdsCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRdsCluster: missing required arguments. Must call: cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRdsClusterState<_>) : aws.DataAwsRdsCluster.DataAwsRdsCluster =
            Unchecked.defaultof<aws.DataAwsRdsCluster.DataAwsRdsCluster>
