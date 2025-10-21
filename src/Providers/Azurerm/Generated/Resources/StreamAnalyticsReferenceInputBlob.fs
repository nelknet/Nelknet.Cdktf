namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> = { assignments: ResizeArray<azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob">azurerm_stream_analytics_reference_input_blob</a>.
    /// </summary>
    type StreamAnalyticsReferenceInputBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsReferenceInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsReferenceInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsReferenceInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsReferenceInputBlobState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#date_format-1">StreamAnalyticsReferenceInputBlob#date_format</a>.
        /// </summary>
        [<CustomOperation "date_format">]
        member _.DateFormat(state: StreamAnalyticsReferenceInputBlobState<Missing, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<Present, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.DateFormat <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<Present, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#name-1">StreamAnalyticsReferenceInputBlob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, Missing, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, Present, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, Present, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#path_pattern-1">StreamAnalyticsReferenceInputBlob#path_pattern</a>.
        /// </summary>
        [<CustomOperation "path_pattern">]
        member _.PathPattern(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, Missing, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, Present, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.PathPattern <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, Present, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#resource_group_name-1">StreamAnalyticsReferenceInputBlob#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, Missing, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, Present, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, Present, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#serialization-1">StreamAnalyticsReferenceInputBlob#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Missing, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobSerialization) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Present, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, Present, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#storage_account_name-1">StreamAnalyticsReferenceInputBlob#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Missing, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Present, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, Present, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#storage_container_name-1">StreamAnalyticsReferenceInputBlob#storage_container_name</a>.
        /// </summary>
        [<CustomOperation "storage_container_name">]
        member _.StorageContainerName(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, Missing, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, Present, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageContainerName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, Present, 'StreamAnalyticsJobName, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#stream_analytics_job_name-1">StreamAnalyticsReferenceInputBlob#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, Missing, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, Present, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, Present, 'TimeFormat>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#time_format-1">StreamAnalyticsReferenceInputBlob#time_format</a>.
        /// </summary>
        [<CustomOperation "time_format">]
        member _.TimeFormat(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.TimeFormat <- value)
            ({ assignments = state.assignments } : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#authentication_mode-1">StreamAnalyticsReferenceInputBlob#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#id-1">StreamAnalyticsReferenceInputBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#storage_account_key-1">StreamAnalyticsReferenceInputBlob#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: string) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            state : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_reference_input_blob#timeouts-1">StreamAnalyticsReferenceInputBlob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>, value: azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobTimeouts) : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsReferenceInputBlobState<'DateFormat, 'Name, 'PathPattern, 'ResourceGroupName, 'Serialization, 'StorageAccountName, 'StorageContainerName, 'StreamAnalyticsJobName, 'TimeFormat>

        member _.Run(state: StreamAnalyticsReferenceInputBlobState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlob =
            let config = azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlobConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsReferenceInputBlob: missing required arguments. Must call: date_format, name, path_pattern, resource_group_name, serialization, storage_account_name, storage_container_name, stream_analytics_job_name, time_format.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsReferenceInputBlobState<_, _, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlob =
            Unchecked.defaultof<azurerm.StreamAnalyticsReferenceInputBlob.StreamAnalyticsReferenceInputBlob>
