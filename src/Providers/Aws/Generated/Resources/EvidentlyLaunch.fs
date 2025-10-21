namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EvidentlyLaunchState<'Groups, 'Name, 'Project> = { assignments: ResizeArray<aws.EvidentlyLaunch.EvidentlyLaunchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch">aws_evidently_launch</a>.
    /// </summary>
    type EvidentlyLaunchBuilder(logicalId: string) =
        member _.Yield(_: unit) : EvidentlyLaunchState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EvidentlyLaunchState<Missing, Missing, Missing>)

        member _.Zero(()) : EvidentlyLaunchState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EvidentlyLaunchState<Missing, Missing, Missing>)

        /// <summary>
        /// groups block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#groups-1">EvidentlyLaunch#groups</a> Accepts: aws.IResolvable | aws.EvidentlyLaunch.EvidentlyLaunchGroups[]
        /// </summary>
        [<CustomOperation "groups">]
        member _.Groups(state: EvidentlyLaunchState<Missing, 'Name, 'Project>, value: HashiCorp.Cdktf.IResolvable) : EvidentlyLaunchState<Present, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.Groups <- value)
            ({ assignments = state.assignments } : EvidentlyLaunchState<Present, 'Name, 'Project>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#name-1">EvidentlyLaunch#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EvidentlyLaunchState<'Groups, Missing, 'Project>, value: string) : EvidentlyLaunchState<'Groups, Present, 'Project> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EvidentlyLaunchState<'Groups, Present, 'Project>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#project-1">EvidentlyLaunch#project</a>.
        /// </summary>
        [<CustomOperation "project">]
        member _.Project(state: EvidentlyLaunchState<'Groups, 'Name, Missing>, value: string) : EvidentlyLaunchState<'Groups, 'Name, Present> =
            state.assignments.Add(fun config -> config.Project <- value)
            ({ assignments = state.assignments } : EvidentlyLaunchState<'Groups, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#description-1">EvidentlyLaunch#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: string) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#id-1">EvidentlyLaunch#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: string) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// metric_monitors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#metric_monitors-1">EvidentlyLaunch#metric_monitors</a> Accepts: aws.IResolvable | aws.EvidentlyLaunch.EvidentlyLaunchMetricMonitors[]
        /// </summary>
        [<CustomOperation "metric_monitors">]
        member _.MetricMonitors(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: HashiCorp.Cdktf.IResolvable) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.MetricMonitors <- value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#randomization_salt-1">EvidentlyLaunch#randomization_salt</a>.
        /// </summary>
        [<CustomOperation "randomization_salt">]
        member _.RandomizationSalt(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: string) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.RandomizationSalt <- value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// scheduled_splits_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#scheduled_splits_config-1">EvidentlyLaunch#scheduled_splits_config</a>
        /// </summary>
        [<CustomOperation "scheduled_splits_config">]
        member _.ScheduledSplitsConfig(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: aws.EvidentlyLaunch.EvidentlyLaunchScheduledSplitsConfig) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.ScheduledSplitsConfig <- value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#tags-1">EvidentlyLaunch#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: seq<string * string>) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#tags_all-1">EvidentlyLaunch#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: seq<string * string>) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#timeouts-1">EvidentlyLaunch#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EvidentlyLaunchState<'Groups, 'Name, 'Project>, value: aws.EvidentlyLaunch.EvidentlyLaunchTimeouts) : EvidentlyLaunchState<'Groups, 'Name, 'Project> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EvidentlyLaunchState<'Groups, 'Name, 'Project>

        member _.Run(state: EvidentlyLaunchState<Present, Present, Present>) : aws.EvidentlyLaunch.EvidentlyLaunch =
            let config = aws.EvidentlyLaunch.EvidentlyLaunchConfig()
            for setter in state.assignments do
                setter config
            aws.EvidentlyLaunch.EvidentlyLaunch(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.evidentlyLaunch: missing required arguments. Must call: groups, name, project.", 9999, IsError = true)>]
        member _.Run(_: EvidentlyLaunchState<_, _, _>) : aws.EvidentlyLaunch.EvidentlyLaunch =
            Unchecked.defaultof<aws.EvidentlyLaunch.EvidentlyLaunch>
