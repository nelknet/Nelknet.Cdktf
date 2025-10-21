namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> = { assignments: ResizeArray<azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsightsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights">azurerm_log_analytics_storage_insights</a>.
    /// </summary>
    type LogAnalyticsStorageInsightsBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsStorageInsightsState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsStorageInsightsState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsStorageInsightsState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsStorageInsightsState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#name-1">LogAnalyticsStorageInsights#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsStorageInsightsState<Missing, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>, value: string) : LogAnalyticsStorageInsightsState<Present, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsStorageInsightsState<Present, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#resource_group_name-1">LogAnalyticsStorageInsights#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsStorageInsightsState<'Name, Missing, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>, value: string) : LogAnalyticsStorageInsightsState<'Name, Present, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsStorageInsightsState<'Name, Present, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#storage_account_id-1">LogAnalyticsStorageInsights#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, Missing, 'StorageAccountKey, 'WorkspaceId>, value: string) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, Present, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, Present, 'StorageAccountKey, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#storage_account_key-1">LogAnalyticsStorageInsights#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, Missing, 'WorkspaceId>, value: string) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            ({ assignments = state.assignments } : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#workspace_id-1">LogAnalyticsStorageInsights#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, Missing>, value: string) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#blob_container_names-1">LogAnalyticsStorageInsights#blob_container_names</a>.
        /// </summary>
        [<CustomOperation "blob_container_names">]
        member _.BlobContainerNames(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>, value: seq<string>) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.BlobContainerNames <- (value |> Seq.toArray))
            state : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#id-1">LogAnalyticsStorageInsights#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>, value: string) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#table_names-1">LogAnalyticsStorageInsights#table_names</a>.
        /// </summary>
        [<CustomOperation "table_names">]
        member _.TableNames(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>, value: seq<string>) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.TableNames <- (value |> Seq.toArray))
            state : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_storage_insights#timeouts-1">LogAnalyticsStorageInsights#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>, value: azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsightsTimeouts) : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsStorageInsightsState<'Name, 'ResourceGroupName, 'StorageAccountId, 'StorageAccountKey, 'WorkspaceId>

        member _.Run(state: LogAnalyticsStorageInsightsState<Present, Present, Present, Present, Present>) : azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsights =
            let config = azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsightsConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsights(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsStorageInsights: missing required arguments. Must call: name, resource_group_name, storage_account_id, storage_account_key, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsStorageInsightsState<_, _, _, _, _>) : azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsights =
            Unchecked.defaultof<azurerm.LogAnalyticsStorageInsights.LogAnalyticsStorageInsights>
