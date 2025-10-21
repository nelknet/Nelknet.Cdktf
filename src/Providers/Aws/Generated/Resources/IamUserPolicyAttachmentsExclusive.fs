namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserPolicyAttachmentsExclusiveState<'PolicyArns, 'UserName> = { assignments: ResizeArray<aws.IamUserPolicyAttachmentsExclusive.IamUserPolicyAttachmentsExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachments_exclusive">aws_iam_user_policy_attachments_exclusive</a>.
    /// </summary>
    type IamUserPolicyAttachmentsExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserPolicyAttachmentsExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPolicyAttachmentsExclusiveState<Missing, Missing>)

        member _.Zero(()) : IamUserPolicyAttachmentsExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPolicyAttachmentsExclusiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachments_exclusive#policy_arns-1">IamUserPolicyAttachmentsExclusive#policy_arns</a>.
        /// </summary>
        [<CustomOperation "policy_arns">]
        member _.PolicyArns(state: IamUserPolicyAttachmentsExclusiveState<Missing, 'UserName>, value: seq<string>) : IamUserPolicyAttachmentsExclusiveState<Present, 'UserName> =
            state.assignments.Add(fun config -> config.PolicyArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamUserPolicyAttachmentsExclusiveState<Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy_attachments_exclusive#user_name-1">IamUserPolicyAttachmentsExclusive#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: IamUserPolicyAttachmentsExclusiveState<'PolicyArns, Missing>, value: string) : IamUserPolicyAttachmentsExclusiveState<'PolicyArns, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : IamUserPolicyAttachmentsExclusiveState<'PolicyArns, Present>)

        member _.Run(state: IamUserPolicyAttachmentsExclusiveState<Present, Present>) : aws.IamUserPolicyAttachmentsExclusive.IamUserPolicyAttachmentsExclusive =
            let config = aws.IamUserPolicyAttachmentsExclusive.IamUserPolicyAttachmentsExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserPolicyAttachmentsExclusive.IamUserPolicyAttachmentsExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserPolicyAttachmentsExclusive: missing required arguments. Must call: policy_arns, user_name.", 9999, IsError = true)>]
        member _.Run(_: IamUserPolicyAttachmentsExclusiveState<_, _>) : aws.IamUserPolicyAttachmentsExclusive.IamUserPolicyAttachmentsExclusive =
            Unchecked.defaultof<aws.IamUserPolicyAttachmentsExclusive.IamUserPolicyAttachmentsExclusive>
