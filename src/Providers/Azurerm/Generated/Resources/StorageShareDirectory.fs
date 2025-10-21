namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageShareDirectoryState<'Name, 'StorageShareId> = { assignments: ResizeArray<azurerm.StorageShareDirectory.StorageShareDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_directory">azurerm_storage_share_directory</a>.
    /// </summary>
    type StorageShareDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageShareDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageShareDirectoryState<Missing, Missing>)

        member _.Zero(()) : StorageShareDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageShareDirectoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_directory#name-1">StorageShareDirectory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageShareDirectoryState<Missing, 'StorageShareId>, value: string) : StorageShareDirectoryState<Present, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageShareDirectoryState<Present, 'StorageShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_directory#storage_share_id-1">StorageShareDirectory#storage_share_id</a>.
        /// </summary>
        [<CustomOperation "storage_share_id">]
        member _.StorageShareId(state: StorageShareDirectoryState<'Name, Missing>, value: string) : StorageShareDirectoryState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageShareId <- value)
            ({ assignments = state.assignments } : StorageShareDirectoryState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_directory#id-1">StorageShareDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageShareDirectoryState<'Name, 'StorageShareId>, value: string) : StorageShareDirectoryState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageShareDirectoryState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_directory#metadata-1">StorageShareDirectory#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: StorageShareDirectoryState<'Name, 'StorageShareId>, value: seq<string * string>) : StorageShareDirectoryState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : StorageShareDirectoryState<'Name, 'StorageShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_directory#timeouts-1">StorageShareDirectory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageShareDirectoryState<'Name, 'StorageShareId>, value: azurerm.StorageShareDirectory.StorageShareDirectoryTimeouts) : StorageShareDirectoryState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageShareDirectoryState<'Name, 'StorageShareId>

        member _.Run(state: StorageShareDirectoryState<Present, Present>) : azurerm.StorageShareDirectory.StorageShareDirectory =
            let config = azurerm.StorageShareDirectory.StorageShareDirectoryConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageShareDirectory.StorageShareDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageShareDirectory: missing required arguments. Must call: name, storage_share_id.", 9999, IsError = true)>]
        member _.Run(_: StorageShareDirectoryState<_, _>) : azurerm.StorageShareDirectory.StorageShareDirectory =
            Unchecked.defaultof<azurerm.StorageShareDirectory.StorageShareDirectory>
