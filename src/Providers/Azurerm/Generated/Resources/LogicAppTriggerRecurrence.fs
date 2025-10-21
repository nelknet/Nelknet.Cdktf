namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name> = { assignments: ResizeArray<azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrenceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence">azurerm_logic_app_trigger_recurrence</a>.
    /// </summary>
    type LogicAppTriggerRecurrenceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppTriggerRecurrenceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppTriggerRecurrenceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppTriggerRecurrenceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppTriggerRecurrenceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#frequency-1">LogicAppTriggerRecurrence#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: LogicAppTriggerRecurrenceState<Missing, 'Interval, 'LogicAppId, 'Name>, value: string) : LogicAppTriggerRecurrenceState<Present, 'Interval, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : LogicAppTriggerRecurrenceState<Present, 'Interval, 'LogicAppId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#interval-1">LogicAppTriggerRecurrence#interval</a>.
        /// </summary>
        [<CustomOperation "interval">]
        member _.Interval(state: LogicAppTriggerRecurrenceState<'Frequency, Missing, 'LogicAppId, 'Name>, value: double) : LogicAppTriggerRecurrenceState<'Frequency, Present, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Interval <- value)
            ({ assignments = state.assignments } : LogicAppTriggerRecurrenceState<'Frequency, Present, 'LogicAppId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#logic_app_id-1">LogicAppTriggerRecurrence#logic_app_id</a>.
        /// </summary>
        [<CustomOperation "logic_app_id">]
        member _.LogicAppId(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, Missing, 'Name>, value: string) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogicAppId <- value)
            ({ assignments = state.assignments } : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#name-1">LogicAppTriggerRecurrence#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, Missing>, value: string) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#id-1">LogicAppTriggerRecurrence#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>, value: string) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#schedule-1">LogicAppTriggerRecurrence#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>, value: azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrenceSchedule) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#start_time-1">LogicAppTriggerRecurrence#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>, value: string) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#timeouts-1">LogicAppTriggerRecurrence#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>, value: azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrenceTimeouts) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_recurrence#time_zone-1">LogicAppTriggerRecurrence#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>, value: string) : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : LogicAppTriggerRecurrenceState<'Frequency, 'Interval, 'LogicAppId, 'Name>

        member _.Run(state: LogicAppTriggerRecurrenceState<Present, Present, Present, Present>) : azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrence =
            let config = azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrenceConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrence(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppTriggerRecurrence: missing required arguments. Must call: frequency, interval, logic_app_id, name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppTriggerRecurrenceState<_, _, _, _>) : azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrence =
            Unchecked.defaultof<azurerm.LogicAppTriggerRecurrence.LogicAppTriggerRecurrence>
