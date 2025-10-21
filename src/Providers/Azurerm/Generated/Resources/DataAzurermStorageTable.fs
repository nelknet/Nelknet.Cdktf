namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageTableState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.DataAzurermStorageTable.DataAzurermStorageTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table">azurerm_storage_table</a>.
    /// </summary>
    type DataAzurermStorageTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageTableState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table#name-1">DataAzurermStorageTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageTableState<Missing, 'StorageAccountName>, value: string) : DataAzurermStorageTableState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table#storage_account_name-1">DataAzurermStorageTable#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: DataAzurermStorageTableState<'Name, Missing>, value: string) : DataAzurermStorageTableState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableState<'Name, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table#timeouts-1">DataAzurermStorageTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageTableState<'Name, 'StorageAccountName>, value: azurerm.DataAzurermStorageTable.DataAzurermStorageTableTimeouts) : DataAzurermStorageTableState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageTableState<'Name, 'StorageAccountName>

        member _.Run(state: DataAzurermStorageTableState<Present, Present>) : azurerm.DataAzurermStorageTable.DataAzurermStorageTable =
            let config = azurerm.DataAzurermStorageTable.DataAzurermStorageTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageTable.DataAzurermStorageTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageTable: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageTableState<_, _>) : azurerm.DataAzurermStorageTable.DataAzurermStorageTable =
            Unchecked.defaultof<azurerm.DataAzurermStorageTable.DataAzurermStorageTable>
