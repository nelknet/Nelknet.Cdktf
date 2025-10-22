namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting> = { assignments: ResizeArray<aws.BackupReportPlan.BackupReportPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan">aws_backup_report_plan</a>.
    /// </summary>
    type BackupReportPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupReportPlanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupReportPlanState<Missing, Missing, Missing>)

        member _.Zero(()) : BackupReportPlanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupReportPlanState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#name-1">BackupReportPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupReportPlanState<Missing, 'ReportDeliveryChannel, 'ReportSetting>, value: string) : BackupReportPlanState<Present, 'ReportDeliveryChannel, 'ReportSetting> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupReportPlanState<Present, 'ReportDeliveryChannel, 'ReportSetting>)

        /// <summary>
        /// report_delivery_channel block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#report_delivery_channel-1">BackupReportPlan#report_delivery_channel</a>
        /// </summary>
        [<CustomOperation "report_delivery_channel">]
        member _.ReportDeliveryChannel(state: BackupReportPlanState<'Name, Missing, 'ReportSetting>, value: aws.BackupReportPlan.BackupReportPlanReportDeliveryChannel) : BackupReportPlanState<'Name, Present, 'ReportSetting> =
            state.assignments.Add(fun config -> config.ReportDeliveryChannel <- value)
            ({ assignments = state.assignments } : BackupReportPlanState<'Name, Present, 'ReportSetting>)

        /// <summary>
        /// report_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#report_setting-1">BackupReportPlan#report_setting</a>
        /// </summary>
        [<CustomOperation "report_setting">]
        member _.ReportSetting(state: BackupReportPlanState<'Name, 'ReportDeliveryChannel, Missing>, value: aws.BackupReportPlan.BackupReportPlanReportSetting) : BackupReportPlanState<'Name, 'ReportDeliveryChannel, Present> =
            state.assignments.Add(fun config -> config.ReportSetting <- value)
            ({ assignments = state.assignments } : BackupReportPlanState<'Name, 'ReportDeliveryChannel, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#description-1">BackupReportPlan#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>, value: string) : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#id-1">BackupReportPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>, value: string) : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#tags-1">BackupReportPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>, value: seq<string * string>) : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_report_plan#tags_all-1">BackupReportPlan#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>, value: seq<string * string>) : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BackupReportPlanState<'Name, 'ReportDeliveryChannel, 'ReportSetting>

        member _.Run(state: BackupReportPlanState<Present, Present, Present>) : aws.BackupReportPlan.BackupReportPlan =
            let config = aws.BackupReportPlan.BackupReportPlanConfig()
            for setter in state.assignments do
                setter config
            aws.BackupReportPlan.BackupReportPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupReportPlan: missing required arguments. Must call: name, report_delivery_channel, report_setting.", 9999, IsError = true)>]
        member _.Run(_: BackupReportPlanState<_, _, _>) : aws.BackupReportPlan.BackupReportPlan =
            Unchecked.defaultof<aws.BackupReportPlan.BackupReportPlan>
