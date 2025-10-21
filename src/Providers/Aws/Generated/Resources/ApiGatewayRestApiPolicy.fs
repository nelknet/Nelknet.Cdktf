namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayRestApiPolicyState<'Policy, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayRestApiPolicy.ApiGatewayRestApiPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_policy">aws_api_gateway_rest_api_policy</a>.
    /// </summary>
    type ApiGatewayRestApiPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayRestApiPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRestApiPolicyState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayRestApiPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRestApiPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_policy#policy-1">ApiGatewayRestApiPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: ApiGatewayRestApiPolicyState<Missing, 'RestApiId>, value: string) : ApiGatewayRestApiPolicyState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : ApiGatewayRestApiPolicyState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_policy#rest_api_id-1">ApiGatewayRestApiPolicy#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayRestApiPolicyState<'Policy, Missing>, value: string) : ApiGatewayRestApiPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayRestApiPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api_policy#id-1">ApiGatewayRestApiPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayRestApiPolicyState<'Policy, 'RestApiId>, value: string) : ApiGatewayRestApiPolicyState<'Policy, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayRestApiPolicyState<'Policy, 'RestApiId>

        member _.Run(state: ApiGatewayRestApiPolicyState<Present, Present>) : aws.ApiGatewayRestApiPolicy.ApiGatewayRestApiPolicy =
            let config = aws.ApiGatewayRestApiPolicy.ApiGatewayRestApiPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayRestApiPolicy.ApiGatewayRestApiPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayRestApiPolicy: missing required arguments. Must call: policy, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayRestApiPolicyState<_, _>) : aws.ApiGatewayRestApiPolicy.ApiGatewayRestApiPolicy =
            Unchecked.defaultof<aws.ApiGatewayRestApiPolicy.ApiGatewayRestApiPolicy>
