namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress> = { assignments: ResizeArray<azurerm.MssqlFirewallRule.MssqlFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule">azurerm_mssql_firewall_rule</a>.
    /// </summary>
    type MssqlFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlFirewallRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlFirewallRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule#end_ip_address-1">MssqlFirewallRule#end_ip_address</a>.
        /// </summary>
        [<CustomOperation "end_ip_address">]
        member _.EndIpAddress(state: MssqlFirewallRuleState<Missing, 'Name, 'ServerId, 'StartIpAddress>, value: string) : MssqlFirewallRuleState<Present, 'Name, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.EndIpAddress <- value)
            ({ assignments = state.assignments } : MssqlFirewallRuleState<Present, 'Name, 'ServerId, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule#name-1">MssqlFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlFirewallRuleState<'EndIpAddress, Missing, 'ServerId, 'StartIpAddress>, value: string) : MssqlFirewallRuleState<'EndIpAddress, Present, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlFirewallRuleState<'EndIpAddress, Present, 'ServerId, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule#server_id-1">MssqlFirewallRule#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlFirewallRuleState<'EndIpAddress, 'Name, Missing, 'StartIpAddress>, value: string) : MssqlFirewallRuleState<'EndIpAddress, 'Name, Present, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlFirewallRuleState<'EndIpAddress, 'Name, Present, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule#start_ip_address-1">MssqlFirewallRule#start_ip_address</a>.
        /// </summary>
        [<CustomOperation "start_ip_address">]
        member _.StartIpAddress(state: MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, Missing>, value: string) : MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.StartIpAddress <- value)
            ({ assignments = state.assignments } : MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule#id-1">MssqlFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>, value: string) : MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_firewall_rule#timeouts-1">MssqlFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>, value: azurerm.MssqlFirewallRule.MssqlFirewallRuleTimeouts) : MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>

        member _.Run(state: MssqlFirewallRuleState<Present, Present, Present, Present>) : azurerm.MssqlFirewallRule.MssqlFirewallRule =
            let config = azurerm.MssqlFirewallRule.MssqlFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlFirewallRule.MssqlFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlFirewallRule: missing required arguments. Must call: end_ip_address, name, server_id, start_ip_address.", 9999, IsError = true)>]
        member _.Run(_: MssqlFirewallRuleState<_, _, _, _>) : azurerm.MssqlFirewallRule.MssqlFirewallRule =
            Unchecked.defaultof<azurerm.MssqlFirewallRule.MssqlFirewallRule>
