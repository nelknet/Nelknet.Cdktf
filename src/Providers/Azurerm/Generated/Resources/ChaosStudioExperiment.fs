namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps> = { assignments: ResizeArray<azurerm.ChaosStudioExperiment.ChaosStudioExperimentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment">azurerm_chaos_studio_experiment</a>.
    /// </summary>
    type ChaosStudioExperimentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChaosStudioExperimentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChaosStudioExperimentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ChaosStudioExperimentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChaosStudioExperimentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#location-1">ChaosStudioExperiment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ChaosStudioExperimentState<Missing, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>, value: string) : ChaosStudioExperimentState<Present, 'Name, 'ResourceGroupName, 'Selectors, 'Steps> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ChaosStudioExperimentState<Present, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#name-1">ChaosStudioExperiment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChaosStudioExperimentState<'Location, Missing, 'ResourceGroupName, 'Selectors, 'Steps>, value: string) : ChaosStudioExperimentState<'Location, Present, 'ResourceGroupName, 'Selectors, 'Steps> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChaosStudioExperimentState<'Location, Present, 'ResourceGroupName, 'Selectors, 'Steps>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#resource_group_name-1">ChaosStudioExperiment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ChaosStudioExperimentState<'Location, 'Name, Missing, 'Selectors, 'Steps>, value: string) : ChaosStudioExperimentState<'Location, 'Name, Present, 'Selectors, 'Steps> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ChaosStudioExperimentState<'Location, 'Name, Present, 'Selectors, 'Steps>)

        /// <summary>
        /// selectors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#selectors-1">ChaosStudioExperiment#selectors</a> Accepts: azurerm.IResolvable | azurerm.ChaosStudioExperiment.ChaosStudioExperimentSelectors[]
        /// </summary>
        [<CustomOperation "selectors">]
        member _.Selectors(state: ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, Missing, 'Steps>, value: HashiCorp.Cdktf.IResolvable) : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, Present, 'Steps> =
            state.assignments.Add(fun config -> config.Selectors <- value)
            ({ assignments = state.assignments } : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, Present, 'Steps>)

        /// <summary>
        /// steps block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#steps-1">ChaosStudioExperiment#steps</a> Accepts: azurerm.IResolvable | azurerm.ChaosStudioExperiment.ChaosStudioExperimentSteps[]
        /// </summary>
        [<CustomOperation "steps">]
        member _.Steps(state: ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, Missing>, value: HashiCorp.Cdktf.IResolvable) : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, Present> =
            state.assignments.Add(fun config -> config.Steps <- value)
            ({ assignments = state.assignments } : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#id-1">ChaosStudioExperiment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>, value: string) : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#identity-1">ChaosStudioExperiment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>, value: azurerm.ChaosStudioExperiment.ChaosStudioExperimentIdentity) : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#timeouts-1">ChaosStudioExperiment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>, value: azurerm.ChaosStudioExperiment.ChaosStudioExperimentTimeouts) : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChaosStudioExperimentState<'Location, 'Name, 'ResourceGroupName, 'Selectors, 'Steps>

        member _.Run(state: ChaosStudioExperimentState<Present, Present, Present, Present, Present>) : azurerm.ChaosStudioExperiment.ChaosStudioExperiment =
            let config = azurerm.ChaosStudioExperiment.ChaosStudioExperimentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ChaosStudioExperiment.ChaosStudioExperiment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.chaosStudioExperiment: missing required arguments. Must call: location, name, resource_group_name, selectors, steps.", 9999, IsError = true)>]
        member _.Run(_: ChaosStudioExperimentState<_, _, _, _, _>) : azurerm.ChaosStudioExperiment.ChaosStudioExperiment =
            Unchecked.defaultof<azurerm.ChaosStudioExperiment.ChaosStudioExperiment>
