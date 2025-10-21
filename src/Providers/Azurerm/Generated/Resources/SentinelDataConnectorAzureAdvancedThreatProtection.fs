namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_advanced_threat_protection">azurerm_sentinel_data_connector_azure_advanced_threat_protection</a>.
    /// </summary>
    type SentinelDataConnectorAzureAdvancedThreatProtectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorAzureAdvancedThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAzureAdvancedThreatProtectionState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorAzureAdvancedThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAzureAdvancedThreatProtectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_advanced_threat_protection#log_analytics_workspace_id-1">SentinelDataConnectorAzureAdvancedThreatProtection#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorAzureAdvancedThreatProtectionState<Missing, 'Name>, value: string) : SentinelDataConnectorAzureAdvancedThreatProtectionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAzureAdvancedThreatProtectionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_advanced_threat_protection#name-1">SentinelDataConnectorAzureAdvancedThreatProtection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_advanced_threat_protection#id-1">SentinelDataConnectorAzureAdvancedThreatProtection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_advanced_threat_protection#tenant_id-1">SentinelDataConnectorAzureAdvancedThreatProtection#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_advanced_threat_protection#timeouts-1">SentinelDataConnectorAzureAdvancedThreatProtection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtectionTimeouts) : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorAzureAdvancedThreatProtectionState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorAzureAdvancedThreatProtectionState<Present, Present>) : azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtection =
            let config = azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorAzureAdvancedThreatProtection: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorAzureAdvancedThreatProtectionState<_, _>) : azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtection =
            Unchecked.defaultof<azurerm.SentinelDataConnectorAzureAdvancedThreatProtection.SentinelDataConnectorAzureAdvancedThreatProtection>
