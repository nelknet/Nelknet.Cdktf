namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2FilesystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem">azurerm_storage_data_lake_gen2_filesystem</a>.
    /// </summary>
    type StorageDataLakeGen2FilesystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageDataLakeGen2FilesystemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageDataLakeGen2FilesystemState<Missing, Missing>)

        member _.Zero(()) : StorageDataLakeGen2FilesystemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageDataLakeGen2FilesystemState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#name-1">StorageDataLakeGen2Filesystem#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageDataLakeGen2FilesystemState<Missing, 'StorageAccountId>, value: string) : StorageDataLakeGen2FilesystemState<Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageDataLakeGen2FilesystemState<Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#storage_account_id-1">StorageDataLakeGen2Filesystem#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageDataLakeGen2FilesystemState<'Name, Missing>, value: string) : StorageDataLakeGen2FilesystemState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageDataLakeGen2FilesystemState<'Name, Present>)

        /// <summary>
        /// ace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#ace-1">StorageDataLakeGen2Filesystem#ace</a> Accepts: azurerm.IResolvable | azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2FilesystemAce[]
        /// </summary>
        [<CustomOperation "ace">]
        member _.Ace(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Ace <- value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#default_encryption_scope-1">StorageDataLakeGen2Filesystem#default_encryption_scope</a>.
        /// </summary>
        [<CustomOperation "default_encryption_scope">]
        member _.DefaultEncryptionScope(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: string) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.DefaultEncryptionScope <- value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#group-1">StorageDataLakeGen2Filesystem#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: string) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Group <- value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#id-1">StorageDataLakeGen2Filesystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: string) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#owner-1">StorageDataLakeGen2Filesystem#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: string) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#properties-1">StorageDataLakeGen2Filesystem#properties</a>.
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: seq<string * string>) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Properties <- dict value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_filesystem#timeouts-1">StorageDataLakeGen2Filesystem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>, value: azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2FilesystemTimeouts) : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageDataLakeGen2FilesystemState<'Name, 'StorageAccountId>

        member _.Run(state: StorageDataLakeGen2FilesystemState<Present, Present>) : azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2Filesystem =
            let config = azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2FilesystemConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2Filesystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageDataLakeGen2Filesystem: missing required arguments. Must call: name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageDataLakeGen2FilesystemState<_, _>) : azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2Filesystem =
            Unchecked.defaultof<azurerm.StorageDataLakeGen2Filesystem.StorageDataLakeGen2Filesystem>
