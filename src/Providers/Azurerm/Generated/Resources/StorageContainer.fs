namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageContainerState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.StorageContainer.StorageContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container">azurerm_storage_container</a>.
    /// </summary>
    type StorageContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageContainerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageContainerState<Missing, Missing>)

        member _.Zero(()) : StorageContainerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageContainerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#name-1">StorageContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageContainerState<Missing, 'StorageAccountName>, value: string) : StorageContainerState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageContainerState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#storage_account_name-1">StorageContainer#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StorageContainerState<'Name, Missing>, value: string) : StorageContainerState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StorageContainerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#container_access_type-1">StorageContainer#container_access_type</a>.
        /// </summary>
        [<CustomOperation "container_access_type">]
        member _.ContainerAccessType(state: StorageContainerState<'Name, 'StorageAccountName>, value: string) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ContainerAccessType <- value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#default_encryption_scope-1">StorageContainer#default_encryption_scope</a>.
        /// </summary>
        [<CustomOperation "default_encryption_scope">]
        member _.DefaultEncryptionScope(state: StorageContainerState<'Name, 'StorageAccountName>, value: string) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.DefaultEncryptionScope <- value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#encryption_scope_override_enabled-1">StorageContainer#encryption_scope_override_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_scope_override_enabled">]
        member _.EncryptionScopeOverrideEnabled(state: StorageContainerState<'Name, 'StorageAccountName>, value: bool) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EncryptionScopeOverrideEnabled <- value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#encryption_scope_override_enabled-1">StorageContainer#encryption_scope_override_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_scope_override_enabled">]
        member _.EncryptionScopeOverrideEnabled(state: StorageContainerState<'Name, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EncryptionScopeOverrideEnabled <- value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#id-1">StorageContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageContainerState<'Name, 'StorageAccountName>, value: string) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#metadata-1">StorageContainer#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: StorageContainerState<'Name, 'StorageAccountName>, value: seq<string * string>) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container#timeouts-1">StorageContainer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageContainerState<'Name, 'StorageAccountName>, value: azurerm.StorageContainer.StorageContainerTimeouts) : StorageContainerState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageContainerState<'Name, 'StorageAccountName>

        member _.Run(state: StorageContainerState<Present, Present>) : azurerm.StorageContainer.StorageContainer =
            let config = azurerm.StorageContainer.StorageContainerConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageContainer.StorageContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageContainer: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: StorageContainerState<_, _>) : azurerm.StorageContainer.StorageContainer =
            Unchecked.defaultof<azurerm.StorageContainer.StorageContainer>
