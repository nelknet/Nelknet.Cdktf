namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> = { assignments: ResizeArray<azurerm.PostgresqlFirewallRule.PostgresqlFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule">azurerm_postgresql_firewall_rule</a>.
    /// </summary>
    type PostgresqlFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#end_ip_address-1">PostgresqlFirewallRule#end_ip_address</a>.
        /// </summary>
        [<CustomOperation "end_ip_address">]
        member _.EndIpAddress(state: PostgresqlFirewallRuleState<Missing, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: string) : PostgresqlFirewallRuleState<Present, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.EndIpAddress <- value)
            ({ assignments = state.assignments } : PostgresqlFirewallRuleState<Present, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#name-1">PostgresqlFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlFirewallRuleState<'EndIpAddress, Missing, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: string) : PostgresqlFirewallRuleState<'EndIpAddress, Present, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlFirewallRuleState<'EndIpAddress, Present, 'ResourceGroupName, 'ServerName, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#resource_group_name-1">PostgresqlFirewallRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlFirewallRuleState<'EndIpAddress, 'Name, Missing, 'ServerName, 'StartIpAddress>, value: string) : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, Present, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, Present, 'ServerName, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#server_name-1">PostgresqlFirewallRule#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, Missing, 'StartIpAddress>, value: string) : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, Present, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, Present, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#start_ip_address-1">PostgresqlFirewallRule#start_ip_address</a>.
        /// </summary>
        [<CustomOperation "start_ip_address">]
        member _.StartIpAddress(state: PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, Missing>, value: string) : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.StartIpAddress <- value)
            ({ assignments = state.assignments } : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#id-1">PostgresqlFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: string) : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_firewall_rule#timeouts-1">PostgresqlFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: azurerm.PostgresqlFirewallRule.PostgresqlFirewallRuleTimeouts) : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>

        member _.Run(state: PostgresqlFirewallRuleState<Present, Present, Present, Present, Present>) : azurerm.PostgresqlFirewallRule.PostgresqlFirewallRule =
            let config = azurerm.PostgresqlFirewallRule.PostgresqlFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlFirewallRule.PostgresqlFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlFirewallRule: missing required arguments. Must call: end_ip_address, name, resource_group_name, server_name, start_ip_address.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlFirewallRuleState<_, _, _, _, _>) : azurerm.PostgresqlFirewallRule.PostgresqlFirewallRule =
            Unchecked.defaultof<azurerm.PostgresqlFirewallRule.PostgresqlFirewallRule>
