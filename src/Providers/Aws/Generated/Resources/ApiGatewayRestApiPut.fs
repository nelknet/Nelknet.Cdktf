namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayRestApiPutState<'Body, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayRestApiPut.ApiGatewayRestApiPutConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put">aws_api_gateway_rest_api_put</a>.
    /// </summary>
    type ApiGatewayRestApiPutBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayRestApiPutState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRestApiPutState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayRestApiPutState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRestApiPutState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#body-1">ApiGatewayRestApiPut#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: ApiGatewayRestApiPutState<Missing, 'RestApiId>, value: string) : ApiGatewayRestApiPutState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : ApiGatewayRestApiPutState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#rest_api_id-1">ApiGatewayRestApiPut#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayRestApiPutState<'Body, Missing>, value: string) : ApiGatewayRestApiPutState<'Body, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayRestApiPutState<'Body, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#fail_on_warnings-1">ApiGatewayRestApiPut#fail_on_warnings</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fail_on_warnings">]
        member _.FailOnWarnings(state: ApiGatewayRestApiPutState<'Body, 'RestApiId>, value: bool) : ApiGatewayRestApiPutState<'Body, 'RestApiId> =
            state.assignments.Add(fun config -> config.FailOnWarnings <- value)
            state : ApiGatewayRestApiPutState<'Body, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#fail_on_warnings-1">ApiGatewayRestApiPut#fail_on_warnings</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fail_on_warnings">]
        member _.FailOnWarnings(state: ApiGatewayRestApiPutState<'Body, 'RestApiId>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayRestApiPutState<'Body, 'RestApiId> =
            state.assignments.Add(fun config -> config.FailOnWarnings <- value)
            state : ApiGatewayRestApiPutState<'Body, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#parameters-1">ApiGatewayRestApiPut#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ApiGatewayRestApiPutState<'Body, 'RestApiId>, value: seq<string * string>) : ApiGatewayRestApiPutState<'Body, 'RestApiId> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : ApiGatewayRestApiPutState<'Body, 'RestApiId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#timeouts-1">ApiGatewayRestApiPut#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiGatewayRestApiPutState<'Body, 'RestApiId>, value: aws.ApiGatewayRestApiPut.ApiGatewayRestApiPutTimeouts) : ApiGatewayRestApiPutState<'Body, 'RestApiId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiGatewayRestApiPutState<'Body, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_put#triggers-1">ApiGatewayRestApiPut#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: ApiGatewayRestApiPutState<'Body, 'RestApiId>, value: seq<string * string>) : ApiGatewayRestApiPutState<'Body, 'RestApiId> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : ApiGatewayRestApiPutState<'Body, 'RestApiId>

        member _.Run(state: ApiGatewayRestApiPutState<Present, Present>) : aws.ApiGatewayRestApiPut.ApiGatewayRestApiPut =
            let config = aws.ApiGatewayRestApiPut.ApiGatewayRestApiPutConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayRestApiPut.ApiGatewayRestApiPut(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayRestApiPut: missing required arguments. Must call: body, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayRestApiPutState<_, _>) : aws.ApiGatewayRestApiPut.ApiGatewayRestApiPut =
            Unchecked.defaultof<aws.ApiGatewayRestApiPut.ApiGatewayRestApiPut>
