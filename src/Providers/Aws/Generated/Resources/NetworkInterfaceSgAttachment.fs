namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId> = { assignments: ResizeArray<aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_sg_attachment">aws_network_interface_sg_attachment</a>.
    /// </summary>
    type NetworkInterfaceSgAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceSgAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceSgAttachmentState<Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceSgAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceSgAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_sg_attachment#network_interface_id-1">NetworkInterfaceSgAttachment#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfaceSgAttachmentState<Missing, 'SecurityGroupId>, value: string) : NetworkInterfaceSgAttachmentState<Present, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceSgAttachmentState<Present, 'SecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_sg_attachment#security_group_id-1">NetworkInterfaceSgAttachment#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, Missing>, value: string) : NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, Present> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_sg_attachment#id-1">NetworkInterfaceSgAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId>, value: string) : NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_sg_attachment#timeouts-1">NetworkInterfaceSgAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId>, value: aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachmentTimeouts) : NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceSgAttachmentState<'NetworkInterfaceId, 'SecurityGroupId>

        member _.Run(state: NetworkInterfaceSgAttachmentState<Present, Present>) : aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachment =
            let config = aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkInterfaceSgAttachment: missing required arguments. Must call: network_interface_id, security_group_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceSgAttachmentState<_, _>) : aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachment =
            Unchecked.defaultof<aws.NetworkInterfaceSgAttachment.NetworkInterfaceSgAttachment>
