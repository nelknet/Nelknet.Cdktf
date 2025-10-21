namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> = { assignments: ResizeArray<azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule">azurerm_mysql_flexible_server_firewall_rule</a>.
    /// </summary>
    type MysqlFlexibleServerFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : MysqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MysqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#end_ip_address-1">MysqlFlexibleServerFirewallRule#end_ip_address</a>.
        /// </summary>
        [<CustomOperation "end_ip_address">]
        member _.EndIpAddress(state: MysqlFlexibleServerFirewallRuleState<Missing, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: string) : MysqlFlexibleServerFirewallRuleState<Present, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.EndIpAddress <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerFirewallRuleState<Present, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#name-1">MysqlFlexibleServerFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MysqlFlexibleServerFirewallRuleState<'EndIpAddress, Missing, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: string) : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, Present, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, Present, 'ResourceGroupName, 'ServerName, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#resource_group_name-1">MysqlFlexibleServerFirewallRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, Missing, 'ServerName, 'StartIpAddress>, value: string) : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, Present, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, Present, 'ServerName, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#server_name-1">MysqlFlexibleServerFirewallRule#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, Missing, 'StartIpAddress>, value: string) : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, Present, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, Present, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#start_ip_address-1">MysqlFlexibleServerFirewallRule#start_ip_address</a>.
        /// </summary>
        [<CustomOperation "start_ip_address">]
        member _.StartIpAddress(state: MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, Missing>, value: string) : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.StartIpAddress <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#id-1">MysqlFlexibleServerFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: string) : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_firewall_rule#timeouts-1">MysqlFlexibleServerFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>, value: azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRuleTimeouts) : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MysqlFlexibleServerFirewallRuleState<'EndIpAddress, 'Name, 'ResourceGroupName, 'ServerName, 'StartIpAddress>

        member _.Run(state: MysqlFlexibleServerFirewallRuleState<Present, Present, Present, Present, Present>) : azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRule =
            let config = azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mysqlFlexibleServerFirewallRule: missing required arguments. Must call: end_ip_address, name, resource_group_name, server_name, start_ip_address.", 9999, IsError = true)>]
        member _.Run(_: MysqlFlexibleServerFirewallRuleState<_, _, _, _, _>) : azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRule =
            Unchecked.defaultof<azurerm.MysqlFlexibleServerFirewallRule.MysqlFlexibleServerFirewallRule>
