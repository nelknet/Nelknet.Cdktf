namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_active_directory">azurerm_sentinel_data_connector_azure_active_directory</a>.
    /// </summary>
    type SentinelDataConnectorAzureActiveDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorAzureActiveDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAzureActiveDirectoryState<Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorAzureActiveDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAzureActiveDirectoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_active_directory#log_analytics_workspace_id-1">SentinelDataConnectorAzureActiveDirectory#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorAzureActiveDirectoryState<Missing, 'Name>, value: string) : SentinelDataConnectorAzureActiveDirectoryState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAzureActiveDirectoryState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_active_directory#name-1">SentinelDataConnectorAzureActiveDirectory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_active_directory#id-1">SentinelDataConnectorAzureActiveDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_active_directory#tenant_id-1">SentinelDataConnectorAzureActiveDirectory#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_azure_active_directory#timeouts-1">SentinelDataConnectorAzureActiveDirectory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectoryTimeouts) : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorAzureActiveDirectoryState<'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorAzureActiveDirectoryState<Present, Present>) : azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectory =
            let config = azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectoryConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorAzureActiveDirectory: missing required arguments. Must call: log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorAzureActiveDirectoryState<_, _>) : azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectory =
            Unchecked.defaultof<azurerm.SentinelDataConnectorAzureActiveDirectory.SentinelDataConnectorAzureActiveDirectory>
