namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailLbAttachmentState<'InstanceName, 'LbName> = { assignments: ResizeArray<aws.LightsailLbAttachment.LightsailLbAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_attachment">aws_lightsail_lb_attachment</a>.
    /// </summary>
    type LightsailLbAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailLbAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbAttachmentState<Missing, Missing>)

        member _.Zero(()) : LightsailLbAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_attachment#instance_name-1">LightsailLbAttachment#instance_name</a>.
        /// </summary>
        [<CustomOperation "instance_name">]
        member _.InstanceName(state: LightsailLbAttachmentState<Missing, 'LbName>, value: string) : LightsailLbAttachmentState<Present, 'LbName> =
            state.assignments.Add(fun config -> config.InstanceName <- value)
            ({ assignments = state.assignments } : LightsailLbAttachmentState<Present, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_attachment#lb_name-1">LightsailLbAttachment#lb_name</a>.
        /// </summary>
        [<CustomOperation "lb_name">]
        member _.LbName(state: LightsailLbAttachmentState<'InstanceName, Missing>, value: string) : LightsailLbAttachmentState<'InstanceName, Present> =
            state.assignments.Add(fun config -> config.LbName <- value)
            ({ assignments = state.assignments } : LightsailLbAttachmentState<'InstanceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_attachment#id-1">LightsailLbAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailLbAttachmentState<'InstanceName, 'LbName>, value: string) : LightsailLbAttachmentState<'InstanceName, 'LbName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailLbAttachmentState<'InstanceName, 'LbName>

        member _.Run(state: LightsailLbAttachmentState<Present, Present>) : aws.LightsailLbAttachment.LightsailLbAttachment =
            let config = aws.LightsailLbAttachment.LightsailLbAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailLbAttachment.LightsailLbAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailLbAttachment: missing required arguments. Must call: instance_name, lb_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailLbAttachmentState<_, _>) : aws.LightsailLbAttachment.LightsailLbAttachment =
            Unchecked.defaultof<aws.LightsailLbAttachment.LightsailLbAttachment>
