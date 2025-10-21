namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIdentitystoreGroupMembershipsState<'GroupId, 'IdentityStoreId> = { assignments: ResizeArray<aws.DataAwsIdentitystoreGroupMemberships.DataAwsIdentitystoreGroupMembershipsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group_memberships">aws_identitystore_group_memberships</a>.
    /// </summary>
    type DataAwsIdentitystoreGroupMembershipsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIdentitystoreGroupMembershipsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreGroupMembershipsState<Missing, Missing>)

        member _.Zero(()) : DataAwsIdentitystoreGroupMembershipsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreGroupMembershipsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group_memberships#group_id-1">DataAwsIdentitystoreGroupMemberships#group_id</a>.
        /// </summary>
        [<CustomOperation "group_id">]
        member _.GroupId(state: DataAwsIdentitystoreGroupMembershipsState<Missing, 'IdentityStoreId>, value: string) : DataAwsIdentitystoreGroupMembershipsState<Present, 'IdentityStoreId> =
            state.assignments.Add(fun config -> config.GroupId <- value)
            ({ assignments = state.assignments } : DataAwsIdentitystoreGroupMembershipsState<Present, 'IdentityStoreId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group_memberships#identity_store_id-1">DataAwsIdentitystoreGroupMemberships#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: DataAwsIdentitystoreGroupMembershipsState<'GroupId, Missing>, value: string) : DataAwsIdentitystoreGroupMembershipsState<'GroupId, Present> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : DataAwsIdentitystoreGroupMembershipsState<'GroupId, Present>)

        member _.Run(state: DataAwsIdentitystoreGroupMembershipsState<Present, Present>) : aws.DataAwsIdentitystoreGroupMemberships.DataAwsIdentitystoreGroupMemberships =
            let config = aws.DataAwsIdentitystoreGroupMemberships.DataAwsIdentitystoreGroupMembershipsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIdentitystoreGroupMemberships.DataAwsIdentitystoreGroupMemberships(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIdentitystoreGroupMemberships: missing required arguments. Must call: group_id, identity_store_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIdentitystoreGroupMembershipsState<_, _>) : aws.DataAwsIdentitystoreGroupMemberships.DataAwsIdentitystoreGroupMemberships =
            Unchecked.defaultof<aws.DataAwsIdentitystoreGroupMemberships.DataAwsIdentitystoreGroupMemberships>
