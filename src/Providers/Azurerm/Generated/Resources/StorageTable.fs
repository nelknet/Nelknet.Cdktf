namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageTableState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.StorageTable.StorageTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table">azurerm_storage_table</a>.
    /// </summary>
    type StorageTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageTableState<Missing, Missing>)

        member _.Zero(()) : StorageTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#name-1">StorageTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageTableState<Missing, 'StorageAccountName>, value: string) : StorageTableState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageTableState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#storage_account_name-1">StorageTable#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StorageTableState<'Name, Missing>, value: string) : StorageTableState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StorageTableState<'Name, Present>)

        /// <summary>
        /// acl block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#acl-1">StorageTable#acl</a> Accepts: azurerm.IResolvable | azurerm.StorageTable.StorageTableAcl[]
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: StorageTableState<'Name, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : StorageTableState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : StorageTableState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#id-1">StorageTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageTableState<'Name, 'StorageAccountName>, value: string) : StorageTableState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageTableState<'Name, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#timeouts-1">StorageTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageTableState<'Name, 'StorageAccountName>, value: azurerm.StorageTable.StorageTableTimeouts) : StorageTableState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageTableState<'Name, 'StorageAccountName>

        member _.Run(state: StorageTableState<Present, Present>) : azurerm.StorageTable.StorageTable =
            let config = azurerm.StorageTable.StorageTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageTable.StorageTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageTable: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: StorageTableState<_, _>) : azurerm.StorageTable.StorageTable =
            Unchecked.defaultof<azurerm.StorageTable.StorageTable>
