namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageContainerState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.DataAzurermStorageContainer.DataAzurermStorageContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container">azurerm_storage_container</a>.
    /// </summary>
    type DataAzurermStorageContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageContainerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageContainerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageContainerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageContainerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#name-1">DataAzurermStorageContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageContainerState<Missing, 'StorageAccountName>, value: string) : DataAzurermStorageContainerState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageContainerState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#storage_account_name-1">DataAzurermStorageContainer#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: DataAzurermStorageContainerState<'Name, Missing>, value: string) : DataAzurermStorageContainerState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageContainerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#id-1">DataAzurermStorageContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageContainerState<'Name, 'StorageAccountName>, value: string) : DataAzurermStorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#metadata-1">DataAzurermStorageContainer#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: DataAzurermStorageContainerState<'Name, 'StorageAccountName>, value: seq<string * string>) : DataAzurermStorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : DataAzurermStorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#timeouts-1">DataAzurermStorageContainer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageContainerState<'Name, 'StorageAccountName>, value: azurerm.DataAzurermStorageContainer.DataAzurermStorageContainerTimeouts) : DataAzurermStorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageContainerState<'Name, 'StorageAccountName>

        member _.Run(state: DataAzurermStorageContainerState<Present, Present>) : azurerm.DataAzurermStorageContainer.DataAzurermStorageContainer =
            let config = azurerm.DataAzurermStorageContainer.DataAzurermStorageContainerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageContainer.DataAzurermStorageContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageContainer: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageContainerState<_, _>) : azurerm.DataAzurermStorageContainer.DataAzurermStorageContainer =
            Unchecked.defaultof<azurerm.DataAzurermStorageContainer.DataAzurermStorageContainer>
