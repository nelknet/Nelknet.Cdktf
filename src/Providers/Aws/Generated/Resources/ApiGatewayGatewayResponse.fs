namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayGatewayResponse.ApiGatewayGatewayResponseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response">aws_api_gateway_gateway_response</a>.
    /// </summary>
    type ApiGatewayGatewayResponseBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayGatewayResponseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayGatewayResponseState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayGatewayResponseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayGatewayResponseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response#response_type-1">ApiGatewayGatewayResponse#response_type</a>.
        /// </summary>
        [<CustomOperation "response_type">]
        member _.ResponseType(state: ApiGatewayGatewayResponseState<Missing, 'RestApiId>, value: string) : ApiGatewayGatewayResponseState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.ResponseType <- value)
            ({ assignments = state.assignments } : ApiGatewayGatewayResponseState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response#rest_api_id-1">ApiGatewayGatewayResponse#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayGatewayResponseState<'ResponseType, Missing>, value: string) : ApiGatewayGatewayResponseState<'ResponseType, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayGatewayResponseState<'ResponseType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response#id-1">ApiGatewayGatewayResponse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>, value: string) : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response#response_parameters-1">ApiGatewayGatewayResponse#response_parameters</a>.
        /// </summary>
        [<CustomOperation "response_parameters">]
        member _.ResponseParameters(state: ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>, value: seq<string * string>) : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId> =
            state.assignments.Add(fun config -> config.ResponseParameters <- dict value)
            state : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response#response_templates-1">ApiGatewayGatewayResponse#response_templates</a>.
        /// </summary>
        [<CustomOperation "response_templates">]
        member _.ResponseTemplates(state: ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>, value: seq<string * string>) : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId> =
            state.assignments.Add(fun config -> config.ResponseTemplates <- dict value)
            state : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_gateway_response#status_code-1">ApiGatewayGatewayResponse#status_code</a>.
        /// </summary>
        [<CustomOperation "status_code">]
        member _.StatusCode(state: ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>, value: string) : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId> =
            state.assignments.Add(fun config -> config.StatusCode <- value)
            state : ApiGatewayGatewayResponseState<'ResponseType, 'RestApiId>

        member _.Run(state: ApiGatewayGatewayResponseState<Present, Present>) : aws.ApiGatewayGatewayResponse.ApiGatewayGatewayResponse =
            let config = aws.ApiGatewayGatewayResponse.ApiGatewayGatewayResponseConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayGatewayResponse.ApiGatewayGatewayResponse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayGatewayResponse: missing required arguments. Must call: response_type, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayGatewayResponseState<_, _>) : aws.ApiGatewayGatewayResponse.ApiGatewayGatewayResponse =
            Unchecked.defaultof<aws.ApiGatewayGatewayResponse.ApiGatewayGatewayResponse>
