namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version> = { assignments: ResizeArray<azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_published_version">azurerm_blueprint_published_version</a>.
    /// </summary>
    type DataAzurermBlueprintPublishedVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBlueprintPublishedVersionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBlueprintPublishedVersionState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBlueprintPublishedVersionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBlueprintPublishedVersionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_published_version#blueprint_name-1">DataAzurermBlueprintPublishedVersion#blueprint_name</a>.
        /// </summary>
        [<CustomOperation "blueprint_name">]
        member _.BlueprintName(state: DataAzurermBlueprintPublishedVersionState<Missing, 'ScopeId, 'Version>, value: string) : DataAzurermBlueprintPublishedVersionState<Present, 'ScopeId, 'Version> =
            state.assignments.Add(fun config -> config.BlueprintName <- value)
            ({ assignments = state.assignments } : DataAzurermBlueprintPublishedVersionState<Present, 'ScopeId, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_published_version#scope_id-1">DataAzurermBlueprintPublishedVersion#scope_id</a>.
        /// </summary>
        [<CustomOperation "scope_id">]
        member _.ScopeId(state: DataAzurermBlueprintPublishedVersionState<'BlueprintName, Missing, 'Version>, value: string) : DataAzurermBlueprintPublishedVersionState<'BlueprintName, Present, 'Version> =
            state.assignments.Add(fun config -> config.ScopeId <- value)
            ({ assignments = state.assignments } : DataAzurermBlueprintPublishedVersionState<'BlueprintName, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_published_version#version-1">DataAzurermBlueprintPublishedVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, Missing>, value: string) : DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_published_version#id-1">DataAzurermBlueprintPublishedVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version>, value: string) : DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_published_version#timeouts-1">DataAzurermBlueprintPublishedVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version>, value: azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersionTimeouts) : DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBlueprintPublishedVersionState<'BlueprintName, 'ScopeId, 'Version>

        member _.Run(state: DataAzurermBlueprintPublishedVersionState<Present, Present, Present>) : azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersion =
            let config = azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBlueprintPublishedVersion: missing required arguments. Must call: blueprint_name, scope_id, version.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBlueprintPublishedVersionState<_, _, _>) : azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersion =
            Unchecked.defaultof<azurerm.DataAzurermBlueprintPublishedVersion.DataAzurermBlueprintPublishedVersion>
