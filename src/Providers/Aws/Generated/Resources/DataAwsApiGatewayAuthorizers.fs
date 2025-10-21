namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayAuthorizersState<'RestApiId> = { assignments: ResizeArray<aws.DataAwsApiGatewayAuthorizers.DataAwsApiGatewayAuthorizersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizers">aws_api_gateway_authorizers</a>.
    /// </summary>
    type DataAwsApiGatewayAuthorizersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayAuthorizersState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayAuthorizersState<Missing>)

        member _.Zero(()) : DataAwsApiGatewayAuthorizersState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayAuthorizersState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizers#rest_api_id-1">DataAwsApiGatewayAuthorizers#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: DataAwsApiGatewayAuthorizersState<Missing>, value: string) : DataAwsApiGatewayAuthorizersState<Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayAuthorizersState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_authorizers#id-1">DataAwsApiGatewayAuthorizers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayAuthorizersState<'RestApiId>, value: string) : DataAwsApiGatewayAuthorizersState<'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewayAuthorizersState<'RestApiId>

        member _.Run(state: DataAwsApiGatewayAuthorizersState<Present>) : aws.DataAwsApiGatewayAuthorizers.DataAwsApiGatewayAuthorizers =
            let config = aws.DataAwsApiGatewayAuthorizers.DataAwsApiGatewayAuthorizersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayAuthorizers.DataAwsApiGatewayAuthorizers(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayAuthorizers: missing required arguments. Must call: rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayAuthorizersState<_>) : aws.DataAwsApiGatewayAuthorizers.DataAwsApiGatewayAuthorizers =
            Unchecked.defaultof<aws.DataAwsApiGatewayAuthorizers.DataAwsApiGatewayAuthorizers>
