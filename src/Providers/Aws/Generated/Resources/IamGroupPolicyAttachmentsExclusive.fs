namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamGroupPolicyAttachmentsExclusiveState<'GroupName, 'PolicyArns> = { assignments: ResizeArray<aws.IamGroupPolicyAttachmentsExclusive.IamGroupPolicyAttachmentsExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachments_exclusive">aws_iam_group_policy_attachments_exclusive</a>.
    /// </summary>
    type IamGroupPolicyAttachmentsExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamGroupPolicyAttachmentsExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPolicyAttachmentsExclusiveState<Missing, Missing>)

        member _.Zero(()) : IamGroupPolicyAttachmentsExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPolicyAttachmentsExclusiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachments_exclusive#group_name-1">IamGroupPolicyAttachmentsExclusive#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: IamGroupPolicyAttachmentsExclusiveState<Missing, 'PolicyArns>, value: string) : IamGroupPolicyAttachmentsExclusiveState<Present, 'PolicyArns> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : IamGroupPolicyAttachmentsExclusiveState<Present, 'PolicyArns>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy_attachments_exclusive#policy_arns-1">IamGroupPolicyAttachmentsExclusive#policy_arns</a>.
        /// </summary>
        [<CustomOperation "policy_arns">]
        member _.PolicyArns(state: IamGroupPolicyAttachmentsExclusiveState<'GroupName, Missing>, value: seq<string>) : IamGroupPolicyAttachmentsExclusiveState<'GroupName, Present> =
            state.assignments.Add(fun config -> config.PolicyArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamGroupPolicyAttachmentsExclusiveState<'GroupName, Present>)

        member _.Run(state: IamGroupPolicyAttachmentsExclusiveState<Present, Present>) : aws.IamGroupPolicyAttachmentsExclusive.IamGroupPolicyAttachmentsExclusive =
            let config = aws.IamGroupPolicyAttachmentsExclusive.IamGroupPolicyAttachmentsExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.IamGroupPolicyAttachmentsExclusive.IamGroupPolicyAttachmentsExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamGroupPolicyAttachmentsExclusive: missing required arguments. Must call: group_name, policy_arns.", 9999, IsError = true)>]
        member _.Run(_: IamGroupPolicyAttachmentsExclusiveState<_, _>) : aws.IamGroupPolicyAttachmentsExclusive.IamGroupPolicyAttachmentsExclusive =
            Unchecked.defaultof<aws.IamGroupPolicyAttachmentsExclusive.IamGroupPolicyAttachmentsExclusive>
