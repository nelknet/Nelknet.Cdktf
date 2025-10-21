namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365">azurerm_sentinel_data_connector_office_365</a>.
    /// </summary>
    type SentinelDataConnectorOffice365Builder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorOffice365State<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOffice365State<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorOffice365State<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOffice365State<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#log_analytics_workspace_id-1">SentinelDataConnectorOffice365#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorOffice365State<Missing, 'Name>, value: string) : SentinelDataConnectorOffice365State<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOffice365State<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#name-1">SentinelDataConnectorOffice365#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#exchange_enabled-1">SentinelDataConnectorOffice365#exchange_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exchange_enabled">]
        member _.ExchangeEnabled(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.ExchangeEnabled <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#exchange_enabled-1">SentinelDataConnectorOffice365#exchange_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exchange_enabled">]
        member _.ExchangeEnabled(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.ExchangeEnabled <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#id-1">SentinelDataConnectorOffice365#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#sharepoint_enabled-1">SentinelDataConnectorOffice365#sharepoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sharepoint_enabled">]
        member _.SharepointEnabled(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.SharepointEnabled <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#sharepoint_enabled-1">SentinelDataConnectorOffice365#sharepoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sharepoint_enabled">]
        member _.SharepointEnabled(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.SharepointEnabled <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#teams_enabled-1">SentinelDataConnectorOffice365#teams_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "teams_enabled">]
        member _.TeamsEnabled(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TeamsEnabled <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#teams_enabled-1">SentinelDataConnectorOffice365#teams_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "teams_enabled">]
        member _.TeamsEnabled(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TeamsEnabled <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#tenant_id-1">SentinelDataConnectorOffice365#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_365#timeouts-1">SentinelDataConnectorOffice365#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365Timeouts) : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorOffice365State<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorOffice365State<Present, Present>) : azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365 =
            let config = azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365Config()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorOffice365: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorOffice365State<_, _>) : azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365 =
            Unchecked.defaultof<azurerm.SentinelDataConnectorOffice365.SentinelDataConnectorOffice365>
