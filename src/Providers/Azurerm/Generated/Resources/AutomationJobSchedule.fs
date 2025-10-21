namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName> = { assignments: ResizeArray<azurerm.AutomationJobSchedule.AutomationJobScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule">azurerm_automation_job_schedule</a>.
    /// </summary>
    type AutomationJobScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationJobScheduleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationJobScheduleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationJobScheduleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationJobScheduleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#automation_account_name-1">AutomationJobSchedule#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationJobScheduleState<Missing, 'ResourceGroupName, 'RunbookName, 'ScheduleName>, value: string) : AutomationJobScheduleState<Present, 'ResourceGroupName, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationJobScheduleState<Present, 'ResourceGroupName, 'RunbookName, 'ScheduleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#resource_group_name-1">AutomationJobSchedule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationJobScheduleState<'AutomationAccountName, Missing, 'RunbookName, 'ScheduleName>, value: string) : AutomationJobScheduleState<'AutomationAccountName, Present, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationJobScheduleState<'AutomationAccountName, Present, 'RunbookName, 'ScheduleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#runbook_name-1">AutomationJobSchedule#runbook_name</a>.
        /// </summary>
        [<CustomOperation "runbook_name">]
        member _.RunbookName(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, Missing, 'ScheduleName>, value: string) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, Present, 'ScheduleName> =
            state.assignments.Add(fun config -> config.RunbookName <- value)
            ({ assignments = state.assignments } : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, Present, 'ScheduleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#schedule_name-1">AutomationJobSchedule#schedule_name</a>.
        /// </summary>
        [<CustomOperation "schedule_name">]
        member _.ScheduleName(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, Missing>, value: string) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, Present> =
            state.assignments.Add(fun config -> config.ScheduleName <- value)
            ({ assignments = state.assignments } : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#id-1">AutomationJobSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>, value: string) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#job_schedule_id-1">AutomationJobSchedule#job_schedule_id</a>.
        /// </summary>
        [<CustomOperation "job_schedule_id">]
        member _.JobScheduleId(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>, value: string) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.JobScheduleId <- value)
            state : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#parameters-1">AutomationJobSchedule#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>, value: seq<string * string>) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#run_on-1">AutomationJobSchedule#run_on</a>.
        /// </summary>
        [<CustomOperation "run_on">]
        member _.RunOn(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>, value: string) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.RunOn <- value)
            state : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_job_schedule#timeouts-1">AutomationJobSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>, value: azurerm.AutomationJobSchedule.AutomationJobScheduleTimeouts) : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationJobScheduleState<'AutomationAccountName, 'ResourceGroupName, 'RunbookName, 'ScheduleName>

        member _.Run(state: AutomationJobScheduleState<Present, Present, Present, Present>) : azurerm.AutomationJobSchedule.AutomationJobSchedule =
            let config = azurerm.AutomationJobSchedule.AutomationJobScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationJobSchedule.AutomationJobSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationJobSchedule: missing required arguments. Must call: automation_account_name, resource_group_name, runbook_name, schedule_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationJobScheduleState<_, _, _, _>) : azurerm.AutomationJobSchedule.AutomationJobSchedule =
            Unchecked.defaultof<azurerm.AutomationJobSchedule.AutomationJobSchedule>
