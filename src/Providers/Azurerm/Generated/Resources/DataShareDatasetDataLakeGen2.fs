namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId> = { assignments: ResizeArray<azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2">azurerm_data_share_dataset_data_lake_gen2</a>.
    /// </summary>
    type DataShareDatasetDataLakeGen2Builder(logicalId: string) =
        member _.Yield(_: unit) : DataShareDatasetDataLakeGen2State<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetDataLakeGen2State<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataShareDatasetDataLakeGen2State<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetDataLakeGen2State<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#file_system_name-1">DataShareDatasetDataLakeGen2#file_system_name</a>.
        /// </summary>
        [<CustomOperation "file_system_name">]
        member _.FileSystemName(state: DataShareDatasetDataLakeGen2State<Missing, 'Name, 'ShareId, 'StorageAccountId>, value: string) : DataShareDatasetDataLakeGen2State<Present, 'Name, 'ShareId, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FileSystemName <- value)
            ({ assignments = state.assignments } : DataShareDatasetDataLakeGen2State<Present, 'Name, 'ShareId, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#name-1">DataShareDatasetDataLakeGen2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataShareDatasetDataLakeGen2State<'FileSystemName, Missing, 'ShareId, 'StorageAccountId>, value: string) : DataShareDatasetDataLakeGen2State<'FileSystemName, Present, 'ShareId, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataShareDatasetDataLakeGen2State<'FileSystemName, Present, 'ShareId, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#share_id-1">DataShareDatasetDataLakeGen2#share_id</a>.
        /// </summary>
        [<CustomOperation "share_id">]
        member _.ShareId(state: DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, Missing, 'StorageAccountId>, value: string) : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ShareId <- value)
            ({ assignments = state.assignments } : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#storage_account_id-1">DataShareDatasetDataLakeGen2#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, Missing>, value: string) : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#file_path-1">DataShareDatasetDataLakeGen2#file_path</a>.
        /// </summary>
        [<CustomOperation "file_path">]
        member _.FilePath(state: DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>, value: string) : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FilePath <- value)
            state : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#folder_path-1">DataShareDatasetDataLakeGen2#folder_path</a>.
        /// </summary>
        [<CustomOperation "folder_path">]
        member _.FolderPath(state: DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>, value: string) : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FolderPath <- value)
            state : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#id-1">DataShareDatasetDataLakeGen2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>, value: string) : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#timeouts-1">DataShareDatasetDataLakeGen2#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>, value: azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2Timeouts) : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataShareDatasetDataLakeGen2State<'FileSystemName, 'Name, 'ShareId, 'StorageAccountId>

        member _.Run(state: DataShareDatasetDataLakeGen2State<Present, Present, Present, Present>) : azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2 =
            let config = azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2Config()
            for setter in state.assignments do
                setter config
            azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataShareDatasetDataLakeGen2: missing required arguments. Must call: file_system_name, name, share_id, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataShareDatasetDataLakeGen2State<_, _, _, _>) : azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2 =
            Unchecked.defaultof<azurerm.DataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2>
