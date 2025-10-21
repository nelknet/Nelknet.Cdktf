namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount> = { assignments: ResizeArray<azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage">azurerm_data_share_dataset_blob_storage</a>.
    /// </summary>
    type DataShareDatasetBlobStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataShareDatasetBlobStorageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetBlobStorageState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataShareDatasetBlobStorageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetBlobStorageState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#container_name-1">DataShareDatasetBlobStorage#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: DataShareDatasetBlobStorageState<Missing, 'DataShareId, 'Name, 'StorageAccount>, value: string) : DataShareDatasetBlobStorageState<Present, 'DataShareId, 'Name, 'StorageAccount> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : DataShareDatasetBlobStorageState<Present, 'DataShareId, 'Name, 'StorageAccount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#data_share_id-1">DataShareDatasetBlobStorage#data_share_id</a>.
        /// </summary>
        [<CustomOperation "data_share_id">]
        member _.DataShareId(state: DataShareDatasetBlobStorageState<'ContainerName, Missing, 'Name, 'StorageAccount>, value: string) : DataShareDatasetBlobStorageState<'ContainerName, Present, 'Name, 'StorageAccount> =
            state.assignments.Add(fun config -> config.DataShareId <- value)
            ({ assignments = state.assignments } : DataShareDatasetBlobStorageState<'ContainerName, Present, 'Name, 'StorageAccount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#name-1">DataShareDatasetBlobStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, Missing, 'StorageAccount>, value: string) : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, Present, 'StorageAccount> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, Present, 'StorageAccount>)

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#storage_account-1">DataShareDatasetBlobStorage#storage_account</a>
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, Missing>, value: azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorageStorageAccount) : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            ({ assignments = state.assignments } : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#file_path-1">DataShareDatasetBlobStorage#file_path</a>.
        /// </summary>
        [<CustomOperation "file_path">]
        member _.FilePath(state: DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>, value: string) : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount> =
            state.assignments.Add(fun config -> config.FilePath <- value)
            state : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#folder_path-1">DataShareDatasetBlobStorage#folder_path</a>.
        /// </summary>
        [<CustomOperation "folder_path">]
        member _.FolderPath(state: DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>, value: string) : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount> =
            state.assignments.Add(fun config -> config.FolderPath <- value)
            state : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#id-1">DataShareDatasetBlobStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>, value: string) : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_blob_storage#timeouts-1">DataShareDatasetBlobStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>, value: azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorageTimeouts) : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataShareDatasetBlobStorageState<'ContainerName, 'DataShareId, 'Name, 'StorageAccount>

        member _.Run(state: DataShareDatasetBlobStorageState<Present, Present, Present, Present>) : azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorage =
            let config = azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataShareDatasetBlobStorage: missing required arguments. Must call: container_name, data_share_id, name, storage_account.", 9999, IsError = true)>]
        member _.Run(_: DataShareDatasetBlobStorageState<_, _, _, _>) : azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorage =
            Unchecked.defaultof<azurerm.DataShareDatasetBlobStorage.DataShareDatasetBlobStorage>
