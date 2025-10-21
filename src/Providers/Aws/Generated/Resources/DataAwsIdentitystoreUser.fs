namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIdentitystoreUserState<'IdentityStoreId> = { assignments: ResizeArray<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user">aws_identitystore_user</a>.
    /// </summary>
    type DataAwsIdentitystoreUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIdentitystoreUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreUserState<Missing>)

        member _.Zero(()) : DataAwsIdentitystoreUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIdentitystoreUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#identity_store_id-1">DataAwsIdentitystoreUser#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: DataAwsIdentitystoreUserState<Missing>, value: string) : DataAwsIdentitystoreUserState<Present> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : DataAwsIdentitystoreUserState<Present>)

        /// <summary>
        /// alternate_identifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#alternate_identifier-1">DataAwsIdentitystoreUser#alternate_identifier</a>
        /// </summary>
        [<CustomOperation "alternate_identifier">]
        member _.AlternateIdentifier(state: DataAwsIdentitystoreUserState<'IdentityStoreId>, value: aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier) : DataAwsIdentitystoreUserState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.AlternateIdentifier <- value)
            state : DataAwsIdentitystoreUserState<'IdentityStoreId>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#filter-1">DataAwsIdentitystoreUser#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsIdentitystoreUserState<'IdentityStoreId>, value: aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserFilter) : DataAwsIdentitystoreUserState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsIdentitystoreUserState<'IdentityStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#id-1">DataAwsIdentitystoreUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIdentitystoreUserState<'IdentityStoreId>, value: string) : DataAwsIdentitystoreUserState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIdentitystoreUserState<'IdentityStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#user_id-1">DataAwsIdentitystoreUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: DataAwsIdentitystoreUserState<'IdentityStoreId>, value: string) : DataAwsIdentitystoreUserState<'IdentityStoreId> =
            state.assignments.Add(fun config -> config.UserId <- value)
            state : DataAwsIdentitystoreUserState<'IdentityStoreId>

        member _.Run(state: DataAwsIdentitystoreUserState<Present>) : aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser =
            let config = aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIdentitystoreUser: missing required arguments. Must call: identity_store_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIdentitystoreUserState<_>) : aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser =
            Unchecked.defaultof<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser>
