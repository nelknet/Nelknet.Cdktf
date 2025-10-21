namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupRestoreTestingPlanState<'Name, 'ScheduleExpression> = { assignments: ResizeArray<aws.BackupRestoreTestingPlan.BackupRestoreTestingPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan">aws_backup_restore_testing_plan</a>.
    /// </summary>
    type BackupRestoreTestingPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupRestoreTestingPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupRestoreTestingPlanState<Missing, Missing>)

        member _.Zero(()) : BackupRestoreTestingPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupRestoreTestingPlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan#name-1">BackupRestoreTestingPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupRestoreTestingPlanState<Missing, 'ScheduleExpression>, value: string) : BackupRestoreTestingPlanState<Present, 'ScheduleExpression> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupRestoreTestingPlanState<Present, 'ScheduleExpression>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan#schedule_expression-1">BackupRestoreTestingPlan#schedule_expression</a>.
        /// </summary>
        [<CustomOperation "schedule_expression">]
        member _.ScheduleExpression(state: BackupRestoreTestingPlanState<'Name, Missing>, value: string) : BackupRestoreTestingPlanState<'Name, Present> =
            state.assignments.Add(fun config -> config.ScheduleExpression <- value)
            ({ assignments = state.assignments } : BackupRestoreTestingPlanState<'Name, Present>)

        /// <summary>
        /// recovery_point_selection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan#recovery_point_selection-1">BackupRestoreTestingPlan#recovery_point_selection</a> Accepts: aws.IResolvable | aws.BackupRestoreTestingPlan.BackupRestoreTestingPlanRecoveryPointSelection[]
        /// </summary>
        [<CustomOperation "recovery_point_selection">]
        member _.RecoveryPointSelection(state: BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>, value: HashiCorp.Cdktf.IResolvable) : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression> =
            state.assignments.Add(fun config -> config.RecoveryPointSelection <- value)
            state : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan#schedule_expression_timezone-1">BackupRestoreTestingPlan#schedule_expression_timezone</a>.
        /// </summary>
        [<CustomOperation "schedule_expression_timezone">]
        member _.ScheduleExpressionTimezone(state: BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>, value: string) : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression> =
            state.assignments.Add(fun config -> config.ScheduleExpressionTimezone <- value)
            state : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan#start_window_hours-1">BackupRestoreTestingPlan#start_window_hours</a>.
        /// </summary>
        [<CustomOperation "start_window_hours">]
        member _.StartWindowHours(state: BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>, value: double) : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression> =
            state.assignments.Add(fun config -> config.StartWindowHours <- value)
            state : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_plan#tags-1">BackupRestoreTestingPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>, value: seq<string * string>) : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BackupRestoreTestingPlanState<'Name, 'ScheduleExpression>

        member _.Run(state: BackupRestoreTestingPlanState<Present, Present>) : aws.BackupRestoreTestingPlan.BackupRestoreTestingPlan =
            let config = aws.BackupRestoreTestingPlan.BackupRestoreTestingPlanConfig()
            for setter in state.assignments do
                setter config
            aws.BackupRestoreTestingPlan.BackupRestoreTestingPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupRestoreTestingPlan: missing required arguments. Must call: name, schedule_expression.", 9999, IsError = true)>]
        member _.Run(_: BackupRestoreTestingPlanState<_, _>) : aws.BackupRestoreTestingPlan.BackupRestoreTestingPlan =
            Unchecked.defaultof<aws.BackupRestoreTestingPlan.BackupRestoreTestingPlan>
