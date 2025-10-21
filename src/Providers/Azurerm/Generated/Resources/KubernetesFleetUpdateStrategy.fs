namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage> = { assignments: ResizeArray<azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy">azurerm_kubernetes_fleet_update_strategy</a>.
    /// </summary>
    type KubernetesFleetUpdateStrategyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesFleetUpdateStrategyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetUpdateStrategyState<Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesFleetUpdateStrategyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetUpdateStrategyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#kubernetes_fleet_manager_id-1">KubernetesFleetUpdateStrategy#kubernetes_fleet_manager_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_fleet_manager_id">]
        member _.KubernetesFleetManagerId(state: KubernetesFleetUpdateStrategyState<Missing, 'Name, 'Stage>, value: string) : KubernetesFleetUpdateStrategyState<Present, 'Name, 'Stage> =
            state.assignments.Add(fun config -> config.KubernetesFleetManagerId <- value)
            ({ assignments = state.assignments } : KubernetesFleetUpdateStrategyState<Present, 'Name, 'Stage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#name-1">KubernetesFleetUpdateStrategy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, Missing, 'Stage>, value: string) : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, Present, 'Stage> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, Present, 'Stage>)

        /// <summary>
        /// stage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#stage-1">KubernetesFleetUpdateStrategy#stage</a> Accepts: azurerm.IResolvable | azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStage[]
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Stage <- value)
            ({ assignments = state.assignments } : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#id-1">KubernetesFleetUpdateStrategy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage>, value: string) : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#timeouts-1">KubernetesFleetUpdateStrategy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage>, value: azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyTimeouts) : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesFleetUpdateStrategyState<'KubernetesFleetManagerId, 'Name, 'Stage>

        member _.Run(state: KubernetesFleetUpdateStrategyState<Present, Present, Present>) : azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategy =
            let config = azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesFleetUpdateStrategy: missing required arguments. Must call: kubernetes_fleet_manager_id, name, stage.", 9999, IsError = true)>]
        member _.Run(_: KubernetesFleetUpdateStrategyState<_, _, _>) : azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategy =
            Unchecked.defaultof<azurerm.KubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategy>
