namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway_connection">azurerm_virtual_network_gateway_connection</a>.
    /// </summary>
    type DataAzurermVirtualNetworkGatewayConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualNetworkGatewayConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualNetworkGatewayConnectionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualNetworkGatewayConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualNetworkGatewayConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway_connection#name-1">DataAzurermVirtualNetworkGatewayConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualNetworkGatewayConnectionState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualNetworkGatewayConnectionState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualNetworkGatewayConnectionState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway_connection#resource_group_name-1">DataAzurermVirtualNetworkGatewayConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualNetworkGatewayConnectionState<'Name, Missing>, value: string) : DataAzurermVirtualNetworkGatewayConnectionState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualNetworkGatewayConnectionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway_connection#id-1">DataAzurermVirtualNetworkGatewayConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway_connection#timeouts-1">DataAzurermVirtualNetworkGatewayConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTimeouts) : DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualNetworkGatewayConnectionState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualNetworkGatewayConnectionState<Present, Present>) : azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection =
            let config = azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualNetworkGatewayConnection: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualNetworkGatewayConnectionState<_, _>) : azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection =
            Unchecked.defaultof<azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection>
