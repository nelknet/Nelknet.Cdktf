namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamRolePolicyAttachmentState<'PolicyArn, 'Role> = { assignments: ResizeArray<aws.IamRolePolicyAttachment.IamRolePolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachment">aws_iam_role_policy_attachment</a>.
    /// </summary>
    type IamRolePolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamRolePolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : IamRolePolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachment#policy_arn-1">IamRolePolicyAttachment#policy_arn</a>.
        /// </summary>
        [<CustomOperation "policy_arn">]
        member _.PolicyArn(state: IamRolePolicyAttachmentState<Missing, 'Role>, value: string) : IamRolePolicyAttachmentState<Present, 'Role> =
            state.assignments.Add(fun config -> config.PolicyArn <- value)
            ({ assignments = state.assignments } : IamRolePolicyAttachmentState<Present, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachment#role-1">IamRolePolicyAttachment#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: IamRolePolicyAttachmentState<'PolicyArn, Missing>, value: string) : IamRolePolicyAttachmentState<'PolicyArn, Present> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : IamRolePolicyAttachmentState<'PolicyArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachment#id-1">IamRolePolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamRolePolicyAttachmentState<'PolicyArn, 'Role>, value: string) : IamRolePolicyAttachmentState<'PolicyArn, 'Role> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamRolePolicyAttachmentState<'PolicyArn, 'Role>

        member _.Run(state: IamRolePolicyAttachmentState<Present, Present>) : aws.IamRolePolicyAttachment.IamRolePolicyAttachment =
            let config = aws.IamRolePolicyAttachment.IamRolePolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.IamRolePolicyAttachment.IamRolePolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamRolePolicyAttachment: missing required arguments. Must call: policy_arn, role.", 9999, IsError = true)>]
        member _.Run(_: IamRolePolicyAttachmentState<_, _>) : aws.IamRolePolicyAttachment.IamRolePolicyAttachment =
            Unchecked.defaultof<aws.IamRolePolicyAttachment.IamRolePolicyAttachment>
