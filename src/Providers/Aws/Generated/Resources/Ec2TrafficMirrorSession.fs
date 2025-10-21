namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> = { assignments: ResizeArray<aws.Ec2TrafficMirrorSession.Ec2TrafficMirrorSessionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session">aws_ec2_traffic_mirror_session</a>.
    /// </summary>
    type Ec2TrafficMirrorSessionBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TrafficMirrorSessionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TrafficMirrorSessionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TrafficMirrorSessionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TrafficMirrorSessionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#network_interface_id-1">Ec2TrafficMirrorSession#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: Ec2TrafficMirrorSessionState<Missing, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: string) : Ec2TrafficMirrorSessionState<Present, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorSessionState<Present, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#session_number-1">Ec2TrafficMirrorSession#session_number</a>.
        /// </summary>
        [<CustomOperation "session_number">]
        member _.SessionNumber(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, Missing, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: double) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, Present, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.SessionNumber <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, Present, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#traffic_mirror_filter_id-1">Ec2TrafficMirrorSession#traffic_mirror_filter_id</a>.
        /// </summary>
        [<CustomOperation "traffic_mirror_filter_id">]
        member _.TrafficMirrorFilterId(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, Missing, 'TrafficMirrorTargetId>, value: string) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, Present, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.TrafficMirrorFilterId <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, Present, 'TrafficMirrorTargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#traffic_mirror_target_id-1">Ec2TrafficMirrorSession#traffic_mirror_target_id</a>.
        /// </summary>
        [<CustomOperation "traffic_mirror_target_id">]
        member _.TrafficMirrorTargetId(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, Missing>, value: string) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, Present> =
            state.assignments.Add(fun config -> config.TrafficMirrorTargetId <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#description-1">Ec2TrafficMirrorSession#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: string) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#id-1">Ec2TrafficMirrorSession#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: string) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#packet_length-1">Ec2TrafficMirrorSession#packet_length</a>.
        /// </summary>
        [<CustomOperation "packet_length">]
        member _.PacketLength(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: double) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.PacketLength <- value)
            state : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#tags-1">Ec2TrafficMirrorSession#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: seq<string * string>) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#tags_all-1">Ec2TrafficMirrorSession#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: seq<string * string>) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_session#virtual_network_id-1">Ec2TrafficMirrorSession#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>, value: double) : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            state : Ec2TrafficMirrorSessionState<'NetworkInterfaceId, 'SessionNumber, 'TrafficMirrorFilterId, 'TrafficMirrorTargetId>

        member _.Run(state: Ec2TrafficMirrorSessionState<Present, Present, Present, Present>) : aws.Ec2TrafficMirrorSession.Ec2TrafficMirrorSession =
            let config = aws.Ec2TrafficMirrorSession.Ec2TrafficMirrorSessionConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TrafficMirrorSession.Ec2TrafficMirrorSession(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TrafficMirrorSession: missing required arguments. Must call: network_interface_id, session_number, traffic_mirror_filter_id, traffic_mirror_target_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TrafficMirrorSessionState<_, _, _, _>) : aws.Ec2TrafficMirrorSession.Ec2TrafficMirrorSession =
            Unchecked.defaultof<aws.Ec2TrafficMirrorSession.Ec2TrafficMirrorSession>
