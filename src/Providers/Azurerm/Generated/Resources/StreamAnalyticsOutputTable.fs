namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table">azurerm_stream_analytics_output_table</a>.
    /// </summary>
    type StreamAnalyticsOutputTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputTableState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputTableState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputTableState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputTableState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#batch_size-1">StreamAnalyticsOutputTable#batch_size</a>.
        /// </summary>
        [<CustomOperation "batch_size">]
        member _.BatchSize(state: StreamAnalyticsOutputTableState<Missing, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: double) : StreamAnalyticsOutputTableState<Present, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.BatchSize <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<Present, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#name-1">StreamAnalyticsOutputTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputTableState<'BatchSize, Missing, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, Present, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, Present, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#partition_key-1">StreamAnalyticsOutputTable#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, Missing, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, Present, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, Present, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#resource_group_name-1">StreamAnalyticsOutputTable#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, Missing, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, Present, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, Present, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#row_key-1">StreamAnalyticsOutputTable#row_key</a>.
        /// </summary>
        [<CustomOperation "row_key">]
        member _.RowKey(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, Missing, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, Present, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.RowKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, Present, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#storage_account_key-1">StreamAnalyticsOutputTable#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, Missing, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, Present, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, Present, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#storage_account_name-1">StreamAnalyticsOutputTable#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, Missing, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, Present, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, Present, 'StreamAnalyticsJobName, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#stream_analytics_job_name-1">StreamAnalyticsOutputTable#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, Missing, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, Present, 'Table> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, Present, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#table-1">StreamAnalyticsOutputTable#table</a>.
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.Table <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#columns_to_remove-1">StreamAnalyticsOutputTable#columns_to_remove</a>.
        /// </summary>
        [<CustomOperation "columns_to_remove">]
        member _.ColumnsToRemove(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: seq<string>) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.ColumnsToRemove <- (value |> Seq.toArray))
            state : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#id-1">StreamAnalyticsOutputTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: string) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_table#timeouts-1">StreamAnalyticsOutputTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>, value: azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTableTimeouts) : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputTableState<'BatchSize, 'Name, 'PartitionKey, 'ResourceGroupName, 'RowKey, 'StorageAccountKey, 'StorageAccountName, 'StreamAnalyticsJobName, 'Table>

        member _.Run(state: StreamAnalyticsOutputTableState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTable =
            let config = azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputTable: missing required arguments. Must call: batch_size, name, partition_key, resource_group_name, row_key, storage_account_key, storage_account_name, stream_analytics_job_name, table.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputTableState<_, _, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTable =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputTable.StreamAnalyticsOutputTable>
