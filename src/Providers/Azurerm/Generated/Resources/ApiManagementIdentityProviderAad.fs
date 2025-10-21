namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAadConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad">azurerm_api_management_identity_provider_aad</a>.
    /// </summary>
    type ApiManagementIdentityProviderAadBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementIdentityProviderAadState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderAadState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementIdentityProviderAadState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderAadState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#allowed_tenants-1">ApiManagementIdentityProviderAad#allowed_tenants</a>.
        /// </summary>
        [<CustomOperation "allowed_tenants">]
        member _.AllowedTenants(state: ApiManagementIdentityProviderAadState<Missing, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: seq<string>) : ApiManagementIdentityProviderAadState<Present, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowedTenants <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadState<Present, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#api_management_name-1">ApiManagementIdentityProviderAad#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementIdentityProviderAadState<'AllowedTenants, Missing, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, Present, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadState<'AllowedTenants, Present, 'ClientId, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#client_id-1">ApiManagementIdentityProviderAad#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, Missing, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, Present, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, Present, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#client_secret-1">ApiManagementIdentityProviderAad#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, Missing, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#resource_group_name-1">ApiManagementIdentityProviderAad#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, Missing>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#client_library-1">ApiManagementIdentityProviderAad#client_library</a>.
        /// </summary>
        [<CustomOperation "client_library">]
        member _.ClientLibrary(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientLibrary <- value)
            state : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#id-1">ApiManagementIdentityProviderAad#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#signin_tenant-1">ApiManagementIdentityProviderAad#signin_tenant</a>.
        /// </summary>
        [<CustomOperation "signin_tenant">]
        member _.SigninTenant(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SigninTenant <- value)
            state : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_aad#timeouts-1">ApiManagementIdentityProviderAad#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAadTimeouts) : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementIdentityProviderAadState<'AllowedTenants, 'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        member _.Run(state: ApiManagementIdentityProviderAadState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAad =
            let config = azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAadConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAad(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementIdentityProviderAad: missing required arguments. Must call: allowed_tenants, api_management_name, client_id, client_secret, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementIdentityProviderAadState<_, _, _, _, _>) : azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAad =
            Unchecked.defaultof<azurerm.ApiManagementIdentityProviderAad.ApiManagementIdentityProviderAad>
