namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> = { assignments: ResizeArray<aws.NetworkmanagerConnection.NetworkmanagerConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection">aws_networkmanager_connection</a>.
    /// </summary>
    type NetworkmanagerConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#connected_device_id-1">NetworkmanagerConnection#connected_device_id</a>.
        /// </summary>
        [<CustomOperation "connected_device_id">]
        member _.ConnectedDeviceId(state: NetworkmanagerConnectionState<Missing, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerConnectionState<Present, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.ConnectedDeviceId <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectionState<Present, 'DeviceId, 'GlobalNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#device_id-1">NetworkmanagerConnection#device_id</a>.
        /// </summary>
        [<CustomOperation "device_id">]
        member _.DeviceId(state: NetworkmanagerConnectionState<'ConnectedDeviceId, Missing, 'GlobalNetworkId>, value: string) : NetworkmanagerConnectionState<'ConnectedDeviceId, Present, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.DeviceId <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectionState<'ConnectedDeviceId, Present, 'GlobalNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#global_network_id-1">NetworkmanagerConnection#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, Missing>, value: string) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#connected_link_id-1">NetworkmanagerConnection#connected_link_id</a>.
        /// </summary>
        [<CustomOperation "connected_link_id">]
        member _.ConnectedLinkId(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.ConnectedLinkId <- value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#description-1">NetworkmanagerConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#id-1">NetworkmanagerConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#link_id-1">NetworkmanagerConnection#link_id</a>.
        /// </summary>
        [<CustomOperation "link_id">]
        member _.LinkId(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.LinkId <- value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#tags-1">NetworkmanagerConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#tags_all-1">NetworkmanagerConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connection#timeouts-1">NetworkmanagerConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>, value: aws.NetworkmanagerConnection.NetworkmanagerConnectionTimeouts) : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerConnectionState<'ConnectedDeviceId, 'DeviceId, 'GlobalNetworkId>

        member _.Run(state: NetworkmanagerConnectionState<Present, Present, Present>) : aws.NetworkmanagerConnection.NetworkmanagerConnection =
            let config = aws.NetworkmanagerConnection.NetworkmanagerConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerConnection.NetworkmanagerConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerConnection: missing required arguments. Must call: connected_device_id, device_id, global_network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerConnectionState<_, _, _>) : aws.NetworkmanagerConnection.NetworkmanagerConnection =
            Unchecked.defaultof<aws.NetworkmanagerConnection.NetworkmanagerConnection>
