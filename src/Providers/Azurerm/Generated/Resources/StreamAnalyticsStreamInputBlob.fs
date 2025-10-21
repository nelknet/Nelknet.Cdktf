namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> = { assignments: ResizeArray<azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob">azurerm_stream_analytics_stream_input_blob</a>.
    /// </summary>
    type StreamAnalyticsStreamInputBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsStreamInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsStreamInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#date_format-1">StreamAnalyticsStreamInputBlob#date_format</a>.
        /// </summary>
        [<CustomOperation "date_format">]
        member _.DateFormat(state: StreamAnalyticsStreamInputBlobState<Missing, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<Present, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.DateFormat <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<Present, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#name-1">StreamAnalyticsStreamInputBlob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsStreamInputBlobState<'DateFormat, Missing, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, Present, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, Present, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#path_pattern-1">StreamAnalyticsStreamInputBlob#path_pattern</a>.
        /// </summary>
        [<CustomOperation "path_pattern">]
        member _.PathPattern(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, Missing, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, Present, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.PathPattern <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, Present, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#resource_group_name-1">StreamAnalyticsStreamInputBlob#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, Missing, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, Present, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, Present, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#serialization-1">StreamAnalyticsStreamInputBlob#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Missing, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobSerialization) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Present, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Present, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#storage_account_key-1">StreamAnalyticsStreamInputBlob#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Missing, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Present, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Present, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#storage_account_name-1">StreamAnalyticsStreamInputBlob#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, Missing, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, Present, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, Present, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#storage_container_name-1">StreamAnalyticsStreamInputBlob#storage_container_name</a>.
        /// </summary>
        [<CustomOperation "storage_container_name">]
        member _.StorageContainerName(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, Missing, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, Present, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageContainerName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, Present, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#stream_analytics_job_name-1">StreamAnalyticsStreamInputBlob#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, Missing, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, Present, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, Present, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#time_format-1">StreamAnalyticsStreamInputBlob#time_format</a>.
        /// </summary>
        [<CustomOperation "time_format">]
        member _.TimeFormat(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.TimeFormat <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#id-1">StreamAnalyticsStreamInputBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#timeouts-1">StreamAnalyticsStreamInputBlob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobTimeouts) : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsStreamInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountKey, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        member _.Run(state: StreamAnalyticsStreamInputBlobState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob =
            let config = azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsStreamInputBlob: missing required arguments. Must call: date_format, name, path_pattern, resource_group_name, serialization, storage_account_key, storage_account_name, storage_container_name, stream_analytics_job_name, time_format.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsStreamInputBlobState<_, _, _, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob =
            Unchecked.defaultof<azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob>
