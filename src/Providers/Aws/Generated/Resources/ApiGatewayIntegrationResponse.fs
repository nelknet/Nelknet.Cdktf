namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> = { assignments: ResizeArray<aws.ApiGatewayIntegrationResponse.ApiGatewayIntegrationResponseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response">aws_api_gateway_integration_response</a>.
    /// </summary>
    type ApiGatewayIntegrationResponseBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayIntegrationResponseState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayIntegrationResponseState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayIntegrationResponseState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayIntegrationResponseState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#http_method-1">ApiGatewayIntegrationResponse#http_method</a>.
        /// </summary>
        [<CustomOperation "http_method">]
        member _.HttpMethod(state: ApiGatewayIntegrationResponseState<Missing, 'ResourceId, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayIntegrationResponseState<Present, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.HttpMethod <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationResponseState<Present, 'ResourceId, 'RestApiId, 'StatusCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#resource_id-1">ApiGatewayIntegrationResponse#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ApiGatewayIntegrationResponseState<'HttpMethod, Missing, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayIntegrationResponseState<'HttpMethod, Present, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationResponseState<'HttpMethod, Present, 'RestApiId, 'StatusCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#rest_api_id-1">ApiGatewayIntegrationResponse#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, Missing, 'StatusCode>, value: string) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, Present, 'StatusCode> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, Present, 'StatusCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#status_code-1">ApiGatewayIntegrationResponse#status_code</a>.
        /// </summary>
        [<CustomOperation "status_code">]
        member _.StatusCode(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, Missing>, value: string) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, Present> =
            state.assignments.Add(fun config -> config.StatusCode <- value)
            ({ assignments = state.assignments } : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#content_handling-1">ApiGatewayIntegrationResponse#content_handling</a>.
        /// </summary>
        [<CustomOperation "content_handling">]
        member _.ContentHandling(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ContentHandling <- value)
            state : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#id-1">ApiGatewayIntegrationResponse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#response_parameters-1">ApiGatewayIntegrationResponse#response_parameters</a>.
        /// </summary>
        [<CustomOperation "response_parameters">]
        member _.ResponseParameters(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: seq<string * string>) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ResponseParameters <- dict value)
            state : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#response_templates-1">ApiGatewayIntegrationResponse#response_templates</a>.
        /// </summary>
        [<CustomOperation "response_templates">]
        member _.ResponseTemplates(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: seq<string * string>) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ResponseTemplates <- dict value)
            state : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_integration_response#selection_pattern-1">ApiGatewayIntegrationResponse#selection_pattern</a>.
        /// </summary>
        [<CustomOperation "selection_pattern">]
        member _.SelectionPattern(state: ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.SelectionPattern <- value)
            state : ApiGatewayIntegrationResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        member _.Run(state: ApiGatewayIntegrationResponseState<Present, Present, Present, Present>) : aws.ApiGatewayIntegrationResponse.ApiGatewayIntegrationResponse =
            let config = aws.ApiGatewayIntegrationResponse.ApiGatewayIntegrationResponseConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayIntegrationResponse.ApiGatewayIntegrationResponse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayIntegrationResponse: missing required arguments. Must call: http_method, resource_id, rest_api_id, status_code.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayIntegrationResponseState<_, _, _, _>) : aws.ApiGatewayIntegrationResponse.ApiGatewayIntegrationResponse =
            Unchecked.defaultof<aws.ApiGatewayIntegrationResponse.ApiGatewayIntegrationResponse>
