namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic">azurerm_api_management_api_diagnostic</a>.
    /// </summary>
    type ApiManagementApiDiagnosticBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiDiagnosticState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiDiagnosticState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiDiagnosticState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiDiagnosticState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#api_management_logger_id-1">ApiManagementApiDiagnostic#api_management_logger_id</a>.
        /// </summary>
        [<CustomOperation "api_management_logger_id">]
        member _.ApiManagementLoggerId(state: ApiManagementApiDiagnosticState<Missing, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<Present, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementLoggerId <- value)
            ({ assignments = state.assignments } : ApiManagementApiDiagnosticState<Present, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#api_management_name-1">ApiManagementApiDiagnostic#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, Missing, 'ApiName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, Present, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, Present, 'ApiName, 'Identifier, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#api_name-1">ApiManagementApiDiagnostic#api_name</a>.
        /// </summary>
        [<CustomOperation "api_name">]
        member _.ApiName(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, Missing, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, Present, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiName <- value)
            ({ assignments = state.assignments } : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, Present, 'Identifier, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#identifier-1">ApiManagementApiDiagnostic#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, Missing, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#resource_group_name-1">ApiManagementApiDiagnostic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, Missing>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#always_log_errors-1">ApiManagementApiDiagnostic#always_log_errors</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_log_errors">]
        member _.AlwaysLogErrors(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: bool) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AlwaysLogErrors <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#always_log_errors-1">ApiManagementApiDiagnostic#always_log_errors</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_log_errors">]
        member _.AlwaysLogErrors(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AlwaysLogErrors <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// backend_request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#backend_request-1">ApiManagementApiDiagnostic#backend_request</a>
        /// </summary>
        [<CustomOperation "backend_request">]
        member _.BackendRequest(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequest) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendRequest <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// backend_response block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#backend_response-1">ApiManagementApiDiagnostic#backend_response</a>
        /// </summary>
        [<CustomOperation "backend_response">]
        member _.BackendResponse(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponse) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendResponse <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// frontend_request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#frontend_request-1">ApiManagementApiDiagnostic#frontend_request</a>
        /// </summary>
        [<CustomOperation "frontend_request">]
        member _.FrontendRequest(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequest) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendRequest <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// frontend_response block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#frontend_response-1">ApiManagementApiDiagnostic#frontend_response</a>
        /// </summary>
        [<CustomOperation "frontend_response">]
        member _.FrontendResponse(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponse) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendResponse <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#http_correlation_protocol-1">ApiManagementApiDiagnostic#http_correlation_protocol</a>.
        /// </summary>
        [<CustomOperation "http_correlation_protocol">]
        member _.HttpCorrelationProtocol(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpCorrelationProtocol <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#id-1">ApiManagementApiDiagnostic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#log_client_ip-1">ApiManagementApiDiagnostic#log_client_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_client_ip">]
        member _.LogClientIp(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: bool) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogClientIp <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#log_client_ip-1">ApiManagementApiDiagnostic#log_client_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_client_ip">]
        member _.LogClientIp(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogClientIp <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#operation_name_format-1">ApiManagementApiDiagnostic#operation_name_format</a>.
        /// </summary>
        [<CustomOperation "operation_name_format">]
        member _.OperationNameFormat(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OperationNameFormat <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#sampling_percentage-1">ApiManagementApiDiagnostic#sampling_percentage</a>.
        /// </summary>
        [<CustomOperation "sampling_percentage">]
        member _.SamplingPercentage(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: double) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SamplingPercentage <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#timeouts-1">ApiManagementApiDiagnostic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticTimeouts) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#verbosity-1">ApiManagementApiDiagnostic#verbosity</a>.
        /// </summary>
        [<CustomOperation "verbosity">]
        member _.Verbosity(state: ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Verbosity <- value)
            state : ApiManagementApiDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'ApiName, 'Identifier, 'ResourceGroupName>

        member _.Run(state: ApiManagementApiDiagnosticState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnostic =
            let config = azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnostic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiDiagnostic: missing required arguments. Must call: api_management_logger_id, api_management_name, api_name, identifier, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiDiagnosticState<_, _, _, _, _>) : azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnostic =
            Unchecked.defaultof<azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnostic>
