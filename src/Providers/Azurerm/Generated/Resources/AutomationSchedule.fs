namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationSchedule.AutomationScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule">azurerm_automation_schedule</a>.
    /// </summary>
    type AutomationScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationScheduleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationScheduleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationScheduleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationScheduleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#automation_account_name-1">AutomationSchedule#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationScheduleState<Missing, 'Frequency, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<Present, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationScheduleState<Present, 'Frequency, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#frequency-1">AutomationSchedule#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: AutomationScheduleState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : AutomationScheduleState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#name-1">AutomationSchedule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, Missing, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationScheduleState<'AutomationAccountName, 'Frequency, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#resource_group_name-1">AutomationSchedule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, Missing>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#description-1">AutomationSchedule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#expiry_time-1">AutomationSchedule#expiry_time</a>.
        /// </summary>
        [<CustomOperation "expiry_time">]
        member _.ExpiryTime(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExpiryTime <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#id-1">AutomationSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#interval-1">AutomationSchedule#interval</a>.
        /// </summary>
        [<CustomOperation "interval">]
        member _.Interval(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: double) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Interval <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#month_days-1">AutomationSchedule#month_days</a>.
        /// </summary>
        [<CustomOperation "month_days">]
        member _.MonthDays(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: seq<double>) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MonthDays <- (value |> Seq.toArray))
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// monthly_occurrence block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#monthly_occurrence-1">AutomationSchedule#monthly_occurrence</a>
        /// </summary>
        [<CustomOperation "monthly_occurrence">]
        member _.MonthlyOccurrence(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: azurerm.AutomationSchedule.AutomationScheduleMonthlyOccurrence) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MonthlyOccurrence <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#start_time-1">AutomationSchedule#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#timeouts-1">AutomationSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: azurerm.AutomationSchedule.AutomationScheduleTimeouts) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#timezone-1">AutomationSchedule#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: string) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#week_days-1">AutomationSchedule#week_days</a>.
        /// </summary>
        [<CustomOperation "week_days">]
        member _.WeekDays(state: AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>, value: seq<string>) : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WeekDays <- (value |> Seq.toArray))
            state : AutomationScheduleState<'AutomationAccountName, 'Frequency, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationScheduleState<Present, Present, Present, Present>) : azurerm.AutomationSchedule.AutomationSchedule =
            let config = azurerm.AutomationSchedule.AutomationScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationSchedule.AutomationSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationSchedule: missing required arguments. Must call: automation_account_name, frequency, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationScheduleState<_, _, _, _>) : azurerm.AutomationSchedule.AutomationSchedule =
            Unchecked.defaultof<azurerm.AutomationSchedule.AutomationSchedule>
