namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection">azurerm_virtual_hub_connection</a>.
    /// </summary>
    type DataAzurermVirtualHubConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualHubConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualHubConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualHubConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualHubConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#name-1">DataAzurermVirtualHubConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualHubConnectionState<Missing, 'ResourceGroupName, 'VirtualHubName>, value: string) : DataAzurermVirtualHubConnectionState<Present, 'ResourceGroupName, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubConnectionState<Present, 'ResourceGroupName, 'VirtualHubName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#resource_group_name-1">DataAzurermVirtualHubConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualHubConnectionState<'Name, Missing, 'VirtualHubName>, value: string) : DataAzurermVirtualHubConnectionState<'Name, Present, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubConnectionState<'Name, Present, 'VirtualHubName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#virtual_hub_name-1">DataAzurermVirtualHubConnection#virtual_hub_name</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_name">]
        member _.VirtualHubName(state: DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualHubName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#id-1">DataAzurermVirtualHubConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName>, value: string) : DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#timeouts-1">DataAzurermVirtualHubConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName>, value: azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionTimeouts) : DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualHubConnectionState<'Name, 'ResourceGroupName, 'VirtualHubName>

        member _.Run(state: DataAzurermVirtualHubConnectionState<Present, Present, Present>) : azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnection =
            let config = azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualHubConnection: missing required arguments. Must call: name, resource_group_name, virtual_hub_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualHubConnectionState<_, _, _>) : azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnection =
            Unchecked.defaultof<azurerm.DataAzurermVirtualHubConnection.DataAzurermVirtualHubConnection>
