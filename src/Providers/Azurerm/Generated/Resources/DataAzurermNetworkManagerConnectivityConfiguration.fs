namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId> = { assignments: ResizeArray<azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_connectivity_configuration">azurerm_network_manager_connectivity_configuration</a>.
    /// </summary>
    type DataAzurermNetworkManagerConnectivityConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkManagerConnectivityConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkManagerConnectivityConfigurationState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkManagerConnectivityConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkManagerConnectivityConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_connectivity_configuration#name-1">DataAzurermNetworkManagerConnectivityConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetworkManagerConnectivityConfigurationState<Missing, 'NetworkManagerId>, value: string) : DataAzurermNetworkManagerConnectivityConfigurationState<Present, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkManagerConnectivityConfigurationState<Present, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_connectivity_configuration#network_manager_id-1">DataAzurermNetworkManagerConnectivityConfiguration#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: DataAzurermNetworkManagerConnectivityConfigurationState<'Name, Missing>, value: string) : DataAzurermNetworkManagerConnectivityConfigurationState<'Name, Present> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkManagerConnectivityConfigurationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_connectivity_configuration#id-1">DataAzurermNetworkManagerConnectivityConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId>, value: string) : DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_connectivity_configuration#timeouts-1">DataAzurermNetworkManagerConnectivityConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId>, value: azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationTimeouts) : DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkManagerConnectivityConfigurationState<'Name, 'NetworkManagerId>

        member _.Run(state: DataAzurermNetworkManagerConnectivityConfigurationState<Present, Present>) : azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration =
            let config = azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkManagerConnectivityConfiguration: missing required arguments. Must call: name, network_manager_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkManagerConnectivityConfigurationState<_, _>) : azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration =
            Unchecked.defaultof<azurerm.DataAzurermNetworkManagerConnectivityConfiguration.DataAzurermNetworkManagerConnectivityConfiguration>
