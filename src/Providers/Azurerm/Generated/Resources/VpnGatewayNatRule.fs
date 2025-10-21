namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnGatewayNatRuleState<'Name, 'VpnGatewayId> = { assignments: ResizeArray<azurerm.VpnGatewayNatRule.VpnGatewayNatRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule">azurerm_vpn_gateway_nat_rule</a>.
    /// </summary>
    type VpnGatewayNatRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnGatewayNatRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayNatRuleState<Missing, Missing>)

        member _.Zero(()) : VpnGatewayNatRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayNatRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#name-1">VpnGatewayNatRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpnGatewayNatRuleState<Missing, 'VpnGatewayId>, value: string) : VpnGatewayNatRuleState<Present, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpnGatewayNatRuleState<Present, 'VpnGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#vpn_gateway_id-1">VpnGatewayNatRule#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: VpnGatewayNatRuleState<'Name, Missing>, value: string) : VpnGatewayNatRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            ({ assignments = state.assignments } : VpnGatewayNatRuleState<'Name, Present>)

        /// <summary>
        /// external_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#external_mapping-1">VpnGatewayNatRule#external_mapping</a> Accepts: azurerm.IResolvable | azurerm.VpnGatewayNatRule.VpnGatewayNatRuleExternalMapping[]
        /// </summary>
        [<CustomOperation "external_mapping">]
        member _.ExternalMapping(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.ExternalMapping <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#id-1">VpnGatewayNatRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: string) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        /// <summary>
        /// internal_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#internal_mapping-1">VpnGatewayNatRule#internal_mapping</a> Accepts: azurerm.IResolvable | azurerm.VpnGatewayNatRule.VpnGatewayNatRuleInternalMapping[]
        /// </summary>
        [<CustomOperation "internal_mapping">]
        member _.InternalMapping(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.InternalMapping <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#ip_configuration_id-1">VpnGatewayNatRule#ip_configuration_id</a>.
        /// </summary>
        [<CustomOperation "ip_configuration_id">]
        member _.IpConfigurationId(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: string) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.IpConfigurationId <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#mode-1">VpnGatewayNatRule#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: string) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#timeouts-1">VpnGatewayNatRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: azurerm.VpnGatewayNatRule.VpnGatewayNatRuleTimeouts) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#type-1">VpnGatewayNatRule#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VpnGatewayNatRuleState<'Name, 'VpnGatewayId>, value: string) : VpnGatewayNatRuleState<'Name, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : VpnGatewayNatRuleState<'Name, 'VpnGatewayId>

        member _.Run(state: VpnGatewayNatRuleState<Present, Present>) : azurerm.VpnGatewayNatRule.VpnGatewayNatRule =
            let config = azurerm.VpnGatewayNatRule.VpnGatewayNatRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.VpnGatewayNatRule.VpnGatewayNatRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vpnGatewayNatRule: missing required arguments. Must call: name, vpn_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: VpnGatewayNatRuleState<_, _>) : azurerm.VpnGatewayNatRule.VpnGatewayNatRule =
            Unchecked.defaultof<azurerm.VpnGatewayNatRule.VpnGatewayNatRule>
