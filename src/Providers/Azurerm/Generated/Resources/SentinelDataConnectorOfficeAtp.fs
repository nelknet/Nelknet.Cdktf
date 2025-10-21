namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_atp">azurerm_sentinel_data_connector_office_atp</a>.
    /// </summary>
    type SentinelDataConnectorOfficeAtpBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorOfficeAtpState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOfficeAtpState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorOfficeAtpState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorOfficeAtpState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_atp#log_analytics_workspace_id-1">SentinelDataConnectorOfficeAtp#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorOfficeAtpState<Missing, 'Name>, value: string) : SentinelDataConnectorOfficeAtpState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOfficeAtpState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_atp#name-1">SentinelDataConnectorOfficeAtp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_atp#id-1">SentinelDataConnectorOfficeAtp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_atp#tenant_id-1">SentinelDataConnectorOfficeAtp#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_office_atp#timeouts-1">SentinelDataConnectorOfficeAtp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtpTimeouts) : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorOfficeAtpState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorOfficeAtpState<Present, Present>) : azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtp =
            let config = azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtpConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorOfficeAtp: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorOfficeAtpState<_, _>) : azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtp =
            Unchecked.defaultof<azurerm.SentinelDataConnectorOfficeAtp.SentinelDataConnectorOfficeAtp>
