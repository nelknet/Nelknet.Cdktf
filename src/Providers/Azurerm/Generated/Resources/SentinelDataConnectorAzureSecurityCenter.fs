namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_security_center">azurerm_sentinel_data_connector_azure_security_center</a>.
    /// </summary>
    type SentinelDataConnectorAzureSecurityCenterBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorAzureSecurityCenterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAzureSecurityCenterState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorAzureSecurityCenterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAzureSecurityCenterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_security_center#log_analytics_workspace_id-1">SentinelDataConnectorAzureSecurityCenter#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorAzureSecurityCenterState<Missing, 'Name>, value: string) : SentinelDataConnectorAzureSecurityCenterState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAzureSecurityCenterState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_security_center#name-1">SentinelDataConnectorAzureSecurityCenter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_security_center#id-1">SentinelDataConnectorAzureSecurityCenter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_security_center#subscription_id-1">SentinelDataConnectorAzureSecurityCenter#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_security_center#timeouts-1">SentinelDataConnectorAzureSecurityCenter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenterTimeouts) : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorAzureSecurityCenterState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorAzureSecurityCenterState<Present, Present>) : azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenter =
            let config = azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenterConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorAzureSecurityCenter: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorAzureSecurityCenterState<_, _>) : azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenter =
            Unchecked.defaultof<azurerm.SentinelDataConnectorAzureSecurityCenter.SentinelDataConnectorAzureSecurityCenter>
