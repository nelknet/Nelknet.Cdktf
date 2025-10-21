namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayApiKeysState = { assignments: ResizeArray<aws.DataAwsApiGatewayApiKeys.DataAwsApiGatewayApiKeysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_keys">aws_api_gateway_api_keys</a>.
    /// </summary>
    type DataAwsApiGatewayApiKeysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayApiKeysState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsApiGatewayApiKeysState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_keys#customer_id-1">DataAwsApiGatewayApiKeys#customer_id</a>.
        /// </summary>
        [<CustomOperation "customer_id">]
        member _.CustomerId(state: DataAwsApiGatewayApiKeysState, value: string) : DataAwsApiGatewayApiKeysState =
            state.assignments.Add(fun config -> config.CustomerId <- value)
            state : DataAwsApiGatewayApiKeysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_keys#include_values-1">DataAwsApiGatewayApiKeys#include_values</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_values">]
        member _.IncludeValues(state: DataAwsApiGatewayApiKeysState, value: bool) : DataAwsApiGatewayApiKeysState =
            state.assignments.Add(fun config -> config.IncludeValues <- value)
            state : DataAwsApiGatewayApiKeysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_keys#include_values-1">DataAwsApiGatewayApiKeys#include_values</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_values">]
        member _.IncludeValues(state: DataAwsApiGatewayApiKeysState, value: HashiCorp.Cdktf.IResolvable) : DataAwsApiGatewayApiKeysState =
            state.assignments.Add(fun config -> config.IncludeValues <- value)
            state : DataAwsApiGatewayApiKeysState

        member _.Run(state: DataAwsApiGatewayApiKeysState) : aws.DataAwsApiGatewayApiKeys.DataAwsApiGatewayApiKeys =
            let config = aws.DataAwsApiGatewayApiKeys.DataAwsApiGatewayApiKeysConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayApiKeys.DataAwsApiGatewayApiKeys(StackContext.get (), logicalId, config)
