namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_power_bi">azurerm_sentinel_data_connector_office_power_bi</a>.
    /// </summary>
    type SentinelDataConnectorOfficePowerBiBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorOfficePowerBiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOfficePowerBiState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorOfficePowerBiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOfficePowerBiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_power_bi#log_analytics_workspace_id-1">SentinelDataConnectorOfficePowerBi#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorOfficePowerBiState<Missing, 'Name>, value: string) : SentinelDataConnectorOfficePowerBiState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOfficePowerBiState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_power_bi#name-1">SentinelDataConnectorOfficePowerBi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_power_bi#id-1">SentinelDataConnectorOfficePowerBi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_power_bi#tenant_id-1">SentinelDataConnectorOfficePowerBi#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_power_bi#timeouts-1">SentinelDataConnectorOfficePowerBi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBiTimeouts) : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorOfficePowerBiState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorOfficePowerBiState<Present, Present>) : azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBi =
            let config = azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBiConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorOfficePowerBi: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorOfficePowerBiState<_, _>) : azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBi =
            Unchecked.defaultof<azurerm.SentinelDataConnectorOfficePowerBi.SentinelDataConnectorOfficePowerBi>
