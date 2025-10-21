namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserPoolClientState<'Name, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoUserPoolClient.CognitoUserPoolClientConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client">aws_cognito_user_pool_client</a>.
    /// </summary>
    type CognitoUserPoolClientBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserPoolClientState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolClientState<Missing, Missing>)

        member _.Zero(()) : CognitoUserPoolClientState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolClientState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#name-1">CognitoUserPoolClient#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CognitoUserPoolClientState<Missing, 'UserPoolId>, value: string) : CognitoUserPoolClientState<Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CognitoUserPoolClientState<Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#user_pool_id-1">CognitoUserPoolClient#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoUserPoolClientState<'Name, Missing>, value: string) : CognitoUserPoolClientState<'Name, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoUserPoolClientState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#access_token_validity-1">CognitoUserPoolClient#access_token_validity</a>.
        /// </summary>
        [<CustomOperation "access_token_validity">]
        member _.AccessTokenValidity(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: double) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AccessTokenValidity <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#allowed_oauth_flows-1">CognitoUserPoolClient#allowed_oauth_flows</a>.
        /// </summary>
        [<CustomOperation "allowed_oauth_flows">]
        member _.AllowedOauthFlows(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthFlows <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#allowed_oauth_flows_user_pool_client-1">CognitoUserPoolClient#allowed_oauth_flows_user_pool_client</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allowed_oauth_flows_user_pool_client">]
        member _.AllowedOauthFlowsUserPoolClient(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: bool) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthFlowsUserPoolClient <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#allowed_oauth_flows_user_pool_client-1">CognitoUserPoolClient#allowed_oauth_flows_user_pool_client</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allowed_oauth_flows_user_pool_client">]
        member _.AllowedOauthFlowsUserPoolClient(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthFlowsUserPoolClient <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#allowed_oauth_scopes-1">CognitoUserPoolClient#allowed_oauth_scopes</a>.
        /// </summary>
        [<CustomOperation "allowed_oauth_scopes">]
        member _.AllowedOauthScopes(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AllowedOauthScopes <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// analytics_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#analytics_configuration-1">CognitoUserPoolClient#analytics_configuration</a> Accepts: aws.IResolvable | aws.CognitoUserPoolClient.CognitoUserPoolClientAnalyticsConfiguration[]
        /// </summary>
        [<CustomOperation "analytics_configuration">]
        member _.AnalyticsConfiguration(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AnalyticsConfiguration <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#auth_session_validity-1">CognitoUserPoolClient#auth_session_validity</a>.
        /// </summary>
        [<CustomOperation "auth_session_validity">]
        member _.AuthSessionValidity(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: double) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AuthSessionValidity <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#callback_urls-1">CognitoUserPoolClient#callback_urls</a>.
        /// </summary>
        [<CustomOperation "callback_urls">]
        member _.CallbackUrls(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.CallbackUrls <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#default_redirect_uri-1">CognitoUserPoolClient#default_redirect_uri</a>.
        /// </summary>
        [<CustomOperation "default_redirect_uri">]
        member _.DefaultRedirectUri(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: string) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.DefaultRedirectUri <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#enable_propagate_additional_user_context_data-1">CognitoUserPoolClient#enable_propagate_additional_user_context_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_propagate_additional_user_context_data">]
        member _.EnablePropagateAdditionalUserContextData(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: bool) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.EnablePropagateAdditionalUserContextData <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#enable_propagate_additional_user_context_data-1">CognitoUserPoolClient#enable_propagate_additional_user_context_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_propagate_additional_user_context_data">]
        member _.EnablePropagateAdditionalUserContextData(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.EnablePropagateAdditionalUserContextData <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#enable_token_revocation-1">CognitoUserPoolClient#enable_token_revocation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_token_revocation">]
        member _.EnableTokenRevocation(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: bool) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.EnableTokenRevocation <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#enable_token_revocation-1">CognitoUserPoolClient#enable_token_revocation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_token_revocation">]
        member _.EnableTokenRevocation(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.EnableTokenRevocation <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#explicit_auth_flows-1">CognitoUserPoolClient#explicit_auth_flows</a>.
        /// </summary>
        [<CustomOperation "explicit_auth_flows">]
        member _.ExplicitAuthFlows(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ExplicitAuthFlows <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#generate_secret-1">CognitoUserPoolClient#generate_secret</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "generate_secret">]
        member _.GenerateSecret(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: bool) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.GenerateSecret <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#generate_secret-1">CognitoUserPoolClient#generate_secret</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "generate_secret">]
        member _.GenerateSecret(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.GenerateSecret <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#id_token_validity-1">CognitoUserPoolClient#id_token_validity</a>.
        /// </summary>
        [<CustomOperation "id_token_validity">]
        member _.IdTokenValidity(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: double) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.IdTokenValidity <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#logout_urls-1">CognitoUserPoolClient#logout_urls</a>.
        /// </summary>
        [<CustomOperation "logout_urls">]
        member _.LogoutUrls(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.LogoutUrls <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#prevent_user_existence_errors-1">CognitoUserPoolClient#prevent_user_existence_errors</a>.
        /// </summary>
        [<CustomOperation "prevent_user_existence_errors">]
        member _.PreventUserExistenceErrors(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: string) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.PreventUserExistenceErrors <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#read_attributes-1">CognitoUserPoolClient#read_attributes</a>.
        /// </summary>
        [<CustomOperation "read_attributes">]
        member _.ReadAttributes(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ReadAttributes <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// refresh_token_rotation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#refresh_token_rotation-1">CognitoUserPoolClient#refresh_token_rotation</a> Accepts: aws.IResolvable | aws.CognitoUserPoolClient.CognitoUserPoolClientRefreshTokenRotation[]
        /// </summary>
        [<CustomOperation "refresh_token_rotation">]
        member _.RefreshTokenRotation(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.RefreshTokenRotation <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#refresh_token_validity-1">CognitoUserPoolClient#refresh_token_validity</a>.
        /// </summary>
        [<CustomOperation "refresh_token_validity">]
        member _.RefreshTokenValidity(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: double) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.RefreshTokenValidity <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#supported_identity_providers-1">CognitoUserPoolClient#supported_identity_providers</a>.
        /// </summary>
        [<CustomOperation "supported_identity_providers">]
        member _.SupportedIdentityProviders(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.SupportedIdentityProviders <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// token_validity_units block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#token_validity_units-1">CognitoUserPoolClient#token_validity_units</a> Accepts: aws.IResolvable | aws.CognitoUserPoolClient.CognitoUserPoolClientTokenValidityUnits[]
        /// </summary>
        [<CustomOperation "token_validity_units">]
        member _.TokenValidityUnits(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.TokenValidityUnits <- value)
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#write_attributes-1">CognitoUserPoolClient#write_attributes</a>.
        /// </summary>
        [<CustomOperation "write_attributes">]
        member _.WriteAttributes(state: CognitoUserPoolClientState<'Name, 'UserPoolId>, value: seq<string>) : CognitoUserPoolClientState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.WriteAttributes <- (value |> Seq.toArray))
            state : CognitoUserPoolClientState<'Name, 'UserPoolId>

        member _.Run(state: CognitoUserPoolClientState<Present, Present>) : aws.CognitoUserPoolClient.CognitoUserPoolClient =
            let config = aws.CognitoUserPoolClient.CognitoUserPoolClientConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUserPoolClient.CognitoUserPoolClient(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUserPoolClient: missing required arguments. Must call: name, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserPoolClientState<_, _>) : aws.CognitoUserPoolClient.CognitoUserPoolClient =
            Unchecked.defaultof<aws.CognitoUserPoolClient.CognitoUserPoolClient>
