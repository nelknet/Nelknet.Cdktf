namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBackupReportPlanState<'Name> = { assignments: ResizeArray<aws.DataAwsBackupReportPlan.DataAwsBackupReportPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_report_plan">aws_backup_report_plan</a>.
    /// </summary>
    type DataAwsBackupReportPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBackupReportPlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupReportPlanState<Missing>)

        member _.Zero(()) : DataAwsBackupReportPlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupReportPlanState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_report_plan#name-1">DataAwsBackupReportPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsBackupReportPlanState<Missing>, value: string) : DataAwsBackupReportPlanState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsBackupReportPlanState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_report_plan#id-1">DataAwsBackupReportPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBackupReportPlanState<'Name>, value: string) : DataAwsBackupReportPlanState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBackupReportPlanState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_report_plan#tags-1">DataAwsBackupReportPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBackupReportPlanState<'Name>, value: seq<string * string>) : DataAwsBackupReportPlanState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBackupReportPlanState<'Name>

        member _.Run(state: DataAwsBackupReportPlanState<Present>) : aws.DataAwsBackupReportPlan.DataAwsBackupReportPlan =
            let config = aws.DataAwsBackupReportPlan.DataAwsBackupReportPlanConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBackupReportPlan.DataAwsBackupReportPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBackupReportPlan: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBackupReportPlanState<_>) : aws.DataAwsBackupReportPlan.DataAwsBackupReportPlan =
            Unchecked.defaultof<aws.DataAwsBackupReportPlan.DataAwsBackupReportPlan>
