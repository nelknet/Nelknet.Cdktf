namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name> = { assignments: ResizeArray<azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_access_policy">azurerm_hpc_cache_access_policy</a>.
    /// </summary>
    type HpcCacheAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : HpcCacheAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheAccessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : HpcCacheAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheAccessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// access_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_access_policy#access_rule-1">HpcCacheAccessPolicy#access_rule</a> Accepts: azurerm.IResolvable | azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicyAccessRule[]
        /// </summary>
        [<CustomOperation "access_rule">]
        member _.AccessRule(state: HpcCacheAccessPolicyState<Missing, 'HpcCacheId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : HpcCacheAccessPolicyState<Present, 'HpcCacheId, 'Name> =
            state.assignments.Add(fun config -> config.AccessRule <- value)
            ({ assignments = state.assignments } : HpcCacheAccessPolicyState<Present, 'HpcCacheId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_access_policy#hpc_cache_id-1">HpcCacheAccessPolicy#hpc_cache_id</a>.
        /// </summary>
        [<CustomOperation "hpc_cache_id">]
        member _.HpcCacheId(state: HpcCacheAccessPolicyState<'AccessRule, Missing, 'Name>, value: string) : HpcCacheAccessPolicyState<'AccessRule, Present, 'Name> =
            state.assignments.Add(fun config -> config.HpcCacheId <- value)
            ({ assignments = state.assignments } : HpcCacheAccessPolicyState<'AccessRule, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_access_policy#name-1">HpcCacheAccessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, Missing>, value: string) : HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_access_policy#id-1">HpcCacheAccessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name>, value: string) : HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_access_policy#timeouts-1">HpcCacheAccessPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name>, value: azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicyTimeouts) : HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HpcCacheAccessPolicyState<'AccessRule, 'HpcCacheId, 'Name>

        member _.Run(state: HpcCacheAccessPolicyState<Present, Present, Present>) : azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicy =
            let config = azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hpcCacheAccessPolicy: missing required arguments. Must call: access_rule, hpc_cache_id, name.", 9999, IsError = true)>]
        member _.Run(_: HpcCacheAccessPolicyState<_, _, _>) : azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicy =
            Unchecked.defaultof<azurerm.HpcCacheAccessPolicy.HpcCacheAccessPolicy>
