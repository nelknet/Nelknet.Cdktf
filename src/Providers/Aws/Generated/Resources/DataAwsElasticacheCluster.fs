namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticacheClusterState<'ClusterId> = { assignments: ResizeArray<aws.DataAwsElasticacheCluster.DataAwsElasticacheClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_cluster">aws_elasticache_cluster</a>.
    /// </summary>
    type DataAwsElasticacheClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticacheClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheClusterState<Missing>)

        member _.Zero(()) : DataAwsElasticacheClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_cluster#cluster_id-1">DataAwsElasticacheCluster#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: DataAwsElasticacheClusterState<Missing>, value: string) : DataAwsElasticacheClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_cluster#id-1">DataAwsElasticacheCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticacheClusterState<'ClusterId>, value: string) : DataAwsElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_cluster#tags-1">DataAwsElasticacheCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsElasticacheClusterState<'ClusterId>, value: seq<string * string>) : DataAwsElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsElasticacheClusterState<'ClusterId>

        member _.Run(state: DataAwsElasticacheClusterState<Present>) : aws.DataAwsElasticacheCluster.DataAwsElasticacheCluster =
            let config = aws.DataAwsElasticacheCluster.DataAwsElasticacheClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticacheCluster.DataAwsElasticacheCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticacheCluster: missing required arguments. Must call: cluster_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticacheClusterState<_>) : aws.DataAwsElasticacheCluster.DataAwsElasticacheCluster =
            Unchecked.defaultof<aws.DataAwsElasticacheCluster.DataAwsElasticacheCluster>
