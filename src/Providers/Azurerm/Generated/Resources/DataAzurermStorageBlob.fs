namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName> = { assignments: ResizeArray<azurerm.DataAzurermStorageBlob.DataAzurermStorageBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob">azurerm_storage_blob</a>.
    /// </summary>
    type DataAzurermStorageBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageBlobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageBlobState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageBlobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageBlobState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob#name-1">DataAzurermStorageBlob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageBlobState<Missing, 'StorageAccountName, 'StorageContainerName>, value: string) : DataAzurermStorageBlobState<Present, 'StorageAccountName, 'StorageContainerName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageBlobState<Present, 'StorageAccountName, 'StorageContainerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob#storage_account_name-1">DataAzurermStorageBlob#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: DataAzurermStorageBlobState<'Name, Missing, 'StorageContainerName>, value: string) : DataAzurermStorageBlobState<'Name, Present, 'StorageContainerName> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageBlobState<'Name, Present, 'StorageContainerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob#storage_container_name-1">DataAzurermStorageBlob#storage_container_name</a>.
        /// </summary>
        [<CustomOperation "storage_container_name">]
        member _.StorageContainerName(state: DataAzurermStorageBlobState<'Name, 'StorageAccountName, Missing>, value: string) : DataAzurermStorageBlobState<'Name, 'StorageAccountName, Present> =
            state.assignments.Add(fun config -> config.StorageContainerName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageBlobState<'Name, 'StorageAccountName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob#id-1">DataAzurermStorageBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName>, value: string) : DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob#metadata-1">DataAzurermStorageBlob#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName>, value: seq<string * string>) : DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_blob#timeouts-1">DataAzurermStorageBlob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName>, value: azurerm.DataAzurermStorageBlob.DataAzurermStorageBlobTimeouts) : DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName>

        member _.Run(state: DataAzurermStorageBlobState<Present, Present, Present>) : azurerm.DataAzurermStorageBlob.DataAzurermStorageBlob =
            let config = azurerm.DataAzurermStorageBlob.DataAzurermStorageBlobConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageBlob.DataAzurermStorageBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageBlob: missing required arguments. Must call: name, storage_account_name, storage_container_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageBlobState<_, _, _>) : azurerm.DataAzurermStorageBlob.DataAzurermStorageBlob =
            Unchecked.defaultof<azurerm.DataAzurermStorageBlob.DataAzurermStorageBlob>
