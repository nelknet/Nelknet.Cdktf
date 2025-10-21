namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayRequestValidatorState<'Name, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayRequestValidator.ApiGatewayRequestValidatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator">aws_api_gateway_request_validator</a>.
    /// </summary>
    type ApiGatewayRequestValidatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayRequestValidatorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRequestValidatorState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayRequestValidatorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRequestValidatorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#name-1">ApiGatewayRequestValidator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayRequestValidatorState<Missing, 'RestApiId>, value: string) : ApiGatewayRequestValidatorState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayRequestValidatorState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#rest_api_id-1">ApiGatewayRequestValidator#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayRequestValidatorState<'Name, Missing>, value: string) : ApiGatewayRequestValidatorState<'Name, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayRequestValidatorState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#id-1">ApiGatewayRequestValidator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayRequestValidatorState<'Name, 'RestApiId>, value: string) : ApiGatewayRequestValidatorState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayRequestValidatorState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#validate_request_body-1">ApiGatewayRequestValidator#validate_request_body</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "validate_request_body">]
        member _.ValidateRequestBody(state: ApiGatewayRequestValidatorState<'Name, 'RestApiId>, value: bool) : ApiGatewayRequestValidatorState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.ValidateRequestBody <- value)
            state : ApiGatewayRequestValidatorState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#validate_request_body-1">ApiGatewayRequestValidator#validate_request_body</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "validate_request_body">]
        member _.ValidateRequestBody(state: ApiGatewayRequestValidatorState<'Name, 'RestApiId>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayRequestValidatorState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.ValidateRequestBody <- value)
            state : ApiGatewayRequestValidatorState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#validate_request_parameters-1">ApiGatewayRequestValidator#validate_request_parameters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "validate_request_parameters">]
        member _.ValidateRequestParameters(state: ApiGatewayRequestValidatorState<'Name, 'RestApiId>, value: bool) : ApiGatewayRequestValidatorState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.ValidateRequestParameters <- value)
            state : ApiGatewayRequestValidatorState<'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_request_validator#validate_request_parameters-1">ApiGatewayRequestValidator#validate_request_parameters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "validate_request_parameters">]
        member _.ValidateRequestParameters(state: ApiGatewayRequestValidatorState<'Name, 'RestApiId>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayRequestValidatorState<'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.ValidateRequestParameters <- value)
            state : ApiGatewayRequestValidatorState<'Name, 'RestApiId>

        member _.Run(state: ApiGatewayRequestValidatorState<Present, Present>) : aws.ApiGatewayRequestValidator.ApiGatewayRequestValidator =
            let config = aws.ApiGatewayRequestValidator.ApiGatewayRequestValidatorConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayRequestValidator.ApiGatewayRequestValidator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayRequestValidator: missing required arguments. Must call: name, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayRequestValidatorState<_, _>) : aws.ApiGatewayRequestValidator.ApiGatewayRequestValidator =
            Unchecked.defaultof<aws.ApiGatewayRequestValidator.ApiGatewayRequestValidator>
