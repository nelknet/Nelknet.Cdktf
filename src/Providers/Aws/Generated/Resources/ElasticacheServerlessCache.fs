namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheServerlessCacheState<'Engine, 'Name> = { assignments: ResizeArray<aws.ElasticacheServerlessCache.ElasticacheServerlessCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache">aws_elasticache_serverless_cache</a>.
    /// </summary>
    type ElasticacheServerlessCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheServerlessCacheState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheServerlessCacheState<Missing, Missing>)

        member _.Zero(()) : ElasticacheServerlessCacheState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheServerlessCacheState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#engine-1">ElasticacheServerlessCache#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: ElasticacheServerlessCacheState<Missing, 'Name>, value: string) : ElasticacheServerlessCacheState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : ElasticacheServerlessCacheState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#name-1">ElasticacheServerlessCache#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticacheServerlessCacheState<'Engine, Missing>, value: string) : ElasticacheServerlessCacheState<'Engine, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticacheServerlessCacheState<'Engine, Present>)

        /// <summary>
        /// cache_usage_limits block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#cache_usage_limits-1">ElasticacheServerlessCache#cache_usage_limits</a> Accepts: aws.IResolvable | aws.ElasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimits[]
        /// </summary>
        [<CustomOperation "cache_usage_limits">]
        member _.CacheUsageLimits(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.CacheUsageLimits <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#daily_snapshot_time-1">ElasticacheServerlessCache#daily_snapshot_time</a>.
        /// </summary>
        [<CustomOperation "daily_snapshot_time">]
        member _.DailySnapshotTime(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: string) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.DailySnapshotTime <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#description-1">ElasticacheServerlessCache#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: string) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#kms_key_id-1">ElasticacheServerlessCache#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: string) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#major_engine_version-1">ElasticacheServerlessCache#major_engine_version</a>.
        /// </summary>
        [<CustomOperation "major_engine_version">]
        member _.MajorEngineVersion(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: string) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.MajorEngineVersion <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#security_group_ids-1">ElasticacheServerlessCache#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: seq<string>) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#snapshot_arns_to_restore-1">ElasticacheServerlessCache#snapshot_arns_to_restore</a>.
        /// </summary>
        [<CustomOperation "snapshot_arns_to_restore">]
        member _.SnapshotArnsToRestore(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: seq<string>) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.SnapshotArnsToRestore <- (value |> Seq.toArray))
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#snapshot_retention_limit-1">ElasticacheServerlessCache#snapshot_retention_limit</a>.
        /// </summary>
        [<CustomOperation "snapshot_retention_limit">]
        member _.SnapshotRetentionLimit(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: double) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.SnapshotRetentionLimit <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#subnet_ids-1">ElasticacheServerlessCache#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: seq<string>) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#tags-1">ElasticacheServerlessCache#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: seq<string * string>) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#timeouts-1">ElasticacheServerlessCache#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: aws.ElasticacheServerlessCache.ElasticacheServerlessCacheTimeouts) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#user_group_id-1">ElasticacheServerlessCache#user_group_id</a>.
        /// </summary>
        [<CustomOperation "user_group_id">]
        member _.UserGroupId(state: ElasticacheServerlessCacheState<'Engine, 'Name>, value: string) : ElasticacheServerlessCacheState<'Engine, 'Name> =
            state.assignments.Add(fun config -> config.UserGroupId <- value)
            state : ElasticacheServerlessCacheState<'Engine, 'Name>

        member _.Run(state: ElasticacheServerlessCacheState<Present, Present>) : aws.ElasticacheServerlessCache.ElasticacheServerlessCache =
            let config = aws.ElasticacheServerlessCache.ElasticacheServerlessCacheConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheServerlessCache.ElasticacheServerlessCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheServerlessCache: missing required arguments. Must call: engine, name.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheServerlessCacheState<_, _>) : aws.ElasticacheServerlessCache.ElasticacheServerlessCache =
            Unchecked.defaultof<aws.ElasticacheServerlessCache.ElasticacheServerlessCache>
