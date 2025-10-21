namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2RouteState<'ApiId, 'RouteKey> = { assignments: ResizeArray<aws.Apigatewayv2Route.Apigatewayv2RouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route">aws_apigatewayv2_route</a>.
    /// </summary>
    type Apigatewayv2RouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2RouteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2RouteState<Missing, Missing>)

        member _.Zero(()) : Apigatewayv2RouteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2RouteState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#api_id-1">Apigatewayv2Route#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2RouteState<Missing, 'RouteKey>, value: string) : Apigatewayv2RouteState<Present, 'RouteKey> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2RouteState<Present, 'RouteKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#route_key-1">Apigatewayv2Route#route_key</a>.
        /// </summary>
        [<CustomOperation "route_key">]
        member _.RouteKey(state: Apigatewayv2RouteState<'ApiId, Missing>, value: string) : Apigatewayv2RouteState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.RouteKey <- value)
            ({ assignments = state.assignments } : Apigatewayv2RouteState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#api_key_required-1">Apigatewayv2Route#api_key_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "api_key_required">]
        member _.ApiKeyRequired(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: bool) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.ApiKeyRequired <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#api_key_required-1">Apigatewayv2Route#api_key_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "api_key_required">]
        member _.ApiKeyRequired(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.ApiKeyRequired <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#authorization_scopes-1">Apigatewayv2Route#authorization_scopes</a>.
        /// </summary>
        [<CustomOperation "authorization_scopes">]
        member _.AuthorizationScopes(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: seq<string>) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.AuthorizationScopes <- (value |> Seq.toArray))
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#authorization_type-1">Apigatewayv2Route#authorization_type</a>.
        /// </summary>
        [<CustomOperation "authorization_type">]
        member _.AuthorizationType(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.AuthorizationType <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#authorizer_id-1">Apigatewayv2Route#authorizer_id</a>.
        /// </summary>
        [<CustomOperation "authorizer_id">]
        member _.AuthorizerId(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.AuthorizerId <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#id-1">Apigatewayv2Route#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#model_selection_expression-1">Apigatewayv2Route#model_selection_expression</a>.
        /// </summary>
        [<CustomOperation "model_selection_expression">]
        member _.ModelSelectionExpression(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.ModelSelectionExpression <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#operation_name-1">Apigatewayv2Route#operation_name</a>.
        /// </summary>
        [<CustomOperation "operation_name">]
        member _.OperationName(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.OperationName <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#request_models-1">Apigatewayv2Route#request_models</a>.
        /// </summary>
        [<CustomOperation "request_models">]
        member _.RequestModels(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: seq<string * string>) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.RequestModels <- dict value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// request_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#request_parameter-1">Apigatewayv2Route#request_parameter</a> Accepts: aws.IResolvable | aws.Apigatewayv2Route.Apigatewayv2RouteRequestParameter[]
        /// </summary>
        [<CustomOperation "request_parameter">]
        member _.RequestParameter(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.RequestParameter <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#route_response_selection_expression-1">Apigatewayv2Route#route_response_selection_expression</a>.
        /// </summary>
        [<CustomOperation "route_response_selection_expression">]
        member _.RouteResponseSelectionExpression(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.RouteResponseSelectionExpression <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#target-1">Apigatewayv2Route#target</a>.
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: Apigatewayv2RouteState<'ApiId, 'RouteKey>, value: string) : Apigatewayv2RouteState<'ApiId, 'RouteKey> =
            state.assignments.Add(fun config -> config.Target <- value)
            state : Apigatewayv2RouteState<'ApiId, 'RouteKey>

        member _.Run(state: Apigatewayv2RouteState<Present, Present>) : aws.Apigatewayv2Route.Apigatewayv2Route =
            let config = aws.Apigatewayv2Route.Apigatewayv2RouteConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Route.Apigatewayv2Route(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Route: missing required arguments. Must call: api_id, route_key.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2RouteState<_, _>) : aws.Apigatewayv2Route.Apigatewayv2Route =
            Unchecked.defaultof<aws.Apigatewayv2Route.Apigatewayv2Route>
