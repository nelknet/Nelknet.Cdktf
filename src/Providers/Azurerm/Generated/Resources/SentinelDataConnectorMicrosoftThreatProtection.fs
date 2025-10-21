namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection">azurerm_sentinel_data_connector_microsoft_threat_protection</a>.
    /// </summary>
    type SentinelDataConnectorMicrosoftThreatProtectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorMicrosoftThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftThreatProtectionState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorMicrosoftThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftThreatProtectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#log_analytics_workspace_id-1">SentinelDataConnectorMicrosoftThreatProtection#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorMicrosoftThreatProtectionState<Missing, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatProtectionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftThreatProtectionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#name-1">SentinelDataConnectorMicrosoftThreatProtection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#id-1">SentinelDataConnectorMicrosoftThreatProtection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#tenant_id-1">SentinelDataConnectorMicrosoftThreatProtection#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#timeouts-1">SentinelDataConnectorMicrosoftThreatProtection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtectionTimeouts) : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorMicrosoftThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorMicrosoftThreatProtectionState<Present, Present>) : azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtection =
            let config = azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorMicrosoftThreatProtection: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorMicrosoftThreatProtectionState<_, _>) : azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtection =
            Unchecked.defaultof<azurerm.SentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtection>
