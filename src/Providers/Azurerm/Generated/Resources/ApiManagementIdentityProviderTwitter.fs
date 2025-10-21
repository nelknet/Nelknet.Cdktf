namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter">azurerm_api_management_identity_provider_twitter</a>.
    /// </summary>
    type ApiManagementIdentityProviderTwitterBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementIdentityProviderTwitterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderTwitterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementIdentityProviderTwitterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderTwitterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter#api_key-1">ApiManagementIdentityProviderTwitter#api_key</a>.
        /// </summary>
        [<CustomOperation "api_key">]
        member _.ApiKey(state: ApiManagementIdentityProviderTwitterState<Missing, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderTwitterState<Present, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiKey <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderTwitterState<Present, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter#api_management_name-1">ApiManagementIdentityProviderTwitter#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementIdentityProviderTwitterState<'ApiKey, Missing, 'ApiSecretKey, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderTwitterState<'ApiKey, Present, 'ApiSecretKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderTwitterState<'ApiKey, Present, 'ApiSecretKey, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter#api_secret_key-1">ApiManagementIdentityProviderTwitter#api_secret_key</a>.
        /// </summary>
        [<CustomOperation "api_secret_key">]
        member _.ApiSecretKey(state: ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiSecretKey <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter#resource_group_name-1">ApiManagementIdentityProviderTwitter#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, Missing>, value: string) : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter#id-1">ApiManagementIdentityProviderTwitter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_twitter#timeouts-1">ApiManagementIdentityProviderTwitter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName>, value: azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitterTimeouts) : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementIdentityProviderTwitterState<'ApiKey, 'ApiManagementName, 'ApiSecretKey, 'ResourceGroupName>

        member _.Run(state: ApiManagementIdentityProviderTwitterState<Present, Present, Present, Present>) : azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitter =
            let config = azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitterConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementIdentityProviderTwitter: missing required arguments. Must call: api_key, api_management_name, api_secret_key, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementIdentityProviderTwitterState<_, _, _, _>) : azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitter =
            Unchecked.defaultof<azurerm.ApiManagementIdentityProviderTwitter.ApiManagementIdentityProviderTwitter>
