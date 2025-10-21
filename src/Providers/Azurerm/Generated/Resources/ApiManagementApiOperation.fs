namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> = { assignments: ResizeArray<azurerm.ApiManagementApiOperation.ApiManagementApiOperationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation">azurerm_api_management_api_operation</a>.
    /// </summary>
    type ApiManagementApiOperationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiOperationState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiOperationState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiOperationState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiOperationState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#api_management_name-1">ApiManagementApiOperation#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiOperationState<Missing, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<Present, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<Present, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#api_name-1">ApiManagementApiOperation#api_name</a>.
        /// </summary>
        [<CustomOperation "api_name">]
        member _.ApiName(state: ApiManagementApiOperationState<'ApiManagementName, Missing, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, Present, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.ApiName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<'ApiManagementName, Present, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#display_name-1">ApiManagementApiOperation#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, Missing, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, Present, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, Present, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#method-1">ApiManagementApiOperation#method</a>.
        /// </summary>
        [<CustomOperation "method">]
        member _.Method(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, Missing, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, Present, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.Method <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, Present, 'OperationId, 'ResourceGroupName, 'UrlTemplate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#operation_id-1">ApiManagementApiOperation#operation_id</a>.
        /// </summary>
        [<CustomOperation "operation_id">]
        member _.OperationId(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, Missing, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, Present, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.OperationId <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, Present, 'ResourceGroupName, 'UrlTemplate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#resource_group_name-1">ApiManagementApiOperation#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, Missing, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, Present, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, Present, 'UrlTemplate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#url_template-1">ApiManagementApiOperation#url_template</a>.
        /// </summary>
        [<CustomOperation "url_template">]
        member _.UrlTemplate(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, Missing>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.UrlTemplate <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#description-1">ApiManagementApiOperation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#id-1">ApiManagementApiOperation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: string) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>

        /// <summary>
        /// request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#request-1">ApiManagementApiOperation#request</a>
        /// </summary>
        [<CustomOperation "request">]
        member _.Request(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: azurerm.ApiManagementApiOperation.ApiManagementApiOperationRequest) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.Request <- value)
            state : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>

        /// <summary>
        /// response block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#response-1">ApiManagementApiOperation#response</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementApiOperation.ApiManagementApiOperationResponse[]
        /// </summary>
        [<CustomOperation "response">]
        member _.Response(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.Response <- value)
            state : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>

        /// <summary>
        /// template_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#template_parameter-1">ApiManagementApiOperation#template_parameter</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementApiOperation.ApiManagementApiOperationTemplateParameter[]
        /// </summary>
        [<CustomOperation "template_parameter">]
        member _.TemplateParameter(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.TemplateParameter <- value)
            state : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#timeouts-1">ApiManagementApiOperation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>, value: azurerm.ApiManagementApiOperation.ApiManagementApiOperationTimeouts) : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiOperationState<'ApiManagementName, 'ApiName, 'DisplayName, 'Method, 'OperationId, 'ResourceGroupName, 'UrlTemplate>

        member _.Run(state: ApiManagementApiOperationState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.ApiManagementApiOperation.ApiManagementApiOperation =
            let config = azurerm.ApiManagementApiOperation.ApiManagementApiOperationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiOperation.ApiManagementApiOperation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiOperation: missing required arguments. Must call: api_management_name, api_name, display_name, method, operation_id, resource_group_name, url_template.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiOperationState<_, _, _, _, _, _, _>) : azurerm.ApiManagementApiOperation.ApiManagementApiOperation =
            Unchecked.defaultof<azurerm.ApiManagementApiOperation.ApiManagementApiOperation>
