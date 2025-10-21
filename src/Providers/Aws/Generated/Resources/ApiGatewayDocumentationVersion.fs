namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayDocumentationVersionState<'RestApiId, 'Version> = { assignments: ResizeArray<aws.ApiGatewayDocumentationVersion.ApiGatewayDocumentationVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_version">aws_api_gateway_documentation_version</a>.
    /// </summary>
    type ApiGatewayDocumentationVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayDocumentationVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDocumentationVersionState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayDocumentationVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDocumentationVersionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_version#rest_api_id-1">ApiGatewayDocumentationVersion#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayDocumentationVersionState<Missing, 'Version>, value: string) : ApiGatewayDocumentationVersionState<Present, 'Version> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayDocumentationVersionState<Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_version#version-1">ApiGatewayDocumentationVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ApiGatewayDocumentationVersionState<'RestApiId, Missing>, value: string) : ApiGatewayDocumentationVersionState<'RestApiId, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ApiGatewayDocumentationVersionState<'RestApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_version#description-1">ApiGatewayDocumentationVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayDocumentationVersionState<'RestApiId, 'Version>, value: string) : ApiGatewayDocumentationVersionState<'RestApiId, 'Version> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayDocumentationVersionState<'RestApiId, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_documentation_version#id-1">ApiGatewayDocumentationVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayDocumentationVersionState<'RestApiId, 'Version>, value: string) : ApiGatewayDocumentationVersionState<'RestApiId, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayDocumentationVersionState<'RestApiId, 'Version>

        member _.Run(state: ApiGatewayDocumentationVersionState<Present, Present>) : aws.ApiGatewayDocumentationVersion.ApiGatewayDocumentationVersion =
            let config = aws.ApiGatewayDocumentationVersion.ApiGatewayDocumentationVersionConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayDocumentationVersion.ApiGatewayDocumentationVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayDocumentationVersion: missing required arguments. Must call: rest_api_id, version.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayDocumentationVersionState<_, _>) : aws.ApiGatewayDocumentationVersion.ApiGatewayDocumentationVersion =
            Unchecked.defaultof<aws.ApiGatewayDocumentationVersion.ApiGatewayDocumentationVersion>
