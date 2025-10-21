namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIdentitystoreUsersState<'IdentityStoreId> = { assignments: ResizeArray<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_users">aws_identitystore_users</a>.
    /// </summary>
    type DataAwsIdentitystoreUsersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIdentitystoreUsersState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreUsersState<Missing>)

        member _.Zero(()) : DataAwsIdentitystoreUsersState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreUsersState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_users#identity_store_id-1">DataAwsIdentitystoreUsers#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: DataAwsIdentitystoreUsersState<Missing>, value: string) : DataAwsIdentitystoreUsersState<Present> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : DataAwsIdentitystoreUsersState<Present>)

        member _.Run(state: DataAwsIdentitystoreUsersState<Present>) : aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsers =
            let config = aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsers(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIdentitystoreUsers: missing required arguments. Must call: identity_store_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIdentitystoreUsersState<_>) : aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsers =
            Unchecked.defaultof<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsers>
