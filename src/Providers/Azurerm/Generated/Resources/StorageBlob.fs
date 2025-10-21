namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> = { assignments: ResizeArray<azurerm.StorageBlob.StorageBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob">azurerm_storage_blob</a>.
    /// </summary>
    type StorageBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageBlobState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageBlobState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageBlobState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageBlobState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#name-1">StorageBlob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageBlobState<Missing, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<Present, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageBlobState<Present, 'StorageAccountName, 'StorageContainerName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#storage_account_name-1">StorageBlob#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StorageBlobState<'Name, Missing, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, Present, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StorageBlobState<'Name, Present, 'StorageContainerName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#storage_container_name-1">StorageBlob#storage_container_name</a>.
        /// </summary>
        [<CustomOperation "storage_container_name">]
        member _.StorageContainerName(state: StorageBlobState<'Name, 'StorageAccountName, Missing, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, Present, 'Type> =
            state.assignments.Add(fun config -> config.StorageContainerName <- value)
            ({ assignments = state.assignments } : StorageBlobState<'Name, 'StorageAccountName, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#type-1">StorageBlob#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, Missing>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#access_tier-1">StorageBlob#access_tier</a>.
        /// </summary>
        [<CustomOperation "access_tier">]
        member _.AccessTier(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.AccessTier <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#cache_control-1">StorageBlob#cache_control</a>.
        /// </summary>
        [<CustomOperation "cache_control">]
        member _.CacheControl(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.CacheControl <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#content_md5-1">StorageBlob#content_md5</a>.
        /// </summary>
        [<CustomOperation "content_md5">]
        member _.ContentMd5(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.ContentMd5 <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#content_type-1">StorageBlob#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#encryption_scope-1">StorageBlob#encryption_scope</a>.
        /// </summary>
        [<CustomOperation "encryption_scope">]
        member _.EncryptionScope(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.EncryptionScope <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#id-1">StorageBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#metadata-1">StorageBlob#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: seq<string * string>) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#parallelism-1">StorageBlob#parallelism</a>.
        /// </summary>
        [<CustomOperation "parallelism">]
        member _.Parallelism(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: double) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Parallelism <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#size-1">StorageBlob#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: double) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Size <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#source-1">StorageBlob#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#source_content-1">StorageBlob#source_content</a>.
        /// </summary>
        [<CustomOperation "source_content">]
        member _.SourceContent(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.SourceContent <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#source_uri-1">StorageBlob#source_uri</a>.
        /// </summary>
        [<CustomOperation "source_uri">]
        member _.SourceUri(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: string) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.SourceUri <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob#timeouts-1">StorageBlob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>, value: azurerm.StorageBlob.StorageBlobTimeouts) : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageBlobState<'Name, 'StorageAccountName, 'StorageContainerName, 'Type>

        member _.Run(state: StorageBlobState<Present, Present, Present, Present>) : azurerm.StorageBlob.StorageBlob =
            let config = azurerm.StorageBlob.StorageBlobConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageBlob.StorageBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageBlob: missing required arguments. Must call: name, storage_account_name, storage_container_name, type.", 9999, IsError = true)>]
        member _.Run(_: StorageBlobState<_, _, _, _>) : azurerm.StorageBlob.StorageBlob =
            Unchecked.defaultof<azurerm.StorageBlob.StorageBlob>
