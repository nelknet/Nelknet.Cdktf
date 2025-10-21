namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key">azurerm_storage_account_customer_managed_key</a>.
    /// </summary>
    type StorageAccountCustomerManagedKeyABuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageAccountCustomerManagedKeyAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountCustomerManagedKeyAState<Missing, Missing>)

        member _.Zero(()) : StorageAccountCustomerManagedKeyAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountCustomerManagedKeyAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#key_name-1">StorageAccountCustomerManagedKeyA#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: StorageAccountCustomerManagedKeyAState<Missing, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.KeyName <- value)
            ({ assignments = state.assignments } : StorageAccountCustomerManagedKeyAState<Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#storage_account_id-1">StorageAccountCustomerManagedKeyA#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageAccountCustomerManagedKeyAState<'KeyName, Missing>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageAccountCustomerManagedKeyAState<'KeyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#federated_identity_client_id-1">StorageAccountCustomerManagedKeyA#federated_identity_client_id</a>.
        /// </summary>
        [<CustomOperation "federated_identity_client_id">]
        member _.FederatedIdentityClientId(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.FederatedIdentityClientId <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#id-1">StorageAccountCustomerManagedKeyA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#key_vault_id-1">StorageAccountCustomerManagedKeyA#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#key_vault_uri-1">StorageAccountCustomerManagedKeyA#key_vault_uri</a>.
        /// </summary>
        [<CustomOperation "key_vault_uri">]
        member _.KeyVaultUri(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.KeyVaultUri <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#key_version-1">StorageAccountCustomerManagedKeyA#key_version</a>.
        /// </summary>
        [<CustomOperation "key_version">]
        member _.KeyVersion(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.KeyVersion <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#managed_hsm_key_id-1">StorageAccountCustomerManagedKeyA#managed_hsm_key_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_key_id">]
        member _.ManagedHsmKeyId(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ManagedHsmKeyId <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#timeouts-1">StorageAccountCustomerManagedKeyA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyTimeouts) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_customer_managed_key#user_assigned_identity_id-1">StorageAccountCustomerManagedKeyA#user_assigned_identity_id</a>.
        /// </summary>
        [<CustomOperation "user_assigned_identity_id">]
        member _.UserAssignedIdentityId(state: StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>, value: string) : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.UserAssignedIdentityId <- value)
            state : StorageAccountCustomerManagedKeyAState<'KeyName, 'StorageAccountId>

        member _.Run(state: StorageAccountCustomerManagedKeyAState<Present, Present>) : azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyA =
            let config = azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyAConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageAccountCustomerManagedKeyA: missing required arguments. Must call: key_name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageAccountCustomerManagedKeyAState<_, _>) : azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyA =
            Unchecked.defaultof<azurerm.StorageAccountCustomerManagedKey.StorageAccountCustomerManagedKeyA>
