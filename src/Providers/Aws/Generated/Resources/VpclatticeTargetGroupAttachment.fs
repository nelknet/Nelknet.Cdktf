namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier> = { assignments: ResizeArray<aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment">aws_vpclattice_target_group_attachment</a>.
    /// </summary>
    type VpclatticeTargetGroupAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeTargetGroupAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeTargetGroupAttachmentState<Missing, Missing>)

        member _.Zero(()) : VpclatticeTargetGroupAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeTargetGroupAttachmentState<Missing, Missing>)

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#target-1">VpclatticeTargetGroupAttachment#target</a>
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: VpclatticeTargetGroupAttachmentState<Missing, 'TargetGroupIdentifier>, value: aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTarget) : VpclatticeTargetGroupAttachmentState<Present, 'TargetGroupIdentifier> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : VpclatticeTargetGroupAttachmentState<Present, 'TargetGroupIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#target_group_identifier-1">VpclatticeTargetGroupAttachment#target_group_identifier</a>.
        /// </summary>
        [<CustomOperation "target_group_identifier">]
        member _.TargetGroupIdentifier(state: VpclatticeTargetGroupAttachmentState<'Target, Missing>, value: string) : VpclatticeTargetGroupAttachmentState<'Target, Present> =
            state.assignments.Add(fun config -> config.TargetGroupIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeTargetGroupAttachmentState<'Target, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#id-1">VpclatticeTargetGroupAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier>, value: string) : VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#timeouts-1">VpclatticeTargetGroupAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier>, value: aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeouts) : VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeTargetGroupAttachmentState<'Target, 'TargetGroupIdentifier>

        member _.Run(state: VpclatticeTargetGroupAttachmentState<Present, Present>) : aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment =
            let config = aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeTargetGroupAttachment: missing required arguments. Must call: target, target_group_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeTargetGroupAttachmentState<_, _>) : aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment =
            Unchecked.defaultof<aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment>
