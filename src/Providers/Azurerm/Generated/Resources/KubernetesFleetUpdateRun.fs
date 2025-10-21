namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name> = { assignments: ResizeArray<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run">azurerm_kubernetes_fleet_update_run</a>.
    /// </summary>
    type KubernetesFleetUpdateRunBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesFleetUpdateRunState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetUpdateRunState<Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesFleetUpdateRunState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetUpdateRunState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#kubernetes_fleet_manager_id-1">KubernetesFleetUpdateRun#kubernetes_fleet_manager_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_fleet_manager_id">]
        member _.KubernetesFleetManagerId(state: KubernetesFleetUpdateRunState<Missing, 'ManagedClusterUpdate, 'Name>, value: string) : KubernetesFleetUpdateRunState<Present, 'ManagedClusterUpdate, 'Name> =
            state.assignments.Add(fun config -> config.KubernetesFleetManagerId <- value)
            ({ assignments = state.assignments } : KubernetesFleetUpdateRunState<Present, 'ManagedClusterUpdate, 'Name>)

        /// <summary>
        /// managed_cluster_update block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#managed_cluster_update-1">KubernetesFleetUpdateRun#managed_cluster_update</a>
        /// </summary>
        [<CustomOperation "managed_cluster_update">]
        member _.ManagedClusterUpdate(state: KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, Missing, 'Name>, value: azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate) : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagedClusterUpdate <- value)
            ({ assignments = state.assignments } : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#name-1">KubernetesFleetUpdateRun#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, Missing>, value: string) : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#fleet_update_strategy_id-1">KubernetesFleetUpdateRun#fleet_update_strategy_id</a>.
        /// </summary>
        [<CustomOperation "fleet_update_strategy_id">]
        member _.FleetUpdateStrategyId(state: KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>, value: string) : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name> =
            state.assignments.Add(fun config -> config.FleetUpdateStrategyId <- value)
            state : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#id-1">KubernetesFleetUpdateRun#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>, value: string) : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>

        /// <summary>
        /// stage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#stage-1">KubernetesFleetUpdateRun#stage</a> Accepts: azurerm.IResolvable | azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunStage[]
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>, value: HashiCorp.Cdktf.IResolvable) : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name> =
            state.assignments.Add(fun config -> config.Stage <- value)
            state : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#timeouts-1">KubernetesFleetUpdateRun#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>, value: azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeouts) : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesFleetUpdateRunState<'KubernetesFleetManagerId, 'ManagedClusterUpdate, 'Name>

        member _.Run(state: KubernetesFleetUpdateRunState<Present, Present, Present>) : azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun =
            let config = azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesFleetUpdateRun: missing required arguments. Must call: kubernetes_fleet_manager_id, managed_cluster_update, name.", 9999, IsError = true)>]
        member _.Run(_: KubernetesFleetUpdateRunState<_, _, _>) : azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun =
            Unchecked.defaultof<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun>
