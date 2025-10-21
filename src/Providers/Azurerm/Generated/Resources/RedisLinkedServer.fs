namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName> = { assignments: ResizeArray<azurerm.RedisLinkedServer.RedisLinkedServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server">azurerm_redis_linked_server</a>.
    /// </summary>
    type RedisLinkedServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisLinkedServerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisLinkedServerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedisLinkedServerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisLinkedServerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#linked_redis_cache_id-1">RedisLinkedServer#linked_redis_cache_id</a>.
        /// </summary>
        [<CustomOperation "linked_redis_cache_id">]
        member _.LinkedRedisCacheId(state: RedisLinkedServerState<Missing, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>, value: string) : RedisLinkedServerState<Present, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName> =
            state.assignments.Add(fun config -> config.LinkedRedisCacheId <- value)
            ({ assignments = state.assignments } : RedisLinkedServerState<Present, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#linked_redis_cache_location-1">RedisLinkedServer#linked_redis_cache_location</a>.
        /// </summary>
        [<CustomOperation "linked_redis_cache_location">]
        member _.LinkedRedisCacheLocation(state: RedisLinkedServerState<'LinkedRedisCacheId, Missing, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>, value: string) : RedisLinkedServerState<'LinkedRedisCacheId, Present, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName> =
            state.assignments.Add(fun config -> config.LinkedRedisCacheLocation <- value)
            ({ assignments = state.assignments } : RedisLinkedServerState<'LinkedRedisCacheId, Present, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#resource_group_name-1">RedisLinkedServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, Missing, 'ServerRole, 'TargetRedisCacheName>, value: string) : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, Present, 'ServerRole, 'TargetRedisCacheName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, Present, 'ServerRole, 'TargetRedisCacheName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#server_role-1">RedisLinkedServer#server_role</a>.
        /// </summary>
        [<CustomOperation "server_role">]
        member _.ServerRole(state: RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, Missing, 'TargetRedisCacheName>, value: string) : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, Present, 'TargetRedisCacheName> =
            state.assignments.Add(fun config -> config.ServerRole <- value)
            ({ assignments = state.assignments } : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, Present, 'TargetRedisCacheName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#target_redis_cache_name-1">RedisLinkedServer#target_redis_cache_name</a>.
        /// </summary>
        [<CustomOperation "target_redis_cache_name">]
        member _.TargetRedisCacheName(state: RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, Missing>, value: string) : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, Present> =
            state.assignments.Add(fun config -> config.TargetRedisCacheName <- value)
            ({ assignments = state.assignments } : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#id-1">RedisLinkedServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>, value: string) : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_linked_server#timeouts-1">RedisLinkedServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>, value: azurerm.RedisLinkedServer.RedisLinkedServerTimeouts) : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisLinkedServerState<'LinkedRedisCacheId, 'LinkedRedisCacheLocation, 'ResourceGroupName, 'ServerRole, 'TargetRedisCacheName>

        member _.Run(state: RedisLinkedServerState<Present, Present, Present, Present, Present>) : azurerm.RedisLinkedServer.RedisLinkedServer =
            let config = azurerm.RedisLinkedServer.RedisLinkedServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisLinkedServer.RedisLinkedServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisLinkedServer: missing required arguments. Must call: linked_redis_cache_id, linked_redis_cache_location, resource_group_name, server_role, target_redis_cache_name.", 9999, IsError = true)>]
        member _.Run(_: RedisLinkedServerState<_, _, _, _, _>) : azurerm.RedisLinkedServer.RedisLinkedServer =
            Unchecked.defaultof<azurerm.RedisLinkedServer.RedisLinkedServer>
