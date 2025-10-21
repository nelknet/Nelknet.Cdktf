namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayModelState<'ContentType, 'Name, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayModel.ApiGatewayModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model">aws_api_gateway_model</a>.
    /// </summary>
    type ApiGatewayModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayModelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayModelState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayModelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayModelState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model#content_type-1">ApiGatewayModel#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: ApiGatewayModelState<Missing, 'Name, 'RestApiId>, value: string) : ApiGatewayModelState<Present, 'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            ({ assignments = state.assignments } : ApiGatewayModelState<Present, 'Name, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model#name-1">ApiGatewayModel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayModelState<'ContentType, Missing, 'RestApiId>, value: string) : ApiGatewayModelState<'ContentType, Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayModelState<'ContentType, Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model#rest_api_id-1">ApiGatewayModel#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayModelState<'ContentType, 'Name, Missing>, value: string) : ApiGatewayModelState<'ContentType, 'Name, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayModelState<'ContentType, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model#description-1">ApiGatewayModel#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayModelState<'ContentType, 'Name, 'RestApiId>, value: string) : ApiGatewayModelState<'ContentType, 'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayModelState<'ContentType, 'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model#id-1">ApiGatewayModel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayModelState<'ContentType, 'Name, 'RestApiId>, value: string) : ApiGatewayModelState<'ContentType, 'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayModelState<'ContentType, 'Name, 'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_model#schema-1">ApiGatewayModel#schema</a>.
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: ApiGatewayModelState<'ContentType, 'Name, 'RestApiId>, value: string) : ApiGatewayModelState<'ContentType, 'Name, 'RestApiId> =
            state.assignments.Add(fun config -> config.Schema <- value)
            state : ApiGatewayModelState<'ContentType, 'Name, 'RestApiId>

        member _.Run(state: ApiGatewayModelState<Present, Present, Present>) : aws.ApiGatewayModel.ApiGatewayModel =
            let config = aws.ApiGatewayModel.ApiGatewayModelConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayModel.ApiGatewayModel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayModel: missing required arguments. Must call: content_type, name, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayModelState<_, _, _>) : aws.ApiGatewayModel.ApiGatewayModel =
            Unchecked.defaultof<aws.ApiGatewayModel.ApiGatewayModel>
