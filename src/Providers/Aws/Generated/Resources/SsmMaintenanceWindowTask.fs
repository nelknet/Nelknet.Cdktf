namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> = { assignments: ResizeArray<aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task">aws_ssm_maintenance_window_task</a>.
    /// </summary>
    type SsmMaintenanceWindowTaskBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmMaintenanceWindowTaskState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmMaintenanceWindowTaskState<Missing, Missing, Missing>)

        member _.Zero(()) : SsmMaintenanceWindowTaskState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmMaintenanceWindowTaskState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#task_arn-1">SsmMaintenanceWindowTask#task_arn</a>.
        /// </summary>
        [<CustomOperation "task_arn">]
        member _.TaskArn(state: SsmMaintenanceWindowTaskState<Missing, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<Present, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.TaskArn <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowTaskState<Present, 'TaskType, 'WindowId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#task_type-1">SsmMaintenanceWindowTask#task_type</a>.
        /// </summary>
        [<CustomOperation "task_type">]
        member _.TaskType(state: SsmMaintenanceWindowTaskState<'TaskArn, Missing, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, Present, 'WindowId> =
            state.assignments.Add(fun config -> config.TaskType <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowTaskState<'TaskArn, Present, 'WindowId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#window_id-1">SsmMaintenanceWindowTask#window_id</a>.
        /// </summary>
        [<CustomOperation "window_id">]
        member _.WindowId(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, Missing>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, Present> =
            state.assignments.Add(fun config -> config.WindowId <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#cutoff_behavior-1">SsmMaintenanceWindowTask#cutoff_behavior</a>.
        /// </summary>
        [<CustomOperation "cutoff_behavior">]
        member _.CutoffBehavior(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.CutoffBehavior <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#description-1">SsmMaintenanceWindowTask#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#id-1">SsmMaintenanceWindowTask#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#max_concurrency-1">SsmMaintenanceWindowTask#max_concurrency</a>.
        /// </summary>
        [<CustomOperation "max_concurrency">]
        member _.MaxConcurrency(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.MaxConcurrency <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#max_errors-1">SsmMaintenanceWindowTask#max_errors</a>.
        /// </summary>
        [<CustomOperation "max_errors">]
        member _.MaxErrors(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.MaxErrors <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#name-1">SsmMaintenanceWindowTask#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#priority-1">SsmMaintenanceWindowTask#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: double) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#service_role_arn-1">SsmMaintenanceWindowTask#service_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_role_arn">]
        member _.ServiceRoleArn(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: string) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.ServiceRoleArn <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// targets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#targets-1">SsmMaintenanceWindowTask#targets</a> Accepts: aws.IResolvable | aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTargets[]
        /// </summary>
        [<CustomOperation "targets">]
        member _.Targets(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: HashiCorp.Cdktf.IResolvable) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.Targets <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        /// <summary>
        /// task_invocation_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#task_invocation_parameters-1">SsmMaintenanceWindowTask#task_invocation_parameters</a>
        /// </summary>
        [<CustomOperation "task_invocation_parameters">]
        member _.TaskInvocationParameters(state: SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>, value: aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParameters) : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId> =
            state.assignments.Add(fun config -> config.TaskInvocationParameters <- value)
            state : SsmMaintenanceWindowTaskState<'TaskArn, 'TaskType, 'WindowId>

        member _.Run(state: SsmMaintenanceWindowTaskState<Present, Present, Present>) : aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTask =
            let config = aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTaskConfig()
            for setter in state.assignments do
                setter config
            aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTask(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmMaintenanceWindowTask: missing required arguments. Must call: task_arn, task_type, window_id.", 9999, IsError = true)>]
        member _.Run(_: SsmMaintenanceWindowTaskState<_, _, _>) : aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTask =
            Unchecked.defaultof<aws.SsmMaintenanceWindowTask.SsmMaintenanceWindowTask>
