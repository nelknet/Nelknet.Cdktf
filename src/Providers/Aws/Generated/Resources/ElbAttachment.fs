namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElbAttachmentState<'Elb, 'Instance> = { assignments: ResizeArray<aws.ElbAttachment.ElbAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb_attachment">aws_elb_attachment</a>.
    /// </summary>
    type ElbAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElbAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElbAttachmentState<Missing, Missing>)

        member _.Zero(()) : ElbAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElbAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb_attachment#elb-1">ElbAttachment#elb</a>.
        /// </summary>
        [<CustomOperation "elb">]
        member _.Elb(state: ElbAttachmentState<Missing, 'Instance>, value: string) : ElbAttachmentState<Present, 'Instance> =
            state.assignments.Add(fun config -> config.Elb <- value)
            ({ assignments = state.assignments } : ElbAttachmentState<Present, 'Instance>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb_attachment#instance-1">ElbAttachment#instance</a>.
        /// </summary>
        [<CustomOperation "instance">]
        member _.Instance(state: ElbAttachmentState<'Elb, Missing>, value: string) : ElbAttachmentState<'Elb, Present> =
            state.assignments.Add(fun config -> config.Instance <- value)
            ({ assignments = state.assignments } : ElbAttachmentState<'Elb, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb_attachment#id-1">ElbAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElbAttachmentState<'Elb, 'Instance>, value: string) : ElbAttachmentState<'Elb, 'Instance> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElbAttachmentState<'Elb, 'Instance>

        member _.Run(state: ElbAttachmentState<Present, Present>) : aws.ElbAttachment.ElbAttachment =
            let config = aws.ElbAttachment.ElbAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.ElbAttachment.ElbAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elbAttachment: missing required arguments. Must call: elb, instance.", 9999, IsError = true)>]
        member _.Run(_: ElbAttachmentState<_, _>) : aws.ElbAttachment.ElbAttachment =
            Unchecked.defaultof<aws.ElbAttachment.ElbAttachment>
