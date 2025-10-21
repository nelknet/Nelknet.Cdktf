namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementRedisCache.ApiManagementRedisCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache">azurerm_api_management_redis_cache</a>.
    /// </summary>
    type ApiManagementRedisCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementRedisCacheState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementRedisCacheState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementRedisCacheState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementRedisCacheState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#api_management_id-1">ApiManagementRedisCache#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementRedisCacheState<Missing, 'ConnectionString, 'Name>, value: string) : ApiManagementRedisCacheState<Present, 'ConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementRedisCacheState<Present, 'ConnectionString, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#connection_string-1">ApiManagementRedisCache#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: ApiManagementRedisCacheState<'ApiManagementId, Missing, 'Name>, value: string) : ApiManagementRedisCacheState<'ApiManagementId, Present, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : ApiManagementRedisCacheState<'ApiManagementId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#name-1">ApiManagementRedisCache#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, Missing>, value: string) : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#cache_location-1">ApiManagementRedisCache#cache_location</a>.
        /// </summary>
        [<CustomOperation "cache_location">]
        member _.CacheLocation(state: ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>, value: string) : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.CacheLocation <- value)
            state : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#description-1">ApiManagementRedisCache#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>, value: string) : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#id-1">ApiManagementRedisCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>, value: string) : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#redis_cache_id-1">ApiManagementRedisCache#redis_cache_id</a>.
        /// </summary>
        [<CustomOperation "redis_cache_id">]
        member _.RedisCacheId(state: ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>, value: string) : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.RedisCacheId <- value)
            state : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_redis_cache#timeouts-1">ApiManagementRedisCache#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>, value: azurerm.ApiManagementRedisCache.ApiManagementRedisCacheTimeouts) : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementRedisCacheState<'ApiManagementId, 'ConnectionString, 'Name>

        member _.Run(state: ApiManagementRedisCacheState<Present, Present, Present>) : azurerm.ApiManagementRedisCache.ApiManagementRedisCache =
            let config = azurerm.ApiManagementRedisCache.ApiManagementRedisCacheConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementRedisCache.ApiManagementRedisCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementRedisCache: missing required arguments. Must call: api_management_id, connection_string, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementRedisCacheState<_, _, _>) : azurerm.ApiManagementRedisCache.ApiManagementRedisCache =
            Unchecked.defaultof<azurerm.ApiManagementRedisCache.ApiManagementRedisCache>
