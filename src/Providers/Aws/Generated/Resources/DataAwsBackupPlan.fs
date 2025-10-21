namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBackupPlanState<'PlanId> = { assignments: ResizeArray<aws.DataAwsBackupPlan.DataAwsBackupPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_plan">aws_backup_plan</a>.
    /// </summary>
    type DataAwsBackupPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBackupPlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupPlanState<Missing>)

        member _.Zero(()) : DataAwsBackupPlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupPlanState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_plan#plan_id-1">DataAwsBackupPlan#plan_id</a>.
        /// </summary>
        [<CustomOperation "plan_id">]
        member _.PlanId(state: DataAwsBackupPlanState<Missing>, value: string) : DataAwsBackupPlanState<Present> =
            state.assignments.Add(fun config -> config.PlanId <- value)
            ({ assignments = state.assignments } : DataAwsBackupPlanState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_plan#id-1">DataAwsBackupPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBackupPlanState<'PlanId>, value: string) : DataAwsBackupPlanState<'PlanId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBackupPlanState<'PlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_plan#tags-1">DataAwsBackupPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBackupPlanState<'PlanId>, value: seq<string * string>) : DataAwsBackupPlanState<'PlanId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBackupPlanState<'PlanId>

        member _.Run(state: DataAwsBackupPlanState<Present>) : aws.DataAwsBackupPlan.DataAwsBackupPlan =
            let config = aws.DataAwsBackupPlan.DataAwsBackupPlanConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBackupPlan.DataAwsBackupPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBackupPlan: missing required arguments. Must call: plan_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBackupPlanState<_>) : aws.DataAwsBackupPlan.DataAwsBackupPlan =
            Unchecked.defaultof<aws.DataAwsBackupPlan.DataAwsBackupPlan>
