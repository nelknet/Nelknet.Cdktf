namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageShareFileState<'Name, 'StorageShareId> = { assignments: ResizeArray<azurerm.StorageShareFile.StorageShareFileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file">azurerm_storage_share_file</a>.
    /// </summary>
    type StorageShareFileBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageShareFileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageShareFileState<Missing, Missing>)

        member _.Zero(()) : StorageShareFileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageShareFileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#name-1">StorageShareFile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageShareFileState<Missing, 'StorageShareId>, value: string) : StorageShareFileState<Present, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageShareFileState<Present, 'StorageShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#storage_share_id-1">StorageShareFile#storage_share_id</a>.
        /// </summary>
        [<CustomOperation "storage_share_id">]
        member _.StorageShareId(state: StorageShareFileState<'Name, Missing>, value: string) : StorageShareFileState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageShareId <- value)
            ({ assignments = state.assignments } : StorageShareFileState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#content_disposition-1">StorageShareFile#content_disposition</a>.
        /// </summary>
        [<CustomOperation "content_disposition">]
        member _.ContentDisposition(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.ContentDisposition <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#content_encoding-1">StorageShareFile#content_encoding</a>.
        /// </summary>
        [<CustomOperation "content_encoding">]
        member _.ContentEncoding(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.ContentEncoding <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#content_md5-1">StorageShareFile#content_md5</a>.
        /// </summary>
        [<CustomOperation "content_md5">]
        member _.ContentMd5(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.ContentMd5 <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#content_type-1">StorageShareFile#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#id-1">StorageShareFile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#metadata-1">StorageShareFile#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: StorageShareFileState<'Name, 'StorageShareId>, value: seq<string * string>) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#path-1">StorageShareFile#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#source-1">StorageShareFile#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: StorageShareFileState<'Name, 'StorageShareId>, value: string) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share_file#timeouts-1">StorageShareFile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageShareFileState<'Name, 'StorageShareId>, value: azurerm.StorageShareFile.StorageShareFileTimeouts) : StorageShareFileState<'Name, 'StorageShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageShareFileState<'Name, 'StorageShareId>

        member _.Run(state: StorageShareFileState<Present, Present>) : azurerm.StorageShareFile.StorageShareFile =
            let config = azurerm.StorageShareFile.StorageShareFileConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageShareFile.StorageShareFile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageShareFile: missing required arguments. Must call: name, storage_share_id.", 9999, IsError = true)>]
        member _.Run(_: StorageShareFileState<_, _>) : azurerm.StorageShareFile.StorageShareFile =
            Unchecked.defaultof<azurerm.StorageShareFile.StorageShareFile>
