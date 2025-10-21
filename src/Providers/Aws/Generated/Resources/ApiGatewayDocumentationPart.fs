namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayDocumentationPartState<'Location, 'Properties, 'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPartConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_part">aws_api_gateway_documentation_part</a>.
    /// </summary>
    type ApiGatewayDocumentationPartBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayDocumentationPartState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDocumentationPartState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayDocumentationPartState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDocumentationPartState<Missing, Missing, Missing>)

        /// <summary>
        /// location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_part#location-1">ApiGatewayDocumentationPart#location</a>
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApiGatewayDocumentationPartState<Missing, 'Properties, 'RestApiId>, value: aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPartLocation) : ApiGatewayDocumentationPartState<Present, 'Properties, 'RestApiId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApiGatewayDocumentationPartState<Present, 'Properties, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_part#properties-1">ApiGatewayDocumentationPart#properties</a>.
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: ApiGatewayDocumentationPartState<'Location, Missing, 'RestApiId>, value: string) : ApiGatewayDocumentationPartState<'Location, Present, 'RestApiId> =
            state.assignments.Add(fun config -> config.Properties <- value)
            ({ assignments = state.assignments } : ApiGatewayDocumentationPartState<'Location, Present, 'RestApiId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_part#rest_api_id-1">ApiGatewayDocumentationPart#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayDocumentationPartState<'Location, 'Properties, Missing>, value: string) : ApiGatewayDocumentationPartState<'Location, 'Properties, Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayDocumentationPartState<'Location, 'Properties, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_part#id-1">ApiGatewayDocumentationPart#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayDocumentationPartState<'Location, 'Properties, 'RestApiId>, value: string) : ApiGatewayDocumentationPartState<'Location, 'Properties, 'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayDocumentationPartState<'Location, 'Properties, 'RestApiId>

        member _.Run(state: ApiGatewayDocumentationPartState<Present, Present, Present>) : aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPart =
            let config = aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPartConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPart(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayDocumentationPart: missing required arguments. Must call: location, properties, rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayDocumentationPartState<_, _, _>) : aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPart =
            Unchecked.defaultof<aws.ApiGatewayDocumentationPart.ApiGatewayDocumentationPart>
