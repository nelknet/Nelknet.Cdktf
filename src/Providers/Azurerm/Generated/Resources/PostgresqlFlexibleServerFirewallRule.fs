namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress> = { assignments: ResizeArray<azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule">azurerm_postgresql_flexible_server_firewall_rule</a>.
    /// </summary>
    type PostgresqlFlexibleServerFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule#end_ip_address-1">PostgresqlFlexibleServerFirewallRule#end_ip_address</a>.
        /// </summary>
        [<CustomOperation "end_ip_address">]
        member _.EndIpAddress(state: PostgresqlFlexibleServerFirewallRuleState<Missing, 'Name, 'ServerId, 'StartIpAddress>, value: string) : PostgresqlFlexibleServerFirewallRuleState<Present, 'Name, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.EndIpAddress <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerFirewallRuleState<Present, 'Name, 'ServerId, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule#name-1">PostgresqlFlexibleServerFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, Missing, 'ServerId, 'StartIpAddress>, value: string) : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, Present, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, Present, 'ServerId, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule#server_id-1">PostgresqlFlexibleServerFirewallRule#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, Missing, 'StartIpAddress>, value: string) : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, Present, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, Present, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule#start_ip_address-1">PostgresqlFlexibleServerFirewallRule#start_ip_address</a>.
        /// </summary>
        [<CustomOperation "start_ip_address">]
        member _.StartIpAddress(state: PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, Missing>, value: string) : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.StartIpAddress <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule#id-1">PostgresqlFlexibleServerFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>, value: string) : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_firewall_rule#timeouts-1">PostgresqlFlexibleServerFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>, value: azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRuleTimeouts) : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ServerId, 'StartIpAddress>

        member _.Run(state: PostgresqlFlexibleServerFirewallRuleState<Present, Present, Present, Present>) : azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRule =
            let config = azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlFlexibleServerFirewallRule: missing required arguments. Must call: end_ip_address, name, server_id, start_ip_address.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlFlexibleServerFirewallRuleState<_, _, _, _>) : azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRule =
            Unchecked.defaultof<azurerm.PostgresqlFlexibleServerFirewallRule.PostgresqlFlexibleServerFirewallRule>
