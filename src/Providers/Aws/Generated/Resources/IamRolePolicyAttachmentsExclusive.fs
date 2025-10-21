namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamRolePolicyAttachmentsExclusiveState<'PolicyArns, 'RoleName> = { assignments: ResizeArray<aws.IamRolePolicyAttachmentsExclusive.IamRolePolicyAttachmentsExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachments_exclusive">aws_iam_role_policy_attachments_exclusive</a>.
    /// </summary>
    type IamRolePolicyAttachmentsExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamRolePolicyAttachmentsExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePolicyAttachmentsExclusiveState<Missing, Missing>)

        member _.Zero(()) : IamRolePolicyAttachmentsExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePolicyAttachmentsExclusiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachments_exclusive#policy_arns-1">IamRolePolicyAttachmentsExclusive#policy_arns</a>.
        /// </summary>
        [<CustomOperation "policy_arns">]
        member _.PolicyArns(state: IamRolePolicyAttachmentsExclusiveState<Missing, 'RoleName>, value: seq<string>) : IamRolePolicyAttachmentsExclusiveState<Present, 'RoleName> =
            state.assignments.Add(fun config -> config.PolicyArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamRolePolicyAttachmentsExclusiveState<Present, 'RoleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy_attachments_exclusive#role_name-1">IamRolePolicyAttachmentsExclusive#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: IamRolePolicyAttachmentsExclusiveState<'PolicyArns, Missing>, value: string) : IamRolePolicyAttachmentsExclusiveState<'PolicyArns, Present> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            ({ assignments = state.assignments } : IamRolePolicyAttachmentsExclusiveState<'PolicyArns, Present>)

        member _.Run(state: IamRolePolicyAttachmentsExclusiveState<Present, Present>) : aws.IamRolePolicyAttachmentsExclusive.IamRolePolicyAttachmentsExclusive =
            let config = aws.IamRolePolicyAttachmentsExclusive.IamRolePolicyAttachmentsExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.IamRolePolicyAttachmentsExclusive.IamRolePolicyAttachmentsExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamRolePolicyAttachmentsExclusive: missing required arguments. Must call: policy_arns, role_name.", 9999, IsError = true)>]
        member _.Run(_: IamRolePolicyAttachmentsExclusiveState<_, _>) : aws.IamRolePolicyAttachmentsExclusive.IamRolePolicyAttachmentsExclusive =
            Unchecked.defaultof<aws.IamRolePolicyAttachmentsExclusive.IamRolePolicyAttachmentsExclusive>
