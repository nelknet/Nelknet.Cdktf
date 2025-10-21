namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> = { assignments: ResizeArray<aws.Apigatewayv2Authorizer.Apigatewayv2AuthorizerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer">aws_apigatewayv2_authorizer</a>.
    /// </summary>
    type Apigatewayv2AuthorizerBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2AuthorizerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2AuthorizerState<Missing, Missing, Missing>)

        member _.Zero(()) : Apigatewayv2AuthorizerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2AuthorizerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#api_id-1">Apigatewayv2Authorizer#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2AuthorizerState<Missing, 'AuthorizerType, 'Name>, value: string) : Apigatewayv2AuthorizerState<Present, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2AuthorizerState<Present, 'AuthorizerType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#authorizer_type-1">Apigatewayv2Authorizer#authorizer_type</a>.
        /// </summary>
        [<CustomOperation "authorizer_type">]
        member _.AuthorizerType(state: Apigatewayv2AuthorizerState<'ApiId, Missing, 'Name>, value: string) : Apigatewayv2AuthorizerState<'ApiId, Present, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizerType <- value)
            ({ assignments = state.assignments } : Apigatewayv2AuthorizerState<'ApiId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#name-1">Apigatewayv2Authorizer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, Missing>, value: string) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#authorizer_credentials_arn-1">Apigatewayv2Authorizer#authorizer_credentials_arn</a>.
        /// </summary>
        [<CustomOperation "authorizer_credentials_arn">]
        member _.AuthorizerCredentialsArn(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: string) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizerCredentialsArn <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#authorizer_payload_format_version-1">Apigatewayv2Authorizer#authorizer_payload_format_version</a>.
        /// </summary>
        [<CustomOperation "authorizer_payload_format_version">]
        member _.AuthorizerPayloadFormatVersion(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: string) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizerPayloadFormatVersion <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#authorizer_result_ttl_in_seconds-1">Apigatewayv2Authorizer#authorizer_result_ttl_in_seconds</a>.
        /// </summary>
        [<CustomOperation "authorizer_result_ttl_in_seconds">]
        member _.AuthorizerResultTtlInSeconds(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: double) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizerResultTtlInSeconds <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#authorizer_uri-1">Apigatewayv2Authorizer#authorizer_uri</a>.
        /// </summary>
        [<CustomOperation "authorizer_uri">]
        member _.AuthorizerUri(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: string) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizerUri <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#enable_simple_responses-1">Apigatewayv2Authorizer#enable_simple_responses</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_simple_responses">]
        member _.EnableSimpleResponses(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: bool) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.EnableSimpleResponses <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#enable_simple_responses-1">Apigatewayv2Authorizer#enable_simple_responses</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_simple_responses">]
        member _.EnableSimpleResponses(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.EnableSimpleResponses <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#id-1">Apigatewayv2Authorizer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: string) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#identity_sources-1">Apigatewayv2Authorizer#identity_sources</a>.
        /// </summary>
        [<CustomOperation "identity_sources">]
        member _.IdentitySources(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: seq<string>) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.IdentitySources <- (value |> Seq.toArray))
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// jwt_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#jwt_configuration-1">Apigatewayv2Authorizer#jwt_configuration</a>
        /// </summary>
        [<CustomOperation "jwt_configuration">]
        member _.JwtConfiguration(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: aws.Apigatewayv2Authorizer.Apigatewayv2AuthorizerJwtConfiguration) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.JwtConfiguration <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#timeouts-1">Apigatewayv2Authorizer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>, value: aws.Apigatewayv2Authorizer.Apigatewayv2AuthorizerTimeouts) : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Apigatewayv2AuthorizerState<'ApiId, 'AuthorizerType, 'Name>

        member _.Run(state: Apigatewayv2AuthorizerState<Present, Present, Present>) : aws.Apigatewayv2Authorizer.Apigatewayv2Authorizer =
            let config = aws.Apigatewayv2Authorizer.Apigatewayv2AuthorizerConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Authorizer.Apigatewayv2Authorizer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Authorizer: missing required arguments. Must call: api_id, authorizer_type, name.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2AuthorizerState<_, _, _>) : aws.Apigatewayv2Authorizer.Apigatewayv2Authorizer =
            Unchecked.defaultof<aws.Apigatewayv2Authorizer.Apigatewayv2Authorizer>
