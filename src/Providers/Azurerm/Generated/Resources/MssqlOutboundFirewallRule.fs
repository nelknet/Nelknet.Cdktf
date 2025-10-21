namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlOutboundFirewallRuleState<'Name, 'ServerId> = { assignments: ResizeArray<azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_outbound_firewall_rule">azurerm_mssql_outbound_firewall_rule</a>.
    /// </summary>
    type MssqlOutboundFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlOutboundFirewallRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlOutboundFirewallRuleState<Missing, Missing>)

        member _.Zero(()) : MssqlOutboundFirewallRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlOutboundFirewallRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_outbound_firewall_rule#name-1">MssqlOutboundFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlOutboundFirewallRuleState<Missing, 'ServerId>, value: string) : MssqlOutboundFirewallRuleState<Present, 'ServerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlOutboundFirewallRuleState<Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_outbound_firewall_rule#server_id-1">MssqlOutboundFirewallRule#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlOutboundFirewallRuleState<'Name, Missing>, value: string) : MssqlOutboundFirewallRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlOutboundFirewallRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_outbound_firewall_rule#id-1">MssqlOutboundFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlOutboundFirewallRuleState<'Name, 'ServerId>, value: string) : MssqlOutboundFirewallRuleState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlOutboundFirewallRuleState<'Name, 'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_outbound_firewall_rule#timeouts-1">MssqlOutboundFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlOutboundFirewallRuleState<'Name, 'ServerId>, value: azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRuleTimeouts) : MssqlOutboundFirewallRuleState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlOutboundFirewallRuleState<'Name, 'ServerId>

        member _.Run(state: MssqlOutboundFirewallRuleState<Present, Present>) : azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRule =
            let config = azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlOutboundFirewallRule: missing required arguments. Must call: name, server_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlOutboundFirewallRuleState<_, _>) : azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRule =
            Unchecked.defaultof<azurerm.MssqlOutboundFirewallRule.MssqlOutboundFirewallRule>
