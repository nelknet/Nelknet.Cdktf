namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic">azurerm_api_management_diagnostic</a>.
    /// </summary>
    type ApiManagementDiagnosticBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementDiagnosticState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementDiagnosticState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementDiagnosticState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementDiagnosticState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#api_management_logger_id-1">ApiManagementDiagnostic#api_management_logger_id</a>.
        /// </summary>
        [<CustomOperation "api_management_logger_id">]
        member _.ApiManagementLoggerId(state: ApiManagementDiagnosticState<Missing, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<Present, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementLoggerId <- value)
            ({ assignments = state.assignments } : ApiManagementDiagnosticState<Present, 'ApiManagementName, 'Identifier, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#api_management_name-1">ApiManagementDiagnostic#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, Missing, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, Present, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementDiagnosticState<'ApiManagementLoggerId, Present, 'Identifier, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#identifier-1">ApiManagementDiagnostic#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#resource_group_name-1">ApiManagementDiagnostic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, Missing>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#always_log_errors-1">ApiManagementDiagnostic#always_log_errors</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_log_errors">]
        member _.AlwaysLogErrors(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: bool) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AlwaysLogErrors <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#always_log_errors-1">ApiManagementDiagnostic#always_log_errors</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_log_errors">]
        member _.AlwaysLogErrors(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AlwaysLogErrors <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// backend_request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#backend_request-1">ApiManagementDiagnostic#backend_request</a>
        /// </summary>
        [<CustomOperation "backend_request">]
        member _.BackendRequest(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendRequest) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendRequest <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// backend_response block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#backend_response-1">ApiManagementDiagnostic#backend_response</a>
        /// </summary>
        [<CustomOperation "backend_response">]
        member _.BackendResponse(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendResponse) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendResponse <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// frontend_request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#frontend_request-1">ApiManagementDiagnostic#frontend_request</a>
        /// </summary>
        [<CustomOperation "frontend_request">]
        member _.FrontendRequest(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendRequest) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendRequest <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// frontend_response block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#frontend_response-1">ApiManagementDiagnostic#frontend_response</a>
        /// </summary>
        [<CustomOperation "frontend_response">]
        member _.FrontendResponse(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendResponse) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendResponse <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#http_correlation_protocol-1">ApiManagementDiagnostic#http_correlation_protocol</a>.
        /// </summary>
        [<CustomOperation "http_correlation_protocol">]
        member _.HttpCorrelationProtocol(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpCorrelationProtocol <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#id-1">ApiManagementDiagnostic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#log_client_ip-1">ApiManagementDiagnostic#log_client_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_client_ip">]
        member _.LogClientIp(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: bool) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogClientIp <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#log_client_ip-1">ApiManagementDiagnostic#log_client_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_client_ip">]
        member _.LogClientIp(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogClientIp <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#operation_name_format-1">ApiManagementDiagnostic#operation_name_format</a>.
        /// </summary>
        [<CustomOperation "operation_name_format">]
        member _.OperationNameFormat(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OperationNameFormat <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#sampling_percentage-1">ApiManagementDiagnostic#sampling_percentage</a>.
        /// </summary>
        [<CustomOperation "sampling_percentage">]
        member _.SamplingPercentage(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: double) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SamplingPercentage <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#timeouts-1">ApiManagementDiagnostic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticTimeouts) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#verbosity-1">ApiManagementDiagnostic#verbosity</a>.
        /// </summary>
        [<CustomOperation "verbosity">]
        member _.Verbosity(state: ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>, value: string) : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Verbosity <- value)
            state : ApiManagementDiagnosticState<'ApiManagementLoggerId, 'ApiManagementName, 'Identifier, 'ResourceGroupName>

        member _.Run(state: ApiManagementDiagnosticState<Present, Present, Present, Present>) : azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic =
            let config = azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementDiagnostic: missing required arguments. Must call: api_management_logger_id, api_management_name, identifier, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementDiagnosticState<_, _, _, _>) : azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic =
            Unchecked.defaultof<azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic>
