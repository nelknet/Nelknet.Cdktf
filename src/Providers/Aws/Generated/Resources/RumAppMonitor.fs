namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RumAppMonitorState<'Name> = { assignments: ResizeArray<aws.RumAppMonitor.RumAppMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor">aws_rum_app_monitor</a>.
    /// </summary>
    type RumAppMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : RumAppMonitorState<Missing> =
            ({ assignments = ResizeArray() } : RumAppMonitorState<Missing>)

        member _.Zero(()) : RumAppMonitorState<Missing> =
            ({ assignments = ResizeArray() } : RumAppMonitorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#name-1">RumAppMonitor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RumAppMonitorState<Missing>, value: string) : RumAppMonitorState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RumAppMonitorState<Present>)

        /// <summary>
        /// app_monitor_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#app_monitor_configuration-1">RumAppMonitor#app_monitor_configuration</a>
        /// </summary>
        [<CustomOperation "app_monitor_configuration">]
        member _.AppMonitorConfiguration(state: RumAppMonitorState<'Name>, value: aws.RumAppMonitor.RumAppMonitorAppMonitorConfiguration) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.AppMonitorConfiguration <- value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// custom_events block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#custom_events-1">RumAppMonitor#custom_events</a>
        /// </summary>
        [<CustomOperation "custom_events">]
        member _.CustomEvents(state: RumAppMonitorState<'Name>, value: aws.RumAppMonitor.RumAppMonitorCustomEvents) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.CustomEvents <- value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#cw_log_enabled-1">RumAppMonitor#cw_log_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cw_log_enabled">]
        member _.CwLogEnabled(state: RumAppMonitorState<'Name>, value: bool) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.CwLogEnabled <- value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#cw_log_enabled-1">RumAppMonitor#cw_log_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cw_log_enabled">]
        member _.CwLogEnabled(state: RumAppMonitorState<'Name>, value: HashiCorp.Cdktf.IResolvable) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.CwLogEnabled <- value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#domain-1">RumAppMonitor#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: RumAppMonitorState<'Name>, value: string) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#domain_list-1">RumAppMonitor#domain_list</a>.
        /// </summary>
        [<CustomOperation "domain_list">]
        member _.DomainList(state: RumAppMonitorState<'Name>, value: seq<string>) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.DomainList <- (value |> Seq.toArray))
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#id-1">RumAppMonitor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RumAppMonitorState<'Name>, value: string) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#tags-1">RumAppMonitor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RumAppMonitorState<'Name>, value: seq<string * string>) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RumAppMonitorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#tags_all-1">RumAppMonitor#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RumAppMonitorState<'Name>, value: seq<string * string>) : RumAppMonitorState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RumAppMonitorState<'Name>

        member _.Run(state: RumAppMonitorState<Present>) : aws.RumAppMonitor.RumAppMonitor =
            let config = aws.RumAppMonitor.RumAppMonitorConfig()
            for setter in state.assignments do
                setter config
            aws.RumAppMonitor.RumAppMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rumAppMonitor: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: RumAppMonitorState<_>) : aws.RumAppMonitor.RumAppMonitor =
            Unchecked.defaultof<aws.RumAppMonitor.RumAppMonitor>
