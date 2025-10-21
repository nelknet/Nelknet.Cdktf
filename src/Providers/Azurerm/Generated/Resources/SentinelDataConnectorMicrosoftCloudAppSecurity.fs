namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security">azurerm_sentinel_data_connector_microsoft_cloud_app_security</a>.
    /// </summary>
    type SentinelDataConnectorMicrosoftCloudAppSecurityBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorMicrosoftCloudAppSecurityState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftCloudAppSecurityState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorMicrosoftCloudAppSecurityState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorMicrosoftCloudAppSecurityState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#log_analytics_workspace_id-1">SentinelDataConnectorMicrosoftCloudAppSecurity#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<Missing, 'Name>, value: string) : SentinelDataConnectorMicrosoftCloudAppSecurityState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftCloudAppSecurityState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#name-1">SentinelDataConnectorMicrosoftCloudAppSecurity#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#alerts_enabled-1">SentinelDataConnectorMicrosoftCloudAppSecurity#alerts_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "alerts_enabled">]
        member _.AlertsEnabled(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.AlertsEnabled <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#alerts_enabled-1">SentinelDataConnectorMicrosoftCloudAppSecurity#alerts_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "alerts_enabled">]
        member _.AlertsEnabled(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.AlertsEnabled <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#discovery_logs_enabled-1">SentinelDataConnectorMicrosoftCloudAppSecurity#discovery_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "discovery_logs_enabled">]
        member _.DiscoveryLogsEnabled(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.DiscoveryLogsEnabled <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#discovery_logs_enabled-1">SentinelDataConnectorMicrosoftCloudAppSecurity#discovery_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "discovery_logs_enabled">]
        member _.DiscoveryLogsEnabled(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.DiscoveryLogsEnabled <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#id-1">SentinelDataConnectorMicrosoftCloudAppSecurity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#tenant_id-1">SentinelDataConnectorMicrosoftCloudAppSecurity#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#timeouts-1">SentinelDataConnectorMicrosoftCloudAppSecurity#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurityTimeouts) : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorMicrosoftCloudAppSecurityState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorMicrosoftCloudAppSecurityState<Present, Present>) : azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurity =
            let config = azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurityConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorMicrosoftCloudAppSecurity: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorMicrosoftCloudAppSecurityState<_, _>) : azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurity =
            Unchecked.defaultof<azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurity>
