namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> = { assignments: ResizeArray<aws.ApiGatewayIntegration.ApiGatewayIntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration">aws_api_gateway_integration</a>.
    /// </summary>
    type ApiGatewayIntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayIntegrationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayIntegrationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayIntegrationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayIntegrationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#http_method-1">ApiGatewayIntegration#http_method</a>.
        /// </summary>
        [<CustomOperation "http_method">]
        member _.HttpMethod(state: ApiGatewayIntegrationState<Missing, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<Present, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.HttpMethod <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationState<Present, 'ResourceId, 'RestApiId, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#resource_id-1">ApiGatewayIntegration#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ApiGatewayIntegrationState<'HttpMethod, Missing, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, Present, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationState<'HttpMethod, Present, 'RestApiId, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#rest_api_id-1">ApiGatewayIntegration#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, Missing, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, Present, 'Type> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#type-1">ApiGatewayIntegration#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, Missing>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#cache_key_parameters-1">ApiGatewayIntegration#cache_key_parameters</a>.
        /// </summary>
        [<CustomOperation "cache_key_parameters">]
        member _.CacheKeyParameters(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: seq<string>) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.CacheKeyParameters <- (value |> Seq.toArray))
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#cache_namespace-1">ApiGatewayIntegration#cache_namespace</a>.
        /// </summary>
        [<CustomOperation "cache_namespace">]
        member _.CacheNamespace(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.CacheNamespace <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#connection_id-1">ApiGatewayIntegration#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#connection_type-1">ApiGatewayIntegration#connection_type</a>.
        /// </summary>
        [<CustomOperation "connection_type">]
        member _.ConnectionType(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.ConnectionType <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#content_handling-1">ApiGatewayIntegration#content_handling</a>.
        /// </summary>
        [<CustomOperation "content_handling">]
        member _.ContentHandling(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.ContentHandling <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#credentials-1">ApiGatewayIntegration#credentials</a>.
        /// </summary>
        [<CustomOperation "credentials">]
        member _.Credentials(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.Credentials <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#id-1">ApiGatewayIntegration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#integration_http_method-1">ApiGatewayIntegration#integration_http_method</a>.
        /// </summary>
        [<CustomOperation "integration_http_method">]
        member _.IntegrationHttpMethod(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.IntegrationHttpMethod <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#passthrough_behavior-1">ApiGatewayIntegration#passthrough_behavior</a>.
        /// </summary>
        [<CustomOperation "passthrough_behavior">]
        member _.PassthroughBehavior(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.PassthroughBehavior <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#request_parameters-1">ApiGatewayIntegration#request_parameters</a>.
        /// </summary>
        [<CustomOperation "request_parameters">]
        member _.RequestParameters(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: seq<string * string>) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.RequestParameters <- dict value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#request_templates-1">ApiGatewayIntegration#request_templates</a>.
        /// </summary>
        [<CustomOperation "request_templates">]
        member _.RequestTemplates(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: seq<string * string>) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.RequestTemplates <- dict value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#timeout_milliseconds-1">ApiGatewayIntegration#timeout_milliseconds</a>.
        /// </summary>
        [<CustomOperation "timeout_milliseconds">]
        member _.TimeoutMilliseconds(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: double) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.TimeoutMilliseconds <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// tls_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#tls_config-1">ApiGatewayIntegration#tls_config</a>
        /// </summary>
        [<CustomOperation "tls_config">]
        member _.TlsConfig(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: aws.ApiGatewayIntegration.ApiGatewayIntegrationTlsConfig) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.TlsConfig <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration#uri-1">ApiGatewayIntegration#uri</a>.
        /// </summary>
        [<CustomOperation "uri">]
        member _.Uri(state: ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>, value: string) : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type> =
            state.assignments.Add(fun config -> config.Uri <- value)
            state : ApiGatewayIntegrationState<'HttpMethod, 'ResourceId, 'RestApiId, 'Type>

        member _.Run(state: ApiGatewayIntegrationState<Present, Present, Present, Present>) : aws.ApiGatewayIntegration.ApiGatewayIntegration =
            let config = aws.ApiGatewayIntegration.ApiGatewayIntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayIntegration.ApiGatewayIntegration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayIntegration: missing required arguments. Must call: http_method, resource_id, rest_api_id, type.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayIntegrationState<_, _, _, _>) : aws.ApiGatewayIntegration.ApiGatewayIntegration =
            Unchecked.defaultof<aws.ApiGatewayIntegration.ApiGatewayIntegration>
