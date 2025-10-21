namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIdentitystoreGroupsState<'IdentityStoreId> = { assignments: ResizeArray<aws.DataAwsIdentitystoreGroups.DataAwsIdentitystoreGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_groups">aws_identitystore_groups</a>.
    /// </summary>
    type DataAwsIdentitystoreGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIdentitystoreGroupsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreGroupsState<Missing>)

        member _.Zero(()) : DataAwsIdentitystoreGroupsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreGroupsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_groups#identity_store_id-1">DataAwsIdentitystoreGroups#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: DataAwsIdentitystoreGroupsState<Missing>, value: string) : DataAwsIdentitystoreGroupsState<Present> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : DataAwsIdentitystoreGroupsState<Present>)

        member _.Run(state: DataAwsIdentitystoreGroupsState<Present>) : aws.DataAwsIdentitystoreGroups.DataAwsIdentitystoreGroups =
            let config = aws.DataAwsIdentitystoreGroups.DataAwsIdentitystoreGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIdentitystoreGroups.DataAwsIdentitystoreGroups(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIdentitystoreGroups: missing required arguments. Must call: identity_store_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIdentitystoreGroupsState<_>) : aws.DataAwsIdentitystoreGroups.DataAwsIdentitystoreGroups =
            Unchecked.defaultof<aws.DataAwsIdentitystoreGroups.DataAwsIdentitystoreGroups>
