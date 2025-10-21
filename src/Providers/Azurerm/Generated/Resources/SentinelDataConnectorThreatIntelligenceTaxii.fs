namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxiiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii">azurerm_sentinel_data_connector_threat_intelligence_taxii</a>.
    /// </summary>
    type SentinelDataConnectorThreatIntelligenceTaxiiBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorThreatIntelligenceTaxiiState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorThreatIntelligenceTaxiiState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorThreatIntelligenceTaxiiState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorThreatIntelligenceTaxiiState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#api_root_url-1">SentinelDataConnectorThreatIntelligenceTaxii#api_root_url</a>.
        /// </summary>
        [<CustomOperation "api_root_url">]
        member _.ApiRootUrl(state: SentinelDataConnectorThreatIntelligenceTaxiiState<Missing, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<Present, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.ApiRootUrl <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceTaxiiState<Present, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#collection_id-1">SentinelDataConnectorThreatIntelligenceTaxii#collection_id</a>.
        /// </summary>
        [<CustomOperation "collection_id">]
        member _.CollectionId(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, Missing, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, Present, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.CollectionId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, Present, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#display_name-1">SentinelDataConnectorThreatIntelligenceTaxii#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, Missing, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, Present, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, Present, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#log_analytics_workspace_id-1">SentinelDataConnectorThreatIntelligenceTaxii#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, Missing, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#name-1">SentinelDataConnectorThreatIntelligenceTaxii#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#id-1">SentinelDataConnectorThreatIntelligenceTaxii#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#lookback_date-1">SentinelDataConnectorThreatIntelligenceTaxii#lookback_date</a>.
        /// </summary>
        [<CustomOperation "lookback_date">]
        member _.LookbackDate(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.LookbackDate <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#password-1">SentinelDataConnectorThreatIntelligenceTaxii#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#polling_frequency-1">SentinelDataConnectorThreatIntelligenceTaxii#polling_frequency</a>.
        /// </summary>
        [<CustomOperation "polling_frequency">]
        member _.PollingFrequency(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.PollingFrequency <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#tenant_id-1">SentinelDataConnectorThreatIntelligenceTaxii#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#timeouts-1">SentinelDataConnectorThreatIntelligenceTaxii#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxiiTimeouts) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_threat_intelligence_taxii#user_name-1">SentinelDataConnectorThreatIntelligenceTaxii#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : SentinelDataConnectorThreatIntelligenceTaxiiState<'ApiRootUrl, 'CollectionId, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorThreatIntelligenceTaxiiState<Present, Present, Present, Present, Present>) : azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxii =
            let config = azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxiiConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxii(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorThreatIntelligenceTaxii: missing required arguments. Must call: api_root_url, collection_id, display_name, log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorThreatIntelligenceTaxiiState<_, _, _, _, _>) : azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxii =
            Unchecked.defaultof<azurerm.SentinelDataConnectorThreatIntelligenceTaxii.SentinelDataConnectorThreatIntelligenceTaxii>
