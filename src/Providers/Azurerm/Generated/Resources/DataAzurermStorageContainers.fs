namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageContainersState<'StorageAccountId> = { assignments: ResizeArray<azurerm.DataAzurermStorageContainers.DataAzurermStorageContainersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers">azurerm_storage_containers</a>.
    /// </summary>
    type DataAzurermStorageContainersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageContainersState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageContainersState<Missing>)

        member _.Zero(()) : DataAzurermStorageContainersState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageContainersState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers#storage_account_id-1">DataAzurermStorageContainers#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: DataAzurermStorageContainersState<Missing>, value: string) : DataAzurermStorageContainersState<Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : DataAzurermStorageContainersState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers#id-1">DataAzurermStorageContainers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageContainersState<'StorageAccountId>, value: string) : DataAzurermStorageContainersState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageContainersState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers#name_prefix-1">DataAzurermStorageContainers#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAzurermStorageContainersState<'StorageAccountId>, value: string) : DataAzurermStorageContainersState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAzurermStorageContainersState<'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers#timeouts-1">DataAzurermStorageContainers#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageContainersState<'StorageAccountId>, value: azurerm.DataAzurermStorageContainers.DataAzurermStorageContainersTimeouts) : DataAzurermStorageContainersState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageContainersState<'StorageAccountId>

        member _.Run(state: DataAzurermStorageContainersState<Present>) : azurerm.DataAzurermStorageContainers.DataAzurermStorageContainers =
            let config = azurerm.DataAzurermStorageContainers.DataAzurermStorageContainersConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageContainers.DataAzurermStorageContainers(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageContainers: missing required arguments. Must call: storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageContainersState<_>) : azurerm.DataAzurermStorageContainers.DataAzurermStorageContainers =
            Unchecked.defaultof<azurerm.DataAzurermStorageContainers.DataAzurermStorageContainers>
