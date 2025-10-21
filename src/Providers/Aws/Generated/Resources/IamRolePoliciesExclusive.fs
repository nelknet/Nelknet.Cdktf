namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamRolePoliciesExclusiveState<'PolicyNames, 'RoleName> = { assignments: ResizeArray<aws.IamRolePoliciesExclusive.IamRolePoliciesExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policies_exclusive">aws_iam_role_policies_exclusive</a>.
    /// </summary>
    type IamRolePoliciesExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamRolePoliciesExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePoliciesExclusiveState<Missing, Missing>)

        member _.Zero(()) : IamRolePoliciesExclusiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePoliciesExclusiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policies_exclusive#policy_names-1">IamRolePoliciesExclusive#policy_names</a>.
        /// </summary>
        [<CustomOperation "policy_names">]
        member _.PolicyNames(state: IamRolePoliciesExclusiveState<Missing, 'RoleName>, value: seq<string>) : IamRolePoliciesExclusiveState<Present, 'RoleName> =
            state.assignments.Add(fun config -> config.PolicyNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamRolePoliciesExclusiveState<Present, 'RoleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policies_exclusive#role_name-1">IamRolePoliciesExclusive#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: IamRolePoliciesExclusiveState<'PolicyNames, Missing>, value: string) : IamRolePoliciesExclusiveState<'PolicyNames, Present> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            ({ assignments = state.assignments } : IamRolePoliciesExclusiveState<'PolicyNames, Present>)

        member _.Run(state: IamRolePoliciesExclusiveState<Present, Present>) : aws.IamRolePoliciesExclusive.IamRolePoliciesExclusive =
            let config = aws.IamRolePoliciesExclusive.IamRolePoliciesExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.IamRolePoliciesExclusive.IamRolePoliciesExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamRolePoliciesExclusive: missing required arguments. Must call: policy_names, role_name.", 9999, IsError = true)>]
        member _.Run(_: IamRolePoliciesExclusiveState<_, _>) : aws.IamRolePoliciesExclusive.IamRolePoliciesExclusive =
            Unchecked.defaultof<aws.IamRolePoliciesExclusive.IamRolePoliciesExclusive>
