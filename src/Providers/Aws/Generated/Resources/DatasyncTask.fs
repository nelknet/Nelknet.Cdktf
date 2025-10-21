namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> = { assignments: ResizeArray<aws.DatasyncTask.DatasyncTaskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task">aws_datasync_task</a>.
    /// </summary>
    type DatasyncTaskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncTaskState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncTaskState<Missing, Missing>)

        member _.Zero(()) : DatasyncTaskState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncTaskState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#destination_location_arn-1">DatasyncTask#destination_location_arn</a>.
        /// </summary>
        [<CustomOperation "destination_location_arn">]
        member _.DestinationLocationArn(state: DatasyncTaskState<Missing, 'SourceLocationArn>, value: string) : DatasyncTaskState<Present, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.DestinationLocationArn <- value)
            ({ assignments = state.assignments } : DatasyncTaskState<Present, 'SourceLocationArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#source_location_arn-1">DatasyncTask#source_location_arn</a>.
        /// </summary>
        [<CustomOperation "source_location_arn">]
        member _.SourceLocationArn(state: DatasyncTaskState<'DestinationLocationArn, Missing>, value: string) : DatasyncTaskState<'DestinationLocationArn, Present> =
            state.assignments.Add(fun config -> config.SourceLocationArn <- value)
            ({ assignments = state.assignments } : DatasyncTaskState<'DestinationLocationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#cloudwatch_log_group_arn-1">DatasyncTask#cloudwatch_log_group_arn</a>.
        /// </summary>
        [<CustomOperation "cloudwatch_log_group_arn">]
        member _.CloudwatchLogGroupArn(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: string) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.CloudwatchLogGroupArn <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// excludes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#excludes-1">DatasyncTask#excludes</a>
        /// </summary>
        [<CustomOperation "excludes">]
        member _.Excludes(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: aws.DatasyncTask.DatasyncTaskExcludes) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Excludes <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#id-1">DatasyncTask#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: string) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// includes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#includes-1">DatasyncTask#includes</a>
        /// </summary>
        [<CustomOperation "includes">]
        member _.Includes(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: aws.DatasyncTask.DatasyncTaskIncludes) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Includes <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#name-1">DatasyncTask#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: string) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#options-1">DatasyncTask#options</a>
        /// </summary>
        [<CustomOperation "options">]
        member _.Options(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: aws.DatasyncTask.DatasyncTaskOptions) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Options <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#schedule-1">DatasyncTask#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: aws.DatasyncTask.DatasyncTaskSchedule) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#tags-1">DatasyncTask#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: seq<string * string>) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#tags_all-1">DatasyncTask#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: seq<string * string>) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#task_mode-1">DatasyncTask#task_mode</a>.
        /// </summary>
        [<CustomOperation "task_mode">]
        member _.TaskMode(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: string) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.TaskMode <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// task_report_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#task_report_config-1">DatasyncTask#task_report_config</a>
        /// </summary>
        [<CustomOperation "task_report_config">]
        member _.TaskReportConfig(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: aws.DatasyncTask.DatasyncTaskTaskReportConfig) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.TaskReportConfig <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#timeouts-1">DatasyncTask#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>, value: aws.DatasyncTask.DatasyncTaskTimeouts) : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatasyncTaskState<'DestinationLocationArn, 'SourceLocationArn>

        member _.Run(state: DatasyncTaskState<Present, Present>) : aws.DatasyncTask.DatasyncTask =
            let config = aws.DatasyncTask.DatasyncTaskConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncTask.DatasyncTask(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncTask: missing required arguments. Must call: destination_location_arn, source_location_arn.", 9999, IsError = true)>]
        member _.Run(_: DatasyncTaskState<_, _>) : aws.DatasyncTask.DatasyncTask =
            Unchecked.defaultof<aws.DatasyncTask.DatasyncTask>
