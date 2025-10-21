namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey> = { assignments: ResizeArray<aws.Apigatewayv2IntegrationResponse.Apigatewayv2IntegrationResponseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response">aws_apigatewayv2_integration_response</a>.
    /// </summary>
    type Apigatewayv2IntegrationResponseBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2IntegrationResponseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2IntegrationResponseState<Missing, Missing, Missing>)

        member _.Zero(()) : Apigatewayv2IntegrationResponseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2IntegrationResponseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#api_id-1">Apigatewayv2IntegrationResponse#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2IntegrationResponseState<Missing, 'IntegrationId, 'IntegrationResponseKey>, value: string) : Apigatewayv2IntegrationResponseState<Present, 'IntegrationId, 'IntegrationResponseKey> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2IntegrationResponseState<Present, 'IntegrationId, 'IntegrationResponseKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#integration_id-1">Apigatewayv2IntegrationResponse#integration_id</a>.
        /// </summary>
        [<CustomOperation "integration_id">]
        member _.IntegrationId(state: Apigatewayv2IntegrationResponseState<'ApiId, Missing, 'IntegrationResponseKey>, value: string) : Apigatewayv2IntegrationResponseState<'ApiId, Present, 'IntegrationResponseKey> =
            state.assignments.Add(fun config -> config.IntegrationId <- value)
            ({ assignments = state.assignments } : Apigatewayv2IntegrationResponseState<'ApiId, Present, 'IntegrationResponseKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#integration_response_key-1">Apigatewayv2IntegrationResponse#integration_response_key</a>.
        /// </summary>
        [<CustomOperation "integration_response_key">]
        member _.IntegrationResponseKey(state: Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, Missing>, value: string) : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, Present> =
            state.assignments.Add(fun config -> config.IntegrationResponseKey <- value)
            ({ assignments = state.assignments } : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#content_handling_strategy-1">Apigatewayv2IntegrationResponse#content_handling_strategy</a>.
        /// </summary>
        [<CustomOperation "content_handling_strategy">]
        member _.ContentHandlingStrategy(state: Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>, value: string) : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey> =
            state.assignments.Add(fun config -> config.ContentHandlingStrategy <- value)
            state : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#id-1">Apigatewayv2IntegrationResponse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>, value: string) : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#response_templates-1">Apigatewayv2IntegrationResponse#response_templates</a>.
        /// </summary>
        [<CustomOperation "response_templates">]
        member _.ResponseTemplates(state: Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>, value: seq<string * string>) : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey> =
            state.assignments.Add(fun config -> config.ResponseTemplates <- dict value)
            state : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration_response#template_selection_expression-1">Apigatewayv2IntegrationResponse#template_selection_expression</a>.
        /// </summary>
        [<CustomOperation "template_selection_expression">]
        member _.TemplateSelectionExpression(state: Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>, value: string) : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey> =
            state.assignments.Add(fun config -> config.TemplateSelectionExpression <- value)
            state : Apigatewayv2IntegrationResponseState<'ApiId, 'IntegrationId, 'IntegrationResponseKey>

        member _.Run(state: Apigatewayv2IntegrationResponseState<Present, Present, Present>) : aws.Apigatewayv2IntegrationResponse.Apigatewayv2IntegrationResponse =
            let config = aws.Apigatewayv2IntegrationResponse.Apigatewayv2IntegrationResponseConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2IntegrationResponse.Apigatewayv2IntegrationResponse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2IntegrationResponse: missing required arguments. Must call: api_id, integration_id, integration_response_key.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2IntegrationResponseState<_, _, _>) : aws.Apigatewayv2IntegrationResponse.Apigatewayv2IntegrationResponse =
            Unchecked.defaultof<aws.Apigatewayv2IntegrationResponse.Apigatewayv2IntegrationResponse>
