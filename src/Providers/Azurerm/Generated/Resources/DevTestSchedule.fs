namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> = { assignments: ResizeArray<azurerm.DevTestSchedule.DevTestScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule">azurerm_dev_test_schedule</a>.
    /// </summary>
    type DevTestScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestScheduleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestScheduleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevTestScheduleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestScheduleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#lab_name-1">DevTestSchedule#lab_name</a>.
        /// </summary>
        [<CustomOperation "lab_name">]
        member _.LabName(state: DevTestScheduleState<Missing, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: string) : DevTestScheduleState<Present, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.LabName <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<Present, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#location-1">DevTestSchedule#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevTestScheduleState<'LabName, Missing, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: string) : DevTestScheduleState<'LabName, Present, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<'LabName, Present, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#name-1">DevTestSchedule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevTestScheduleState<'LabName, 'Location, Missing, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: string) : DevTestScheduleState<'LabName, 'Location, Present, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<'LabName, 'Location, Present, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>)

        /// <summary>
        /// notification_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#notification_settings-1">DevTestSchedule#notification_settings</a>
        /// </summary>
        [<CustomOperation "notification_settings">]
        member _.NotificationSettings(state: DevTestScheduleState<'LabName, 'Location, 'Name, Missing, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: azurerm.DevTestSchedule.DevTestScheduleNotificationSettings) : DevTestScheduleState<'LabName, 'Location, 'Name, Present, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.NotificationSettings <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<'LabName, 'Location, 'Name, Present, 'ResourceGroupName, 'TaskType, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#resource_group_name-1">DevTestSchedule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, Missing, 'TaskType, 'TimeZoneId>, value: string) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, Present, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, Present, 'TaskType, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#task_type-1">DevTestSchedule#task_type</a>.
        /// </summary>
        [<CustomOperation "task_type">]
        member _.TaskType(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, Missing, 'TimeZoneId>, value: string) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, Present, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.TaskType <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, Present, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time_zone_id-1">DevTestSchedule#time_zone_id</a>.
        /// </summary>
        [<CustomOperation "time_zone_id">]
        member _.TimeZoneId(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, Missing>, value: string) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, Present> =
            state.assignments.Add(fun config -> config.TimeZoneId <- value)
            ({ assignments = state.assignments } : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, Present>)

        /// <summary>
        /// daily_recurrence block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#daily_recurrence-1">DevTestSchedule#daily_recurrence</a>
        /// </summary>
        [<CustomOperation "daily_recurrence">]
        member _.DailyRecurrence(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: azurerm.DevTestSchedule.DevTestScheduleDailyRecurrence) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.DailyRecurrence <- value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        /// <summary>
        /// hourly_recurrence block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#hourly_recurrence-1">DevTestSchedule#hourly_recurrence</a>
        /// </summary>
        [<CustomOperation "hourly_recurrence">]
        member _.HourlyRecurrence(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: azurerm.DevTestSchedule.DevTestScheduleHourlyRecurrence) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.HourlyRecurrence <- value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#id-1">DevTestSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: string) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#status-1">DevTestSchedule#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: string) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#tags-1">DevTestSchedule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: seq<string * string>) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#timeouts-1">DevTestSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: azurerm.DevTestSchedule.DevTestScheduleTimeouts) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        /// <summary>
        /// weekly_recurrence block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#weekly_recurrence-1">DevTestSchedule#weekly_recurrence</a>
        /// </summary>
        [<CustomOperation "weekly_recurrence">]
        member _.WeeklyRecurrence(state: DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>, value: azurerm.DevTestSchedule.DevTestScheduleWeeklyRecurrence) : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.WeeklyRecurrence <- value)
            state : DevTestScheduleState<'LabName, 'Location, 'Name, 'NotificationSettings, 'ResourceGroupName, 'TaskType, 'TimeZoneId>

        member _.Run(state: DevTestScheduleState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.DevTestSchedule.DevTestSchedule =
            let config = azurerm.DevTestSchedule.DevTestScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestSchedule.DevTestSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestSchedule: missing required arguments. Must call: lab_name, location, name, notification_settings, resource_group_name, task_type, time_zone_id.", 9999, IsError = true)>]
        member _.Run(_: DevTestScheduleState<_, _, _, _, _, _, _>) : azurerm.DevTestSchedule.DevTestSchedule =
            Unchecked.defaultof<azurerm.DevTestSchedule.DevTestSchedule>
