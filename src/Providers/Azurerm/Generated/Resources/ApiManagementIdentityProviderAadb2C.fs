namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> = { assignments: ResizeArray<azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c">azurerm_api_management_identity_provider_aadb2c</a>.
    /// </summary>
    type ApiManagementIdentityProviderAadb2CBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementIdentityProviderAadb2CState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderAadb2CState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementIdentityProviderAadb2CState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderAadb2CState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#allowed_tenant-1">ApiManagementIdentityProviderAadb2C#allowed_tenant</a>.
        /// </summary>
        [<CustomOperation "allowed_tenant">]
        member _.AllowedTenant(state: ApiManagementIdentityProviderAadb2CState<Missing, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<Present, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.AllowedTenant <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<Present, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#api_management_name-1">ApiManagementIdentityProviderAadb2C#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, Missing, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, Present, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, Present, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#authority-1">ApiManagementIdentityProviderAadb2C#authority</a>.
        /// </summary>
        [<CustomOperation "authority">]
        member _.Authority(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, Missing, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, Present, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.Authority <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, Present, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#client_id-1">ApiManagementIdentityProviderAadb2C#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, Missing, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, Present, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, Present, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#client_secret-1">ApiManagementIdentityProviderAadb2C#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, Missing, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, Present, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, Present, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#resource_group_name-1">ApiManagementIdentityProviderAadb2C#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, Missing, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, Present, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, Present, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#signin_policy-1">ApiManagementIdentityProviderAadb2C#signin_policy</a>.
        /// </summary>
        [<CustomOperation "signin_policy">]
        member _.SigninPolicy(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, Missing, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, Present, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.SigninPolicy <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, Present, 'SigninTenant, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#signin_tenant-1">ApiManagementIdentityProviderAadb2C#signin_tenant</a>.
        /// </summary>
        [<CustomOperation "signin_tenant">]
        member _.SigninTenant(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, Missing, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, Present, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.SigninTenant <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, Present, 'SignupPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#signup_policy-1">ApiManagementIdentityProviderAadb2C#signup_policy</a>.
        /// </summary>
        [<CustomOperation "signup_policy">]
        member _.SignupPolicy(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, Missing>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, Present> =
            state.assignments.Add(fun config -> config.SignupPolicy <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#client_library-1">ApiManagementIdentityProviderAadb2C#client_library</a>.
        /// </summary>
        [<CustomOperation "client_library">]
        member _.ClientLibrary(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.ClientLibrary <- value)
            state : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#id-1">ApiManagementIdentityProviderAadb2C#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#password_reset_policy-1">ApiManagementIdentityProviderAadb2C#password_reset_policy</a>.
        /// </summary>
        [<CustomOperation "password_reset_policy">]
        member _.PasswordResetPolicy(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.PasswordResetPolicy <- value)
            state : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#profile_editing_policy-1">ApiManagementIdentityProviderAadb2C#profile_editing_policy</a>.
        /// </summary>
        [<CustomOperation "profile_editing_policy">]
        member _.ProfileEditingPolicy(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: string) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.ProfileEditingPolicy <- value)
            state : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aadb2c#timeouts-1">ApiManagementIdentityProviderAadb2C#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>, value: azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CTimeouts) : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementIdentityProviderAadb2CState<'AllowedTenant, 'ApiManagementName, 'Authority, 'ClientId, 'ClientSecret, 'ResourceGroupName, 'SigninPolicy, 'SigninTenant, 'SignupPolicy>

        member _.Run(state: ApiManagementIdentityProviderAadb2CState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2C =
            let config = azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2C(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementIdentityProviderAadb2C: missing required arguments. Must call: allowed_tenant, api_management_name, authority, client_id, client_secret, resource_group_name, signin_policy, signin_tenant, signup_policy.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementIdentityProviderAadb2CState<_, _, _, _, _, _, _, _, _>) : azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2C =
            Unchecked.defaultof<azurerm.ApiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2C>
