namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingAttachmentState<'AutoscalingGroupName> = { assignments: ResizeArray<aws.AutoscalingAttachment.AutoscalingAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_attachment">aws_autoscaling_attachment</a>.
    /// </summary>
    type AutoscalingAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : AutoscalingAttachmentState<Missing>)

        member _.Zero(()) : AutoscalingAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : AutoscalingAttachmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_attachment#autoscaling_group_name-1">AutoscalingAttachment#autoscaling_group_name</a>.
        /// </summary>
        [<CustomOperation "autoscaling_group_name">]
        member _.AutoscalingGroupName(state: AutoscalingAttachmentState<Missing>, value: string) : AutoscalingAttachmentState<Present> =
            state.assignments.Add(fun config -> config.AutoscalingGroupName <- value)
            ({ assignments = state.assignments } : AutoscalingAttachmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_attachment#elb-1">AutoscalingAttachment#elb</a>.
        /// </summary>
        [<CustomOperation "elb">]
        member _.Elb(state: AutoscalingAttachmentState<'AutoscalingGroupName>, value: string) : AutoscalingAttachmentState<'AutoscalingGroupName> =
            state.assignments.Add(fun config -> config.Elb <- value)
            state : AutoscalingAttachmentState<'AutoscalingGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_attachment#id-1">AutoscalingAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingAttachmentState<'AutoscalingGroupName>, value: string) : AutoscalingAttachmentState<'AutoscalingGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingAttachmentState<'AutoscalingGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_attachment#lb_target_group_arn-1">AutoscalingAttachment#lb_target_group_arn</a>.
        /// </summary>
        [<CustomOperation "lb_target_group_arn">]
        member _.LbTargetGroupArn(state: AutoscalingAttachmentState<'AutoscalingGroupName>, value: string) : AutoscalingAttachmentState<'AutoscalingGroupName> =
            state.assignments.Add(fun config -> config.LbTargetGroupArn <- value)
            state : AutoscalingAttachmentState<'AutoscalingGroupName>

        member _.Run(state: AutoscalingAttachmentState<Present>) : aws.AutoscalingAttachment.AutoscalingAttachment =
            let config = aws.AutoscalingAttachment.AutoscalingAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingAttachment.AutoscalingAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingAttachment: missing required arguments. Must call: autoscaling_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingAttachmentState<_>) : aws.AutoscalingAttachment.AutoscalingAttachment =
            Unchecked.defaultof<aws.AutoscalingAttachment.AutoscalingAttachment>
