namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserPolicyAttachmentState<'PolicyArn, 'User> = { assignments: ResizeArray<aws.IamUserPolicyAttachment.IamUserPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachment">aws_iam_user_policy_attachment</a>.
    /// </summary>
    type IamUserPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : IamUserPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachment#policy_arn-1">IamUserPolicyAttachment#policy_arn</a>.
        /// </summary>
        [<CustomOperation "policy_arn">]
        member _.PolicyArn(state: IamUserPolicyAttachmentState<Missing, 'User>, value: string) : IamUserPolicyAttachmentState<Present, 'User> =
            state.assignments.Add(fun config -> config.PolicyArn <- value)
            ({ assignments = state.assignments } : IamUserPolicyAttachmentState<Present, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachment#user-1">IamUserPolicyAttachment#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: IamUserPolicyAttachmentState<'PolicyArn, Missing>, value: string) : IamUserPolicyAttachmentState<'PolicyArn, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : IamUserPolicyAttachmentState<'PolicyArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachment#id-1">IamUserPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamUserPolicyAttachmentState<'PolicyArn, 'User>, value: string) : IamUserPolicyAttachmentState<'PolicyArn, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamUserPolicyAttachmentState<'PolicyArn, 'User>

        member _.Run(state: IamUserPolicyAttachmentState<Present, Present>) : aws.IamUserPolicyAttachment.IamUserPolicyAttachment =
            let config = aws.IamUserPolicyAttachment.IamUserPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserPolicyAttachment.IamUserPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserPolicyAttachment: missing required arguments. Must call: policy_arn, user.", 9999, IsError = true)>]
        member _.Run(_: IamUserPolicyAttachmentState<_, _>) : aws.IamUserPolicyAttachment.IamUserPolicyAttachment =
            Unchecked.defaultof<aws.IamUserPolicyAttachment.IamUserPolicyAttachment>
