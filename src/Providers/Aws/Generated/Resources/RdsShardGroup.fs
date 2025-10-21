namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> = { assignments: ResizeArray<aws.RdsShardGroup.RdsShardGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group">aws_rds_shard_group</a>.
    /// </summary>
    type RdsShardGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsShardGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsShardGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : RdsShardGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsShardGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#db_cluster_identifier-1">RdsShardGroup#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: RdsShardGroupState<Missing, 'DbShardGroupIdentifier, 'MaxAcu>, value: string) : RdsShardGroupState<Present, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            ({ assignments = state.assignments } : RdsShardGroupState<Present, 'DbShardGroupIdentifier, 'MaxAcu>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#db_shard_group_identifier-1">RdsShardGroup#db_shard_group_identifier</a>.
        /// </summary>
        [<CustomOperation "db_shard_group_identifier">]
        member _.DbShardGroupIdentifier(state: RdsShardGroupState<'DbClusterIdentifier, Missing, 'MaxAcu>, value: string) : RdsShardGroupState<'DbClusterIdentifier, Present, 'MaxAcu> =
            state.assignments.Add(fun config -> config.DbShardGroupIdentifier <- value)
            ({ assignments = state.assignments } : RdsShardGroupState<'DbClusterIdentifier, Present, 'MaxAcu>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#max_acu-1">RdsShardGroup#max_acu</a>.
        /// </summary>
        [<CustomOperation "max_acu">]
        member _.MaxAcu(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, Missing>, value: double) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, Present> =
            state.assignments.Add(fun config -> config.MaxAcu <- value)
            ({ assignments = state.assignments } : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#compute_redundancy-1">RdsShardGroup#compute_redundancy</a>.
        /// </summary>
        [<CustomOperation "compute_redundancy">]
        member _.ComputeRedundancy(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>, value: double) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.ComputeRedundancy <- value)
            state : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#min_acu-1">RdsShardGroup#min_acu</a>.
        /// </summary>
        [<CustomOperation "min_acu">]
        member _.MinAcu(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>, value: double) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.MinAcu <- value)
            state : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#publicly_accessible-1">RdsShardGroup#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>, value: bool) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#publicly_accessible-1">RdsShardGroup#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>, value: HashiCorp.Cdktf.IResolvable) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#tags-1">RdsShardGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>, value: seq<string * string>) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_shard_group#timeouts-1">RdsShardGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>, value: aws.RdsShardGroup.RdsShardGroupTimeouts) : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsShardGroupState<'DbClusterIdentifier, 'DbShardGroupIdentifier, 'MaxAcu>

        member _.Run(state: RdsShardGroupState<Present, Present, Present>) : aws.RdsShardGroup.RdsShardGroup =
            let config = aws.RdsShardGroup.RdsShardGroupConfig()
            for setter in state.assignments do
                setter config
            aws.RdsShardGroup.RdsShardGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsShardGroup: missing required arguments. Must call: db_cluster_identifier, db_shard_group_identifier, max_acu.", 9999, IsError = true)>]
        member _.Run(_: RdsShardGroupState<_, _, _>) : aws.RdsShardGroup.RdsShardGroup =
            Unchecked.defaultof<aws.RdsShardGroup.RdsShardGroup>
