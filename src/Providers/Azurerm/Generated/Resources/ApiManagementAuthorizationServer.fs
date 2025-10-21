namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server">azurerm_api_management_authorization_server</a>.
    /// </summary>
    type ApiManagementAuthorizationServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementAuthorizationServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementAuthorizationServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementAuthorizationServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementAuthorizationServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#api_management_name-1">ApiManagementAuthorizationServer#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementAuthorizationServerState<Missing, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<Present, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<Present, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#authorization_endpoint-1">ApiManagementAuthorizationServer#authorization_endpoint</a>.
        /// </summary>
        [<CustomOperation "authorization_endpoint">]
        member _.AuthorizationEndpoint(state: ApiManagementAuthorizationServerState<'ApiManagementName, Missing, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, Present, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthorizationEndpoint <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, Present, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#authorization_methods-1">ApiManagementAuthorizationServer#authorization_methods</a>.
        /// </summary>
        [<CustomOperation "authorization_methods">]
        member _.AuthorizationMethods(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, Missing, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: seq<string>) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, Present, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthorizationMethods <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, Present, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#client_id-1">ApiManagementAuthorizationServer#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, Missing, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, Present, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, Present, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#client_registration_endpoint-1">ApiManagementAuthorizationServer#client_registration_endpoint</a>.
        /// </summary>
        [<CustomOperation "client_registration_endpoint">]
        member _.ClientRegistrationEndpoint(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, Missing, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, Present, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientRegistrationEndpoint <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, Present, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#display_name-1">ApiManagementAuthorizationServer#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, Missing, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, Present, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, Present, 'GrantTypes, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#grant_types-1">ApiManagementAuthorizationServer#grant_types</a>.
        /// </summary>
        [<CustomOperation "grant_types">]
        member _.GrantTypes(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, Missing, 'Name, 'ResourceGroupName>, value: seq<string>) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GrantTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#name-1">ApiManagementAuthorizationServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, Missing, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#resource_group_name-1">ApiManagementAuthorizationServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, Missing>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#bearer_token_sending_methods-1">ApiManagementAuthorizationServer#bearer_token_sending_methods</a>.
        /// </summary>
        [<CustomOperation "bearer_token_sending_methods">]
        member _.BearerTokenSendingMethods(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: seq<string>) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BearerTokenSendingMethods <- (value |> Seq.toArray))
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#client_authentication_method-1">ApiManagementAuthorizationServer#client_authentication_method</a>.
        /// </summary>
        [<CustomOperation "client_authentication_method">]
        member _.ClientAuthenticationMethod(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: seq<string>) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientAuthenticationMethod <- (value |> Seq.toArray))
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#client_secret-1">ApiManagementAuthorizationServer#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#default_scope-1">ApiManagementAuthorizationServer#default_scope</a>.
        /// </summary>
        [<CustomOperation "default_scope">]
        member _.DefaultScope(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultScope <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#description-1">ApiManagementAuthorizationServer#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#id-1">ApiManagementAuthorizationServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#resource_owner_password-1">ApiManagementAuthorizationServer#resource_owner_password</a>.
        /// </summary>
        [<CustomOperation "resource_owner_password">]
        member _.ResourceOwnerPassword(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ResourceOwnerPassword <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#resource_owner_username-1">ApiManagementAuthorizationServer#resource_owner_username</a>.
        /// </summary>
        [<CustomOperation "resource_owner_username">]
        member _.ResourceOwnerUsername(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ResourceOwnerUsername <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#support_state-1">ApiManagementAuthorizationServer#support_state</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "support_state">]
        member _.SupportState(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: bool) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SupportState <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#support_state-1">ApiManagementAuthorizationServer#support_state</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "support_state">]
        member _.SupportState(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SupportState <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#timeouts-1">ApiManagementAuthorizationServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServerTimeouts) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// token_body_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#token_body_parameter-1">ApiManagementAuthorizationServer#token_body_parameter</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter[]
        /// </summary>
        [<CustomOperation "token_body_parameter">]
        member _.TokenBodyParameter(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TokenBodyParameter <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#token_endpoint-1">ApiManagementAuthorizationServer#token_endpoint</a>.
        /// </summary>
        [<CustomOperation "token_endpoint">]
        member _.TokenEndpoint(state: ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>, value: string) : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TokenEndpoint <- value)
            state : ApiManagementAuthorizationServerState<'ApiManagementName, 'AuthorizationEndpoint, 'AuthorizationMethods, 'ClientId, 'ClientRegistrationEndpoint, 'DisplayName, 'GrantTypes, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementAuthorizationServerState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServer =
            let config = azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementAuthorizationServer: missing required arguments. Must call: api_management_name, authorization_endpoint, authorization_methods, client_id, client_registration_endpoint, display_name, grant_types, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementAuthorizationServerState<_, _, _, _, _, _, _, _, _>) : azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServer =
            Unchecked.defaultof<azurerm.ApiManagementAuthorizationServer.ApiManagementAuthorizationServer>
