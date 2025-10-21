namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId> = { assignments: ResizeArray<azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_gateway_backend_address_pool_association">azurerm_network_interface_application_gateway_backend_address_pool_association</a>.
    /// </summary>
    type NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_gateway_backend_address_pool_association#backend_address_pool_id-1">NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation#backend_address_pool_id</a>.
        /// </summary>
        [<CustomOperation "backend_address_pool_id">]
        member _.BackendAddressPoolId(state: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Missing, 'IpConfigurationName, 'NetworkInterfaceId>, value: string) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Present, 'IpConfigurationName, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.BackendAddressPoolId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Present, 'IpConfigurationName, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_gateway_backend_address_pool_association#ip_configuration_name-1">NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation#ip_configuration_name</a>.
        /// </summary>
        [<CustomOperation "ip_configuration_name">]
        member _.IpConfigurationName(state: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, Missing, 'NetworkInterfaceId>, value: string) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, Present, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.IpConfigurationName <- value)
            ({ assignments = state.assignments } : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, Present, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_gateway_backend_address_pool_association#network_interface_id-1">NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, Missing>, value: string) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, Present> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_gateway_backend_address_pool_association#id-1">NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>, value: string) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface_application_gateway_backend_address_pool_association#timeouts-1">NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>, value: azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationTimeouts) : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<'BackendAddressPoolId, 'IpConfigurationName, 'NetworkInterfaceId>

        member _.Run(state: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<Present, Present, Present>) : azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation =
            let config = azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkInterfaceApplicationGatewayBackendAddressPoolAssociation: missing required arguments. Must call: backend_address_pool_id, ip_configuration_name, network_interface_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationState<_, _, _>) : azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation =
            Unchecked.defaultof<azurerm.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation>
