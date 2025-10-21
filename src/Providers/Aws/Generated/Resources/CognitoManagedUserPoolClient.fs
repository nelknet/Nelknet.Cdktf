namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoManagedUserPoolClientState<'UserPoolId> = { assignments: ResizeArray<aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClientConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client">aws_cognito_managed_user_pool_client</a>.
    /// </summary>
    type CognitoManagedUserPoolClientBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoManagedUserPoolClientState<Missing> =
            ({ assignments = ResizeArray() } : CognitoManagedUserPoolClientState<Missing>)

        member _.Zero(()) : CognitoManagedUserPoolClientState<Missing> =
            ({ assignments = ResizeArray() } : CognitoManagedUserPoolClientState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#user_pool_id-1">CognitoManagedUserPoolClient#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoManagedUserPoolClientState<Missing>, value: string) : CognitoManagedUserPoolClientState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoManagedUserPoolClientState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#access_token_validity-1">CognitoManagedUserPoolClient#access_token_validity</a>.
        /// </summary>
        [<CustomOperation "access_token_validity">]
        member _.AccessTokenValidity(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: double) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AccessTokenValidity <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#allowed_oauth_flows-1">CognitoManagedUserPoolClient#allowed_oauth_flows</a>.
        /// </summary>
        [<CustomOperation "allowed_oauth_flows">]
        member _.AllowedOauthFlows(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthFlows <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#allowed_oauth_flows_user_pool_client-1">CognitoManagedUserPoolClient#allowed_oauth_flows_user_pool_client</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allowed_oauth_flows_user_pool_client">]
        member _.AllowedOauthFlowsUserPoolClient(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: bool) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthFlowsUserPoolClient <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#allowed_oauth_flows_user_pool_client-1">CognitoManagedUserPoolClient#allowed_oauth_flows_user_pool_client</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allowed_oauth_flows_user_pool_client">]
        member _.AllowedOauthFlowsUserPoolClient(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthFlowsUserPoolClient <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#allowed_oauth_scopes-1">CognitoManagedUserPoolClient#allowed_oauth_scopes</a>.
        /// </summary>
        [<CustomOperation "allowed_oauth_scopes">]
        member _.AllowedOauthScopes(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthScopes <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// analytics_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#analytics_configuration-1">CognitoManagedUserPoolClient#analytics_configuration</a> Accepts: aws.IResolvable | aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClientAnalyticsConfiguration[]
        /// </summary>
        [<CustomOperation "analytics_configuration">]
        member _.AnalyticsConfiguration(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AnalyticsConfiguration <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#auth_session_validity-1">CognitoManagedUserPoolClient#auth_session_validity</a>.
        /// </summary>
        [<CustomOperation "auth_session_validity">]
        member _.AuthSessionValidity(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: double) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AuthSessionValidity <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#callback_urls-1">CognitoManagedUserPoolClient#callback_urls</a>.
        /// </summary>
        [<CustomOperation "callback_urls">]
        member _.CallbackUrls(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.CallbackUrls <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#default_redirect_uri-1">CognitoManagedUserPoolClient#default_redirect_uri</a>.
        /// </summary>
        [<CustomOperation "default_redirect_uri">]
        member _.DefaultRedirectUri(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: string) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.DefaultRedirectUri <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#enable_propagate_additional_user_context_data-1">CognitoManagedUserPoolClient#enable_propagate_additional_user_context_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_propagate_additional_user_context_data">]
        member _.EnablePropagateAdditionalUserContextData(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: bool) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.EnablePropagateAdditionalUserContextData <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#enable_propagate_additional_user_context_data-1">CognitoManagedUserPoolClient#enable_propagate_additional_user_context_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_propagate_additional_user_context_data">]
        member _.EnablePropagateAdditionalUserContextData(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.EnablePropagateAdditionalUserContextData <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#enable_token_revocation-1">CognitoManagedUserPoolClient#enable_token_revocation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_token_revocation">]
        member _.EnableTokenRevocation(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: bool) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.EnableTokenRevocation <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#enable_token_revocation-1">CognitoManagedUserPoolClient#enable_token_revocation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_token_revocation">]
        member _.EnableTokenRevocation(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.EnableTokenRevocation <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#explicit_auth_flows-1">CognitoManagedUserPoolClient#explicit_auth_flows</a>.
        /// </summary>
        [<CustomOperation "explicit_auth_flows">]
        member _.ExplicitAuthFlows(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.ExplicitAuthFlows <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#id_token_validity-1">CognitoManagedUserPoolClient#id_token_validity</a>.
        /// </summary>
        [<CustomOperation "id_token_validity">]
        member _.IdTokenValidity(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: double) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.IdTokenValidity <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#logout_urls-1">CognitoManagedUserPoolClient#logout_urls</a>.
        /// </summary>
        [<CustomOperation "logout_urls">]
        member _.LogoutUrls(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.LogoutUrls <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#name_pattern-1">CognitoManagedUserPoolClient#name_pattern</a>.
        /// </summary>
        [<CustomOperation "name_pattern">]
        member _.NamePattern(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: string) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.NamePattern <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#name_prefix-1">CognitoManagedUserPoolClient#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: string) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#prevent_user_existence_errors-1">CognitoManagedUserPoolClient#prevent_user_existence_errors</a>.
        /// </summary>
        [<CustomOperation "prevent_user_existence_errors">]
        member _.PreventUserExistenceErrors(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: string) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.PreventUserExistenceErrors <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#read_attributes-1">CognitoManagedUserPoolClient#read_attributes</a>.
        /// </summary>
        [<CustomOperation "read_attributes">]
        member _.ReadAttributes(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.ReadAttributes <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// refresh_token_rotation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#refresh_token_rotation-1">CognitoManagedUserPoolClient#refresh_token_rotation</a> Accepts: aws.IResolvable | aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClientRefreshTokenRotation[]
        /// </summary>
        [<CustomOperation "refresh_token_rotation">]
        member _.RefreshTokenRotation(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.RefreshTokenRotation <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#refresh_token_validity-1">CognitoManagedUserPoolClient#refresh_token_validity</a>.
        /// </summary>
        [<CustomOperation "refresh_token_validity">]
        member _.RefreshTokenValidity(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: double) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.RefreshTokenValidity <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#supported_identity_providers-1">CognitoManagedUserPoolClient#supported_identity_providers</a>.
        /// </summary>
        [<CustomOperation "supported_identity_providers">]
        member _.SupportedIdentityProviders(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.SupportedIdentityProviders <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// token_validity_units block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#token_validity_units-1">CognitoManagedUserPoolClient#token_validity_units</a> Accepts: aws.IResolvable | aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClientTokenValidityUnits[]
        /// </summary>
        [<CustomOperation "token_validity_units">]
        member _.TokenValidityUnits(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.TokenValidityUnits <- value)
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#write_attributes-1">CognitoManagedUserPoolClient#write_attributes</a>.
        /// </summary>
        [<CustomOperation "write_attributes">]
        member _.WriteAttributes(state: CognitoManagedUserPoolClientState<'UserPoolId>, value: seq<string>) : CognitoManagedUserPoolClientState<'UserPoolId> =
            state.assignments.Add(fun config -> config.WriteAttributes <- (value |> Seq.toArray))
            state : CognitoManagedUserPoolClientState<'UserPoolId>

        member _.Run(state: CognitoManagedUserPoolClientState<Present>) : aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClient =
            let config = aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClientConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClient(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoManagedUserPoolClient: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoManagedUserPoolClientState<_>) : aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClient =
            Unchecked.defaultof<aws.CognitoManagedUserPoolClient.CognitoManagedUserPoolClient>
