namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> = { assignments: ResizeArray<azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window">azurerm_data_factory_trigger_tumbling_window</a>.
    /// </summary>
    type DataFactoryTriggerTumblingWindowBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryTriggerTumblingWindowState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerTumblingWindowState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryTriggerTumblingWindowState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerTumblingWindowState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#data_factory_id-1">DataFactoryTriggerTumblingWindow#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryTriggerTumblingWindowState<Missing, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<Present, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerTumblingWindowState<Present, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#frequency-1">DataFactoryTriggerTumblingWindow#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, Missing, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, Present, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerTumblingWindowState<'DataFactoryId, Present, 'Interval, 'Name, 'Pipeline, 'StartTime>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#interval-1">DataFactoryTriggerTumblingWindow#interval</a>.
        /// </summary>
        [<CustomOperation "interval">]
        member _.Interval(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, Missing, 'Name, 'Pipeline, 'StartTime>, value: double) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, Present, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Interval <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, Present, 'Name, 'Pipeline, 'StartTime>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#name-1">DataFactoryTriggerTumblingWindow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, Missing, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, Present, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, Present, 'Pipeline, 'StartTime>)

        /// <summary>
        /// pipeline block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#pipeline-1">DataFactoryTriggerTumblingWindow#pipeline</a>
        /// </summary>
        [<CustomOperation "pipeline">]
        member _.Pipeline(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, Missing, 'StartTime>, value: azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowPipeline) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, Present, 'StartTime> =
            state.assignments.Add(fun config -> config.Pipeline <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, Present, 'StartTime>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#start_time-1">DataFactoryTriggerTumblingWindow#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, Missing>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, Present> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#activated-1">DataFactoryTriggerTumblingWindow#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: bool) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#activated-1">DataFactoryTriggerTumblingWindow#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#additional_properties-1">DataFactoryTriggerTumblingWindow#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: seq<string * string>) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#annotations-1">DataFactoryTriggerTumblingWindow#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: seq<string>) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#delay-1">DataFactoryTriggerTumblingWindow#delay</a>.
        /// </summary>
        [<CustomOperation "delay">]
        member _.Delay(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Delay <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#description-1">DataFactoryTriggerTumblingWindow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#end_time-1">DataFactoryTriggerTumblingWindow#end_time</a>.
        /// </summary>
        [<CustomOperation "end_time">]
        member _.EndTime(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.EndTime <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#id-1">DataFactoryTriggerTumblingWindow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: string) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#max_concurrency-1">DataFactoryTriggerTumblingWindow#max_concurrency</a>.
        /// </summary>
        [<CustomOperation "max_concurrency">]
        member _.MaxConcurrency(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: double) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.MaxConcurrency <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// retry block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#retry-1">DataFactoryTriggerTumblingWindow#retry</a>
        /// </summary>
        [<CustomOperation "retry">]
        member _.Retry(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowRetry) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Retry <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#timeouts-1">DataFactoryTriggerTumblingWindow#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowTimeouts) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        /// <summary>
        /// trigger_dependency block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#trigger_dependency-1">DataFactoryTriggerTumblingWindow#trigger_dependency</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowTriggerDependency[]
        /// </summary>
        [<CustomOperation "trigger_dependency">]
        member _.TriggerDependency(state: DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime> =
            state.assignments.Add(fun config -> config.TriggerDependency <- value)
            state : DataFactoryTriggerTumblingWindowState<'DataFactoryId, 'Frequency, 'Interval, 'Name, 'Pipeline, 'StartTime>

        member _.Run(state: DataFactoryTriggerTumblingWindowState<Present, Present, Present, Present, Present, Present>) : azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindow =
            let config = azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryTriggerTumblingWindow: missing required arguments. Must call: data_factory_id, frequency, interval, name, pipeline, start_time.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryTriggerTumblingWindowState<_, _, _, _, _, _>) : azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindow =
            Unchecked.defaultof<azurerm.DataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindow>
