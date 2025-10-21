namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserPoliciesExclusiveState<'PolicyNames, 'UserName> = { assignments: ResizeArray<aws.IamUserPoliciesExclusive.IamUserPoliciesExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policies_exclusive">aws_iam_user_policies_exclusive</a>.
    /// </summary>
    type IamUserPoliciesExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserPoliciesExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPoliciesExclusiveState<Missing, Missing>)

        member _.Zero(()) : IamUserPoliciesExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPoliciesExclusiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policies_exclusive#policy_names-1">IamUserPoliciesExclusive#policy_names</a>.
        /// </summary>
        [<CustomOperation "policy_names">]
        member _.PolicyNames(state: IamUserPoliciesExclusiveState<Missing, 'UserName>, value: seq<string>) : IamUserPoliciesExclusiveState<Present, 'UserName> =
            state.assignments.Add(fun config -> config.PolicyNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamUserPoliciesExclusiveState<Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policies_exclusive#user_name-1">IamUserPoliciesExclusive#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: IamUserPoliciesExclusiveState<'PolicyNames, Missing>, value: string) : IamUserPoliciesExclusiveState<'PolicyNames, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : IamUserPoliciesExclusiveState<'PolicyNames, Present>)

        member _.Run(state: IamUserPoliciesExclusiveState<Present, Present>) : aws.IamUserPoliciesExclusive.IamUserPoliciesExclusive =
            let config = aws.IamUserPoliciesExclusive.IamUserPoliciesExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserPoliciesExclusive.IamUserPoliciesExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserPoliciesExclusive: missing required arguments. Must call: policy_names, user_name.", 9999, IsError = true)>]
        member _.Run(_: IamUserPoliciesExclusiveState<_, _>) : aws.IamUserPoliciesExclusive.IamUserPoliciesExclusive =
            Unchecked.defaultof<aws.IamUserPoliciesExclusive.IamUserPoliciesExclusive>
