namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_tag">azurerm_api_management_api_operation_tag</a>.
    /// </summary>
    type ApiManagementApiOperationTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiOperationTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiOperationTagState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiOperationTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiOperationTagState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_tag#api_operation_id-1">ApiManagementApiOperationTag#api_operation_id</a>.
        /// </summary>
        [<CustomOperation "api_operation_id">]
        member _.ApiOperationId(state: ApiManagementApiOperationTagState<Missing, 'DisplayName, 'Name>, value: string) : ApiManagementApiOperationTagState<Present, 'DisplayName, 'Name> =
            state.assignments.Add(fun config -> config.ApiOperationId <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationTagState<Present, 'DisplayName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_tag#display_name-1">ApiManagementApiOperationTag#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementApiOperationTagState<'ApiOperationId, Missing, 'Name>, value: string) : ApiManagementApiOperationTagState<'ApiOperationId, Present, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationTagState<'ApiOperationId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_tag#name-1">ApiManagementApiOperationTag#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, Missing>, value: string) : ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_tag#id-1">ApiManagementApiOperationTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name>, value: string) : ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_tag#timeouts-1">ApiManagementApiOperationTag#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name>, value: azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTagTimeouts) : ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiOperationTagState<'ApiOperationId, 'DisplayName, 'Name>

        member _.Run(state: ApiManagementApiOperationTagState<Present, Present, Present>) : azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTag =
            let config = azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTagConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiOperationTag: missing required arguments. Must call: api_operation_id, display_name, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiOperationTagState<_, _, _>) : azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTag =
            Unchecked.defaultof<azurerm.ApiManagementApiOperationTag.ApiManagementApiOperationTag>
