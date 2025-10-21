namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule">azurerm_dev_test_global_vm_shutdown_schedule</a>.
    /// </summary>
    type DevTestGlobalVmShutdownScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestGlobalVmShutdownScheduleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestGlobalVmShutdownScheduleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevTestGlobalVmShutdownScheduleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestGlobalVmShutdownScheduleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#daily_recurrence_time-1">DevTestGlobalVmShutdownSchedule#daily_recurrence_time</a>.
        /// </summary>
        [<CustomOperation "daily_recurrence_time">]
        member _.DailyRecurrenceTime(state: DevTestGlobalVmShutdownScheduleState<Missing, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: string) : DevTestGlobalVmShutdownScheduleState<Present, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.DailyRecurrenceTime <- value)
            ({ assignments = state.assignments } : DevTestGlobalVmShutdownScheduleState<Present, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#location-1">DevTestGlobalVmShutdownSchedule#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, Missing, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: string) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, Present, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, Present, 'NotificationSettings, 'Timezone, 'VirtualMachineId>)

        /// <summary>
        /// notification_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#notification_settings-1">DevTestGlobalVmShutdownSchedule#notification_settings</a>
        /// </summary>
        [<CustomOperation "notification_settings">]
        member _.NotificationSettings(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, Missing, 'Timezone, 'VirtualMachineId>, value: azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleNotificationSettings) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, Present, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.NotificationSettings <- value)
            ({ assignments = state.assignments } : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, Present, 'Timezone, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#timezone-1">DevTestGlobalVmShutdownSchedule#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, Missing, 'VirtualMachineId>, value: string) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            ({ assignments = state.assignments } : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#virtual_machine_id-1">DevTestGlobalVmShutdownSchedule#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, Missing>, value: string) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#enabled-1">DevTestGlobalVmShutdownSchedule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: bool) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#enabled-1">DevTestGlobalVmShutdownSchedule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#id-1">DevTestGlobalVmShutdownSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: string) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#tags-1">DevTestGlobalVmShutdownSchedule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: seq<string * string>) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_global_vm_shutdown_schedule#timeouts-1">DevTestGlobalVmShutdownSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>, value: azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleTimeouts) : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestGlobalVmShutdownScheduleState<'DailyRecurrenceTime, 'Location, 'NotificationSettings, 'Timezone, 'VirtualMachineId>

        member _.Run(state: DevTestGlobalVmShutdownScheduleState<Present, Present, Present, Present, Present>) : azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownSchedule =
            let config = azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestGlobalVmShutdownSchedule: missing required arguments. Must call: daily_recurrence_time, location, notification_settings, timezone, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: DevTestGlobalVmShutdownScheduleState<_, _, _, _, _>) : azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownSchedule =
            Unchecked.defaultof<azurerm.DevTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownSchedule>
