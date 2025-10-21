namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId> = { assignments: ResizeArray<azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_backend_address_pool_association">azurerm_network_interface_backend_address_pool_association</a>.
    /// </summary>
    type NetworkInterfaceBackendAddressPoolAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceBackendAddressPoolAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceBackendAddressPoolAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceBackendAddressPoolAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceBackendAddressPoolAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_backend_address_pool_association#backend_address_pool_id-1">NetworkInterfaceBackendAddressPoolAssociation#backend_address_pool_id</a>.
        /// </summary>
        [<CustomOperation "backend_address_pool_id">]
        member _.BackendAddressPoolId(state: NetworkInterfaceBackendAddressPoolAssociationState<Missing, 'IpConfigurationName, 'NetworkInterfaceId>, value: string) : NetworkInterfaceBackendAddressPoolAssociationState<Present, 'IpConfigurationName, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.BackendAddressPoolId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceBackendAddressPoolAssociationState<Present, 'IpConfigurationName, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_backend_address_pool_association#ip_configuration_name-1">NetworkInterfaceBackendAddressPoolAssociation#ip_configuration_name</a>.
        /// </summary>
        [<CustomOperation "ip_configuration_name">]
        member _.IpConfigurationName(state: NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, Missing, 'NetworkInterfaceId>, value: string) : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, Present, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.IpConfigurationName <- value)
            ({ assignments = state.assignments } : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, Present, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_backend_address_pool_association#network_interface_id-1">NetworkInterfaceBackendAddressPoolAssociation#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, Missing>, value: string) : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, Present> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_backend_address_pool_association#id-1">NetworkInterfaceBackendAddressPoolAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>, value: string) : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_backend_address_pool_association#timeouts-1">NetworkInterfaceBackendAddressPoolAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>, value: azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationTimeouts) : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>

        member _.Run(state: NetworkInterfaceBackendAddressPoolAssociationState<Present, Present, Present>) : azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation =
            let config = azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkInterfaceBackendAddressPoolAssociation: missing required arguments. Must call: backend_address_pool_id, ip_configuration_name, network_interface_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceBackendAddressPoolAssociationState<_, _, _>) : azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation =
            Unchecked.defaultof<azurerm.NetworkInterfaceBackendAddressPoolAssociation.NetworkInterfaceBackendAddressPoolAssociation>
