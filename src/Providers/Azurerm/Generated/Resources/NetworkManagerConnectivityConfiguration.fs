namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> = { assignments: ResizeArray<azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration">azurerm_network_manager_connectivity_configuration</a>.
    /// </summary>
    type NetworkManagerConnectivityConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerConnectivityConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerConnectivityConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerConnectivityConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerConnectivityConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// applies_to_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#applies_to_group-1">NetworkManagerConnectivityConfiguration#applies_to_group</a> Accepts: azurerm.IResolvable | azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfigurationAppliesToGroup[]
        /// </summary>
        [<CustomOperation "applies_to_group">]
        member _.AppliesToGroup(state: NetworkManagerConnectivityConfigurationState<Missing, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: HashiCorp.Cdktf.IResolvable) : NetworkManagerConnectivityConfigurationState<Present, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.AppliesToGroup <- value)
            ({ assignments = state.assignments } : NetworkManagerConnectivityConfigurationState<Present, 'ConnectivityTopology, 'Name, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#connectivity_topology-1">NetworkManagerConnectivityConfiguration#connectivity_topology</a>.
        /// </summary>
        [<CustomOperation "connectivity_topology">]
        member _.ConnectivityTopology(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, Missing, 'Name, 'NetworkManagerId>, value: string) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, Present, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.ConnectivityTopology <- value)
            ({ assignments = state.assignments } : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, Present, 'Name, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#name-1">NetworkManagerConnectivityConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, Missing, 'NetworkManagerId>, value: string) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, Present, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, Present, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#network_manager_id-1">NetworkManagerConnectivityConfiguration#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, Missing>, value: string) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, Present> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#delete_existing_peering_enabled-1">NetworkManagerConnectivityConfiguration#delete_existing_peering_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "delete_existing_peering_enabled">]
        member _.DeleteExistingPeeringEnabled(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: bool) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.DeleteExistingPeeringEnabled <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#delete_existing_peering_enabled-1">NetworkManagerConnectivityConfiguration#delete_existing_peering_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "delete_existing_peering_enabled">]
        member _.DeleteExistingPeeringEnabled(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: HashiCorp.Cdktf.IResolvable) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.DeleteExistingPeeringEnabled <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#description-1">NetworkManagerConnectivityConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: string) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#global_mesh_enabled-1">NetworkManagerConnectivityConfiguration#global_mesh_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "global_mesh_enabled">]
        member _.GlobalMeshEnabled(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: bool) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.GlobalMeshEnabled <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#global_mesh_enabled-1">NetworkManagerConnectivityConfiguration#global_mesh_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "global_mesh_enabled">]
        member _.GlobalMeshEnabled(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: HashiCorp.Cdktf.IResolvable) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.GlobalMeshEnabled <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// hub block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#hub-1">NetworkManagerConnectivityConfiguration#hub</a>
        /// </summary>
        [<CustomOperation "hub">]
        member _.Hub(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfigurationHub) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Hub <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#id-1">NetworkManagerConnectivityConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: string) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_connectivity_configuration#timeouts-1">NetworkManagerConnectivityConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>, value: azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfigurationTimeouts) : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerConnectivityConfigurationState<'AppliesToGroup, 'ConnectivityTopology, 'Name, 'NetworkManagerId>

        member _.Run(state: NetworkManagerConnectivityConfigurationState<Present, Present, Present, Present>) : azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfiguration =
            let config = azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerConnectivityConfiguration: missing required arguments. Must call: applies_to_group, connectivity_topology, name, network_manager_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerConnectivityConfigurationState<_, _, _, _>) : azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfiguration =
            Unchecked.defaultof<azurerm.NetworkManagerConnectivityConfiguration.NetworkManagerConnectivityConfiguration>
