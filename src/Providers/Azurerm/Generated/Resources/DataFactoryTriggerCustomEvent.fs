namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> = { assignments: ResizeArray<azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEventConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event">azurerm_data_factory_trigger_custom_event</a>.
    /// </summary>
    type DataFactoryTriggerCustomEventBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryTriggerCustomEventState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerCustomEventState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryTriggerCustomEventState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerCustomEventState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#data_factory_id-1">DataFactoryTriggerCustomEvent#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryTriggerCustomEventState<Missing, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<Present, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerCustomEventState<Present, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#eventgrid_topic_id-1">DataFactoryTriggerCustomEvent#eventgrid_topic_id</a>.
        /// </summary>
        [<CustomOperation "eventgrid_topic_id">]
        member _.EventgridTopicId(state: DataFactoryTriggerCustomEventState<'DataFactoryId, Missing, 'Events, 'Name, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<'DataFactoryId, Present, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.EventgridTopicId <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerCustomEventState<'DataFactoryId, Present, 'Events, 'Name, 'Pipeline>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#events-1">DataFactoryTriggerCustomEvent#events</a>.
        /// </summary>
        [<CustomOperation "events">]
        member _.Events(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, Missing, 'Name, 'Pipeline>, value: seq<string>) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, Present, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Events <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, Present, 'Name, 'Pipeline>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#name-1">DataFactoryTriggerCustomEvent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, Missing, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, Present, 'Pipeline> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, Present, 'Pipeline>)

        /// <summary>
        /// pipeline block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#pipeline-1">DataFactoryTriggerCustomEvent#pipeline</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEventPipeline[]
        /// </summary>
        [<CustomOperation "pipeline">]
        member _.Pipeline(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, Present> =
            state.assignments.Add(fun config -> config.Pipeline <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#activated-1">DataFactoryTriggerCustomEvent#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: bool) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#activated-1">DataFactoryTriggerCustomEvent#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#additional_properties-1">DataFactoryTriggerCustomEvent#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: seq<string * string>) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#annotations-1">DataFactoryTriggerCustomEvent#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: seq<string>) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#description-1">DataFactoryTriggerCustomEvent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#id-1">DataFactoryTriggerCustomEvent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#subject_begins_with-1">DataFactoryTriggerCustomEvent#subject_begins_with</a>.
        /// </summary>
        [<CustomOperation "subject_begins_with">]
        member _.SubjectBeginsWith(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.SubjectBeginsWith <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#subject_ends_with-1">DataFactoryTriggerCustomEvent#subject_ends_with</a>.
        /// </summary>
        [<CustomOperation "subject_ends_with">]
        member _.SubjectEndsWith(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: string) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.SubjectEndsWith <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_custom_event#timeouts-1">DataFactoryTriggerCustomEvent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>, value: azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEventTimeouts) : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryTriggerCustomEventState<'DataFactoryId, 'EventgridTopicId, 'Events, 'Name, 'Pipeline>

        member _.Run(state: DataFactoryTriggerCustomEventState<Present, Present, Present, Present, Present>) : azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEvent =
            let config = azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEventConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEvent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryTriggerCustomEvent: missing required arguments. Must call: data_factory_id, eventgrid_topic_id, events, name, pipeline.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryTriggerCustomEventState<_, _, _, _, _>) : azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEvent =
            Unchecked.defaultof<azurerm.DataFactoryTriggerCustomEvent.DataFactoryTriggerCustomEvent>
