namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayAuthorizerState<'AuthorizerId, 'RestApiId> = { assignments: ResizeArray<aws.DataAwsApiGatewayAuthorizer.DataAwsApiGatewayAuthorizerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizer">aws_api_gateway_authorizer</a>.
    /// </summary>
    type DataAwsApiGatewayAuthorizerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayAuthorizerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayAuthorizerState<Missing, Missing>)

        member _.Zero(()) : DataAwsApiGatewayAuthorizerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayAuthorizerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizer#authorizer_id-1">DataAwsApiGatewayAuthorizer#authorizer_id</a>.
        /// </summary>
        [<CustomOperation "authorizer_id">]
        member _.AuthorizerId(state: DataAwsApiGatewayAuthorizerState<Missing, 'RestApiId>, value: string) : DataAwsApiGatewayAuthorizerState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.AuthorizerId <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayAuthorizerState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizer#rest_api_id-1">DataAwsApiGatewayAuthorizer#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: DataAwsApiGatewayAuthorizerState<'AuthorizerId, Missing>, value: string) : DataAwsApiGatewayAuthorizerState<'AuthorizerId, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayAuthorizerState<'AuthorizerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizer#id-1">DataAwsApiGatewayAuthorizer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayAuthorizerState<'AuthorizerId, 'RestApiId>, value: string) : DataAwsApiGatewayAuthorizerState<'AuthorizerId, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewayAuthorizerState<'AuthorizerId, 'RestApiId>

        member _.Run(state: DataAwsApiGatewayAuthorizerState<Present, Present>) : aws.DataAwsApiGatewayAuthorizer.DataAwsApiGatewayAuthorizer =
            let config = aws.DataAwsApiGatewayAuthorizer.DataAwsApiGatewayAuthorizerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayAuthorizer.DataAwsApiGatewayAuthorizer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayAuthorizer: missing required arguments. Must call: authorizer_id, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayAuthorizerState<_, _>) : aws.DataAwsApiGatewayAuthorizer.DataAwsApiGatewayAuthorizer =
            Unchecked.defaultof<aws.DataAwsApiGatewayAuthorizer.DataAwsApiGatewayAuthorizer>
