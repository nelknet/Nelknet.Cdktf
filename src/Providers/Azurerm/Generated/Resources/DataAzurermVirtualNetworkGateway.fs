namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway">azurerm_virtual_network_gateway</a>.
    /// </summary>
    type DataAzurermVirtualNetworkGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualNetworkGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualNetworkGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualNetworkGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualNetworkGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#name-1">DataAzurermVirtualNetworkGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualNetworkGatewayState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualNetworkGatewayState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualNetworkGatewayState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#resource_group_name-1">DataAzurermVirtualNetworkGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualNetworkGatewayState<'Name, Missing>, value: string) : DataAzurermVirtualNetworkGatewayState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualNetworkGatewayState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#id-1">DataAzurermVirtualNetworkGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#timeouts-1">DataAzurermVirtualNetworkGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGatewayTimeouts) : DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualNetworkGatewayState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualNetworkGatewayState<Present, Present>) : azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGateway =
            let config = azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualNetworkGateway: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualNetworkGatewayState<_, _>) : azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGateway =
            Unchecked.defaultof<azurerm.DataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGateway>
