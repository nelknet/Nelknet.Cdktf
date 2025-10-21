namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob">azurerm_stream_analytics_output_blob</a>.
    /// </summary>
    type StreamAnalyticsOutputBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#date_format-1">StreamAnalyticsOutputBlob#date_format</a>.
        /// </summary>
        [<CustomOperation "date_format">]
        member _.DateFormat(state: StreamAnalyticsOutputBlobState<Missing, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<Present, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.DateFormat <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<Present, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#name-1">StreamAnalyticsOutputBlob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputBlobState<'DateFormat, Missing, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, Present, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, Present, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#path_pattern-1">StreamAnalyticsOutputBlob#path_pattern</a>.
        /// </summary>
        [<CustomOperation "path_pattern">]
        member _.PathPattern(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, Missing, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, Present, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.PathPattern <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, Present, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#resource_group_name-1">StreamAnalyticsOutputBlob#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, Missing, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, Present, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, Present, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#serialization-1">StreamAnalyticsOutputBlob#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Missing, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlobSerialization) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Present, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Present, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#storage_account_name-1">StreamAnalyticsOutputBlob#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Missing, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Present, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Present, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#storage_container_name-1">StreamAnalyticsOutputBlob#storage_container_name</a>.
        /// </summary>
        [<CustomOperation "storage_container_name">]
        member _.StorageContainerName(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, Missing, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, Present, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageContainerName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, Present, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#stream_analytics_job_name-1">StreamAnalyticsOutputBlob#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, Missing, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, Present, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, Present, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#time_format-1">StreamAnalyticsOutputBlob#time_format</a>.
        /// </summary>
        [<CustomOperation "time_format">]
        member _.TimeFormat(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.TimeFormat <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#authentication_mode-1">StreamAnalyticsOutputBlob#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#batch_max_wait_time-1">StreamAnalyticsOutputBlob#batch_max_wait_time</a>.
        /// </summary>
        [<CustomOperation "batch_max_wait_time">]
        member _.BatchMaxWaitTime(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.BatchMaxWaitTime <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#batch_min_rows-1">StreamAnalyticsOutputBlob#batch_min_rows</a>.
        /// </summary>
        [<CustomOperation "batch_min_rows">]
        member _.BatchMinRows(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: double) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.BatchMinRows <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#blob_write_mode-1">StreamAnalyticsOutputBlob#blob_write_mode</a>.
        /// </summary>
        [<CustomOperation "blob_write_mode">]
        member _.BlobWriteMode(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.BlobWriteMode <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#id-1">StreamAnalyticsOutputBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#storage_account_key-1">StreamAnalyticsOutputBlob#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_blob#timeouts-1">StreamAnalyticsOutputBlob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlobTimeouts) : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        member _.Run(state: StreamAnalyticsOutputBlobState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlob =
            let config = azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlobConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputBlob: missing required arguments. Must call: date_format, name, path_pattern, resource_group_name, serialization, storage_account_name, storage_container_name, stream_analytics_job_name, time_format.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputBlobState<_, _, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlob =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputBlob.StreamAnalyticsOutputBlob>
