namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiReleaseState<'ApiId, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementApiRelease.ApiManagementApiReleaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_release">azurerm_api_management_api_release</a>.
    /// </summary>
    type ApiManagementApiReleaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiReleaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiReleaseState<Missing, Missing>)

        member _.Zero(()) : ApiManagementApiReleaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiReleaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_release#api_id-1">ApiManagementApiRelease#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: ApiManagementApiReleaseState<Missing, 'Name>, value: string) : ApiManagementApiReleaseState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : ApiManagementApiReleaseState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_release#name-1">ApiManagementApiRelease#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementApiReleaseState<'ApiId, Missing>, value: string) : ApiManagementApiReleaseState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementApiReleaseState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_release#id-1">ApiManagementApiRelease#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiReleaseState<'ApiId, 'Name>, value: string) : ApiManagementApiReleaseState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiReleaseState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_release#notes-1">ApiManagementApiRelease#notes</a>.
        /// </summary>
        [<CustomOperation "notes">]
        member _.Notes(state: ApiManagementApiReleaseState<'ApiId, 'Name>, value: string) : ApiManagementApiReleaseState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Notes <- value)
            state : ApiManagementApiReleaseState<'ApiId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_release#timeouts-1">ApiManagementApiRelease#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiReleaseState<'ApiId, 'Name>, value: azurerm.ApiManagementApiRelease.ApiManagementApiReleaseTimeouts) : ApiManagementApiReleaseState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiReleaseState<'ApiId, 'Name>

        member _.Run(state: ApiManagementApiReleaseState<Present, Present>) : azurerm.ApiManagementApiRelease.ApiManagementApiRelease =
            let config = azurerm.ApiManagementApiRelease.ApiManagementApiReleaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiRelease.ApiManagementApiRelease(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiRelease: missing required arguments. Must call: api_id, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiReleaseState<_, _>) : azurerm.ApiManagementApiRelease.ApiManagementApiRelease =
            Unchecked.defaultof<azurerm.ApiManagementApiRelease.ApiManagementApiRelease>
