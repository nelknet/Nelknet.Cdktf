namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageEncryptionScope.StorageEncryptionScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope">azurerm_storage_encryption_scope</a>.
    /// </summary>
    type StorageEncryptionScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageEncryptionScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageEncryptionScopeState<Missing, Missing, Missing>)

        member _.Zero(()) : StorageEncryptionScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageEncryptionScopeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#name-1">StorageEncryptionScope#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageEncryptionScopeState<Missing, 'Source, 'StorageAccountId>, value: string) : StorageEncryptionScopeState<Present, 'Source, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageEncryptionScopeState<Present, 'Source, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#source-1">StorageEncryptionScope#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: StorageEncryptionScopeState<'Name, Missing, 'StorageAccountId>, value: string) : StorageEncryptionScopeState<'Name, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : StorageEncryptionScopeState<'Name, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#storage_account_id-1">StorageEncryptionScope#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageEncryptionScopeState<'Name, 'Source, Missing>, value: string) : StorageEncryptionScopeState<'Name, 'Source, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageEncryptionScopeState<'Name, 'Source, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#id-1">StorageEncryptionScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>, value: string) : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#infrastructure_encryption_required-1">StorageEncryptionScope#infrastructure_encryption_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_required">]
        member _.InfrastructureEncryptionRequired(state: StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>, value: bool) : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionRequired <- value)
            state : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#infrastructure_encryption_required-1">StorageEncryptionScope#infrastructure_encryption_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_required">]
        member _.InfrastructureEncryptionRequired(state: StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionRequired <- value)
            state : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#key_vault_key_id-1">StorageEncryptionScope#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>, value: string) : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_encryption_scope#timeouts-1">StorageEncryptionScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>, value: azurerm.StorageEncryptionScope.StorageEncryptionScopeTimeouts) : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageEncryptionScopeState<'Name, 'Source, 'StorageAccountId>

        member _.Run(state: StorageEncryptionScopeState<Present, Present, Present>) : azurerm.StorageEncryptionScope.StorageEncryptionScope =
            let config = azurerm.StorageEncryptionScope.StorageEncryptionScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageEncryptionScope.StorageEncryptionScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageEncryptionScope: missing required arguments. Must call: name, source, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageEncryptionScopeState<_, _, _>) : azurerm.StorageEncryptionScope.StorageEncryptionScope =
            Unchecked.defaultof<azurerm.StorageEncryptionScope.StorageEncryptionScope>
