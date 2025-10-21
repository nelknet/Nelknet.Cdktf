namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHostedConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted">azurerm_synapse_integration_runtime_self_hosted</a>.
    /// </summary>
    type SynapseIntegrationRuntimeSelfHostedBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseIntegrationRuntimeSelfHostedState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseIntegrationRuntimeSelfHostedState<Missing, Missing>)

        member _.Zero(()) : SynapseIntegrationRuntimeSelfHostedState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseIntegrationRuntimeSelfHostedState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#name-1">SynapseIntegrationRuntimeSelfHosted#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseIntegrationRuntimeSelfHostedState<Missing, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeSelfHostedState<Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseIntegrationRuntimeSelfHostedState<Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#synapse_workspace_id-1">SynapseIntegrationRuntimeSelfHosted#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseIntegrationRuntimeSelfHostedState<'Name, Missing>, value: string) : SynapseIntegrationRuntimeSelfHostedState<'Name, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseIntegrationRuntimeSelfHostedState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#description-1">SynapseIntegrationRuntimeSelfHosted#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#id-1">SynapseIntegrationRuntimeSelfHosted#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId>, value: string) : SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_integration_runtime_self_hosted#timeouts-1">SynapseIntegrationRuntimeSelfHosted#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId>, value: azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHostedTimeouts) : SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseIntegrationRuntimeSelfHostedState<'Name, 'SynapseWorkspaceId>

        member _.Run(state: SynapseIntegrationRuntimeSelfHostedState<Present, Present>) : azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHosted =
            let config = azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHostedConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHosted(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseIntegrationRuntimeSelfHosted: missing required arguments. Must call: name, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseIntegrationRuntimeSelfHostedState<_, _>) : azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHosted =
            Unchecked.defaultof<azurerm.SynapseIntegrationRuntimeSelfHosted.SynapseIntegrationRuntimeSelfHosted>
