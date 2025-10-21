namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId> = { assignments: ResizeArray<azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnectionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service_endpoint_connections">azurerm_private_link_service_endpoint_connections</a>.
    /// </summary>
    type DataAzurermPrivateLinkServiceEndpointConnectionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateLinkServiceEndpointConnectionsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateLinkServiceEndpointConnectionsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateLinkServiceEndpointConnectionsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateLinkServiceEndpointConnectionsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service_endpoint_connections#resource_group_name-1">DataAzurermPrivateLinkServiceEndpointConnections#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateLinkServiceEndpointConnectionsState<Missing, 'ServiceId>, value: string) : DataAzurermPrivateLinkServiceEndpointConnectionsState<Present, 'ServiceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateLinkServiceEndpointConnectionsState<Present, 'ServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service_endpoint_connections#service_id-1">DataAzurermPrivateLinkServiceEndpointConnections#service_id</a>.
        /// </summary>
        [<CustomOperation "service_id">]
        member _.ServiceId(state: DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, Missing>, value: string) : DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceId <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service_endpoint_connections#id-1">DataAzurermPrivateLinkServiceEndpointConnections#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId>, value: string) : DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service_endpoint_connections#timeouts-1">DataAzurermPrivateLinkServiceEndpointConnections#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId>, value: azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnectionsTimeouts) : DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateLinkServiceEndpointConnectionsState<'ResourceGroupName, 'ServiceId>

        member _.Run(state: DataAzurermPrivateLinkServiceEndpointConnectionsState<Present, Present>) : azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnections =
            let config = azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnectionsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnections(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateLinkServiceEndpointConnections: missing required arguments. Must call: resource_group_name, service_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateLinkServiceEndpointConnectionsState<_, _>) : azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnections =
            Unchecked.defaultof<azurerm.DataAzurermPrivateLinkServiceEndpointConnections.DataAzurermPrivateLinkServiceEndpointConnections>
