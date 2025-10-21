namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> = { assignments: ResizeArray<azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account">azurerm_key_vault_managed_storage_account</a>.
    /// </summary>
    type KeyVaultManagedStorageAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultManagedStorageAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedStorageAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultManagedStorageAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedStorageAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#key_vault_id-1">KeyVaultManagedStorageAccount#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultManagedStorageAccountState<Missing, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: string) : KeyVaultManagedStorageAccountState<Present, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountState<Present, 'Name, 'StorageAccountId, 'StorageAccountKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#name-1">KeyVaultManagedStorageAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultManagedStorageAccountState<'KeyVaultId, Missing, 'StorageAccountId, 'StorageAccountKey>, value: string) : KeyVaultManagedStorageAccountState<'KeyVaultId, Present, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountState<'KeyVaultId, Present, 'StorageAccountId, 'StorageAccountKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#storage_account_id-1">KeyVaultManagedStorageAccount#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, Missing, 'StorageAccountKey>, value: string) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, Present, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, Present, 'StorageAccountKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#storage_account_key-1">KeyVaultManagedStorageAccount#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, Missing>, value: string) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, Present> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#id-1">KeyVaultManagedStorageAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: string) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#regenerate_key_automatically-1">KeyVaultManagedStorageAccount#regenerate_key_automatically</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "regenerate_key_automatically">]
        member _.RegenerateKeyAutomatically(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: bool) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.RegenerateKeyAutomatically <- value)
            state : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#regenerate_key_automatically-1">KeyVaultManagedStorageAccount#regenerate_key_automatically</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "regenerate_key_automatically">]
        member _.RegenerateKeyAutomatically(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.RegenerateKeyAutomatically <- value)
            state : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#regeneration_period-1">KeyVaultManagedStorageAccount#regeneration_period</a>.
        /// </summary>
        [<CustomOperation "regeneration_period">]
        member _.RegenerationPeriod(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: string) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.RegenerationPeriod <- value)
            state : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#tags-1">KeyVaultManagedStorageAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: seq<string * string>) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account#timeouts-1">KeyVaultManagedStorageAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>, value: azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccountTimeouts) : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultManagedStorageAccountState<'KeyVaultId, 'Name, 'StorageAccountId, 'StorageAccountKey>

        member _.Run(state: KeyVaultManagedStorageAccountState<Present, Present, Present, Present>) : azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccount =
            let config = azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultManagedStorageAccount: missing required arguments. Must call: key_vault_id, name, storage_account_id, storage_account_key.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultManagedStorageAccountState<_, _, _, _>) : azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccount =
            Unchecked.defaultof<azurerm.KeyVaultManagedStorageAccount.KeyVaultManagedStorageAccount>
