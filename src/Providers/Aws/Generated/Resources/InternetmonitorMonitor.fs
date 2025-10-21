namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InternetmonitorMonitorState<'MonitorName> = { assignments: ResizeArray<aws.InternetmonitorMonitor.InternetmonitorMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor">aws_internetmonitor_monitor</a>.
    /// </summary>
    type InternetmonitorMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : InternetmonitorMonitorState<Missing> =
            ({ assignments = ResizeArray() } : InternetmonitorMonitorState<Missing>)

        member _.Zero(()) : InternetmonitorMonitorState<Missing> =
            ({ assignments = ResizeArray() } : InternetmonitorMonitorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#monitor_name-1">InternetmonitorMonitor#monitor_name</a>.
        /// </summary>
        [<CustomOperation "monitor_name">]
        member _.MonitorName(state: InternetmonitorMonitorState<Missing>, value: string) : InternetmonitorMonitorState<Present> =
            state.assignments.Add(fun config -> config.MonitorName <- value)
            ({ assignments = state.assignments } : InternetmonitorMonitorState<Present>)

        /// <summary>
        /// health_events_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#health_events_config-1">InternetmonitorMonitor#health_events_config</a>
        /// </summary>
        [<CustomOperation "health_events_config">]
        member _.HealthEventsConfig(state: InternetmonitorMonitorState<'MonitorName>, value: aws.InternetmonitorMonitor.InternetmonitorMonitorHealthEventsConfig) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.HealthEventsConfig <- value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#id-1">InternetmonitorMonitor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InternetmonitorMonitorState<'MonitorName>, value: string) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// internet_measurements_log_delivery block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#internet_measurements_log_delivery-1">InternetmonitorMonitor#internet_measurements_log_delivery</a>
        /// </summary>
        [<CustomOperation "internet_measurements_log_delivery">]
        member _.InternetMeasurementsLogDelivery(state: InternetmonitorMonitorState<'MonitorName>, value: aws.InternetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDelivery) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.InternetMeasurementsLogDelivery <- value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#max_city_networks_to_monitor-1">InternetmonitorMonitor#max_city_networks_to_monitor</a>.
        /// </summary>
        [<CustomOperation "max_city_networks_to_monitor">]
        member _.MaxCityNetworksToMonitor(state: InternetmonitorMonitorState<'MonitorName>, value: double) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.MaxCityNetworksToMonitor <- value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#resources-1">InternetmonitorMonitor#resources</a>.
        /// </summary>
        [<CustomOperation "resources">]
        member _.Resources(state: InternetmonitorMonitorState<'MonitorName>, value: seq<string>) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.Resources <- (value |> Seq.toArray))
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#status-1">InternetmonitorMonitor#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: InternetmonitorMonitorState<'MonitorName>, value: string) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#tags-1">InternetmonitorMonitor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: InternetmonitorMonitorState<'MonitorName>, value: seq<string * string>) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#tags_all-1">InternetmonitorMonitor#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: InternetmonitorMonitorState<'MonitorName>, value: seq<string * string>) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : InternetmonitorMonitorState<'MonitorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internetmonitor_monitor#traffic_percentage_to_monitor-1">InternetmonitorMonitor#traffic_percentage_to_monitor</a>.
        /// </summary>
        [<CustomOperation "traffic_percentage_to_monitor">]
        member _.TrafficPercentageToMonitor(state: InternetmonitorMonitorState<'MonitorName>, value: double) : InternetmonitorMonitorState<'MonitorName> =
            state.assignments.Add(fun config -> config.TrafficPercentageToMonitor <- value)
            state : InternetmonitorMonitorState<'MonitorName>

        member _.Run(state: InternetmonitorMonitorState<Present>) : aws.InternetmonitorMonitor.InternetmonitorMonitor =
            let config = aws.InternetmonitorMonitor.InternetmonitorMonitorConfig()
            for setter in state.assignments do
                setter config
            aws.InternetmonitorMonitor.InternetmonitorMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.internetmonitorMonitor: missing required arguments. Must call: monitor_name.", 9999, IsError = true)>]
        member _.Run(_: InternetmonitorMonitorState<_>) : aws.InternetmonitorMonitor.InternetmonitorMonitor =
            Unchecked.defaultof<aws.InternetmonitorMonitor.InternetmonitorMonitor>
