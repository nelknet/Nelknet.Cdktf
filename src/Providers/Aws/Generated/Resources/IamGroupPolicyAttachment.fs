namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamGroupPolicyAttachmentState<'Group, 'PolicyArn> = { assignments: ResizeArray<aws.IamGroupPolicyAttachment.IamGroupPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachment">aws_iam_group_policy_attachment</a>.
    /// </summary>
    type IamGroupPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamGroupPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : IamGroupPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachment#group-1">IamGroupPolicyAttachment#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: IamGroupPolicyAttachmentState<Missing, 'PolicyArn>, value: string) : IamGroupPolicyAttachmentState<Present, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Group <- value)
            ({ assignments = state.assignments } : IamGroupPolicyAttachmentState<Present, 'PolicyArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachment#policy_arn-1">IamGroupPolicyAttachment#policy_arn</a>.
        /// </summary>
        [<CustomOperation "policy_arn">]
        member _.PolicyArn(state: IamGroupPolicyAttachmentState<'Group, Missing>, value: string) : IamGroupPolicyAttachmentState<'Group, Present> =
            state.assignments.Add(fun config -> config.PolicyArn <- value)
            ({ assignments = state.assignments } : IamGroupPolicyAttachmentState<'Group, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachment#id-1">IamGroupPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamGroupPolicyAttachmentState<'Group, 'PolicyArn>, value: string) : IamGroupPolicyAttachmentState<'Group, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamGroupPolicyAttachmentState<'Group, 'PolicyArn>

        member _.Run(state: IamGroupPolicyAttachmentState<Present, Present>) : aws.IamGroupPolicyAttachment.IamGroupPolicyAttachment =
            let config = aws.IamGroupPolicyAttachment.IamGroupPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.IamGroupPolicyAttachment.IamGroupPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamGroupPolicyAttachment: missing required arguments. Must call: group, policy_arn.", 9999, IsError = true)>]
        member _.Run(_: IamGroupPolicyAttachmentState<_, _>) : aws.IamGroupPolicyAttachment.IamGroupPolicyAttachment =
            Unchecked.defaultof<aws.IamGroupPolicyAttachment.IamGroupPolicyAttachment>
