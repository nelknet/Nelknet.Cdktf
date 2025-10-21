namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmonitorMonitorState<'MonitorName> = { assignments: ResizeArray<aws.NetworkmonitorMonitor.NetworkmonitorMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_monitor">aws_networkmonitor_monitor</a>.
    /// </summary>
    type NetworkmonitorMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmonitorMonitorState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmonitorMonitorState<Missing>)

        member _.Zero(()) : NetworkmonitorMonitorState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmonitorMonitorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_monitor#monitor_name-1">NetworkmonitorMonitor#monitor_name</a>.
        /// </summary>
        [<CustomOperation "monitor_name">]
        member _.MonitorName(state: NetworkmonitorMonitorState<Missing>, value: string) : NetworkmonitorMonitorState<Present> =
            state.assignments.Add(fun config -> config.MonitorName <- value)
            ({ assignments = state.assignments } : NetworkmonitorMonitorState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_monitor#aggregation_period-1">NetworkmonitorMonitor#aggregation_period</a>.
        /// </summary>
        [<CustomOperation "aggregation_period">]
        member _.AggregationPeriod(state: NetworkmonitorMonitorState<'MonitorName>, value: double) : NetworkmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.AggregationPeriod <- value)
            state : NetworkmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_monitor#tags-1">NetworkmonitorMonitor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmonitorMonitorState<'MonitorName>, value: seq<string * string>) : NetworkmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmonitorMonitorState<'MonitorName>

        member _.Run(state: NetworkmonitorMonitorState<Present>) : aws.NetworkmonitorMonitor.NetworkmonitorMonitor =
            let config = aws.NetworkmonitorMonitor.NetworkmonitorMonitorConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmonitorMonitor.NetworkmonitorMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmonitorMonitor: missing required arguments. Must call: monitor_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkmonitorMonitorState<_>) : aws.NetworkmonitorMonitor.NetworkmonitorMonitor =
            Unchecked.defaultof<aws.NetworkmonitorMonitor.NetworkmonitorMonitor>
