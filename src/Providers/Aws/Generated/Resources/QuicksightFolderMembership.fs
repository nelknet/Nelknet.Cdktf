namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightFolderMembershipState<'FolderId, 'MemberId, 'MemberType> = { assignments: ResizeArray<aws.QuicksightFolderMembership.QuicksightFolderMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder_membership">aws_quicksight_folder_membership</a>.
    /// </summary>
    type QuicksightFolderMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightFolderMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightFolderMembershipState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightFolderMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightFolderMembershipState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder_membership#folder_id-1">QuicksightFolderMembership#folder_id</a>.
        /// </summary>
        [<CustomOperation "folder_id">]
        member _.FolderId(state: QuicksightFolderMembershipState<Missing, 'MemberId, 'MemberType>, value: string) : QuicksightFolderMembershipState<Present, 'MemberId, 'MemberType> =
            state.assignments.Add(fun config -> config.FolderId <- value)
            ({ assignments = state.assignments } : QuicksightFolderMembershipState<Present, 'MemberId, 'MemberType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder_membership#member_id-1">QuicksightFolderMembership#member_id</a>.
        /// </summary>
        [<CustomOperation "member_id">]
        member _.MemberId(state: QuicksightFolderMembershipState<'FolderId, Missing, 'MemberType>, value: string) : QuicksightFolderMembershipState<'FolderId, Present, 'MemberType> =
            state.assignments.Add(fun config -> config.MemberId <- value)
            ({ assignments = state.assignments } : QuicksightFolderMembershipState<'FolderId, Present, 'MemberType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder_membership#member_type-1">QuicksightFolderMembership#member_type</a>.
        /// </summary>
        [<CustomOperation "member_type">]
        member _.MemberType(state: QuicksightFolderMembershipState<'FolderId, 'MemberId, Missing>, value: string) : QuicksightFolderMembershipState<'FolderId, 'MemberId, Present> =
            state.assignments.Add(fun config -> config.MemberType <- value)
            ({ assignments = state.assignments } : QuicksightFolderMembershipState<'FolderId, 'MemberId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder_membership#aws_account_id-1">QuicksightFolderMembership#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightFolderMembershipState<'FolderId, 'MemberId, 'MemberType>, value: string) : QuicksightFolderMembershipState<'FolderId, 'MemberId, 'MemberType> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightFolderMembershipState<'FolderId, 'MemberId, 'MemberType>

        member _.Run(state: QuicksightFolderMembershipState<Present, Present, Present>) : aws.QuicksightFolderMembership.QuicksightFolderMembership =
            let config = aws.QuicksightFolderMembership.QuicksightFolderMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightFolderMembership.QuicksightFolderMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightFolderMembership: missing required arguments. Must call: folder_id, member_id, member_type.", 9999, IsError = true)>]
        member _.Run(_: QuicksightFolderMembershipState<_, _, _>) : aws.QuicksightFolderMembership.QuicksightFolderMembership =
            Unchecked.defaultof<aws.QuicksightFolderMembership.QuicksightFolderMembership>
