namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google">azurerm_api_management_identity_provider_google</a>.
    /// </summary>
    type ApiManagementIdentityProviderGoogleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementIdentityProviderGoogleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderGoogleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementIdentityProviderGoogleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderGoogleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google#api_management_name-1">ApiManagementIdentityProviderGoogle#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementIdentityProviderGoogleState<Missing, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderGoogleState<Present, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderGoogleState<Present, 'ClientId, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google#client_id-1">ApiManagementIdentityProviderGoogle#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: ApiManagementIdentityProviderGoogleState<'ApiManagementName, Missing, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderGoogleState<'ApiManagementName, Present, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderGoogleState<'ApiManagementName, Present, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google#client_secret-1">ApiManagementIdentityProviderGoogle#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, Missing, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google#resource_group_name-1">ApiManagementIdentityProviderGoogle#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, Missing>, value: string) : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google#id-1">ApiManagementIdentityProviderGoogle#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_google#timeouts-1">ApiManagementIdentityProviderGoogle#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogleTimeouts) : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementIdentityProviderGoogleState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        member _.Run(state: ApiManagementIdentityProviderGoogleState<Present, Present, Present, Present>) : azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogle =
            let config = azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogle(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementIdentityProviderGoogle: missing required arguments. Must call: api_management_name, client_id, client_secret, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementIdentityProviderGoogleState<_, _, _, _>) : azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogle =
            Unchecked.defaultof<azurerm.ApiManagementIdentityProviderGoogle.ApiManagementIdentityProviderGoogle>
