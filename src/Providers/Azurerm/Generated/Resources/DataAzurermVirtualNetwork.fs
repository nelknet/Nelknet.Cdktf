namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network">azurerm_virtual_network</a>.
    /// </summary>
    type DataAzurermVirtualNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualNetworkState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualNetworkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network#name-1">DataAzurermVirtualNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualNetworkState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualNetworkState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualNetworkState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network#resource_group_name-1">DataAzurermVirtualNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualNetworkState<'Name, Missing>, value: string) : DataAzurermVirtualNetworkState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualNetworkState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network#id-1">DataAzurermVirtualNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network#timeouts-1">DataAzurermVirtualNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetworkTimeouts) : DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualNetworkState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualNetworkState<Present, Present>) : azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetwork =
            let config = azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualNetwork: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualNetworkState<_, _>) : azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetwork =
            Unchecked.defaultof<azurerm.DataAzurermVirtualNetwork.DataAzurermVirtualNetwork>
