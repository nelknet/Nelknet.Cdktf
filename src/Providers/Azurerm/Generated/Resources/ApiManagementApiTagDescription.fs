namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiTagDescriptionState<'ApiTagId> = { assignments: ResizeArray<azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description">azurerm_api_management_api_tag_description</a>.
    /// </summary>
    type ApiManagementApiTagDescriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiTagDescriptionState<Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiTagDescriptionState<Missing>)

        member _.Zero(()) : ApiManagementApiTagDescriptionState<Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiTagDescriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description#api_tag_id-1">ApiManagementApiTagDescription#api_tag_id</a>.
        /// </summary>
        [<CustomOperation "api_tag_id">]
        member _.ApiTagId(state: ApiManagementApiTagDescriptionState<Missing>, value: string) : ApiManagementApiTagDescriptionState<Present> =
            state.assignments.Add(fun config -> config.ApiTagId <- value)
            ({ assignments = state.assignments } : ApiManagementApiTagDescriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description#description-1">ApiManagementApiTagDescription#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementApiTagDescriptionState<'ApiTagId>, value: string) : ApiManagementApiTagDescriptionState<'ApiTagId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementApiTagDescriptionState<'ApiTagId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description#external_documentation_description-1">ApiManagementApiTagDescription#external_documentation_description</a>.
        /// </summary>
        [<CustomOperation "external_documentation_description">]
        member _.ExternalDocumentationDescription(state: ApiManagementApiTagDescriptionState<'ApiTagId>, value: string) : ApiManagementApiTagDescriptionState<'ApiTagId> =
            state.assignments.Add(fun config -> config.ExternalDocumentationDescription <- value)
            state : ApiManagementApiTagDescriptionState<'ApiTagId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description#external_documentation_url-1">ApiManagementApiTagDescription#external_documentation_url</a>.
        /// </summary>
        [<CustomOperation "external_documentation_url">]
        member _.ExternalDocumentationUrl(state: ApiManagementApiTagDescriptionState<'ApiTagId>, value: string) : ApiManagementApiTagDescriptionState<'ApiTagId> =
            state.assignments.Add(fun config -> config.ExternalDocumentationUrl <- value)
            state : ApiManagementApiTagDescriptionState<'ApiTagId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description#id-1">ApiManagementApiTagDescription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiTagDescriptionState<'ApiTagId>, value: string) : ApiManagementApiTagDescriptionState<'ApiTagId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiTagDescriptionState<'ApiTagId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag_description#timeouts-1">ApiManagementApiTagDescription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiTagDescriptionState<'ApiTagId>, value: azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescriptionTimeouts) : ApiManagementApiTagDescriptionState<'ApiTagId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiTagDescriptionState<'ApiTagId>

        member _.Run(state: ApiManagementApiTagDescriptionState<Present>) : azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescription =
            let config = azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiTagDescription: missing required arguments. Must call: api_tag_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiTagDescriptionState<_>) : azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescription =
            Unchecked.defaultof<azurerm.ApiManagementApiTagDescription.ApiManagementApiTagDescription>
