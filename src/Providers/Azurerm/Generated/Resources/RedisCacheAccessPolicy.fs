namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId> = { assignments: ResizeArray<azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy">azurerm_redis_cache_access_policy</a>.
    /// </summary>
    type RedisCacheAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisCacheAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisCacheAccessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : RedisCacheAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisCacheAccessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy#name-1">RedisCacheAccessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedisCacheAccessPolicyState<Missing, 'Permissions, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyState<Present, 'Permissions, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyState<Present, 'Permissions, 'RedisCacheId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy#permissions-1">RedisCacheAccessPolicy#permissions</a>.
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: RedisCacheAccessPolicyState<'Name, Missing, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyState<'Name, Present, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyState<'Name, Present, 'RedisCacheId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy#redis_cache_id-1">RedisCacheAccessPolicy#redis_cache_id</a>.
        /// </summary>
        [<CustomOperation "redis_cache_id">]
        member _.RedisCacheId(state: RedisCacheAccessPolicyState<'Name, 'Permissions, Missing>, value: string) : RedisCacheAccessPolicyState<'Name, 'Permissions, Present> =
            state.assignments.Add(fun config -> config.RedisCacheId <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyState<'Name, 'Permissions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy#id-1">RedisCacheAccessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy#timeouts-1">RedisCacheAccessPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId>, value: azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicyTimeouts) : RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisCacheAccessPolicyState<'Name, 'Permissions, 'RedisCacheId>

        member _.Run(state: RedisCacheAccessPolicyState<Present, Present, Present>) : azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicy =
            let config = azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisCacheAccessPolicy: missing required arguments. Must call: name, permissions, redis_cache_id.", 9999, IsError = true)>]
        member _.Run(_: RedisCacheAccessPolicyState<_, _, _>) : azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicy =
            Unchecked.defaultof<azurerm.RedisCacheAccessPolicy.RedisCacheAccessPolicy>
