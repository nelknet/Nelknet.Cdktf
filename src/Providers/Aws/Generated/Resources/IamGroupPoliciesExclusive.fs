namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamGroupPoliciesExclusiveState<'GroupName, 'PolicyNames> = { assignments: ResizeArray<aws.IamGroupPoliciesExclusive.IamGroupPoliciesExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policies_exclusive">aws_iam_group_policies_exclusive</a>.
    /// </summary>
    type IamGroupPoliciesExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamGroupPoliciesExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPoliciesExclusiveState<Missing, Missing>)

        member _.Zero(()) : IamGroupPoliciesExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPoliciesExclusiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policies_exclusive#group_name-1">IamGroupPoliciesExclusive#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: IamGroupPoliciesExclusiveState<Missing, 'PolicyNames>, value: string) : IamGroupPoliciesExclusiveState<Present, 'PolicyNames> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : IamGroupPoliciesExclusiveState<Present, 'PolicyNames>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policies_exclusive#policy_names-1">IamGroupPoliciesExclusive#policy_names</a>.
        /// </summary>
        [<CustomOperation "policy_names">]
        member _.PolicyNames(state: IamGroupPoliciesExclusiveState<'GroupName, Missing>, value: seq<string>) : IamGroupPoliciesExclusiveState<'GroupName, Present> =
            state.assignments.Add(fun config -> config.PolicyNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamGroupPoliciesExclusiveState<'GroupName, Present>)

        member _.Run(state: IamGroupPoliciesExclusiveState<Present, Present>) : aws.IamGroupPoliciesExclusive.IamGroupPoliciesExclusive =
            let config = aws.IamGroupPoliciesExclusive.IamGroupPoliciesExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.IamGroupPoliciesExclusive.IamGroupPoliciesExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamGroupPoliciesExclusive: missing required arguments. Must call: group_name, policy_names.", 9999, IsError = true)>]
        member _.Run(_: IamGroupPoliciesExclusiveState<_, _>) : aws.IamGroupPoliciesExclusive.IamGroupPoliciesExclusive =
            Unchecked.defaultof<aws.IamGroupPoliciesExclusive.IamGroupPoliciesExclusive>
