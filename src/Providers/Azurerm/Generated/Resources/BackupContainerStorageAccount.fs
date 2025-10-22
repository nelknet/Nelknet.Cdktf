namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId> = { assignments: ResizeArray<azurerm.BackupContainerStorageAccount.BackupContainerStorageAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_container_storage_account">azurerm_backup_container_storage_account</a>.
    /// </summary>
    type BackupContainerStorageAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupContainerStorageAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupContainerStorageAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : BackupContainerStorageAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupContainerStorageAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_container_storage_account#recovery_vault_name-1">BackupContainerStorageAccount#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: BackupContainerStorageAccountState<Missing, 'ResourceGroupName, 'StorageAccountId>, value: string) : BackupContainerStorageAccountState<Present, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : BackupContainerStorageAccountState<Present, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_container_storage_account#resource_group_name-1">BackupContainerStorageAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BackupContainerStorageAccountState<'RecoveryVaultName, Missing, 'StorageAccountId>, value: string) : BackupContainerStorageAccountState<'RecoveryVaultName, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BackupContainerStorageAccountState<'RecoveryVaultName, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_container_storage_account#storage_account_id-1">BackupContainerStorageAccount#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, Missing>, value: string) : BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_container_storage_account#id-1">BackupContainerStorageAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId>, value: string) : BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_container_storage_account#timeouts-1">BackupContainerStorageAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.BackupContainerStorageAccount.BackupContainerStorageAccountTimeouts) : BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupContainerStorageAccountState<'RecoveryVaultName, 'ResourceGroupName, 'StorageAccountId>

        member _.Run(state: BackupContainerStorageAccountState<Present, Present, Present>) : azurerm.BackupContainerStorageAccount.BackupContainerStorageAccount =
            let config = azurerm.BackupContainerStorageAccount.BackupContainerStorageAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.BackupContainerStorageAccount.BackupContainerStorageAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.backupContainerStorageAccount: missing required arguments. Must call: recovery_vault_name, resource_group_name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: BackupContainerStorageAccountState<_, _, _>) : azurerm.BackupContainerStorageAccount.BackupContainerStorageAccount =
            Unchecked.defaultof<azurerm.BackupContainerStorageAccount.BackupContainerStorageAccount>
