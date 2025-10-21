namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway">azurerm_local_network_gateway</a>.
    /// </summary>
    type DataAzurermLocalNetworkGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLocalNetworkGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLocalNetworkGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLocalNetworkGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLocalNetworkGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#name-1">DataAzurermLocalNetworkGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLocalNetworkGatewayState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLocalNetworkGatewayState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLocalNetworkGatewayState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#resource_group_name-1">DataAzurermLocalNetworkGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLocalNetworkGatewayState<'Name, Missing>, value: string) : DataAzurermLocalNetworkGatewayState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLocalNetworkGatewayState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#id-1">DataAzurermLocalNetworkGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#timeouts-1">DataAzurermLocalNetworkGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGatewayTimeouts) : DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLocalNetworkGatewayState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLocalNetworkGatewayState<Present, Present>) : azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGateway =
            let config = azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLocalNetworkGateway: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLocalNetworkGatewayState<_, _>) : azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGateway =
            Unchecked.defaultof<azurerm.DataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGateway>
