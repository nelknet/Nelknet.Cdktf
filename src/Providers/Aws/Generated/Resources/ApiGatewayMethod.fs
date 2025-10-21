namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayMethod.ApiGatewayMethodConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method">aws_api_gateway_method</a>.
    /// </summary>
    type ApiGatewayMethodBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayMethodState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayMethodState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayMethodState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayMethodState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#authorization-1">ApiGatewayMethod#authorization</a>.
        /// </summary>
        [<CustomOperation "authorization">]
        member _.Authorization(state: ApiGatewayMethodState<Missing, 'HttpMethod, 'ResourceId, 'RestApiId>, value: string) : ApiGatewayMethodState<Present, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.Authorization <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodState<Present, 'HttpMethod, 'ResourceId, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#http_method-1">ApiGatewayMethod#http_method</a>.
        /// </summary>
        [<CustomOperation "http_method">]
        member _.HttpMethod(state: ApiGatewayMethodState<'Authorization, Missing, 'ResourceId, 'RestApiId>, value: string) : ApiGatewayMethodState<'Authorization, Present, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.HttpMethod <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodState<'Authorization, Present, 'ResourceId, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#resource_id-1">ApiGatewayMethod#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, Missing, 'RestApiId>, value: string) : ApiGatewayMethodState<'Authorization, 'HttpMethod, Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodState<'Authorization, 'HttpMethod, Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#rest_api_id-1">ApiGatewayMethod#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, Missing>, value: string) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#api_key_required-1">ApiGatewayMethod#api_key_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "api_key_required">]
        member _.ApiKeyRequired(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: bool) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.ApiKeyRequired <- value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#api_key_required-1">ApiGatewayMethod#api_key_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "api_key_required">]
        member _.ApiKeyRequired(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.ApiKeyRequired <- value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#authorization_scopes-1">ApiGatewayMethod#authorization_scopes</a>.
        /// </summary>
        [<CustomOperation "authorization_scopes">]
        member _.AuthorizationScopes(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: seq<string>) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.AuthorizationScopes <- (value |> Seq.toArray))
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#authorizer_id-1">ApiGatewayMethod#authorizer_id</a>.
        /// </summary>
        [<CustomOperation "authorizer_id">]
        member _.AuthorizerId(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: string) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.AuthorizerId <- value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#id-1">ApiGatewayMethod#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: string) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#operation_name-1">ApiGatewayMethod#operation_name</a>.
        /// </summary>
        [<CustomOperation "operation_name">]
        member _.OperationName(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: string) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.OperationName <- value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#request_models-1">ApiGatewayMethod#request_models</a>.
        /// </summary>
        [<CustomOperation "request_models">]
        member _.RequestModels(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: seq<string * string>) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.RequestModels <- dict value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#request_parameters-1">ApiGatewayMethod#request_parameters</a>.
        /// </summary>
        [<CustomOperation "request_parameters">]
        member _.RequestParameters(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: seq<string * obj>) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.RequestParameters <- dict value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method#request_validator_id-1">ApiGatewayMethod#request_validator_id</a>.
        /// </summary>
        [<CustomOperation "request_validator_id">]
        member _.RequestValidatorId(state: ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>, value: string) : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId> =
            state.assignments.Add(fun config -> config.RequestValidatorId <- value)
            state : ApiGatewayMethodState<'Authorization, 'HttpMethod, 'ResourceId, 'RestApiId>

        member _.Run(state: ApiGatewayMethodState<Present, Present, Present, Present>) : aws.ApiGatewayMethod.ApiGatewayMethod =
            let config = aws.ApiGatewayMethod.ApiGatewayMethodConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayMethod.ApiGatewayMethod(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayMethod: missing required arguments. Must call: authorization, http_method, resource_id, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayMethodState<_, _, _, _>) : aws.ApiGatewayMethod.ApiGatewayMethod =
            Unchecked.defaultof<aws.ApiGatewayMethod.ApiGatewayMethod>
