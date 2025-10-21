namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365ProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365_project">azurerm_sentinel_data_connector_office_365_project</a>.
    /// </summary>
    type SentinelDataConnectorOffice365ProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorOffice365ProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOffice365ProjectState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorOffice365ProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOffice365ProjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365_project#log_analytics_workspace_id-1">SentinelDataConnectorOffice365Project#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorOffice365ProjectState<Missing, 'Name>, value: string) : SentinelDataConnectorOffice365ProjectState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOffice365ProjectState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365_project#name-1">SentinelDataConnectorOffice365Project#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365_project#id-1">SentinelDataConnectorOffice365Project#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365_project#tenant_id-1">SentinelDataConnectorOffice365Project#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365_project#timeouts-1">SentinelDataConnectorOffice365Project#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365ProjectTimeouts) : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorOffice365ProjectState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorOffice365ProjectState<Present, Present>) : azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365Project =
            let config = azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365ProjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365Project(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorOffice365Project: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorOffice365ProjectState<_, _>) : azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365Project =
            Unchecked.defaultof<azurerm.SentinelDataConnectorOffice365Project.SentinelDataConnectorOffice365Project>
