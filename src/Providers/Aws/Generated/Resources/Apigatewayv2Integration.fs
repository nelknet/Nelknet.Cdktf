namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> = { assignments: ResizeArray<aws.Apigatewayv2Integration.Apigatewayv2IntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration">aws_apigatewayv2_integration</a>.
    /// </summary>
    type Apigatewayv2IntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2IntegrationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2IntegrationState<Missing, Missing>)

        member _.Zero(()) : Apigatewayv2IntegrationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2IntegrationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#api_id-1">Apigatewayv2Integration#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2IntegrationState<Missing, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<Present, 'IntegrationType> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2IntegrationState<Present, 'IntegrationType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#integration_type-1">Apigatewayv2Integration#integration_type</a>.
        /// </summary>
        [<CustomOperation "integration_type">]
        member _.IntegrationType(state: Apigatewayv2IntegrationState<'ApiId, Missing>, value: string) : Apigatewayv2IntegrationState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.IntegrationType <- value)
            ({ assignments = state.assignments } : Apigatewayv2IntegrationState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#connection_id-1">Apigatewayv2Integration#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#connection_type-1">Apigatewayv2Integration#connection_type</a>.
        /// </summary>
        [<CustomOperation "connection_type">]
        member _.ConnectionType(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.ConnectionType <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#content_handling_strategy-1">Apigatewayv2Integration#content_handling_strategy</a>.
        /// </summary>
        [<CustomOperation "content_handling_strategy">]
        member _.ContentHandlingStrategy(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.ContentHandlingStrategy <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#credentials_arn-1">Apigatewayv2Integration#credentials_arn</a>.
        /// </summary>
        [<CustomOperation "credentials_arn">]
        member _.CredentialsArn(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.CredentialsArn <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#description-1">Apigatewayv2Integration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#id-1">Apigatewayv2Integration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#integration_method-1">Apigatewayv2Integration#integration_method</a>.
        /// </summary>
        [<CustomOperation "integration_method">]
        member _.IntegrationMethod(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.IntegrationMethod <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#integration_subtype-1">Apigatewayv2Integration#integration_subtype</a>.
        /// </summary>
        [<CustomOperation "integration_subtype">]
        member _.IntegrationSubtype(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.IntegrationSubtype <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#integration_uri-1">Apigatewayv2Integration#integration_uri</a>.
        /// </summary>
        [<CustomOperation "integration_uri">]
        member _.IntegrationUri(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.IntegrationUri <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#passthrough_behavior-1">Apigatewayv2Integration#passthrough_behavior</a>.
        /// </summary>
        [<CustomOperation "passthrough_behavior">]
        member _.PassthroughBehavior(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.PassthroughBehavior <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#payload_format_version-1">Apigatewayv2Integration#payload_format_version</a>.
        /// </summary>
        [<CustomOperation "payload_format_version">]
        member _.PayloadFormatVersion(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.PayloadFormatVersion <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#request_parameters-1">Apigatewayv2Integration#request_parameters</a>.
        /// </summary>
        [<CustomOperation "request_parameters">]
        member _.RequestParameters(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: seq<string * string>) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.RequestParameters <- dict value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#request_templates-1">Apigatewayv2Integration#request_templates</a>.
        /// </summary>
        [<CustomOperation "request_templates">]
        member _.RequestTemplates(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: seq<string * string>) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.RequestTemplates <- dict value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// response_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#response_parameters-1">Apigatewayv2Integration#response_parameters</a> Accepts: aws.IResolvable | aws.Apigatewayv2Integration.Apigatewayv2IntegrationResponseParameters[]
        /// </summary>
        [<CustomOperation "response_parameters">]
        member _.ResponseParameters(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.ResponseParameters <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#template_selection_expression-1">Apigatewayv2Integration#template_selection_expression</a>.
        /// </summary>
        [<CustomOperation "template_selection_expression">]
        member _.TemplateSelectionExpression(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: string) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.TemplateSelectionExpression <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#timeout_milliseconds-1">Apigatewayv2Integration#timeout_milliseconds</a>.
        /// </summary>
        [<CustomOperation "timeout_milliseconds">]
        member _.TimeoutMilliseconds(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: double) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.TimeoutMilliseconds <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        /// <summary>
        /// tls_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#tls_config-1">Apigatewayv2Integration#tls_config</a>
        /// </summary>
        [<CustomOperation "tls_config">]
        member _.TlsConfig(state: Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>, value: aws.Apigatewayv2Integration.Apigatewayv2IntegrationTlsConfig) : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType> =
            state.assignments.Add(fun config -> config.TlsConfig <- value)
            state : Apigatewayv2IntegrationState<'ApiId, 'IntegrationType>

        member _.Run(state: Apigatewayv2IntegrationState<Present, Present>) : aws.Apigatewayv2Integration.Apigatewayv2Integration =
            let config = aws.Apigatewayv2Integration.Apigatewayv2IntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Integration.Apigatewayv2Integration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Integration: missing required arguments. Must call: api_id, integration_type.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2IntegrationState<_, _>) : aws.Apigatewayv2Integration.Apigatewayv2Integration =
            Unchecked.defaultof<aws.Apigatewayv2Integration.Apigatewayv2Integration>
