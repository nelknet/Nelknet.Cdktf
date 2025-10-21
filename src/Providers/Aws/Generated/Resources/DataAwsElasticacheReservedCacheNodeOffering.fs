namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, 'OfferingType, 'ProductDescription> = { assignments: ResizeArray<aws.DataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOfferingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_reserved_cache_node_offering">aws_elasticache_reserved_cache_node_offering</a>.
    /// </summary>
    type DataAwsElasticacheReservedCacheNodeOfferingBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticacheReservedCacheNodeOfferingState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheReservedCacheNodeOfferingState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsElasticacheReservedCacheNodeOfferingState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheReservedCacheNodeOfferingState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_reserved_cache_node_offering#cache_node_type-1">DataAwsElasticacheReservedCacheNodeOffering#cache_node_type</a>.
        /// </summary>
        [<CustomOperation "cache_node_type">]
        member _.CacheNodeType(state: DataAwsElasticacheReservedCacheNodeOfferingState<Missing, 'Duration, 'OfferingType, 'ProductDescription>, value: string) : DataAwsElasticacheReservedCacheNodeOfferingState<Present, 'Duration, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.CacheNodeType <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheReservedCacheNodeOfferingState<Present, 'Duration, 'OfferingType, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_reserved_cache_node_offering#duration-1">DataAwsElasticacheReservedCacheNodeOffering#duration</a>.
        /// </summary>
        [<CustomOperation "duration">]
        member _.Duration(state: DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, Missing, 'OfferingType, 'ProductDescription>, value: string) : DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, Present, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.Duration <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, Present, 'OfferingType, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_reserved_cache_node_offering#offering_type-1">DataAwsElasticacheReservedCacheNodeOffering#offering_type</a>.
        /// </summary>
        [<CustomOperation "offering_type">]
        member _.OfferingType(state: DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, Missing, 'ProductDescription>, value: string) : DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, Present, 'ProductDescription> =
            state.assignments.Add(fun config -> config.OfferingType <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, Present, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_reserved_cache_node_offering#product_description-1">DataAwsElasticacheReservedCacheNodeOffering#product_description</a>.
        /// </summary>
        [<CustomOperation "product_description">]
        member _.ProductDescription(state: DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, 'OfferingType, Missing>, value: string) : DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, 'OfferingType, Present> =
            state.assignments.Add(fun config -> config.ProductDescription <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheReservedCacheNodeOfferingState<'CacheNodeType, 'Duration, 'OfferingType, Present>)

        member _.Run(state: DataAwsElasticacheReservedCacheNodeOfferingState<Present, Present, Present, Present>) : aws.DataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOffering =
            let config = aws.DataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOfferingConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOffering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticacheReservedCacheNodeOffering: missing required arguments. Must call: cache_node_type, duration, offering_type, product_description.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticacheReservedCacheNodeOfferingState<_, _, _, _>) : aws.DataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOffering =
            Unchecked.defaultof<aws.DataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOffering>
