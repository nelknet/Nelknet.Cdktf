namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> = { assignments: ResizeArray<aws.AlbTargetGroupAttachment.AlbTargetGroupAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group_attachment">aws_alb_target_group_attachment</a>.
    /// </summary>
    type AlbTargetGroupAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AlbTargetGroupAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbTargetGroupAttachmentState<Missing, Missing>)

        member _.Zero(()) : AlbTargetGroupAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbTargetGroupAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group_attachment#target_group_arn-1">AlbTargetGroupAttachment#target_group_arn</a>.
        /// </summary>
        [<CustomOperation "target_group_arn">]
        member _.TargetGroupArn(state: AlbTargetGroupAttachmentState<Missing, 'TargetId>, value: string) : AlbTargetGroupAttachmentState<Present, 'TargetId> =
            state.assignments.Add(fun config -> config.TargetGroupArn <- value)
            ({ assignments = state.assignments } : AlbTargetGroupAttachmentState<Present, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group_attachment#target_id-1">AlbTargetGroupAttachment#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: AlbTargetGroupAttachmentState<'TargetGroupArn, Missing>, value: string) : AlbTargetGroupAttachmentState<'TargetGroupArn, Present> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : AlbTargetGroupAttachmentState<'TargetGroupArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group_attachment#availability_zone-1">AlbTargetGroupAttachment#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>, value: string) : AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group_attachment#id-1">AlbTargetGroupAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>, value: string) : AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group_attachment#port-1">AlbTargetGroupAttachment#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>, value: double) : AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : AlbTargetGroupAttachmentState<'TargetGroupArn, 'TargetId>

        member _.Run(state: AlbTargetGroupAttachmentState<Present, Present>) : aws.AlbTargetGroupAttachment.AlbTargetGroupAttachment =
            let config = aws.AlbTargetGroupAttachment.AlbTargetGroupAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.AlbTargetGroupAttachment.AlbTargetGroupAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.albTargetGroupAttachment: missing required arguments. Must call: target_group_arn, target_id.", 9999, IsError = true)>]
        member _.Run(_: AlbTargetGroupAttachmentState<_, _>) : aws.AlbTargetGroupAttachment.AlbTargetGroupAttachment =
            Unchecked.defaultof<aws.AlbTargetGroupAttachment.AlbTargetGroupAttachment>
