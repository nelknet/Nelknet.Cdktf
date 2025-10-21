namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayAuthorizerState<'Name, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayAuthorizer.ApiGatewayAuthorizerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer">aws_api_gateway_authorizer</a>.
    /// </summary>
    type ApiGatewayAuthorizerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayAuthorizerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayAuthorizerState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayAuthorizerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayAuthorizerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#name-1">ApiGatewayAuthorizer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayAuthorizerState<Missing, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayAuthorizerState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#rest_api_id-1">ApiGatewayAuthorizer#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayAuthorizerState<'Name, Missing>, value: string) : ApiGatewayAuthorizerState<'Name, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayAuthorizerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#authorizer_credentials-1">ApiGatewayAuthorizer#authorizer_credentials</a>.
        /// </summary>
        [<CustomOperation "authorizer_credentials">]
        member _.AuthorizerCredentials(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.AuthorizerCredentials <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#authorizer_result_ttl_in_seconds-1">ApiGatewayAuthorizer#authorizer_result_ttl_in_seconds</a>.
        /// </summary>
        [<CustomOperation "authorizer_result_ttl_in_seconds">]
        member _.AuthorizerResultTtlInSeconds(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: double) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.AuthorizerResultTtlInSeconds <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#authorizer_uri-1">ApiGatewayAuthorizer#authorizer_uri</a>.
        /// </summary>
        [<CustomOperation "authorizer_uri">]
        member _.AuthorizerUri(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.AuthorizerUri <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#id-1">ApiGatewayAuthorizer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#identity_source-1">ApiGatewayAuthorizer#identity_source</a>.
        /// </summary>
        [<CustomOperation "identity_source">]
        member _.IdentitySource(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.IdentitySource <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#identity_validation_expression-1">ApiGatewayAuthorizer#identity_validation_expression</a>.
        /// </summary>
        [<CustomOperation "identity_validation_expression">]
        member _.IdentityValidationExpression(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.IdentityValidationExpression <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#provider_arns-1">ApiGatewayAuthorizer#provider_arns</a>.
        /// </summary>
        [<CustomOperation "provider_arns">]
        member _.ProviderArns(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: seq<string>) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.ProviderArns <- (value |> Seq.toArray))
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_authorizer#type-1">ApiGatewayAuthorizer#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ApiGatewayAuthorizerState<'Name, 'RestApiId>, value: string) : ApiGatewayAuthorizerState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : ApiGatewayAuthorizerState<'Name, 'RestApiId>

        member _.Run(state: ApiGatewayAuthorizerState<Present, Present>) : aws.ApiGatewayAuthorizer.ApiGatewayAuthorizer =
            let config = aws.ApiGatewayAuthorizer.ApiGatewayAuthorizerConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayAuthorizer.ApiGatewayAuthorizer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayAuthorizer: missing required arguments. Must call: name, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayAuthorizerState<_, _>) : aws.ApiGatewayAuthorizer.ApiGatewayAuthorizer =
            Unchecked.defaultof<aws.ApiGatewayAuthorizer.ApiGatewayAuthorizer>
