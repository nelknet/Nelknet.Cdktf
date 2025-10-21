namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association">azurerm_spring_cloud_app_redis_association</a>.
    /// </summary>
    type SpringCloudAppRedisAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudAppRedisAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppRedisAssociationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudAppRedisAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppRedisAssociationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#name-1">SpringCloudAppRedisAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudAppRedisAssociationState<Missing, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>, value: string) : SpringCloudAppRedisAssociationState<Present, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudAppRedisAssociationState<Present, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#redis_access_key-1">SpringCloudAppRedisAssociation#redis_access_key</a>.
        /// </summary>
        [<CustomOperation "redis_access_key">]
        member _.RedisAccessKey(state: SpringCloudAppRedisAssociationState<'Name, Missing, 'RedisCacheId, 'SpringCloudAppId>, value: string) : SpringCloudAppRedisAssociationState<'Name, Present, 'RedisCacheId, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.RedisAccessKey <- value)
            ({ assignments = state.assignments } : SpringCloudAppRedisAssociationState<'Name, Present, 'RedisCacheId, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#redis_cache_id-1">SpringCloudAppRedisAssociation#redis_cache_id</a>.
        /// </summary>
        [<CustomOperation "redis_cache_id">]
        member _.RedisCacheId(state: SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, Missing, 'SpringCloudAppId>, value: string) : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.RedisCacheId <- value)
            ({ assignments = state.assignments } : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#spring_cloud_app_id-1">SpringCloudAppRedisAssociation#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, Missing>, value: string) : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#id-1">SpringCloudAppRedisAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>, value: string) : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#ssl_enabled-1">SpringCloudAppRedisAssociation#ssl_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssl_enabled">]
        member _.SslEnabled(state: SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>, value: bool) : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.SslEnabled <- value)
            state : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#ssl_enabled-1">SpringCloudAppRedisAssociation#ssl_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssl_enabled">]
        member _.SslEnabled(state: SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.SslEnabled <- value)
            state : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_redis_association#timeouts-1">SpringCloudAppRedisAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>, value: azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociationTimeouts) : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudAppRedisAssociationState<'Name, 'RedisAccessKey, 'RedisCacheId, 'SpringCloudAppId>

        member _.Run(state: SpringCloudAppRedisAssociationState<Present, Present, Present, Present>) : azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociation =
            let config = azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudAppRedisAssociation: missing required arguments. Must call: name, redis_access_key, redis_cache_id, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudAppRedisAssociationState<_, _, _, _>) : azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociation =
            Unchecked.defaultof<azurerm.SpringCloudAppRedisAssociation.SpringCloudAppRedisAssociation>
