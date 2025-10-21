namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure">azurerm_synapse_integration_runtime_azure</a>.
    /// </summary>
    type SynapseIntegrationRuntimeAzureBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseIntegrationRuntimeAzureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseIntegrationRuntimeAzureState<Missing, Missing, Missing>)

        member _.Zero(()) : SynapseIntegrationRuntimeAzureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseIntegrationRuntimeAzureState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#location-1">SynapseIntegrationRuntimeAzure#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SynapseIntegrationRuntimeAzureState<Missing, 'Name, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeAzureState<Present, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SynapseIntegrationRuntimeAzureState<Present, 'Name, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#name-1">SynapseIntegrationRuntimeAzure#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseIntegrationRuntimeAzureState<'Location, Missing, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeAzureState<'Location, Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseIntegrationRuntimeAzureState<'Location, Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#synapse_workspace_id-1">SynapseIntegrationRuntimeAzure#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, Missing>, value: string) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseIntegrationRuntimeAzureState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#compute_type-1">SynapseIntegrationRuntimeAzure#compute_type</a>.
        /// </summary>
        [<CustomOperation "compute_type">]
        member _.ComputeType(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.ComputeType <- value)
            state : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#core_count-1">SynapseIntegrationRuntimeAzure#core_count</a>.
        /// </summary>
        [<CustomOperation "core_count">]
        member _.CoreCount(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>, value: double) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.CoreCount <- value)
            state : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#description-1">SynapseIntegrationRuntimeAzure#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#id-1">SynapseIntegrationRuntimeAzure#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#timeouts-1">SynapseIntegrationRuntimeAzure#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>, value: azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzureTimeouts) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_azure#time_to_live_min-1">SynapseIntegrationRuntimeAzure#time_to_live_min</a>.
        /// </summary>
        [<CustomOperation "time_to_live_min">]
        member _.TimeToLiveMin(state: SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>, value: double) : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.TimeToLiveMin <- value)
            state : SynapseIntegrationRuntimeAzureState<'Location, 'Name, 'SynapseWorkspaceId>

        member _.Run(state: SynapseIntegrationRuntimeAzureState<Present, Present, Present>) : azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzure =
            let config = azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzureConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzure(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseIntegrationRuntimeAzure: missing required arguments. Must call: location, name, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseIntegrationRuntimeAzureState<_, _, _>) : azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzure =
            Unchecked.defaultof<azurerm.SynapseIntegrationRuntimeAzure.SynapseIntegrationRuntimeAzure>
