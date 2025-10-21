namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticacheServerlessCacheState<'Name> = { assignments: ResizeArray<aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_serverless_cache">aws_elasticache_serverless_cache</a>.
    /// </summary>
    type DataAwsElasticacheServerlessCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticacheServerlessCacheState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheServerlessCacheState<Missing>)

        member _.Zero(()) : DataAwsElasticacheServerlessCacheState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheServerlessCacheState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_serverless_cache#name-1">DataAwsElasticacheServerlessCache#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsElasticacheServerlessCacheState<Missing>, value: string) : DataAwsElasticacheServerlessCacheState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheServerlessCacheState<Present>)

        member _.Run(state: DataAwsElasticacheServerlessCacheState<Present>) : aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCache =
            let config = aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticacheServerlessCache: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticacheServerlessCacheState<_>) : aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCache =
            Unchecked.defaultof<aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCache>
