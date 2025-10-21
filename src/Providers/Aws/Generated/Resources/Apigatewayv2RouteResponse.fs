namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey> = { assignments: ResizeArray<aws.Apigatewayv2RouteResponse.Apigatewayv2RouteResponseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response">aws_apigatewayv2_route_response</a>.
    /// </summary>
    type Apigatewayv2RouteResponseBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2RouteResponseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2RouteResponseState<Missing, Missing, Missing>)

        member _.Zero(()) : Apigatewayv2RouteResponseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2RouteResponseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response#api_id-1">Apigatewayv2RouteResponse#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2RouteResponseState<Missing, 'RouteId, 'RouteResponseKey>, value: string) : Apigatewayv2RouteResponseState<Present, 'RouteId, 'RouteResponseKey> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2RouteResponseState<Present, 'RouteId, 'RouteResponseKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response#route_id-1">Apigatewayv2RouteResponse#route_id</a>.
        /// </summary>
        [<CustomOperation "route_id">]
        member _.RouteId(state: Apigatewayv2RouteResponseState<'ApiId, Missing, 'RouteResponseKey>, value: string) : Apigatewayv2RouteResponseState<'ApiId, Present, 'RouteResponseKey> =
            state.assignments.Add(fun config -> config.RouteId <- value)
            ({ assignments = state.assignments } : Apigatewayv2RouteResponseState<'ApiId, Present, 'RouteResponseKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response#route_response_key-1">Apigatewayv2RouteResponse#route_response_key</a>.
        /// </summary>
        [<CustomOperation "route_response_key">]
        member _.RouteResponseKey(state: Apigatewayv2RouteResponseState<'ApiId, 'RouteId, Missing>, value: string) : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, Present> =
            state.assignments.Add(fun config -> config.RouteResponseKey <- value)
            ({ assignments = state.assignments } : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response#id-1">Apigatewayv2RouteResponse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey>, value: string) : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response#model_selection_expression-1">Apigatewayv2RouteResponse#model_selection_expression</a>.
        /// </summary>
        [<CustomOperation "model_selection_expression">]
        member _.ModelSelectionExpression(state: Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey>, value: string) : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey> =
            state.assignments.Add(fun config -> config.ModelSelectionExpression <- value)
            state : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route_response#response_models-1">Apigatewayv2RouteResponse#response_models</a>.
        /// </summary>
        [<CustomOperation "response_models">]
        member _.ResponseModels(state: Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey>, value: seq<string * string>) : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey> =
            state.assignments.Add(fun config -> config.ResponseModels <- dict value)
            state : Apigatewayv2RouteResponseState<'ApiId, 'RouteId, 'RouteResponseKey>

        member _.Run(state: Apigatewayv2RouteResponseState<Present, Present, Present>) : aws.Apigatewayv2RouteResponse.Apigatewayv2RouteResponse =
            let config = aws.Apigatewayv2RouteResponse.Apigatewayv2RouteResponseConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2RouteResponse.Apigatewayv2RouteResponse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2RouteResponse: missing required arguments. Must call: api_id, route_id, route_response_key.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2RouteResponseState<_, _, _>) : aws.Apigatewayv2RouteResponse.Apigatewayv2RouteResponse =
            Unchecked.defaultof<aws.Apigatewayv2RouteResponse.Apigatewayv2RouteResponse>
