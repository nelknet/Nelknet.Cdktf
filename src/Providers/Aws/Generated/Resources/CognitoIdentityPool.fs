namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoIdentityPoolState<'IdentityPoolName> = { assignments: ResizeArray<aws.CognitoIdentityPool.CognitoIdentityPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool">aws_cognito_identity_pool</a>.
    /// </summary>
    type CognitoIdentityPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoIdentityPoolState<Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityPoolState<Missing>)

        member _.Zero(()) : CognitoIdentityPoolState<Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityPoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#identity_pool_name-1">CognitoIdentityPool#identity_pool_name</a>.
        /// </summary>
        [<CustomOperation "identity_pool_name">]
        member _.IdentityPoolName(state: CognitoIdentityPoolState<Missing>, value: string) : CognitoIdentityPoolState<Present> =
            state.assignments.Add(fun config -> config.IdentityPoolName <- value)
            ({ assignments = state.assignments } : CognitoIdentityPoolState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#allow_classic_flow-1">CognitoIdentityPool#allow_classic_flow</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_classic_flow">]
        member _.AllowClassicFlow(state: CognitoIdentityPoolState<'IdentityPoolName>, value: bool) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.AllowClassicFlow <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#allow_classic_flow-1">CognitoIdentityPool#allow_classic_flow</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_classic_flow">]
        member _.AllowClassicFlow(state: CognitoIdentityPoolState<'IdentityPoolName>, value: HashiCorp.Cdktf.IResolvable) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.AllowClassicFlow <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#allow_unauthenticated_identities-1">CognitoIdentityPool#allow_unauthenticated_identities</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_unauthenticated_identities">]
        member _.AllowUnauthenticatedIdentities(state: CognitoIdentityPoolState<'IdentityPoolName>, value: bool) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.AllowUnauthenticatedIdentities <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#allow_unauthenticated_identities-1">CognitoIdentityPool#allow_unauthenticated_identities</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_unauthenticated_identities">]
        member _.AllowUnauthenticatedIdentities(state: CognitoIdentityPoolState<'IdentityPoolName>, value: HashiCorp.Cdktf.IResolvable) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.AllowUnauthenticatedIdentities <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// cognito_identity_providers block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#cognito_identity_providers-1">CognitoIdentityPool#cognito_identity_providers</a> Accepts: aws.IResolvable | aws.CognitoIdentityPool.CognitoIdentityPoolCognitoIdentityProviders[]
        /// </summary>
        [<CustomOperation "cognito_identity_providers">]
        member _.CognitoIdentityProviders(state: CognitoIdentityPoolState<'IdentityPoolName>, value: HashiCorp.Cdktf.IResolvable) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.CognitoIdentityProviders <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#developer_provider_name-1">CognitoIdentityPool#developer_provider_name</a>.
        /// </summary>
        [<CustomOperation "developer_provider_name">]
        member _.DeveloperProviderName(state: CognitoIdentityPoolState<'IdentityPoolName>, value: string) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.DeveloperProviderName <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#id-1">CognitoIdentityPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoIdentityPoolState<'IdentityPoolName>, value: string) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#openid_connect_provider_arns-1">CognitoIdentityPool#openid_connect_provider_arns</a>.
        /// </summary>
        [<CustomOperation "openid_connect_provider_arns">]
        member _.OpenidConnectProviderArns(state: CognitoIdentityPoolState<'IdentityPoolName>, value: seq<string>) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.OpenidConnectProviderArns <- (value |> Seq.toArray))
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#saml_provider_arns-1">CognitoIdentityPool#saml_provider_arns</a>.
        /// </summary>
        [<CustomOperation "saml_provider_arns">]
        member _.SamlProviderArns(state: CognitoIdentityPoolState<'IdentityPoolName>, value: seq<string>) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.SamlProviderArns <- (value |> Seq.toArray))
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#supported_login_providers-1">CognitoIdentityPool#supported_login_providers</a>.
        /// </summary>
        [<CustomOperation "supported_login_providers">]
        member _.SupportedLoginProviders(state: CognitoIdentityPoolState<'IdentityPoolName>, value: seq<string * string>) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.SupportedLoginProviders <- dict value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#tags-1">CognitoIdentityPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CognitoIdentityPoolState<'IdentityPoolName>, value: seq<string * string>) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool#tags_all-1">CognitoIdentityPool#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CognitoIdentityPoolState<'IdentityPoolName>, value: seq<string * string>) : CognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CognitoIdentityPoolState<'IdentityPoolName>

        member _.Run(state: CognitoIdentityPoolState<Present>) : aws.CognitoIdentityPool.CognitoIdentityPool =
            let config = aws.CognitoIdentityPool.CognitoIdentityPoolConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoIdentityPool.CognitoIdentityPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoIdentityPool: missing required arguments. Must call: identity_pool_name.", 9999, IsError = true)>]
        member _.Run(_: CognitoIdentityPoolState<_>) : aws.CognitoIdentityPool.CognitoIdentityPool =
            Unchecked.defaultof<aws.CognitoIdentityPool.CognitoIdentityPool>
