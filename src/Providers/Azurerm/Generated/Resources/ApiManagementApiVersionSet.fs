namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> = { assignments: ResizeArray<azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set">azurerm_api_management_api_version_set</a>.
    /// </summary>
    type ApiManagementApiVersionSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiVersionSetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiVersionSetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiVersionSetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiVersionSetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#api_management_name-1">ApiManagementApiVersionSet#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiVersionSetState<Missing, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<Present, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiVersionSetState<Present, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#display_name-1">ApiManagementApiVersionSet#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementApiVersionSetState<'ApiManagementName, Missing, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, Present, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementApiVersionSetState<'ApiManagementName, Present, 'Name, 'ResourceGroupName, 'VersioningScheme>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#name-1">ApiManagementApiVersionSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, Missing, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, Present, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, Present, 'ResourceGroupName, 'VersioningScheme>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#resource_group_name-1">ApiManagementApiVersionSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, Missing, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, Present, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, Present, 'VersioningScheme>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#versioning_scheme-1">ApiManagementApiVersionSet#versioning_scheme</a>.
        /// </summary>
        [<CustomOperation "versioning_scheme">]
        member _.VersioningScheme(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, Missing>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VersioningScheme <- value)
            ({ assignments = state.assignments } : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#description-1">ApiManagementApiVersionSet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#id-1">ApiManagementApiVersionSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#timeouts-1">ApiManagementApiVersionSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSetTimeouts) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#version_header_name-1">ApiManagementApiVersionSet#version_header_name</a>.
        /// </summary>
        [<CustomOperation "version_header_name">]
        member _.VersionHeaderName(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.VersionHeaderName <- value)
            state : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_version_set#version_query_name-1">ApiManagementApiVersionSet#version_query_name</a>.
        /// </summary>
        [<CustomOperation "version_query_name">]
        member _.VersionQueryName(state: ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>, value: string) : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme> =
            state.assignments.Add(fun config -> config.VersionQueryName <- value)
            state : ApiManagementApiVersionSetState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName, 'VersioningScheme>

        member _.Run(state: ApiManagementApiVersionSetState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSet =
            let config = azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiVersionSet: missing required arguments. Must call: api_management_name, display_name, name, resource_group_name, versioning_scheme.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiVersionSetState<_, _, _, _, _>) : azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSet =
            Unchecked.defaultof<azurerm.ApiManagementApiVersionSet.ApiManagementApiVersionSet>
