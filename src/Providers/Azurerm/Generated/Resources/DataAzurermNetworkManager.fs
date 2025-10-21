namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkManagerState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetworkManager.DataAzurermNetworkManagerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager">azurerm_network_manager</a>.
    /// </summary>
    type DataAzurermNetworkManagerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkManagerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkManagerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkManagerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkManagerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager#name-1">DataAzurermNetworkManager#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetworkManagerState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNetworkManagerState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkManagerState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager#resource_group_name-1">DataAzurermNetworkManager#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetworkManagerState<'Name, Missing>, value: string) : DataAzurermNetworkManagerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkManagerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager#id-1">DataAzurermNetworkManager#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkManagerState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNetworkManagerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkManagerState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager#timeouts-1">DataAzurermNetworkManager#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkManagerState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetworkManager.DataAzurermNetworkManagerTimeouts) : DataAzurermNetworkManagerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkManagerState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetworkManagerState<Present, Present>) : azurerm.DataAzurermNetworkManager.DataAzurermNetworkManager =
            let config = azurerm.DataAzurermNetworkManager.DataAzurermNetworkManagerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkManager.DataAzurermNetworkManager(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkManager: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkManagerState<_, _>) : azurerm.DataAzurermNetworkManager.DataAzurermNetworkManager =
            Unchecked.defaultof<azurerm.DataAzurermNetworkManager.DataAzurermNetworkManager>
