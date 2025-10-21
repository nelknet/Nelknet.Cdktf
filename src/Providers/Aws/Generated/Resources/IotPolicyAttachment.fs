namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotPolicyAttachmentState<'Policy, 'Target> = { assignments: ResizeArray<aws.IotPolicyAttachment.IotPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy_attachment">aws_iot_policy_attachment</a>.
    /// </summary>
    type IotPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotPolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : IotPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotPolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy_attachment#policy-1">IotPolicyAttachment#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: IotPolicyAttachmentState<Missing, 'Target>, value: string) : IotPolicyAttachmentState<Present, 'Target> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : IotPolicyAttachmentState<Present, 'Target>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy_attachment#target-1">IotPolicyAttachment#target</a>.
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: IotPolicyAttachmentState<'Policy, Missing>, value: string) : IotPolicyAttachmentState<'Policy, Present> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : IotPolicyAttachmentState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy_attachment#id-1">IotPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotPolicyAttachmentState<'Policy, 'Target>, value: string) : IotPolicyAttachmentState<'Policy, 'Target> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotPolicyAttachmentState<'Policy, 'Target>

        member _.Run(state: IotPolicyAttachmentState<Present, Present>) : aws.IotPolicyAttachment.IotPolicyAttachment =
            let config = aws.IotPolicyAttachment.IotPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.IotPolicyAttachment.IotPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotPolicyAttachment: missing required arguments. Must call: policy, target.", 9999, IsError = true)>]
        member _.Run(_: IotPolicyAttachmentState<_, _>) : aws.IotPolicyAttachment.IotPolicyAttachment =
            Unchecked.defaultof<aws.IotPolicyAttachment.IotPolicyAttachment>
