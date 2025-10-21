namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_irm">azurerm_sentinel_data_connector_office_irm</a>.
    /// </summary>
    type SentinelDataConnectorOfficeIrmBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorOfficeIrmState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOfficeIrmState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorOfficeIrmState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOfficeIrmState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_irm#log_analytics_workspace_id-1">SentinelDataConnectorOfficeIrm#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorOfficeIrmState<Missing, 'Name>, value: string) : SentinelDataConnectorOfficeIrmState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOfficeIrmState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_irm#name-1">SentinelDataConnectorOfficeIrm#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_irm#id-1">SentinelDataConnectorOfficeIrm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_irm#tenant_id-1">SentinelDataConnectorOfficeIrm#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_irm#timeouts-1">SentinelDataConnectorOfficeIrm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrmTimeouts) : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorOfficeIrmState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorOfficeIrmState<Present, Present>) : azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrm =
            let config = azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrmConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorOfficeIrm: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorOfficeIrmState<_, _>) : azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrm =
            Unchecked.defaultof<azurerm.SentinelDataConnectorOfficeIrm.SentinelDataConnectorOfficeIrm>
