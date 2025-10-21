namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> = { assignments: ResizeArray<azurerm.SynapseLinkedService.SynapseLinkedServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service">azurerm_synapse_linked_service</a>.
    /// </summary>
    type SynapseLinkedServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseLinkedServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseLinkedServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseLinkedServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseLinkedServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#name-1">SynapseLinkedService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseLinkedServiceState<Missing, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: string) : SynapseLinkedServiceState<Present, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseLinkedServiceState<Present, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#synapse_workspace_id-1">SynapseLinkedService#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseLinkedServiceState<'Name, Missing, 'Type, 'TypePropertiesJson>, value: string) : SynapseLinkedServiceState<'Name, Present, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseLinkedServiceState<'Name, Present, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#type-1">SynapseLinkedService#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, Missing, 'TypePropertiesJson>, value: string) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, Present, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, Present, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#type_properties_json-1">SynapseLinkedService#type_properties_json</a>.
        /// </summary>
        [<CustomOperation "type_properties_json">]
        member _.TypePropertiesJson(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, Missing>, value: string) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, Present> =
            state.assignments.Add(fun config -> config.TypePropertiesJson <- value)
            ({ assignments = state.assignments } : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#additional_properties-1">SynapseLinkedService#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: seq<string * string>) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#annotations-1">SynapseLinkedService#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: seq<string>) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#description-1">SynapseLinkedService#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: string) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#id-1">SynapseLinkedService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: string) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// integration_runtime block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#integration_runtime-1">SynapseLinkedService#integration_runtime</a>
        /// </summary>
        [<CustomOperation "integration_runtime">]
        member _.IntegrationRuntime(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: azurerm.SynapseLinkedService.SynapseLinkedServiceIntegrationRuntime) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.IntegrationRuntime <- value)
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#parameters-1">SynapseLinkedService#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: seq<string * string>) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_linked_service#timeouts-1">SynapseLinkedService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>, value: azurerm.SynapseLinkedService.SynapseLinkedServiceTimeouts) : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseLinkedServiceState<'Name, 'SynapseWorkspaceId, 'Type, 'TypePropertiesJson>

        member _.Run(state: SynapseLinkedServiceState<Present, Present, Present, Present>) : azurerm.SynapseLinkedService.SynapseLinkedService =
            let config = azurerm.SynapseLinkedService.SynapseLinkedServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseLinkedService.SynapseLinkedService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseLinkedService: missing required arguments. Must call: name, synapse_workspace_id, type, type_properties_json.", 9999, IsError = true)>]
        member _.Run(_: SynapseLinkedServiceState<_, _, _, _>) : azurerm.SynapseLinkedService.SynapseLinkedService =
            Unchecked.defaultof<azurerm.SynapseLinkedService.SynapseLinkedService>
