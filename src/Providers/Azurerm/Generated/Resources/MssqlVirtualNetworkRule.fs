namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId> = { assignments: ResizeArray<azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule">azurerm_mssql_virtual_network_rule</a>.
    /// </summary>
    type MssqlVirtualNetworkRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlVirtualNetworkRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualNetworkRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : MssqlVirtualNetworkRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualNetworkRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#name-1">MssqlVirtualNetworkRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlVirtualNetworkRuleState<Missing, 'ServerId, 'SubnetId>, value: string) : MssqlVirtualNetworkRuleState<Present, 'ServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlVirtualNetworkRuleState<Present, 'ServerId, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#server_id-1">MssqlVirtualNetworkRule#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlVirtualNetworkRuleState<'Name, Missing, 'SubnetId>, value: string) : MssqlVirtualNetworkRuleState<'Name, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlVirtualNetworkRuleState<'Name, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#subnet_id-1">MssqlVirtualNetworkRule#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: MssqlVirtualNetworkRuleState<'Name, 'ServerId, Missing>, value: string) : MssqlVirtualNetworkRuleState<'Name, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : MssqlVirtualNetworkRuleState<'Name, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#id-1">MssqlVirtualNetworkRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>, value: string) : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#ignore_missing_vnet_service_endpoint-1">MssqlVirtualNetworkRule#ignore_missing_vnet_service_endpoint</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_missing_vnet_service_endpoint">]
        member _.IgnoreMissingVnetServiceEndpoint(state: MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>, value: bool) : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.IgnoreMissingVnetServiceEndpoint <- value)
            state : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#ignore_missing_vnet_service_endpoint-1">MssqlVirtualNetworkRule#ignore_missing_vnet_service_endpoint</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_missing_vnet_service_endpoint">]
        member _.IgnoreMissingVnetServiceEndpoint(state: MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.IgnoreMissingVnetServiceEndpoint <- value)
            state : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_network_rule#timeouts-1">MssqlVirtualNetworkRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>, value: azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRuleTimeouts) : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlVirtualNetworkRuleState<'Name, 'ServerId, 'SubnetId>

        member _.Run(state: MssqlVirtualNetworkRuleState<Present, Present, Present>) : azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRule =
            let config = azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlVirtualNetworkRule: missing required arguments. Must call: name, server_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlVirtualNetworkRuleState<_, _, _>) : azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRule =
            Unchecked.defaultof<azurerm.MssqlVirtualNetworkRule.MssqlVirtualNetworkRule>
