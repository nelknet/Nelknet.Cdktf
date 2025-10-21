namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageShareState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.DataAzurermStorageShare.DataAzurermStorageShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share">azurerm_storage_share</a>.
    /// </summary>
    type DataAzurermStorageShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageShareState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageShareState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageShareState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageShareState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#name-1">DataAzurermStorageShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageShareState<Missing, 'StorageAccountName>, value: string) : DataAzurermStorageShareState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageShareState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#storage_account_name-1">DataAzurermStorageShare#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: DataAzurermStorageShareState<'Name, Missing>, value: string) : DataAzurermStorageShareState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageShareState<'Name, Present>)

        /// <summary>
        /// acl block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#acl-1">DataAzurermStorageShare#acl</a> Accepts: azurerm.IResolvable | azurerm.DataAzurermStorageShare.DataAzurermStorageShareAcl[]
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: DataAzurermStorageShareState<'Name, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermStorageShareState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : DataAzurermStorageShareState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#id-1">DataAzurermStorageShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageShareState<'Name, 'StorageAccountName>, value: string) : DataAzurermStorageShareState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageShareState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#metadata-1">DataAzurermStorageShare#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: DataAzurermStorageShareState<'Name, 'StorageAccountName>, value: seq<string * string>) : DataAzurermStorageShareState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : DataAzurermStorageShareState<'Name, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#timeouts-1">DataAzurermStorageShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageShareState<'Name, 'StorageAccountName>, value: azurerm.DataAzurermStorageShare.DataAzurermStorageShareTimeouts) : DataAzurermStorageShareState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageShareState<'Name, 'StorageAccountName>

        member _.Run(state: DataAzurermStorageShareState<Present, Present>) : azurerm.DataAzurermStorageShare.DataAzurermStorageShare =
            let config = azurerm.DataAzurermStorageShare.DataAzurermStorageShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageShare.DataAzurermStorageShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageShare: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageShareState<_, _>) : azurerm.DataAzurermStorageShare.DataAzurermStorageShare =
            Unchecked.defaultof<azurerm.DataAzurermStorageShare.DataAzurermStorageShare>
