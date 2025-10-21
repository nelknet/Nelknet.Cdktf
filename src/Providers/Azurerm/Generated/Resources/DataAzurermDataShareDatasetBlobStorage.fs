namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_blob_storage">azurerm_data_share_dataset_blob_storage</a>.
    /// </summary>
    type DataAzurermDataShareDatasetBlobStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataShareDatasetBlobStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetBlobStorageState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataShareDatasetBlobStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetBlobStorageState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_blob_storage#data_share_id-1">DataAzurermDataShareDatasetBlobStorage#data_share_id</a>.
        /// </summary>
        [<CustomOperation "data_share_id">]
        member _.DataShareId(state: DataAzurermDataShareDatasetBlobStorageState<Missing, 'Name>, value: string) : DataAzurermDataShareDatasetBlobStorageState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataShareId <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetBlobStorageState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_blob_storage#name-1">DataAzurermDataShareDatasetBlobStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataShareDatasetBlobStorageState<'DataShareId, Missing>, value: string) : DataAzurermDataShareDatasetBlobStorageState<'DataShareId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetBlobStorageState<'DataShareId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_blob_storage#id-1">DataAzurermDataShareDatasetBlobStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name>, value: string) : DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_blob_storage#timeouts-1">DataAzurermDataShareDatasetBlobStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name>, value: azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorageTimeouts) : DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataShareDatasetBlobStorageState<'DataShareId, 'Name>

        member _.Run(state: DataAzurermDataShareDatasetBlobStorageState<Present, Present>) : azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorage =
            let config = azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataShareDatasetBlobStorage: missing required arguments. Must call: data_share_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataShareDatasetBlobStorageState<_, _>) : azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorage =
            Unchecked.defaultof<azurerm.DataAzurermDataShareDatasetBlobStorage.DataAzurermDataShareDatasetBlobStorage>
