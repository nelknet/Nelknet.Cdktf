namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn> = { assignments: ResizeArray<aws.NetworkmonitorProbe.NetworkmonitorProbeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe">aws_networkmonitor_probe</a>.
    /// </summary>
    type NetworkmonitorProbeBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmonitorProbeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmonitorProbeState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmonitorProbeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmonitorProbeState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#destination-1">NetworkmonitorProbe#destination</a>.
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: NetworkmonitorProbeState<Missing, 'MonitorName, 'Protocol, 'SourceArn>, value: string) : NetworkmonitorProbeState<Present, 'MonitorName, 'Protocol, 'SourceArn> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : NetworkmonitorProbeState<Present, 'MonitorName, 'Protocol, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#monitor_name-1">NetworkmonitorProbe#monitor_name</a>.
        /// </summary>
        [<CustomOperation "monitor_name">]
        member _.MonitorName(state: NetworkmonitorProbeState<'Destination, Missing, 'Protocol, 'SourceArn>, value: string) : NetworkmonitorProbeState<'Destination, Present, 'Protocol, 'SourceArn> =
            state.assignments.Add(fun config -> config.MonitorName <- value)
            ({ assignments = state.assignments } : NetworkmonitorProbeState<'Destination, Present, 'Protocol, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#protocol-1">NetworkmonitorProbe#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: NetworkmonitorProbeState<'Destination, 'MonitorName, Missing, 'SourceArn>, value: string) : NetworkmonitorProbeState<'Destination, 'MonitorName, Present, 'SourceArn> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : NetworkmonitorProbeState<'Destination, 'MonitorName, Present, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#source_arn-1">NetworkmonitorProbe#source_arn</a>.
        /// </summary>
        [<CustomOperation "source_arn">]
        member _.SourceArn(state: NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, Missing>, value: string) : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.SourceArn <- value)
            ({ assignments = state.assignments } : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#destination_port-1">NetworkmonitorProbe#destination_port</a>.
        /// </summary>
        [<CustomOperation "destination_port">]
        member _.DestinationPort(state: NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn>, value: double) : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn> =
            state.assignments.Add(fun config -> config.DestinationPort <- value)
            state : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#packet_size-1">NetworkmonitorProbe#packet_size</a>.
        /// </summary>
        [<CustomOperation "packet_size">]
        member _.PacketSize(state: NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn>, value: double) : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn> =
            state.assignments.Add(fun config -> config.PacketSize <- value)
            state : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmonitor_probe#tags-1">NetworkmonitorProbe#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn>, value: seq<string * string>) : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmonitorProbeState<'Destination, 'MonitorName, 'Protocol, 'SourceArn>

        member _.Run(state: NetworkmonitorProbeState<Present, Present, Present, Present>) : aws.NetworkmonitorProbe.NetworkmonitorProbe =
            let config = aws.NetworkmonitorProbe.NetworkmonitorProbeConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmonitorProbe.NetworkmonitorProbe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmonitorProbe: missing required arguments. Must call: destination, monitor_name, protocol, source_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmonitorProbeState<_, _, _, _>) : aws.NetworkmonitorProbe.NetworkmonitorProbe =
            Unchecked.defaultof<aws.NetworkmonitorProbe.NetworkmonitorProbe>
