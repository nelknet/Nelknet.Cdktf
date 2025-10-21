namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId> = { assignments: ResizeArray<azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule">azurerm_postgresql_virtual_network_rule</a>.
    /// </summary>
    type PostgresqlVirtualNetworkRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlVirtualNetworkRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlVirtualNetworkRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlVirtualNetworkRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlVirtualNetworkRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#name-1">PostgresqlVirtualNetworkRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlVirtualNetworkRuleState<Missing, 'ResourceGroupName, 'ServerName, 'SubnetId>, value: string) : PostgresqlVirtualNetworkRuleState<Present, 'ResourceGroupName, 'ServerName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlVirtualNetworkRuleState<Present, 'ResourceGroupName, 'ServerName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#resource_group_name-1">PostgresqlVirtualNetworkRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlVirtualNetworkRuleState<'Name, Missing, 'ServerName, 'SubnetId>, value: string) : PostgresqlVirtualNetworkRuleState<'Name, Present, 'ServerName, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlVirtualNetworkRuleState<'Name, Present, 'ServerName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#server_name-1">PostgresqlVirtualNetworkRule#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, Missing, 'SubnetId>, value: string) : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#subnet_id-1">PostgresqlVirtualNetworkRule#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, Missing>, value: string) : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#id-1">PostgresqlVirtualNetworkRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>, value: string) : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#ignore_missing_vnet_service_endpoint-1">PostgresqlVirtualNetworkRule#ignore_missing_vnet_service_endpoint</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_missing_vnet_service_endpoint">]
        member _.IgnoreMissingVnetServiceEndpoint(state: PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>, value: bool) : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId> =
            state.assignments.Add(fun config -> config.IgnoreMissingVnetServiceEndpoint <- value)
            state : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#ignore_missing_vnet_service_endpoint-1">PostgresqlVirtualNetworkRule#ignore_missing_vnet_service_endpoint</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_missing_vnet_service_endpoint">]
        member _.IgnoreMissingVnetServiceEndpoint(state: PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId> =
            state.assignments.Add(fun config -> config.IgnoreMissingVnetServiceEndpoint <- value)
            state : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_virtual_network_rule#timeouts-1">PostgresqlVirtualNetworkRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>, value: azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRuleTimeouts) : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlVirtualNetworkRuleState<'Name, 'ResourceGroupName, 'ServerName, 'SubnetId>

        member _.Run(state: PostgresqlVirtualNetworkRuleState<Present, Present, Present, Present>) : azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRule =
            let config = azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlVirtualNetworkRule: missing required arguments. Must call: name, resource_group_name, server_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlVirtualNetworkRuleState<_, _, _, _>) : azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRule =
            Unchecked.defaultof<azurerm.PostgresqlVirtualNetworkRule.PostgresqlVirtualNetworkRule>
