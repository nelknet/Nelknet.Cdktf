namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.KubernetesFleetManager.KubernetesFleetManagerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager">azurerm_kubernetes_fleet_manager</a>.
    /// </summary>
    type KubernetesFleetManagerBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesFleetManagerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetManagerState<Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesFleetManagerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetManagerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#location-1">KubernetesFleetManager#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KubernetesFleetManagerState<Missing, 'Name, 'ResourceGroupName>, value: string) : KubernetesFleetManagerState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KubernetesFleetManagerState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#name-1">KubernetesFleetManager#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesFleetManagerState<'Location, Missing, 'ResourceGroupName>, value: string) : KubernetesFleetManagerState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesFleetManagerState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#resource_group_name-1">KubernetesFleetManager#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KubernetesFleetManagerState<'Location, 'Name, Missing>, value: string) : KubernetesFleetManagerState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KubernetesFleetManagerState<'Location, 'Name, Present>)

        /// <summary>
        /// hub_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#hub_profile-1">KubernetesFleetManager#hub_profile</a>
        /// </summary>
        [<CustomOperation "hub_profile">]
        member _.HubProfile(state: KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesFleetManager.KubernetesFleetManagerHubProfile) : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HubProfile <- value)
            state : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#id-1">KubernetesFleetManager#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>, value: string) : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#tags-1">KubernetesFleetManager#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#timeouts-1">KubernetesFleetManager#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.KubernetesFleetManager.KubernetesFleetManagerTimeouts) : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesFleetManagerState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: KubernetesFleetManagerState<Present, Present, Present>) : azurerm.KubernetesFleetManager.KubernetesFleetManager =
            let config = azurerm.KubernetesFleetManager.KubernetesFleetManagerConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesFleetManager.KubernetesFleetManager(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesFleetManager: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: KubernetesFleetManagerState<_, _, _>) : azurerm.KubernetesFleetManager.KubernetesFleetManager =
            Unchecked.defaultof<azurerm.KubernetesFleetManager.KubernetesFleetManager>
