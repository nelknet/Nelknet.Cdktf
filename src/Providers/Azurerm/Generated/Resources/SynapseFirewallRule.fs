namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseFirewallRule.SynapseFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule">azurerm_synapse_firewall_rule</a>.
    /// </summary>
    type SynapseFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseFirewallRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseFirewallRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule#end_ip_address-1">SynapseFirewallRule#end_ip_address</a>.
        /// </summary>
        [<CustomOperation "end_ip_address">]
        member _.EndIpAddress(state: SynapseFirewallRuleState<Missing, 'Name, 'StartIpAddress, 'SynapseWorkspaceId>, value: string) : SynapseFirewallRuleState<Present, 'Name, 'StartIpAddress, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.EndIpAddress <- value)
            ({ assignments = state.assignments } : SynapseFirewallRuleState<Present, 'Name, 'StartIpAddress, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule#name-1">SynapseFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseFirewallRuleState<'EndIpAddress, Missing, 'StartIpAddress, 'SynapseWorkspaceId>, value: string) : SynapseFirewallRuleState<'EndIpAddress, Present, 'StartIpAddress, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseFirewallRuleState<'EndIpAddress, Present, 'StartIpAddress, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule#start_ip_address-1">SynapseFirewallRule#start_ip_address</a>.
        /// </summary>
        [<CustomOperation "start_ip_address">]
        member _.StartIpAddress(state: SynapseFirewallRuleState<'EndIpAddress, 'Name, Missing, 'SynapseWorkspaceId>, value: string) : SynapseFirewallRuleState<'EndIpAddress, 'Name, Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StartIpAddress <- value)
            ({ assignments = state.assignments } : SynapseFirewallRuleState<'EndIpAddress, 'Name, Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule#synapse_workspace_id-1">SynapseFirewallRule#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, Missing>, value: string) : SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule#id-1">SynapseFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId>, value: string) : SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_firewall_rule#timeouts-1">SynapseFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId>, value: azurerm.SynapseFirewallRule.SynapseFirewallRuleTimeouts) : SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseFirewallRuleState<'EndIpAddress, 'Name, 'StartIpAddress, 'SynapseWorkspaceId>

        member _.Run(state: SynapseFirewallRuleState<Present, Present, Present, Present>) : azurerm.SynapseFirewallRule.SynapseFirewallRule =
            let config = azurerm.SynapseFirewallRule.SynapseFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseFirewallRule.SynapseFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseFirewallRule: missing required arguments. Must call: end_ip_address, name, start_ip_address, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseFirewallRuleState<_, _, _, _>) : azurerm.SynapseFirewallRule.SynapseFirewallRule =
            Unchecked.defaultof<azurerm.SynapseFirewallRule.SynapseFirewallRule>
