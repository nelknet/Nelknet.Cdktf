namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection">azurerm_sentinel_data_connector_microsoft_defender_advanced_threat_protection</a>.
    /// </summary>
    type SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#log_analytics_workspace_id-1">SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Missing, 'Name>, value: string) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#name-1">SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#id-1">SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#tenant_id-1">SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#timeouts-1">SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionTimeouts) : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<Present, Present>) : azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection =
            let config = azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionState<_, _>) : azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection =
            Unchecked.defaultof<azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection>
