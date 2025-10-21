namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> = { assignments: ResizeArray<aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query">aws_timestreamquery_scheduled_query</a>.
    /// </summary>
    type TimestreamqueryScheduledQueryBuilder(logicalId: string) =
        member _.Yield(_: unit) : TimestreamqueryScheduledQueryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TimestreamqueryScheduledQueryState<Missing, Missing, Missing>)

        member _.Zero(()) : TimestreamqueryScheduledQueryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TimestreamqueryScheduledQueryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#execution_role_arn-1">TimestreamqueryScheduledQuery#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: TimestreamqueryScheduledQueryState<Missing, 'Name, 'QueryString>, value: string) : TimestreamqueryScheduledQueryState<Present, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            ({ assignments = state.assignments } : TimestreamqueryScheduledQueryState<Present, 'Name, 'QueryString>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#name-1">TimestreamqueryScheduledQuery#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, Missing, 'QueryString>, value: string) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, Present, 'QueryString> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, Present, 'QueryString>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#query_string-1">TimestreamqueryScheduledQuery#query_string</a>.
        /// </summary>
        [<CustomOperation "query_string">]
        member _.QueryString(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, Missing>, value: string) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, Present> =
            state.assignments.Add(fun config -> config.QueryString <- value)
            ({ assignments = state.assignments } : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, Present>)

        /// <summary>
        /// error_report_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#error_report_configuration-1">TimestreamqueryScheduledQuery#error_report_configuration</a> Accepts: aws.IResolvable | aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfiguration[]
        /// </summary>
        [<CustomOperation "error_report_configuration">]
        member _.ErrorReportConfiguration(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: HashiCorp.Cdktf.IResolvable) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.ErrorReportConfiguration <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#kms_key_id-1">TimestreamqueryScheduledQuery#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: string) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// last_run_summary block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#last_run_summary-1">TimestreamqueryScheduledQuery#last_run_summary</a> Accepts: aws.IResolvable | aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummary[]
        /// </summary>
        [<CustomOperation "last_run_summary">]
        member _.LastRunSummary(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: HashiCorp.Cdktf.IResolvable) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.LastRunSummary <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// notification_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#notification_configuration-1">TimestreamqueryScheduledQuery#notification_configuration</a> Accepts: aws.IResolvable | aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryNotificationConfiguration[]
        /// </summary>
        [<CustomOperation "notification_configuration">]
        member _.NotificationConfiguration(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: HashiCorp.Cdktf.IResolvable) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.NotificationConfiguration <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// recently_failed_runs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#recently_failed_runs-1">TimestreamqueryScheduledQuery#recently_failed_runs</a> Accepts: aws.IResolvable | aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRuns[]
        /// </summary>
        [<CustomOperation "recently_failed_runs">]
        member _.RecentlyFailedRuns(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: HashiCorp.Cdktf.IResolvable) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.RecentlyFailedRuns <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// schedule_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#schedule_configuration-1">TimestreamqueryScheduledQuery#schedule_configuration</a> Accepts: aws.IResolvable | aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryScheduleConfiguration[]
        /// </summary>
        [<CustomOperation "schedule_configuration">]
        member _.ScheduleConfiguration(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: HashiCorp.Cdktf.IResolvable) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.ScheduleConfiguration <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#tags-1">TimestreamqueryScheduledQuery#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: seq<string * string>) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// target_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#target_configuration-1">TimestreamqueryScheduledQuery#target_configuration</a> Accepts: aws.IResolvable | aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfiguration[]
        /// </summary>
        [<CustomOperation "target_configuration">]
        member _.TargetConfiguration(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: HashiCorp.Cdktf.IResolvable) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.TargetConfiguration <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#timeouts-1">TimestreamqueryScheduledQuery#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>, value: aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTimeouts) : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TimestreamqueryScheduledQueryState<'ExecutionRoleArn, 'Name, 'QueryString>

        member _.Run(state: TimestreamqueryScheduledQueryState<Present, Present, Present>) : aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQuery =
            let config = aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQueryConfig()
            for setter in state.assignments do
                setter config
            aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQuery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.timestreamqueryScheduledQuery: missing required arguments. Must call: execution_role_arn, name, query_string.", 9999, IsError = true)>]
        member _.Run(_: TimestreamqueryScheduledQueryState<_, _, _>) : aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQuery =
            Unchecked.defaultof<aws.TimestreamqueryScheduledQuery.TimestreamqueryScheduledQuery>
