namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName> = { assignments: ResizeArray<aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_traffic_source_attachment">aws_autoscaling_traffic_source_attachment</a>.
    /// </summary>
    type AutoscalingTrafficSourceAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingTrafficSourceAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : AutoscalingTrafficSourceAttachmentState<Missing>)

        member _.Zero(()) : AutoscalingTrafficSourceAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : AutoscalingTrafficSourceAttachmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_traffic_source_attachment#autoscaling_group_name-1">AutoscalingTrafficSourceAttachment#autoscaling_group_name</a>.
        /// </summary>
        [<CustomOperation "autoscaling_group_name">]
        member _.AutoscalingGroupName(state: AutoscalingTrafficSourceAttachmentState<Missing>, value: string) : AutoscalingTrafficSourceAttachmentState<Present> =
            state.assignments.Add(fun config -> config.AutoscalingGroupName <- value)
            ({ assignments = state.assignments } : AutoscalingTrafficSourceAttachmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_traffic_source_attachment#id-1">AutoscalingTrafficSourceAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName>, value: string) : AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_traffic_source_attachment#timeouts-1">AutoscalingTrafficSourceAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName>, value: aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentTimeouts) : AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName>

        /// <summary>
        /// traffic_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_traffic_source_attachment#traffic_source-1">AutoscalingTrafficSourceAttachment#traffic_source</a>
        /// </summary>
        [<CustomOperation "traffic_source">]
        member _.TrafficSource(state: AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName>, value: aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentTrafficSource) : AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName> =
            state.assignments.Add(fun config -> config.TrafficSource <- value)
            state : AutoscalingTrafficSourceAttachmentState<'AutoscalingGroupName>

        member _.Run(state: AutoscalingTrafficSourceAttachmentState<Present>) : aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachment =
            let config = aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingTrafficSourceAttachment: missing required arguments. Must call: autoscaling_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingTrafficSourceAttachmentState<_>) : aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachment =
            Unchecked.defaultof<aws.AutoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachment>
