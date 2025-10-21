namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId> = { assignments: ResizeArray<azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_nat_rule_association">azurerm_network_interface_nat_rule_association</a>.
    /// </summary>
    type NetworkInterfaceNatRuleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceNatRuleAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceNatRuleAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceNatRuleAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceNatRuleAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_nat_rule_association#ip_configuration_name-1">NetworkInterfaceNatRuleAssociation#ip_configuration_name</a>.
        /// </summary>
        [<CustomOperation "ip_configuration_name">]
        member _.IpConfigurationName(state: NetworkInterfaceNatRuleAssociationState<Missing, 'NatRuleId, 'NetworkInterfaceId>, value: string) : NetworkInterfaceNatRuleAssociationState<Present, 'NatRuleId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.IpConfigurationName <- value)
            ({ assignments = state.assignments } : NetworkInterfaceNatRuleAssociationState<Present, 'NatRuleId, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_nat_rule_association#nat_rule_id-1">NetworkInterfaceNatRuleAssociation#nat_rule_id</a>.
        /// </summary>
        [<CustomOperation "nat_rule_id">]
        member _.NatRuleId(state: NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, Missing, 'NetworkInterfaceId>, value: string) : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, Present, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.NatRuleId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, Present, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_nat_rule_association#network_interface_id-1">NetworkInterfaceNatRuleAssociation#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, Missing>, value: string) : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, Present> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_nat_rule_association#id-1">NetworkInterfaceNatRuleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId>, value: string) : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_nat_rule_association#timeouts-1">NetworkInterfaceNatRuleAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId>, value: azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociationTimeouts) : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceNatRuleAssociationState<'IpConfigurationName, 'NatRuleId, 'NetworkInterfaceId>

        member _.Run(state: NetworkInterfaceNatRuleAssociationState<Present, Present, Present>) : azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociation =
            let config = azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkInterfaceNatRuleAssociation: missing required arguments. Must call: ip_configuration_name, nat_rule_id, network_interface_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceNatRuleAssociationState<_, _, _>) : azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociation =
            Unchecked.defaultof<azurerm.NetworkInterfaceNatRuleAssociation.NetworkInterfaceNatRuleAssociation>
