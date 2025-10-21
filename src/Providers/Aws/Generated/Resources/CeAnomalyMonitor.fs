namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CeAnomalyMonitorState<'MonitorType, 'Name> = { assignments: ResizeArray<aws.CeAnomalyMonitor.CeAnomalyMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor">aws_ce_anomaly_monitor</a>.
    /// </summary>
    type CeAnomalyMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : CeAnomalyMonitorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CeAnomalyMonitorState<Missing, Missing>)

        member _.Zero(()) : CeAnomalyMonitorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CeAnomalyMonitorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#monitor_type-1">CeAnomalyMonitor#monitor_type</a>.
        /// </summary>
        [<CustomOperation "monitor_type">]
        member _.MonitorType(state: CeAnomalyMonitorState<Missing, 'Name>, value: string) : CeAnomalyMonitorState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MonitorType <- value)
            ({ assignments = state.assignments } : CeAnomalyMonitorState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#name-1">CeAnomalyMonitor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CeAnomalyMonitorState<'MonitorType, Missing>, value: string) : CeAnomalyMonitorState<'MonitorType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CeAnomalyMonitorState<'MonitorType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#id-1">CeAnomalyMonitor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CeAnomalyMonitorState<'MonitorType, 'Name>, value: string) : CeAnomalyMonitorState<'MonitorType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CeAnomalyMonitorState<'MonitorType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#monitor_dimension-1">CeAnomalyMonitor#monitor_dimension</a>.
        /// </summary>
        [<CustomOperation "monitor_dimension">]
        member _.MonitorDimension(state: CeAnomalyMonitorState<'MonitorType, 'Name>, value: string) : CeAnomalyMonitorState<'MonitorType, 'Name> =
            state.assignments.Add(fun config -> config.MonitorDimension <- value)
            state : CeAnomalyMonitorState<'MonitorType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#monitor_specification-1">CeAnomalyMonitor#monitor_specification</a>.
        /// </summary>
        [<CustomOperation "monitor_specification">]
        member _.MonitorSpecification(state: CeAnomalyMonitorState<'MonitorType, 'Name>, value: string) : CeAnomalyMonitorState<'MonitorType, 'Name> =
            state.assignments.Add(fun config -> config.MonitorSpecification <- value)
            state : CeAnomalyMonitorState<'MonitorType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#tags-1">CeAnomalyMonitor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CeAnomalyMonitorState<'MonitorType, 'Name>, value: seq<string * string>) : CeAnomalyMonitorState<'MonitorType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CeAnomalyMonitorState<'MonitorType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_monitor#tags_all-1">CeAnomalyMonitor#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CeAnomalyMonitorState<'MonitorType, 'Name>, value: seq<string * string>) : CeAnomalyMonitorState<'MonitorType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CeAnomalyMonitorState<'MonitorType, 'Name>

        member _.Run(state: CeAnomalyMonitorState<Present, Present>) : aws.CeAnomalyMonitor.CeAnomalyMonitor =
            let config = aws.CeAnomalyMonitor.CeAnomalyMonitorConfig()
            for setter in state.assignments do
                setter config
            aws.CeAnomalyMonitor.CeAnomalyMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ceAnomalyMonitor: missing required arguments. Must call: monitor_type, name.", 9999, IsError = true)>]
        member _.Run(_: CeAnomalyMonitorState<_, _>) : aws.CeAnomalyMonitor.CeAnomalyMonitor =
            Unchecked.defaultof<aws.CeAnomalyMonitor.CeAnomalyMonitor>
