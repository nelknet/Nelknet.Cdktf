namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> = { assignments: ResizeArray<aws.SsmMaintenanceWindow.SsmMaintenanceWindowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window">aws_ssm_maintenance_window</a>.
    /// </summary>
    type SsmMaintenanceWindowBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmMaintenanceWindowState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmMaintenanceWindowState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SsmMaintenanceWindowState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmMaintenanceWindowState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#cutoff-1">SsmMaintenanceWindow#cutoff</a>.
        /// </summary>
        [<CustomOperation "cutoff">]
        member _.Cutoff(state: SsmMaintenanceWindowState<Missing, 'Duration, 'Name, 'Schedule>, value: double) : SsmMaintenanceWindowState<Present, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Cutoff <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowState<Present, 'Duration, 'Name, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#duration-1">SsmMaintenanceWindow#duration</a>.
        /// </summary>
        [<CustomOperation "duration">]
        member _.Duration(state: SsmMaintenanceWindowState<'Cutoff, Missing, 'Name, 'Schedule>, value: double) : SsmMaintenanceWindowState<'Cutoff, Present, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Duration <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowState<'Cutoff, Present, 'Name, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#name-1">SsmMaintenanceWindow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, Missing, 'Schedule>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, Present, 'Schedule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowState<'Cutoff, 'Duration, Present, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#schedule-1">SsmMaintenanceWindow#schedule</a>.
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, Missing>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, Present> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#allow_unassociated_targets-1">SsmMaintenanceWindow#allow_unassociated_targets</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_unassociated_targets">]
        member _.AllowUnassociatedTargets(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: bool) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.AllowUnassociatedTargets <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#allow_unassociated_targets-1">SsmMaintenanceWindow#allow_unassociated_targets</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_unassociated_targets">]
        member _.AllowUnassociatedTargets(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: HashiCorp.Cdktf.IResolvable) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.AllowUnassociatedTargets <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#description-1">SsmMaintenanceWindow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#enabled-1">SsmMaintenanceWindow#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: bool) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#enabled-1">SsmMaintenanceWindow#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: HashiCorp.Cdktf.IResolvable) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#end_date-1">SsmMaintenanceWindow#end_date</a>.
        /// </summary>
        [<CustomOperation "end_date">]
        member _.EndDate(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.EndDate <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#id-1">SsmMaintenanceWindow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#schedule_offset-1">SsmMaintenanceWindow#schedule_offset</a>.
        /// </summary>
        [<CustomOperation "schedule_offset">]
        member _.ScheduleOffset(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: double) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.ScheduleOffset <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#schedule_timezone-1">SsmMaintenanceWindow#schedule_timezone</a>.
        /// </summary>
        [<CustomOperation "schedule_timezone">]
        member _.ScheduleTimezone(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.ScheduleTimezone <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#start_date-1">SsmMaintenanceWindow#start_date</a>.
        /// </summary>
        [<CustomOperation "start_date">]
        member _.StartDate(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: string) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.StartDate <- value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#tags-1">SsmMaintenanceWindow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: seq<string * string>) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window#tags_all-1">SsmMaintenanceWindow#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>, value: seq<string * string>) : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmMaintenanceWindowState<'Cutoff, 'Duration, 'Name, 'Schedule>

        member _.Run(state: SsmMaintenanceWindowState<Present, Present, Present, Present>) : aws.SsmMaintenanceWindow.SsmMaintenanceWindow =
            let config = aws.SsmMaintenanceWindow.SsmMaintenanceWindowConfig()
            for setter in state.assignments do
                setter config
            aws.SsmMaintenanceWindow.SsmMaintenanceWindow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmMaintenanceWindow: missing required arguments. Must call: cutoff, duration, name, schedule.", 9999, IsError = true)>]
        member _.Run(_: SsmMaintenanceWindowState<_, _, _, _>) : aws.SsmMaintenanceWindow.SsmMaintenanceWindow =
            Unchecked.defaultof<aws.SsmMaintenanceWindow.SsmMaintenanceWindow>
