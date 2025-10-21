namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoftConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft">azurerm_api_management_identity_provider_microsoft</a>.
    /// </summary>
    type ApiManagementIdentityProviderMicrosoftBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementIdentityProviderMicrosoftState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderMicrosoftState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementIdentityProviderMicrosoftState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementIdentityProviderMicrosoftState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft#api_management_name-1">ApiManagementIdentityProviderMicrosoft#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementIdentityProviderMicrosoftState<Missing, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderMicrosoftState<Present, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderMicrosoftState<Present, 'ClientId, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft#client_id-1">ApiManagementIdentityProviderMicrosoft#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, Missing, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, Present, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, Present, 'ClientSecret, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft#client_secret-1">ApiManagementIdentityProviderMicrosoft#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, Missing, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft#resource_group_name-1">ApiManagementIdentityProviderMicrosoft#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, Missing>, value: string) : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft#id-1">ApiManagementIdentityProviderMicrosoft#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: string) : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_identity_provider_microsoft#timeouts-1">ApiManagementIdentityProviderMicrosoft#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>, value: azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoftTimeouts) : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementIdentityProviderMicrosoftState<'ApiManagementName, 'ClientId, 'ClientSecret, 'ResourceGroupName>

        member _.Run(state: ApiManagementIdentityProviderMicrosoftState<Present, Present, Present, Present>) : azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoft =
            let config = azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoftConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoft(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementIdentityProviderMicrosoft: missing required arguments. Must call: api_management_name, client_id, client_secret, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementIdentityProviderMicrosoftState<_, _, _, _>) : azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoft =
            Unchecked.defaultof<azurerm.ApiManagementIdentityProviderMicrosoft.ApiManagementIdentityProviderMicrosoft>
