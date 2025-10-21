namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayResourceState<'ParentId, 'PathPart, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayResource.ApiGatewayResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_resource">aws_api_gateway_resource</a>.
    /// </summary>
    type ApiGatewayResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayResourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayResourceState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayResourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayResourceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_resource#parent_id-1">ApiGatewayResource#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: ApiGatewayResourceState<Missing, 'PathPart, 'RestApiId>, value: string) : ApiGatewayResourceState<Present, 'PathPart, 'RestApiId> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : ApiGatewayResourceState<Present, 'PathPart, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_resource#path_part-1">ApiGatewayResource#path_part</a>.
        /// </summary>
        [<CustomOperation "path_part">]
        member _.PathPart(state: ApiGatewayResourceState<'ParentId, Missing, 'RestApiId>, value: string) : ApiGatewayResourceState<'ParentId, Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.PathPart <- value)
            ({ assignments = state.assignments } : ApiGatewayResourceState<'ParentId, Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_resource#rest_api_id-1">ApiGatewayResource#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayResourceState<'ParentId, 'PathPart, Missing>, value: string) : ApiGatewayResourceState<'ParentId, 'PathPart, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayResourceState<'ParentId, 'PathPart, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_resource#id-1">ApiGatewayResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayResourceState<'ParentId, 'PathPart, 'RestApiId>, value: string) : ApiGatewayResourceState<'ParentId, 'PathPart, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayResourceState<'ParentId, 'PathPart, 'RestApiId>

        member _.Run(state: ApiGatewayResourceState<Present, Present, Present>) : aws.ApiGatewayResource.ApiGatewayResource =
            let config = aws.ApiGatewayResource.ApiGatewayResourceConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayResource.ApiGatewayResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayResource: missing required arguments. Must call: parent_id, path_part, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayResourceState<_, _, _>) : aws.ApiGatewayResource.ApiGatewayResource =
            Unchecked.defaultof<aws.ApiGatewayResource.ApiGatewayResource>
