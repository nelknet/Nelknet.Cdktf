namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId> = { assignments: ResizeArray<azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account">azurerm_log_analytics_linked_storage_account</a>.
    /// </summary>
    type LogAnalyticsLinkedStorageAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsLinkedStorageAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsLinkedStorageAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsLinkedStorageAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsLinkedStorageAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account#data_source_type-1">LogAnalyticsLinkedStorageAccount#data_source_type</a>.
        /// </summary>
        [<CustomOperation "data_source_type">]
        member _.DataSourceType(state: LogAnalyticsLinkedStorageAccountState<Missing, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId>, value: string) : LogAnalyticsLinkedStorageAccountState<Present, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.DataSourceType <- value)
            ({ assignments = state.assignments } : LogAnalyticsLinkedStorageAccountState<Present, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account#resource_group_name-1">LogAnalyticsLinkedStorageAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsLinkedStorageAccountState<'DataSourceType, Missing, 'StorageAccountIds, 'WorkspaceResourceId>, value: string) : LogAnalyticsLinkedStorageAccountState<'DataSourceType, Present, 'StorageAccountIds, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsLinkedStorageAccountState<'DataSourceType, Present, 'StorageAccountIds, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account#storage_account_ids-1">LogAnalyticsLinkedStorageAccount#storage_account_ids</a>.
        /// </summary>
        [<CustomOperation "storage_account_ids">]
        member _.StorageAccountIds(state: LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, Missing, 'WorkspaceResourceId>, value: seq<string>) : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, Present, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.StorageAccountIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, Present, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account#workspace_resource_id-1">LogAnalyticsLinkedStorageAccount#workspace_resource_id</a>.
        /// </summary>
        [<CustomOperation "workspace_resource_id">]
        member _.WorkspaceResourceId(state: LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, Missing>, value: string) : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, Present> =
            state.assignments.Add(fun config -> config.WorkspaceResourceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account#id-1">LogAnalyticsLinkedStorageAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId>, value: string) : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_storage_account#timeouts-1">LogAnalyticsLinkedStorageAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId>, value: azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccountTimeouts) : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsLinkedStorageAccountState<'DataSourceType, 'ResourceGroupName, 'StorageAccountIds, 'WorkspaceResourceId>

        member _.Run(state: LogAnalyticsLinkedStorageAccountState<Present, Present, Present, Present>) : azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccount =
            let config = azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsLinkedStorageAccount: missing required arguments. Must call: data_source_type, resource_group_name, storage_account_ids, workspace_resource_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsLinkedStorageAccountState<_, _, _, _>) : azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccount =
            Unchecked.defaultof<azurerm.LogAnalyticsLinkedStorageAccount.LogAnalyticsLinkedStorageAccount>
