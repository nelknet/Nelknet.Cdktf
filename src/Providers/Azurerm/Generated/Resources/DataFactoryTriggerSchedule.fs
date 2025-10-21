namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule">azurerm_data_factory_trigger_schedule</a>.
    /// </summary>
    type DataFactoryTriggerScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryTriggerScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerScheduleState<Missing, Missing>)

        member _.Zero(()) : DataFactoryTriggerScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryTriggerScheduleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#data_factory_id-1">DataFactoryTriggerSchedule#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryTriggerScheduleState<Missing, 'Name>, value: string) : DataFactoryTriggerScheduleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerScheduleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#name-1">DataFactoryTriggerSchedule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryTriggerScheduleState<'DataFactoryId, Missing>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryTriggerScheduleState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#activated-1">DataFactoryTriggerSchedule#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: bool) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#activated-1">DataFactoryTriggerSchedule#activated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activated">]
        member _.Activated(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Activated <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#annotations-1">DataFactoryTriggerSchedule#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#description-1">DataFactoryTriggerSchedule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#end_time-1">DataFactoryTriggerSchedule#end_time</a>.
        /// </summary>
        [<CustomOperation "end_time">]
        member _.EndTime(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.EndTime <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#frequency-1">DataFactoryTriggerSchedule#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#id-1">DataFactoryTriggerSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#interval-1">DataFactoryTriggerSchedule#interval</a>.
        /// </summary>
        [<CustomOperation "interval">]
        member _.Interval(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: double) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Interval <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// pipeline block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#pipeline-1">DataFactoryTriggerSchedule#pipeline</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerSchedulePipeline[]
        /// </summary>
        [<CustomOperation "pipeline">]
        member _.Pipeline(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Pipeline <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#pipeline_name-1">DataFactoryTriggerSchedule#pipeline_name</a>.
        /// </summary>
        [<CustomOperation "pipeline_name">]
        member _.PipelineName(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.PipelineName <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#pipeline_parameters-1">DataFactoryTriggerSchedule#pipeline_parameters</a>.
        /// </summary>
        [<CustomOperation "pipeline_parameters">]
        member _.PipelineParameters(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.PipelineParameters <- dict value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#schedule-1">DataFactoryTriggerSchedule#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerScheduleSchedule) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#start_time-1">DataFactoryTriggerSchedule#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#timeouts-1">DataFactoryTriggerSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerScheduleTimeouts) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#time_zone-1">DataFactoryTriggerSchedule#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : DataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryTriggerScheduleState<Present, Present>) : azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerSchedule =
            let config = azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryTriggerSchedule: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryTriggerScheduleState<_, _>) : azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerSchedule =
            Unchecked.defaultof<azurerm.DataFactoryTriggerSchedule.DataFactoryTriggerSchedule>
