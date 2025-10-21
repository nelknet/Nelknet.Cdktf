namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> = { assignments: ResizeArray<aws.LbTargetGroupAttachment.LbTargetGroupAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group_attachment">aws_lb_target_group_attachment</a>.
    /// </summary>
    type LbTargetGroupAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbTargetGroupAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbTargetGroupAttachmentState<Missing, Missing>)

        member _.Zero(()) : LbTargetGroupAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbTargetGroupAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group_attachment#target_group_arn-1">LbTargetGroupAttachment#target_group_arn</a>.
        /// </summary>
        [<CustomOperation "target_group_arn">]
        member _.TargetGroupArn(state: LbTargetGroupAttachmentState<Missing, 'TargetId>, value: string) : LbTargetGroupAttachmentState<Present, 'TargetId> =
            state.assignments.Add(fun config -> config.TargetGroupArn <- value)
            ({ assignments = state.assignments } : LbTargetGroupAttachmentState<Present, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group_attachment#target_id-1">LbTargetGroupAttachment#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: LbTargetGroupAttachmentState<'TargetGroupArn, Missing>, value: string) : LbTargetGroupAttachmentState<'TargetGroupArn, Present> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : LbTargetGroupAttachmentState<'TargetGroupArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group_attachment#availability_zone-1">LbTargetGroupAttachment#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>, value: string) : LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group_attachment#id-1">LbTargetGroupAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>, value: string) : LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group_attachment#port-1">LbTargetGroupAttachment#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>, value: double) : LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : LbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>

        member _.Run(state: LbTargetGroupAttachmentState<Present, Present>) : aws.LbTargetGroupAttachment.LbTargetGroupAttachment =
            let config = aws.LbTargetGroupAttachment.LbTargetGroupAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.LbTargetGroupAttachment.LbTargetGroupAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbTargetGroupAttachment: missing required arguments. Must call: target_group_arn, target_id.", 9999, IsError = true)>]
        member _.Run(_: LbTargetGroupAttachmentState<_, _>) : aws.LbTargetGroupAttachment.LbTargetGroupAttachment =
            Unchecked.defaultof<aws.LbTargetGroupAttachment.LbTargetGroupAttachment>
