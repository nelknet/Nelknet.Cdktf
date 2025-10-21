namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_dynamics_365">azurerm_sentinel_data_connector_dynamics_365</a>.
    /// </summary>
    type SentinelDataConnectorDynamics365Builder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorDynamics365State<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorDynamics365State<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorDynamics365State<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorDynamics365State<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_dynamics_365#log_analytics_workspace_id-1">SentinelDataConnectorDynamics365#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorDynamics365State<Missing, 'Name>, value: string) : SentinelDataConnectorDynamics365State<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorDynamics365State<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_dynamics_365#name-1">SentinelDataConnectorDynamics365#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_dynamics_365#id-1">SentinelDataConnectorDynamics365#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_dynamics_365#tenant_id-1">SentinelDataConnectorDynamics365#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_dynamics_365#timeouts-1">SentinelDataConnectorDynamics365#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365Timeouts) : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorDynamics365State<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorDynamics365State<Present, Present>) : azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365 =
            let config = azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365Config()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorDynamics365: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorDynamics365State<_, _>) : azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365 =
            Unchecked.defaultof<azurerm.SentinelDataConnectorDynamics365.SentinelDataConnectorDynamics365>
