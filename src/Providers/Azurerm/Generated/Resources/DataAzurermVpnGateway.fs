namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVpnGatewayState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway">azurerm_vpn_gateway</a>.
    /// </summary>
    type DataAzurermVpnGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVpnGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVpnGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVpnGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVpnGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway#name-1">DataAzurermVpnGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVpnGatewayState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVpnGatewayState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVpnGatewayState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway#resource_group_name-1">DataAzurermVpnGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVpnGatewayState<'Name, Missing>, value: string) : DataAzurermVpnGatewayState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVpnGatewayState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway#id-1">DataAzurermVpnGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVpnGatewayState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVpnGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVpnGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway#timeouts-1">DataAzurermVpnGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVpnGatewayState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayTimeouts) : DataAzurermVpnGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVpnGatewayState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVpnGatewayState<Present, Present>) : azurerm.DataAzurermVpnGateway.DataAzurermVpnGateway =
            let config = azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVpnGateway.DataAzurermVpnGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVpnGateway: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVpnGatewayState<_, _>) : azurerm.DataAzurermVpnGateway.DataAzurermVpnGateway =
            Unchecked.defaultof<azurerm.DataAzurermVpnGateway.DataAzurermVpnGateway>
