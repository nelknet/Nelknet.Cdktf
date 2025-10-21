namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version> = { assignments: ResizeArray<azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version">azurerm_template_spec_version</a>.
    /// </summary>
    type DataAzurermTemplateSpecVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermTemplateSpecVersionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTemplateSpecVersionState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermTemplateSpecVersionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTemplateSpecVersionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#name-1">DataAzurermTemplateSpecVersion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermTemplateSpecVersionState<Missing, 'ResourceGroupName, 'Version>, value: string) : DataAzurermTemplateSpecVersionState<Present, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermTemplateSpecVersionState<Present, 'ResourceGroupName, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#resource_group_name-1">DataAzurermTemplateSpecVersion#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermTemplateSpecVersionState<'Name, Missing, 'Version>, value: string) : DataAzurermTemplateSpecVersionState<'Name, Present, 'Version> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermTemplateSpecVersionState<'Name, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#version-1">DataAzurermTemplateSpecVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#id-1">DataAzurermTemplateSpecVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version>, value: string) : DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#timeouts-1">DataAzurermTemplateSpecVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version>, value: azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersionTimeouts) : DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermTemplateSpecVersionState<'Name, 'ResourceGroupName, 'Version>

        member _.Run(state: DataAzurermTemplateSpecVersionState<Present, Present, Present>) : azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersion =
            let config = azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermTemplateSpecVersion: missing required arguments. Must call: name, resource_group_name, version.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermTemplateSpecVersionState<_, _, _>) : azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersion =
            Unchecked.defaultof<azurerm.DataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersion>
