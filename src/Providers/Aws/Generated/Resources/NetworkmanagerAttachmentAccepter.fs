namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType> = { assignments: ResizeArray<aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter">aws_networkmanager_attachment_accepter</a>.
    /// </summary>
    type NetworkmanagerAttachmentAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerAttachmentAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerAttachmentAccepterState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerAttachmentAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerAttachmentAccepterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#attachment_id-1">NetworkmanagerAttachmentAccepter#attachment_id</a>.
        /// </summary>
        [<CustomOperation "attachment_id">]
        member _.AttachmentId(state: NetworkmanagerAttachmentAccepterState<Missing, 'AttachmentType>, value: string) : NetworkmanagerAttachmentAccepterState<Present, 'AttachmentType> =
            state.assignments.Add(fun config -> config.AttachmentId <- value)
            ({ assignments = state.assignments } : NetworkmanagerAttachmentAccepterState<Present, 'AttachmentType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#attachment_type-1">NetworkmanagerAttachmentAccepter#attachment_type</a>.
        /// </summary>
        [<CustomOperation "attachment_type">]
        member _.AttachmentType(state: NetworkmanagerAttachmentAccepterState<'AttachmentId, Missing>, value: string) : NetworkmanagerAttachmentAccepterState<'AttachmentId, Present> =
            state.assignments.Add(fun config -> config.AttachmentType <- value)
            ({ assignments = state.assignments } : NetworkmanagerAttachmentAccepterState<'AttachmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#id-1">NetworkmanagerAttachmentAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType>, value: string) : NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#timeouts-1">NetworkmanagerAttachmentAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType>, value: aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepterTimeouts) : NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerAttachmentAccepterState<'AttachmentId, 'AttachmentType>

        member _.Run(state: NetworkmanagerAttachmentAccepterState<Present, Present>) : aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepter =
            let config = aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerAttachmentAccepter: missing required arguments. Must call: attachment_id, attachment_type.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerAttachmentAccepterState<_, _>) : aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepter =
            Unchecked.defaultof<aws.NetworkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepter>
