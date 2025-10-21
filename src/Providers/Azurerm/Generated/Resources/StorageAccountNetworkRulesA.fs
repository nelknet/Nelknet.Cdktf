namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules">azurerm_storage_account_network_rules</a>.
    /// </summary>
    type StorageAccountNetworkRulesABuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageAccountNetworkRulesAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountNetworkRulesAState<Missing, Missing>)

        member _.Zero(()) : StorageAccountNetworkRulesAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountNetworkRulesAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#default_action-1">StorageAccountNetworkRulesA#default_action</a>.
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: StorageAccountNetworkRulesAState<Missing, 'StorageAccountId>, value: string) : StorageAccountNetworkRulesAState<Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : StorageAccountNetworkRulesAState<Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#storage_account_id-1">StorageAccountNetworkRulesA#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageAccountNetworkRulesAState<'DefaultAction, Missing>, value: string) : StorageAccountNetworkRulesAState<'DefaultAction, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageAccountNetworkRulesAState<'DefaultAction, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#bypass-1">StorageAccountNetworkRulesA#bypass</a>.
        /// </summary>
        [<CustomOperation "bypass">]
        member _.Bypass(state: StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>, value: seq<string>) : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Bypass <- (value |> Seq.toArray))
            state : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#id-1">StorageAccountNetworkRulesA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>, value: string) : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#ip_rules-1">StorageAccountNetworkRulesA#ip_rules</a>.
        /// </summary>
        [<CustomOperation "ip_rules">]
        member _.IpRules(state: StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>, value: seq<string>) : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.IpRules <- (value |> Seq.toArray))
            state : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>

        /// <summary>
        /// private_link_access block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#private_link_access-1">StorageAccountNetworkRulesA#private_link_access</a> Accepts: azurerm.IResolvable | azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesPrivateLinkAccessA[]
        /// </summary>
        [<CustomOperation "private_link_access">]
        member _.PrivateLinkAccess(state: StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.PrivateLinkAccess <- value)
            state : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#timeouts-1">StorageAccountNetworkRulesA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>, value: azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesTimeouts) : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#virtual_network_subnet_ids-1">StorageAccountNetworkRulesA#virtual_network_subnet_ids</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_ids">]
        member _.VirtualNetworkSubnetIds(state: StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>, value: seq<string>) : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetIds <- (value |> Seq.toArray))
            state : StorageAccountNetworkRulesAState<'DefaultAction, 'StorageAccountId>

        member _.Run(state: StorageAccountNetworkRulesAState<Present, Present>) : azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesA =
            let config = azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesAConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageAccountNetworkRulesA: missing required arguments. Must call: default_action, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageAccountNetworkRulesAState<_, _>) : azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesA =
            Unchecked.defaultof<azurerm.StorageAccountNetworkRules.StorageAccountNetworkRulesA>
