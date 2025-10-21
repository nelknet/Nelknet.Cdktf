namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightGroupMembershipState<'GroupName, 'MemberName> = { assignments: ResizeArray<aws.QuicksightGroupMembership.QuicksightGroupMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group_membership">aws_quicksight_group_membership</a>.
    /// </summary>
    type QuicksightGroupMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightGroupMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightGroupMembershipState<Missing, Missing>)

        member _.Zero(()) : QuicksightGroupMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightGroupMembershipState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group_membership#group_name-1">QuicksightGroupMembership#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: QuicksightGroupMembershipState<Missing, 'MemberName>, value: string) : QuicksightGroupMembershipState<Present, 'MemberName> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : QuicksightGroupMembershipState<Present, 'MemberName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group_membership#member_name-1">QuicksightGroupMembership#member_name</a>.
        /// </summary>
        [<CustomOperation "member_name">]
        member _.MemberName(state: QuicksightGroupMembershipState<'GroupName, Missing>, value: string) : QuicksightGroupMembershipState<'GroupName, Present> =
            state.assignments.Add(fun config -> config.MemberName <- value)
            ({ assignments = state.assignments } : QuicksightGroupMembershipState<'GroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group_membership#aws_account_id-1">QuicksightGroupMembership#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightGroupMembershipState<'GroupName, 'MemberName>, value: string) : QuicksightGroupMembershipState<'GroupName, 'MemberName> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightGroupMembershipState<'GroupName, 'MemberName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group_membership#id-1">QuicksightGroupMembership#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightGroupMembershipState<'GroupName, 'MemberName>, value: string) : QuicksightGroupMembershipState<'GroupName, 'MemberName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightGroupMembershipState<'GroupName, 'MemberName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group_membership#namespace-1">QuicksightGroupMembership#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: QuicksightGroupMembershipState<'GroupName, 'MemberName>, value: string) : QuicksightGroupMembershipState<'GroupName, 'MemberName> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : QuicksightGroupMembershipState<'GroupName, 'MemberName>

        member _.Run(state: QuicksightGroupMembershipState<Present, Present>) : aws.QuicksightGroupMembership.QuicksightGroupMembership =
            let config = aws.QuicksightGroupMembership.QuicksightGroupMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightGroupMembership.QuicksightGroupMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightGroupMembership: missing required arguments. Must call: group_name, member_name.", 9999, IsError = true)>]
        member _.Run(_: QuicksightGroupMembershipState<_, _>) : aws.QuicksightGroupMembership.QuicksightGroupMembership =
            Unchecked.defaultof<aws.QuicksightGroupMembership.QuicksightGroupMembership>
