namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId> = { assignments: ResizeArray<azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_security_group_association">azurerm_network_interface_security_group_association</a>.
    /// </summary>
    type NetworkInterfaceSecurityGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceSecurityGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceSecurityGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_security_group_association#network_interface_id-1">NetworkInterfaceSecurityGroupAssociation#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceSecurityGroupAssociationState<Missing, 'NetworkSecurityGroupId>, value: string) : NetworkInterfaceSecurityGroupAssociationState<Present, 'NetworkSecurityGroupId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceSecurityGroupAssociationState<Present, 'NetworkSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_security_group_association#network_security_group_id-1">NetworkInterfaceSecurityGroupAssociation#network_security_group_id</a>.
        /// </summary>
        [<CustomOperation "network_security_group_id">]
        member _.NetworkSecurityGroupId(state: NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, Missing>, value: string) : NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, Present> =
            state.assignments.Add(fun config -> config.NetworkSecurityGroupId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_security_group_association#id-1">NetworkInterfaceSecurityGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId>, value: string) : NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_security_group_association#timeouts-1">NetworkInterfaceSecurityGroupAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId>, value: azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociationTimeouts) : NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceSecurityGroupAssociationState<'NetworkInterfaceId, 'NetworkSecurityGroupId>

        member _.Run(state: NetworkInterfaceSecurityGroupAssociationState<Present, Present>) : azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociation =
            let config = azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkInterfaceSecurityGroupAssociation: missing required arguments. Must call: network_interface_id, network_security_group_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceSecurityGroupAssociationState<_, _>) : azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociation =
            Unchecked.defaultof<azurerm.NetworkInterfaceSecurityGroupAssociation.NetworkInterfaceSecurityGroupAssociation>
