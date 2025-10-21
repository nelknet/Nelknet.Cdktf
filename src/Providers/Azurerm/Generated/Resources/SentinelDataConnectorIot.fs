namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorIot.SentinelDataConnectorIotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_iot">azurerm_sentinel_data_connector_iot</a>.
    /// </summary>
    type SentinelDataConnectorIotBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorIotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorIotState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorIotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorIotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_iot#log_analytics_workspace_id-1">SentinelDataConnectorIot#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorIotState<Missing, 'Name>, value: string) : SentinelDataConnectorIotState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorIotState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_iot#name-1">SentinelDataConnectorIot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_iot#id-1">SentinelDataConnectorIot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_iot#subscription_id-1">SentinelDataConnectorIot#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_iot#timeouts-1">SentinelDataConnectorIot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorIot.SentinelDataConnectorIotTimeouts) : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorIotState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorIotState<Present, Present>) : azurerm.SentinelDataConnectorIot.SentinelDataConnectorIot =
            let config = azurerm.SentinelDataConnectorIot.SentinelDataConnectorIotConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorIot.SentinelDataConnectorIot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorIot: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorIotState<_, _>) : azurerm.SentinelDataConnectorIot.SentinelDataConnectorIot =
            Unchecked.defaultof<azurerm.SentinelDataConnectorIot.SentinelDataConnectorIot>
