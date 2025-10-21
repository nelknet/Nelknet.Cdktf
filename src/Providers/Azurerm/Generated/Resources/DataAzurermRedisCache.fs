namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRedisCacheState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermRedisCache.DataAzurermRedisCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_cache">azurerm_redis_cache</a>.
    /// </summary>
    type DataAzurermRedisCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRedisCacheState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRedisCacheState<Missing, Missing>)

        member _.Zero(()) : DataAzurermRedisCacheState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRedisCacheState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_cache#name-1">DataAzurermRedisCache#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermRedisCacheState<Missing, 'ResourceGroupName>, value: string) : DataAzurermRedisCacheState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermRedisCacheState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_cache#resource_group_name-1">DataAzurermRedisCache#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermRedisCacheState<'Name, Missing>, value: string) : DataAzurermRedisCacheState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermRedisCacheState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_cache#id-1">DataAzurermRedisCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRedisCacheState<'Name, 'ResourceGroupName>, value: string) : DataAzurermRedisCacheState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRedisCacheState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_cache#timeouts-1">DataAzurermRedisCache#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRedisCacheState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermRedisCache.DataAzurermRedisCacheTimeouts) : DataAzurermRedisCacheState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRedisCacheState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermRedisCacheState<Present, Present>) : azurerm.DataAzurermRedisCache.DataAzurermRedisCache =
            let config = azurerm.DataAzurermRedisCache.DataAzurermRedisCacheConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRedisCache.DataAzurermRedisCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermRedisCache: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermRedisCacheState<_, _>) : azurerm.DataAzurermRedisCache.DataAzurermRedisCache =
            Unchecked.defaultof<azurerm.DataAzurermRedisCache.DataAzurermRedisCache>
