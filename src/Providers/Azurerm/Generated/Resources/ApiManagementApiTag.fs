namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiTagState<'ApiId, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementApiTag.ApiManagementApiTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag">azurerm_api_management_api_tag</a>.
    /// </summary>
    type ApiManagementApiTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiTagState<Missing, Missing>)

        member _.Zero(()) : ApiManagementApiTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiTagState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag#api_id-1">ApiManagementApiTag#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: ApiManagementApiTagState<Missing, 'Name>, value: string) : ApiManagementApiTagState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : ApiManagementApiTagState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag#name-1">ApiManagementApiTag#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementApiTagState<'ApiId, Missing>, value: string) : ApiManagementApiTagState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementApiTagState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag#id-1">ApiManagementApiTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiTagState<'ApiId, 'Name>, value: string) : ApiManagementApiTagState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiTagState<'ApiId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_tag#timeouts-1">ApiManagementApiTag#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiTagState<'ApiId, 'Name>, value: azurerm.ApiManagementApiTag.ApiManagementApiTagTimeouts) : ApiManagementApiTagState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiTagState<'ApiId, 'Name>

        member _.Run(state: ApiManagementApiTagState<Present, Present>) : azurerm.ApiManagementApiTag.ApiManagementApiTag =
            let config = azurerm.ApiManagementApiTag.ApiManagementApiTagConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiTag.ApiManagementApiTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiTag: missing required arguments. Must call: api_id, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiTagState<_, _>) : azurerm.ApiManagementApiTag.ApiManagementApiTag =
            Unchecked.defaultof<azurerm.ApiManagementApiTag.ApiManagementApiTag>
