namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId> = { assignments: ResizeArray<azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_security_group_association">azurerm_network_interface_application_security_group_association</a>.
    /// </summary>
    type NetworkInterfaceApplicationSecurityGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceApplicationSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceApplicationSecurityGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceApplicationSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceApplicationSecurityGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_security_group_association#application_security_group_id-1">NetworkInterfaceApplicationSecurityGroupAssociation#application_security_group_id</a>.
        /// </summary>
        [<CustomOperation "application_security_group_id">]
        member _.ApplicationSecurityGroupId(state: NetworkInterfaceApplicationSecurityGroupAssociationState<Missing, 'NetworkInterfaceId>, value: string) : NetworkInterfaceApplicationSecurityGroupAssociationState<Present, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.ApplicationSecurityGroupId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceApplicationSecurityGroupAssociationState<Present, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_security_group_association#network_interface_id-1">NetworkInterfaceApplicationSecurityGroupAssociation#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, Missing>, value: string) : NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, Present> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_security_group_association#id-1">NetworkInterfaceApplicationSecurityGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId>, value: string) : NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_security_group_association#timeouts-1">NetworkInterfaceApplicationSecurityGroupAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId>, value: azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociationTimeouts) : NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'NetworkInterfaceId>

        member _.Run(state: NetworkInterfaceApplicationSecurityGroupAssociationState<Present, Present>) : azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociation =
            let config = azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkInterfaceApplicationSecurityGroupAssociation: missing required arguments. Must call: application_security_group_id, network_interface_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceApplicationSecurityGroupAssociationState<_, _>) : azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociation =
            Unchecked.defaultof<azurerm.NetworkInterfaceApplicationSecurityGroupAssociation.NetworkInterfaceApplicationSecurityGroupAssociation>
