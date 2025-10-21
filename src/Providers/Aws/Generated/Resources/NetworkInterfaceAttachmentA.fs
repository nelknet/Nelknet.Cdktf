namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, 'NetworkInterfaceId> = { assignments: ResizeArray<aws.NetworkInterfaceAttachment.NetworkInterfaceAttachmentAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_attachment">aws_network_interface_attachment</a>.
    /// </summary>
    type NetworkInterfaceAttachmentABuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceAttachmentAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceAttachmentAState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceAttachmentAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceAttachmentAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_attachment#device_index-1">NetworkInterfaceAttachmentA#device_index</a>.
        /// </summary>
        [<CustomOperation "device_index">]
        member _.DeviceIndex(state: NetworkInterfaceAttachmentAState<Missing, 'InstanceId, 'NetworkInterfaceId>, value: double) : NetworkInterfaceAttachmentAState<Present, 'InstanceId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.DeviceIndex <- value)
            ({ assignments = state.assignments } : NetworkInterfaceAttachmentAState<Present, 'InstanceId, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_attachment#instance_id-1">NetworkInterfaceAttachmentA#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: NetworkInterfaceAttachmentAState<'DeviceIndex, Missing, 'NetworkInterfaceId>, value: string) : NetworkInterfaceAttachmentAState<'DeviceIndex, Present, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceAttachmentAState<'DeviceIndex, Present, 'NetworkInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_attachment#network_interface_id-1">NetworkInterfaceAttachmentA#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, Missing>, value: string) : NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, Present> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_attachment#id-1">NetworkInterfaceAttachmentA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, 'NetworkInterfaceId>, value: string) : NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, 'NetworkInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceAttachmentAState<'DeviceIndex, 'InstanceId, 'NetworkInterfaceId>

        member _.Run(state: NetworkInterfaceAttachmentAState<Present, Present, Present>) : aws.NetworkInterfaceAttachment.NetworkInterfaceAttachmentA =
            let config = aws.NetworkInterfaceAttachment.NetworkInterfaceAttachmentAConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkInterfaceAttachment.NetworkInterfaceAttachmentA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkInterfaceAttachmentA: missing required arguments. Must call: device_index, instance_id, network_interface_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceAttachmentAState<_, _, _>) : aws.NetworkInterfaceAttachment.NetworkInterfaceAttachmentA =
            Unchecked.defaultof<aws.NetworkInterfaceAttachment.NetworkInterfaceAttachmentA>
