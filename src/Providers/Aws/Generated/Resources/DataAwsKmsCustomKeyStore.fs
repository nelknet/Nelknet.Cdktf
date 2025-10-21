namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsCustomKeyStoreState = { assignments: ResizeArray<aws.DataAwsKmsCustomKeyStore.DataAwsKmsCustomKeyStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_custom_key_store">aws_kms_custom_key_store</a>.
    /// </summary>
    type DataAwsKmsCustomKeyStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsCustomKeyStoreState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsKmsCustomKeyStoreState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_custom_key_store#custom_key_store_id-1">DataAwsKmsCustomKeyStore#custom_key_store_id</a>.
        /// </summary>
        [<CustomOperation "custom_key_store_id">]
        member _.CustomKeyStoreId(state: DataAwsKmsCustomKeyStoreState, value: string) : DataAwsKmsCustomKeyStoreState =
            state.assignments.Add(fun config -> config.CustomKeyStoreId <- value)
            state : DataAwsKmsCustomKeyStoreState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_custom_key_store#custom_key_store_name-1">DataAwsKmsCustomKeyStore#custom_key_store_name</a>.
        /// </summary>
        [<CustomOperation "custom_key_store_name">]
        member _.CustomKeyStoreName(state: DataAwsKmsCustomKeyStoreState, value: string) : DataAwsKmsCustomKeyStoreState =
            state.assignments.Add(fun config -> config.CustomKeyStoreName <- value)
            state : DataAwsKmsCustomKeyStoreState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_custom_key_store#id-1">DataAwsKmsCustomKeyStore#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsCustomKeyStoreState, value: string) : DataAwsKmsCustomKeyStoreState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsCustomKeyStoreState

        member _.Run(state: DataAwsKmsCustomKeyStoreState) : aws.DataAwsKmsCustomKeyStore.DataAwsKmsCustomKeyStore =
            let config = aws.DataAwsKmsCustomKeyStore.DataAwsKmsCustomKeyStoreConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsCustomKeyStore.DataAwsKmsCustomKeyStore(StackContext.get (), logicalId, config)
