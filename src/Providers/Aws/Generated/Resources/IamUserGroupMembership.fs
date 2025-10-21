namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserGroupMembershipState<'Groups, 'User> = { assignments: ResizeArray<aws.IamUserGroupMembership.IamUserGroupMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_group_membership">aws_iam_user_group_membership</a>.
    /// </summary>
    type IamUserGroupMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserGroupMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserGroupMembershipState<Missing, Missing>)

        member _.Zero(()) : IamUserGroupMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserGroupMembershipState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_group_membership#groups-1">IamUserGroupMembership#groups</a>.
        /// </summary>
        [<CustomOperation "groups">]
        member _.Groups(state: IamUserGroupMembershipState<Missing, 'User>, value: seq<string>) : IamUserGroupMembershipState<Present, 'User> =
            state.assignments.Add(fun config -> config.Groups <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamUserGroupMembershipState<Present, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_group_membership#user-1">IamUserGroupMembership#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: IamUserGroupMembershipState<'Groups, Missing>, value: string) : IamUserGroupMembershipState<'Groups, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : IamUserGroupMembershipState<'Groups, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_group_membership#id-1">IamUserGroupMembership#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamUserGroupMembershipState<'Groups, 'User>, value: string) : IamUserGroupMembershipState<'Groups, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamUserGroupMembershipState<'Groups, 'User>

        member _.Run(state: IamUserGroupMembershipState<Present, Present>) : aws.IamUserGroupMembership.IamUserGroupMembership =
            let config = aws.IamUserGroupMembership.IamUserGroupMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserGroupMembership.IamUserGroupMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserGroupMembership: missing required arguments. Must call: groups, user.", 9999, IsError = true)>]
        member _.Run(_: IamUserGroupMembershipState<_, _>) : aws.IamUserGroupMembership.IamUserGroupMembership =
            Unchecked.defaultof<aws.IamUserGroupMembership.IamUserGroupMembership>
