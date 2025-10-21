namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamGroupMembershipState<'Group, 'Name, 'Users> = { assignments: ResizeArray<aws.IamGroupMembership.IamGroupMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_membership">aws_iam_group_membership</a>.
    /// </summary>
    type IamGroupMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamGroupMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupMembershipState<Missing, Missing, Missing>)

        member _.Zero(()) : IamGroupMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupMembershipState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_membership#group-1">IamGroupMembership#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: IamGroupMembershipState<Missing, 'Name, 'Users>, value: string) : IamGroupMembershipState<Present, 'Name, 'Users> =
            state.assignments.Add(fun config -> config.Group <- value)
            ({ assignments = state.assignments } : IamGroupMembershipState<Present, 'Name, 'Users>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_membership#name-1">IamGroupMembership#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamGroupMembershipState<'Group, Missing, 'Users>, value: string) : IamGroupMembershipState<'Group, Present, 'Users> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IamGroupMembershipState<'Group, Present, 'Users>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_membership#users-1">IamGroupMembership#users</a>.
        /// </summary>
        [<CustomOperation "users">]
        member _.Users(state: IamGroupMembershipState<'Group, 'Name, Missing>, value: seq<string>) : IamGroupMembershipState<'Group, 'Name, Present> =
            state.assignments.Add(fun config -> config.Users <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamGroupMembershipState<'Group, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_membership#id-1">IamGroupMembership#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamGroupMembershipState<'Group, 'Name, 'Users>, value: string) : IamGroupMembershipState<'Group, 'Name, 'Users> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamGroupMembershipState<'Group, 'Name, 'Users>

        member _.Run(state: IamGroupMembershipState<Present, Present, Present>) : aws.IamGroupMembership.IamGroupMembership =
            let config = aws.IamGroupMembership.IamGroupMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.IamGroupMembership.IamGroupMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamGroupMembership: missing required arguments. Must call: group, name, users.", 9999, IsError = true)>]
        member _.Run(_: IamGroupMembershipState<_, _, _>) : aws.IamGroupMembership.IamGroupMembership =
            Unchecked.defaultof<aws.IamGroupMembership.IamGroupMembership>
