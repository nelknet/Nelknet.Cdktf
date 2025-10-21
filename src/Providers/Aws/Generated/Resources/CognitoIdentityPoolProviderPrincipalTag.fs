namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName> = { assignments: ResizeArray<aws.CognitoIdentityPoolProviderPrincipalTag.CognitoIdentityPoolProviderPrincipalTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag">aws_cognito_identity_pool_provider_principal_tag</a>.
    /// </summary>
    type CognitoIdentityPoolProviderPrincipalTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoIdentityPoolProviderPrincipalTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityPoolProviderPrincipalTagState<Missing, Missing>)

        member _.Zero(()) : CognitoIdentityPoolProviderPrincipalTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityPoolProviderPrincipalTagState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag#identity_pool_id-1">CognitoIdentityPoolProviderPrincipalTag#identity_pool_id</a>.
        /// </summary>
        [<CustomOperation "identity_pool_id">]
        member _.IdentityPoolId(state: CognitoIdentityPoolProviderPrincipalTagState<Missing, 'IdentityProviderName>, value: string) : CognitoIdentityPoolProviderPrincipalTagState<Present, 'IdentityProviderName> =
            state.assignments.Add(fun config -> config.IdentityPoolId <- value)
            ({ assignments = state.assignments } : CognitoIdentityPoolProviderPrincipalTagState<Present, 'IdentityProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag#identity_provider_name-1">CognitoIdentityPoolProviderPrincipalTag#identity_provider_name</a>.
        /// </summary>
        [<CustomOperation "identity_provider_name">]
        member _.IdentityProviderName(state: CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, Missing>, value: string) : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, Present> =
            state.assignments.Add(fun config -> config.IdentityProviderName <- value)
            ({ assignments = state.assignments } : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag#id-1">CognitoIdentityPoolProviderPrincipalTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>, value: string) : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag#principal_tags-1">CognitoIdentityPoolProviderPrincipalTag#principal_tags</a>.
        /// </summary>
        [<CustomOperation "principal_tags">]
        member _.PrincipalTags(state: CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>, value: seq<string * string>) : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName> =
            state.assignments.Add(fun config -> config.PrincipalTags <- dict value)
            state : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag#use_defaults-1">CognitoIdentityPoolProviderPrincipalTag#use_defaults</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_defaults">]
        member _.UseDefaults(state: CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>, value: bool) : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName> =
            state.assignments.Add(fun config -> config.UseDefaults <- value)
            state : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_provider_principal_tag#use_defaults-1">CognitoIdentityPoolProviderPrincipalTag#use_defaults</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_defaults">]
        member _.UseDefaults(state: CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>, value: HashiCorp.Cdktf.IResolvable) : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName> =
            state.assignments.Add(fun config -> config.UseDefaults <- value)
            state : CognitoIdentityPoolProviderPrincipalTagState<'IdentityPoolId, 'IdentityProviderName>

        member _.Run(state: CognitoIdentityPoolProviderPrincipalTagState<Present, Present>) : aws.CognitoIdentityPoolProviderPrincipalTag.CognitoIdentityPoolProviderPrincipalTag =
            let config = aws.CognitoIdentityPoolProviderPrincipalTag.CognitoIdentityPoolProviderPrincipalTagConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoIdentityPoolProviderPrincipalTag.CognitoIdentityPoolProviderPrincipalTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoIdentityPoolProviderPrincipalTag: missing required arguments. Must call: identity_pool_id, identity_provider_name.", 9999, IsError = true)>]
        member _.Run(_: CognitoIdentityPoolProviderPrincipalTagState<_, _>) : aws.CognitoIdentityPoolProviderPrincipalTag.CognitoIdentityPoolProviderPrincipalTag =
            Unchecked.defaultof<aws.CognitoIdentityPoolProviderPrincipalTag.CognitoIdentityPoolProviderPrincipalTag>
