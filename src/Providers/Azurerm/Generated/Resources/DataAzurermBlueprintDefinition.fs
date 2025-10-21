namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBlueprintDefinitionState<'Name, 'ScopeId> = { assignments: ResizeArray<azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition">azurerm_blueprint_definition</a>.
    /// </summary>
    type DataAzurermBlueprintDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBlueprintDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBlueprintDefinitionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermBlueprintDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBlueprintDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#name-1">DataAzurermBlueprintDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBlueprintDefinitionState<Missing, 'ScopeId>, value: string) : DataAzurermBlueprintDefinitionState<Present, 'ScopeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBlueprintDefinitionState<Present, 'ScopeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#scope_id-1">DataAzurermBlueprintDefinition#scope_id</a>.
        /// </summary>
        [<CustomOperation "scope_id">]
        member _.ScopeId(state: DataAzurermBlueprintDefinitionState<'Name, Missing>, value: string) : DataAzurermBlueprintDefinitionState<'Name, Present> =
            state.assignments.Add(fun config -> config.ScopeId <- value)
            ({ assignments = state.assignments } : DataAzurermBlueprintDefinitionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#id-1">DataAzurermBlueprintDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBlueprintDefinitionState<'Name, 'ScopeId>, value: string) : DataAzurermBlueprintDefinitionState<'Name, 'ScopeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBlueprintDefinitionState<'Name, 'ScopeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#timeouts-1">DataAzurermBlueprintDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBlueprintDefinitionState<'Name, 'ScopeId>, value: azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinitionTimeouts) : DataAzurermBlueprintDefinitionState<'Name, 'ScopeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBlueprintDefinitionState<'Name, 'ScopeId>

        member _.Run(state: DataAzurermBlueprintDefinitionState<Present, Present>) : azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinition =
            let config = azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBlueprintDefinition: missing required arguments. Must call: name, scope_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBlueprintDefinitionState<_, _>) : azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinition =
            Unchecked.defaultof<azurerm.DataAzurermBlueprintDefinition.DataAzurermBlueprintDefinition>
