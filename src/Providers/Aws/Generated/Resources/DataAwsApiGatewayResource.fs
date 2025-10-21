namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayResourceState<'Path, 'RestApiId> = { assignments: ResizeArray<aws.DataAwsApiGatewayResource.DataAwsApiGatewayResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_resource">aws_api_gateway_resource</a>.
    /// </summary>
    type DataAwsApiGatewayResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayResourceState<Missing, Missing>)

        member _.Zero(()) : DataAwsApiGatewayResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayResourceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_resource#path-1">DataAwsApiGatewayResource#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: DataAwsApiGatewayResourceState<Missing, 'RestApiId>, value: string) : DataAwsApiGatewayResourceState<Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Path <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayResourceState<Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_resource#rest_api_id-1">DataAwsApiGatewayResource#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: DataAwsApiGatewayResourceState<'Path, Missing>, value: string) : DataAwsApiGatewayResourceState<'Path, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayResourceState<'Path, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_resource#id-1">DataAwsApiGatewayResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayResourceState<'Path, 'RestApiId>, value: string) : DataAwsApiGatewayResourceState<'Path, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewayResourceState<'Path, 'RestApiId>

        member _.Run(state: DataAwsApiGatewayResourceState<Present, Present>) : aws.DataAwsApiGatewayResource.DataAwsApiGatewayResource =
            let config = aws.DataAwsApiGatewayResource.DataAwsApiGatewayResourceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayResource.DataAwsApiGatewayResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayResource: missing required arguments. Must call: path, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayResourceState<_, _>) : aws.DataAwsApiGatewayResource.DataAwsApiGatewayResource =
            Unchecked.defaultof<aws.DataAwsApiGatewayResource.DataAwsApiGatewayResource>
