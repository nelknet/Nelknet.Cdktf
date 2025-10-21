namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, 'MemberId> = { assignments: ResizeArray<aws.IdentitystoreGroupMembership.IdentitystoreGroupMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group_membership">aws_identitystore_group_membership</a>.
    /// </summary>
    type IdentitystoreGroupMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : IdentitystoreGroupMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IdentitystoreGroupMembershipState<Missing, Missing, Missing>)

        member _.Zero(()) : IdentitystoreGroupMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IdentitystoreGroupMembershipState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group_membership#group_id-1">IdentitystoreGroupMembership#group_id</a>.
        /// </summary>
        [<CustomOperation "group_id">]
        member _.GroupId(state: IdentitystoreGroupMembershipState<Missing, 'IdentityStoreId, 'MemberId>, value: string) : IdentitystoreGroupMembershipState<Present, 'IdentityStoreId, 'MemberId> =
            state.assignments.Add(fun config -> config.GroupId <- value)
            ({ assignments = state.assignments } : IdentitystoreGroupMembershipState<Present, 'IdentityStoreId, 'MemberId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group_membership#identity_store_id-1">IdentitystoreGroupMembership#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: IdentitystoreGroupMembershipState<'GroupId, Missing, 'MemberId>, value: string) : IdentitystoreGroupMembershipState<'GroupId, Present, 'MemberId> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : IdentitystoreGroupMembershipState<'GroupId, Present, 'MemberId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group_membership#member_id-1">IdentitystoreGroupMembership#member_id</a>.
        /// </summary>
        [<CustomOperation "member_id">]
        member _.MemberId(state: IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, Missing>, value: string) : IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, Present> =
            state.assignments.Add(fun config -> config.MemberId <- value)
            ({ assignments = state.assignments } : IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group_membership#id-1">IdentitystoreGroupMembership#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, 'MemberId>, value: string) : IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, 'MemberId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IdentitystoreGroupMembershipState<'GroupId, 'IdentityStoreId, 'MemberId>

        member _.Run(state: IdentitystoreGroupMembershipState<Present, Present, Present>) : aws.IdentitystoreGroupMembership.IdentitystoreGroupMembership =
            let config = aws.IdentitystoreGroupMembership.IdentitystoreGroupMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.IdentitystoreGroupMembership.IdentitystoreGroupMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.identitystoreGroupMembership: missing required arguments. Must call: group_id, identity_store_id, member_id.", 9999, IsError = true)>]
        member _.Run(_: IdentitystoreGroupMembershipState<_, _, _>) : aws.IdentitystoreGroupMembership.IdentitystoreGroupMembership =
            Unchecked.defaultof<aws.IdentitystoreGroupMembership.IdentitystoreGroupMembership>
