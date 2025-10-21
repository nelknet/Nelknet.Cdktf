namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook">azurerm_api_management_identity_provider_facebook</a>.
    /// </summary>
    type ApiManagementIdentityProviderFacebookBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementIdentityProviderFacebookState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderFacebookState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementIdentityProviderFacebookState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderFacebookState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook#api_management_name-1">ApiManagementIdentityProviderFacebook#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementIdentityProviderFacebookState<Missing, 'AppId, 'AppSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderFacebookState<Present, 'AppId, 'AppSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderFacebookState<Present, 'AppId, 'AppSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook#app_id-1">ApiManagementIdentityProviderFacebook#app_id</a>.
        /// </summary>
        [<CustomOperation "app_id">]
        member _.AppId(state: ApiManagementIdentityProviderFacebookState<'ApiManagementName, Missing, 'AppSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderFacebookState<'ApiManagementName, Present, 'AppSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppId <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderFacebookState<'ApiManagementName, Present, 'AppSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook#app_secret-1">ApiManagementIdentityProviderFacebook#app_secret</a>.
        /// </summary>
        [<CustomOperation "app_secret">]
        member _.AppSecret(state: ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, Missing, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppSecret <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook#resource_group_name-1">ApiManagementIdentityProviderFacebook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, Missing>, value: string) : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook#id-1">ApiManagementIdentityProviderFacebook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_facebook#timeouts-1">ApiManagementIdentityProviderFacebook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName>, value: azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebookTimeouts) : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementIdentityProviderFacebookState<'ApiManagementName, 'AppId, 'AppSecret, 'ResourceGroupName>

        member _.Run(state: ApiManagementIdentityProviderFacebookState<Present, Present, Present, Present>) : azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebook =
            let config = azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebookConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementIdentityProviderFacebook: missing required arguments. Must call: api_management_name, app_id, app_secret, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementIdentityProviderFacebookState<_, _, _, _>) : azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebook =
            Unchecked.defaultof<azurerm.ApiManagementIdentityProviderFacebook.ApiManagementIdentityProviderFacebook>
