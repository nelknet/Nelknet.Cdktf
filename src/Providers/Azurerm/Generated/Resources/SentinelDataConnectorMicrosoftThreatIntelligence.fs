namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligenceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence">azurerm_sentinel_data_connector_microsoft_threat_intelligence</a>.
    /// </summary>
    type SentinelDataConnectorMicrosoftThreatIntelligenceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorMicrosoftThreatIntelligenceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftThreatIntelligenceState<Missing, Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorMicrosoftThreatIntelligenceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftThreatIntelligenceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence#log_analytics_workspace_id-1">SentinelDataConnectorMicrosoftThreatIntelligence#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<Missing, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatIntelligenceState<Present, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftThreatIntelligenceState<Present, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence#microsoft_emerging_threat_feed_lookback_date-1">SentinelDataConnectorMicrosoftThreatIntelligence#microsoft_emerging_threat_feed_lookback_date</a>.
        /// </summary>
        [<CustomOperation "microsoft_emerging_threat_feed_lookback_date">]
        member _.MicrosoftEmergingThreatFeedLookbackDate(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, Missing, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, Present, 'Name> =
            state.assignments.Add(fun config -> config.MicrosoftEmergingThreatFeedLookbackDate <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence#name-1">SentinelDataConnectorMicrosoftThreatIntelligence#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, Missing>, value: string) : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence#id-1">SentinelDataConnectorMicrosoftThreatIntelligence#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence#tenant_id-1">SentinelDataConnectorMicrosoftThreatIntelligence#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_intelligence#timeouts-1">SentinelDataConnectorMicrosoftThreatIntelligence#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>, value: azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligenceTimeouts) : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorMicrosoftThreatIntelligenceState<'LogAnalyticsWorkspaceId, 'MicrosoftEmergingThreatFeedLookbackDate, 'Name>

        member _.Run(state: SentinelDataConnectorMicrosoftThreatIntelligenceState<Present, Present, Present>) : azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligence =
            let config = azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligenceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligence(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorMicrosoftThreatIntelligence: missing required arguments. Must call: log_analytics_workspace_id, microsoft_emerging_threat_feed_lookback_date, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorMicrosoftThreatIntelligenceState<_, _, _>) : azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligence =
            Unchecked.defaultof<azurerm.SentinelDataConnectorMicrosoftThreatIntelligence.SentinelDataConnectorMicrosoftThreatIntelligence>
