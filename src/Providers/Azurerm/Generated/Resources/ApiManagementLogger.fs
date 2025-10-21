namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementLogger.ApiManagementLoggerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger">azurerm_api_management_logger</a>.
    /// </summary>
    type ApiManagementLoggerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementLoggerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementLoggerState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementLoggerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementLoggerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#api_management_name-1">ApiManagementLogger#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementLoggerState<Missing, 'Name, 'ResourceGroupName>, value: string) : ApiManagementLoggerState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementLoggerState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#name-1">ApiManagementLogger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementLoggerState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementLoggerState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementLoggerState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#resource_group_name-1">ApiManagementLogger#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementLoggerState<'ApiManagementName, 'Name, Missing>, value: string) : ApiManagementLoggerState<'ApiManagementName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementLoggerState<'ApiManagementName, 'Name, Present>)

        /// <summary>
        /// application_insights block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#application_insights-1">ApiManagementLogger#application_insights</a>
        /// </summary>
        [<CustomOperation "application_insights">]
        member _.ApplicationInsights(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementLogger.ApiManagementLoggerApplicationInsights) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationInsights <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#buffered-1">ApiManagementLogger#buffered</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "buffered">]
        member _.Buffered(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: bool) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Buffered <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#buffered-1">ApiManagementLogger#buffered</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "buffered">]
        member _.Buffered(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Buffered <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#description-1">ApiManagementLogger#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// eventhub block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#eventhub-1">ApiManagementLogger#eventhub</a>
        /// </summary>
        [<CustomOperation "eventhub">]
        member _.Eventhub(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementLogger.ApiManagementLoggerEventhub) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Eventhub <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#id-1">ApiManagementLogger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#resource_id-1">ApiManagementLogger#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#timeouts-1">ApiManagementLogger#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementLogger.ApiManagementLoggerTimeouts) : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementLoggerState<'ApiManagementName, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementLoggerState<Present, Present, Present>) : azurerm.ApiManagementLogger.ApiManagementLogger =
            let config = azurerm.ApiManagementLogger.ApiManagementLoggerConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementLogger.ApiManagementLogger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementLogger: missing required arguments. Must call: api_management_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementLoggerState<_, _, _>) : azurerm.ApiManagementLogger.ApiManagementLogger =
            Unchecked.defaultof<azurerm.ApiManagementLogger.ApiManagementLogger>
