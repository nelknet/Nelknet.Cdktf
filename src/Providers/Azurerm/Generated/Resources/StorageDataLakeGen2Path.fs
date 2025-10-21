namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2PathConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path">azurerm_storage_data_lake_gen2_path</a>.
    /// </summary>
    type StorageDataLakeGen2PathBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageDataLakeGen2PathState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageDataLakeGen2PathState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageDataLakeGen2PathState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageDataLakeGen2PathState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#filesystem_name-1">StorageDataLakeGen2Path#filesystem_name</a>.
        /// </summary>
        [<CustomOperation "filesystem_name">]
        member _.FilesystemName(state: StorageDataLakeGen2PathState<Missing, 'Path, 'Resource, 'StorageAccountId>, value: string) : StorageDataLakeGen2PathState<Present, 'Path, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FilesystemName <- value)
            ({ assignments = state.assignments } : StorageDataLakeGen2PathState<Present, 'Path, 'Resource, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#path-1">StorageDataLakeGen2Path#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: StorageDataLakeGen2PathState<'FilesystemName, Missing, 'Resource, 'StorageAccountId>, value: string) : StorageDataLakeGen2PathState<'FilesystemName, Present, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Path <- value)
            ({ assignments = state.assignments } : StorageDataLakeGen2PathState<'FilesystemName, Present, 'Resource, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#resource-1">StorageDataLakeGen2Path#resource</a>.
        /// </summary>
        [<CustomOperation "resource">]
        member _.Resource(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, Missing, 'StorageAccountId>, value: string) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Resource <- value)
            ({ assignments = state.assignments } : StorageDataLakeGen2PathState<'FilesystemName, 'Path, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#storage_account_id-1">StorageDataLakeGen2Path#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, Missing>, value: string) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, Present>)

        /// <summary>
        /// ace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#ace-1">StorageDataLakeGen2Path#ace</a> Accepts: azurerm.IResolvable | azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2PathAce[]
        /// </summary>
        [<CustomOperation "ace">]
        member _.Ace(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Ace <- value)
            state : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#group-1">StorageDataLakeGen2Path#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>, value: string) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Group <- value)
            state : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#id-1">StorageDataLakeGen2Path#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>, value: string) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#owner-1">StorageDataLakeGen2Path#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>, value: string) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_data_lake_gen2_path#timeouts-1">StorageDataLakeGen2Path#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>, value: azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2PathTimeouts) : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageDataLakeGen2PathState<'FilesystemName, 'Path, 'Resource, 'StorageAccountId>

        member _.Run(state: StorageDataLakeGen2PathState<Present, Present, Present, Present>) : azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2Path =
            let config = azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2PathConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2Path(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageDataLakeGen2Path: missing required arguments. Must call: filesystem_name, path, resource, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageDataLakeGen2PathState<_, _, _, _>) : azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2Path =
            Unchecked.defaultof<azurerm.StorageDataLakeGen2Path.StorageDataLakeGen2Path>
