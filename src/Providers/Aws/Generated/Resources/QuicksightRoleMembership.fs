namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightRoleMembershipState<'MemberName, 'Role> = { assignments: ResizeArray<aws.QuicksightRoleMembership.QuicksightRoleMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_role_membership">aws_quicksight_role_membership</a>.
    /// </summary>
    type QuicksightRoleMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightRoleMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightRoleMembershipState<Missing, Missing>)

        member _.Zero(()) : QuicksightRoleMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightRoleMembershipState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_role_membership#member_name-1">QuicksightRoleMembership#member_name</a>.
        /// </summary>
        [<CustomOperation "member_name">]
        member _.MemberName(state: QuicksightRoleMembershipState<Missing, 'Role>, value: string) : QuicksightRoleMembershipState<Present, 'Role> =
            state.assignments.Add(fun config -> config.MemberName <- value)
            ({ assignments = state.assignments } : QuicksightRoleMembershipState<Present, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_role_membership#role-1">QuicksightRoleMembership#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: QuicksightRoleMembershipState<'MemberName, Missing>, value: string) : QuicksightRoleMembershipState<'MemberName, Present> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : QuicksightRoleMembershipState<'MemberName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_role_membership#aws_account_id-1">QuicksightRoleMembership#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightRoleMembershipState<'MemberName, 'Role>, value: string) : QuicksightRoleMembershipState<'MemberName, 'Role> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightRoleMembershipState<'MemberName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_role_membership#namespace-1">QuicksightRoleMembership#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: QuicksightRoleMembershipState<'MemberName, 'Role>, value: string) : QuicksightRoleMembershipState<'MemberName, 'Role> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : QuicksightRoleMembershipState<'MemberName, 'Role>

        member _.Run(state: QuicksightRoleMembershipState<Present, Present>) : aws.QuicksightRoleMembership.QuicksightRoleMembership =
            let config = aws.QuicksightRoleMembership.QuicksightRoleMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightRoleMembership.QuicksightRoleMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightRoleMembership: missing required arguments. Must call: member_name, role.", 9999, IsError = true)>]
        member _.Run(_: QuicksightRoleMembershipState<_, _>) : aws.QuicksightRoleMembership.QuicksightRoleMembership =
            Unchecked.defaultof<aws.QuicksightRoleMembership.QuicksightRoleMembership>
