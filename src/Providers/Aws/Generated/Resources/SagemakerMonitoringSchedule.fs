namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerMonitoringScheduleState<'MonitoringScheduleConfig> = { assignments: ResizeArray<aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_monitoring_schedule">aws_sagemaker_monitoring_schedule</a>.
    /// </summary>
    type SagemakerMonitoringScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerMonitoringScheduleState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerMonitoringScheduleState<Missing>)

        member _.Zero(()) : SagemakerMonitoringScheduleState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerMonitoringScheduleState<Missing>)

        /// <summary>
        /// monitoring_schedule_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_monitoring_schedule#monitoring_schedule_config-1">SagemakerMonitoringSchedule#monitoring_schedule_config</a>
        /// </summary>
        [<CustomOperation "monitoring_schedule_config">]
        member _.MonitoringScheduleConfig(state: SagemakerMonitoringScheduleState<Missing>, value: aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfig) : SagemakerMonitoringScheduleState<Present> =
            state.assignments.Add(fun config -> config.MonitoringScheduleConfig <- value)
            ({ assignments = state.assignments } : SagemakerMonitoringScheduleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_monitoring_schedule#id-1">SagemakerMonitoringSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>, value: string) : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_monitoring_schedule#name-1">SagemakerMonitoringSchedule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>, value: string) : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_monitoring_schedule#tags-1">SagemakerMonitoringSchedule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>, value: seq<string * string>) : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_monitoring_schedule#tags_all-1">SagemakerMonitoringSchedule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>, value: seq<string * string>) : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerMonitoringScheduleState<'MonitoringScheduleConfig>

        member _.Run(state: SagemakerMonitoringScheduleState<Present>) : aws.SagemakerMonitoringSchedule.SagemakerMonitoringSchedule =
            let config = aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerMonitoringSchedule.SagemakerMonitoringSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerMonitoringSchedule: missing required arguments. Must call: monitoring_schedule_config.", 9999, IsError = true)>]
        member _.Run(_: SagemakerMonitoringScheduleState<_>) : aws.SagemakerMonitoringSchedule.SagemakerMonitoringSchedule =
            Unchecked.defaultof<aws.SagemakerMonitoringSchedule.SagemakerMonitoringSchedule>
