namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> = { assignments: ResizeArray<aws.ApiGatewayMethodResponse.ApiGatewayMethodResponseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response">aws_api_gateway_method_response</a>.
    /// </summary>
    type ApiGatewayMethodResponseBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayMethodResponseState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayMethodResponseState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayMethodResponseState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayMethodResponseState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#http_method-1">ApiGatewayMethodResponse#http_method</a>.
        /// </summary>
        [<CustomOperation "http_method">]
        member _.HttpMethod(state: ApiGatewayMethodResponseState<Missing, 'ResourceId, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayMethodResponseState<Present, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.HttpMethod <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodResponseState<Present, 'ResourceId, 'RestApiId, 'StatusCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#resource_id-1">ApiGatewayMethodResponse#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ApiGatewayMethodResponseState<'HttpMethod, Missing, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayMethodResponseState<'HttpMethod, Present, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodResponseState<'HttpMethod, Present, 'RestApiId, 'StatusCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#rest_api_id-1">ApiGatewayMethodResponse#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, Missing, 'StatusCode>, value: string) : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, Present, 'StatusCode> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, Present, 'StatusCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#status_code-1">ApiGatewayMethodResponse#status_code</a>.
        /// </summary>
        [<CustomOperation "status_code">]
        member _.StatusCode(state: ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, Missing>, value: string) : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, Present> =
            state.assignments.Add(fun config -> config.StatusCode <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#id-1">ApiGatewayMethodResponse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: string) : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#response_models-1">ApiGatewayMethodResponse#response_models</a>.
        /// </summary>
        [<CustomOperation "response_models">]
        member _.ResponseModels(state: ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: seq<string * string>) : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ResponseModels <- dict value)
            state : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_response#response_parameters-1">ApiGatewayMethodResponse#response_parameters</a>.
        /// </summary>
        [<CustomOperation "response_parameters">]
        member _.ResponseParameters(state: ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>, value: seq<string * obj>) : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode> =
            state.assignments.Add(fun config -> config.ResponseParameters <- dict value)
            state : ApiGatewayMethodResponseState<'HttpMethod, 'ResourceId, 'RestApiId, 'StatusCode>

        member _.Run(state: ApiGatewayMethodResponseState<Present, Present, Present, Present>) : aws.ApiGatewayMethodResponse.ApiGatewayMethodResponse =
            let config = aws.ApiGatewayMethodResponse.ApiGatewayMethodResponseConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayMethodResponse.ApiGatewayMethodResponse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayMethodResponse: missing required arguments. Must call: http_method, resource_id, rest_api_id, status_code.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayMethodResponseState<_, _, _, _>) : aws.ApiGatewayMethodResponse.ApiGatewayMethodResponse =
            Unchecked.defaultof<aws.ApiGatewayMethodResponse.ApiGatewayMethodResponse>
