namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> = { assignments: ResizeArray<azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule">azurerm_virtual_network_gateway_nat_rule</a>.
    /// </summary>
    type VirtualNetworkGatewayNatRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualNetworkGatewayNatRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkGatewayNatRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualNetworkGatewayNatRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkGatewayNatRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// external_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#external_mapping-1">VirtualNetworkGatewayNatRule#external_mapping</a> Accepts: azurerm.IResolvable | azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleExternalMapping[]
        /// </summary>
        [<CustomOperation "external_mapping">]
        member _.ExternalMapping(state: VirtualNetworkGatewayNatRuleState<Missing, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayNatRuleState<Present, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ExternalMapping <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayNatRuleState<Present, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// internal_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#internal_mapping-1">VirtualNetworkGatewayNatRule#internal_mapping</a> Accepts: azurerm.IResolvable | azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleInternalMapping[]
        /// </summary>
        [<CustomOperation "internal_mapping">]
        member _.InternalMapping(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, Missing, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, Present, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.InternalMapping <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayNatRuleState<'ExternalMapping, Present, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#name-1">VirtualNetworkGatewayNatRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, Missing, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, Present, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, Present, 'ResourceGroupName, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#resource_group_name-1">VirtualNetworkGatewayNatRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, Missing, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, Present, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, Present, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#virtual_network_gateway_id-1">VirtualNetworkGatewayNatRule#virtual_network_gateway_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_gateway_id">]
        member _.VirtualNetworkGatewayId(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, Missing>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkGatewayId <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#id-1">VirtualNetworkGatewayNatRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#ip_configuration_id-1">VirtualNetworkGatewayNatRule#ip_configuration_id</a>.
        /// </summary>
        [<CustomOperation "ip_configuration_id">]
        member _.IpConfigurationId(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.IpConfigurationId <- value)
            state : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#mode-1">VirtualNetworkGatewayNatRule#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#timeouts-1">VirtualNetworkGatewayNatRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleTimeouts) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#type-1">VirtualNetworkGatewayNatRule#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : VirtualNetworkGatewayNatRuleState<'ExternalMapping, 'InternalMapping, 'Name, 'ResourceGroupName, 'VirtualNetworkGatewayId>

        member _.Run(state: VirtualNetworkGatewayNatRuleState<Present, Present, Present, Present, Present>) : azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRule =
            let config = azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualNetworkGatewayNatRule: missing required arguments. Must call: external_mapping, internal_mapping, name, resource_group_name, virtual_network_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualNetworkGatewayNatRuleState<_, _, _, _, _>) : azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRule =
            Unchecked.defaultof<azurerm.VirtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRule>
