namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIdentitystoreGroupState<'IdentityStoreId> = { assignments: ResizeArray<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group">aws_identitystore_group</a>.
    /// </summary>
    type DataAwsIdentitystoreGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIdentitystoreGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreGroupState<Missing>)

        member _.Zero(()) : DataAwsIdentitystoreGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#identity_store_id-1">DataAwsIdentitystoreGroup#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: DataAwsIdentitystoreGroupState<Missing>, value: string) : DataAwsIdentitystoreGroupState<Present> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : DataAwsIdentitystoreGroupState<Present>)

        /// <summary>
        /// alternate_identifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#alternate_identifier-1">DataAwsIdentitystoreGroup#alternate_identifier</a>
        /// </summary>
        [<CustomOperation "alternate_identifier">]
        member _.AlternateIdentifier(state: DataAwsIdentitystoreGroupState<'IdentityStoreId>, value: aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier) : DataAwsIdentitystoreGroupState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.AlternateIdentifier <- value)
            state : DataAwsIdentitystoreGroupState<'IdentityStoreId>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#filter-1">DataAwsIdentitystoreGroup#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsIdentitystoreGroupState<'IdentityStoreId>, value: aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilter) : DataAwsIdentitystoreGroupState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsIdentitystoreGroupState<'IdentityStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#group_id-1">DataAwsIdentitystoreGroup#group_id</a>.
        /// </summary>
        [<CustomOperation "group_id">]
        member _.GroupId(state: DataAwsIdentitystoreGroupState<'IdentityStoreId>, value: string) : DataAwsIdentitystoreGroupState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.GroupId <- value)
            state : DataAwsIdentitystoreGroupState<'IdentityStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#id-1">DataAwsIdentitystoreGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIdentitystoreGroupState<'IdentityStoreId>, value: string) : DataAwsIdentitystoreGroupState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIdentitystoreGroupState<'IdentityStoreId>

        member _.Run(state: DataAwsIdentitystoreGroupState<Present>) : aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup =
            let config = aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIdentitystoreGroup: missing required arguments. Must call: identity_store_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIdentitystoreGroupState<_>) : aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup =
            Unchecked.defaultof<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup>
