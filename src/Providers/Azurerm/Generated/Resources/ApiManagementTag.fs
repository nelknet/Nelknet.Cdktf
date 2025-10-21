namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementTagState<'ApiManagementId, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementTag.ApiManagementTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_tag">azurerm_api_management_tag</a>.
    /// </summary>
    type ApiManagementTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementTagState<Missing, Missing>)

        member _.Zero(()) : ApiManagementTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementTagState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_tag#api_management_id-1">ApiManagementTag#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementTagState<Missing, 'Name>, value: string) : ApiManagementTagState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementTagState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_tag#name-1">ApiManagementTag#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementTagState<'ApiManagementId, Missing>, value: string) : ApiManagementTagState<'ApiManagementId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementTagState<'ApiManagementId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_tag#display_name-1">ApiManagementTag#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementTagState<'ApiManagementId, 'Name>, value: string) : ApiManagementTagState<'ApiManagementId, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ApiManagementTagState<'ApiManagementId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_tag#id-1">ApiManagementTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementTagState<'ApiManagementId, 'Name>, value: string) : ApiManagementTagState<'ApiManagementId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementTagState<'ApiManagementId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_tag#timeouts-1">ApiManagementTag#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementTagState<'ApiManagementId, 'Name>, value: azurerm.ApiManagementTag.ApiManagementTagTimeouts) : ApiManagementTagState<'ApiManagementId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementTagState<'ApiManagementId, 'Name>

        member _.Run(state: ApiManagementTagState<Present, Present>) : azurerm.ApiManagementTag.ApiManagementTag =
            let config = azurerm.ApiManagementTag.ApiManagementTagConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementTag.ApiManagementTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementTag: missing required arguments. Must call: api_management_id, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementTagState<_, _>) : azurerm.ApiManagementTag.ApiManagementTag =
            Unchecked.defaultof<azurerm.ApiManagementTag.ApiManagementTag>
