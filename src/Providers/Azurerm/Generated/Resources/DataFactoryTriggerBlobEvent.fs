namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> = { assignments: ResizeArray<azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEventConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event">azurerm_data_factory_trigger_blob_event</a>.
    /// </summary>
    type DataFactoryTriggerBlobEventBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryTriggerBlobEventState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerBlobEventState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryTriggerBlobEventState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerBlobEventState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#data_factory_id-1">DataFactoryTriggerBlobEvent#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryTriggerBlobEventState<Missing, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: string) : DataFactoryTriggerBlobEventState<Present, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerBlobEventState<Present, 'Events, 'Name, 'Pipeline, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#events-1">DataFactoryTriggerBlobEvent#events</a>.
        /// </summary>
        [<CustomOperation "events">]
        member _.Events(state: DataFactoryTriggerBlobEventState<'DataFactoryId, Missing, 'Name, 'Pipeline, 'StorageAccountId>, value: seq<string>) : DataFactoryTriggerBlobEventState<'DataFactoryId, Present, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Events <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataFactoryTriggerBlobEventState<'DataFactoryId, Present, 'Name, 'Pipeline, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#name-1">DataFactoryTriggerBlobEvent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, Missing, 'Pipeline, 'StorageAccountId>, value: string) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, Present, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, Present, 'Pipeline, 'StorageAccountId>)

        /// <summary>
        /// pipeline block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#pipeline-1">DataFactoryTriggerBlobEvent#pipeline</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEventPipeline[]
        /// </summary>
        [<CustomOperation "pipeline">]
        member _.Pipeline(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, Missing, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Pipeline <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#storage_account_id-1">DataFactoryTriggerBlobEvent#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, Missing>, value: string) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#activated-1">DataFactoryTriggerBlobEvent#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: bool) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#activated-1">DataFactoryTriggerBlobEvent#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#additional_properties-1">DataFactoryTriggerBlobEvent#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: seq<string * string>) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#annotations-1">DataFactoryTriggerBlobEvent#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: seq<string>) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#blob_path_begins_with-1">DataFactoryTriggerBlobEvent#blob_path_begins_with</a>.
        /// </summary>
        [<CustomOperation "blob_path_begins_with">]
        member _.BlobPathBeginsWith(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: string) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.BlobPathBeginsWith <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#blob_path_ends_with-1">DataFactoryTriggerBlobEvent#blob_path_ends_with</a>.
        /// </summary>
        [<CustomOperation "blob_path_ends_with">]
        member _.BlobPathEndsWith(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: string) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.BlobPathEndsWith <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#description-1">DataFactoryTriggerBlobEvent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: string) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#id-1">DataFactoryTriggerBlobEvent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: string) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#ignore_empty_blobs-1">DataFactoryTriggerBlobEvent#ignore_empty_blobs</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_empty_blobs">]
        member _.IgnoreEmptyBlobs(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: bool) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.IgnoreEmptyBlobs <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#ignore_empty_blobs-1">DataFactoryTriggerBlobEvent#ignore_empty_blobs</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_empty_blobs">]
        member _.IgnoreEmptyBlobs(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.IgnoreEmptyBlobs <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_blob_event#timeouts-1">DataFactoryTriggerBlobEvent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>, value: azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEventTimeouts) : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryTriggerBlobEventState<'DataFactoryId, 'Events, 'Name, 'Pipeline, 'StorageAccountId>

        member _.Run(state: DataFactoryTriggerBlobEventState<Present, Present, Present, Present, Present>) : azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEvent =
            let config = azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEventConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEvent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryTriggerBlobEvent: missing required arguments. Must call: data_factory_id, events, name, pipeline, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryTriggerBlobEventState<_, _, _, _, _>) : azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEvent =
            Unchecked.defaultof<azurerm.DataFactoryTriggerBlobEvent.DataFactoryTriggerBlobEvent>
