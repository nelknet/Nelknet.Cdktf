namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticacheReplicationGroupState<'ReplicationGroupId> = { assignments: ResizeArray<aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_replication_group">aws_elasticache_replication_group</a>.
    /// </summary>
    type DataAwsElasticacheReplicationGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticacheReplicationGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheReplicationGroupState<Missing>)

        member _.Zero(()) : DataAwsElasticacheReplicationGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheReplicationGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_replication_group#replication_group_id-1">DataAwsElasticacheReplicationGroup#replication_group_id</a>.
        /// </summary>
        [<CustomOperation "replication_group_id">]
        member _.ReplicationGroupId(state: DataAwsElasticacheReplicationGroupState<Missing>, value: string) : DataAwsElasticacheReplicationGroupState<Present> =
            state.assignments.Add(fun config -> config.ReplicationGroupId <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheReplicationGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_replication_group#id-1">DataAwsElasticacheReplicationGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticacheReplicationGroupState<'ReplicationGroupId>, value: string) : DataAwsElasticacheReplicationGroupState<'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticacheReplicationGroupState<'ReplicationGroupId>

        member _.Run(state: DataAwsElasticacheReplicationGroupState<Present>) : aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroup =
            let config = aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticacheReplicationGroup: missing required arguments. Must call: replication_group_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticacheReplicationGroupState<_>) : aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroup =
            Unchecked.defaultof<aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroup>
