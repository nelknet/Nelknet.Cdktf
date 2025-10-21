namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligenceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence">azurerm_sentinel_data_connector_threat_intelligence</a>.
    /// </summary>
    type SentinelDataConnectorThreatIntelligenceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorThreatIntelligenceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorThreatIntelligenceState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorThreatIntelligenceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorThreatIntelligenceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence#log_analytics_workspace_id-1">SentinelDataConnectorThreatIntelligence#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorThreatIntelligenceState<Missing, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence#name-1">SentinelDataConnectorThreatIntelligence#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence#id-1">SentinelDataConnectorThreatIntelligence#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence#lookback_date-1">SentinelDataConnectorThreatIntelligence#lookback_date</a>.
        /// </summary>
        [<CustomOperation "lookback_date">]
        member _.LookbackDate(state: SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.LookbackDate <- value)
            state : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence#tenant_id-1">SentinelDataConnectorThreatIntelligence#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence#timeouts-1">SentinelDataConnectorThreatIntelligence#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligenceTimeouts) : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorThreatIntelligenceState<Present, Present>) : azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligence =
            let config = azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligenceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligence(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorThreatIntelligence: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorThreatIntelligenceState<_, _>) : azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligence =
            Unchecked.defaultof<azurerm.SentinelDataConnectorThreatIntelligence.SentinelDataConnectorThreatIntelligence>
