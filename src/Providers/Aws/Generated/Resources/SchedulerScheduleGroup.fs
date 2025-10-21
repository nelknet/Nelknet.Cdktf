namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SchedulerScheduleGroupState = { assignments: ResizeArray<aws.SchedulerScheduleGroup.SchedulerScheduleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group">aws_scheduler_schedule_group</a>.
    /// </summary>
    type SchedulerScheduleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SchedulerScheduleGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SchedulerScheduleGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group#id-1">SchedulerScheduleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SchedulerScheduleGroupState, value: string) : SchedulerScheduleGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SchedulerScheduleGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group#name-1">SchedulerScheduleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SchedulerScheduleGroupState, value: string) : SchedulerScheduleGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SchedulerScheduleGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group#name_prefix-1">SchedulerScheduleGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SchedulerScheduleGroupState, value: string) : SchedulerScheduleGroupState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SchedulerScheduleGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group#tags-1">SchedulerScheduleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SchedulerScheduleGroupState, value: seq<string * string>) : SchedulerScheduleGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SchedulerScheduleGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group#tags_all-1">SchedulerScheduleGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SchedulerScheduleGroupState, value: seq<string * string>) : SchedulerScheduleGroupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SchedulerScheduleGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule_group#timeouts-1">SchedulerScheduleGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SchedulerScheduleGroupState, value: aws.SchedulerScheduleGroup.SchedulerScheduleGroupTimeouts) : SchedulerScheduleGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SchedulerScheduleGroupState

        member _.Run(state: SchedulerScheduleGroupState) : aws.SchedulerScheduleGroup.SchedulerScheduleGroup =
            let config = aws.SchedulerScheduleGroup.SchedulerScheduleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.SchedulerScheduleGroup.SchedulerScheduleGroup(StackContext.get (), logicalId, config)
