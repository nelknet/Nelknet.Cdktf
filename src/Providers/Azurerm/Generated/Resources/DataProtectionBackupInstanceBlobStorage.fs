namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage">azurerm_data_protection_backup_instance_blob_storage</a>.
    /// </summary>
    type DataProtectionBackupInstanceBlobStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupInstanceBlobStorageState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstanceBlobStorageState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupInstanceBlobStorageState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstanceBlobStorageState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#backup_policy_id-1">DataProtectionBackupInstanceBlobStorage#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: DataProtectionBackupInstanceBlobStorageState<Missing, 'Location, 'Name, 'StorageAccountId, 'VaultId>, value: string) : DataProtectionBackupInstanceBlobStorageState<Present, 'Location, 'Name, 'StorageAccountId, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceBlobStorageState<Present, 'Location, 'Name, 'StorageAccountId, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#location-1">DataProtectionBackupInstanceBlobStorage#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, Missing, 'Name, 'StorageAccountId, 'VaultId>, value: string) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, Present, 'Name, 'StorageAccountId, 'VaultId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, Present, 'Name, 'StorageAccountId, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#name-1">DataProtectionBackupInstanceBlobStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, Missing, 'StorageAccountId, 'VaultId>, value: string) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, Present, 'StorageAccountId, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, Present, 'StorageAccountId, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#storage_account_id-1">DataProtectionBackupInstanceBlobStorage#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, Missing, 'VaultId>, value: string) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#vault_id-1">DataProtectionBackupInstanceBlobStorage#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, Missing>, value: string) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#id-1">DataProtectionBackupInstanceBlobStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId>, value: string) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#storage_account_container_names-1">DataProtectionBackupInstanceBlobStorage#storage_account_container_names</a>.
        /// </summary>
        [<CustomOperation "storage_account_container_names">]
        member _.StorageAccountContainerNames(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId>, value: seq<string>) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId> =
            state.assignments.Add(fun config -> config.StorageAccountContainerNames <- (value |> Seq.toArray))
            state : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_blob_storage#timeouts-1">DataProtectionBackupInstanceBlobStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId>, value: azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorageTimeouts) : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupInstanceBlobStorageState<'BackupPolicyId, 'Location, 'Name, 'StorageAccountId, 'VaultId>

        member _.Run(state: DataProtectionBackupInstanceBlobStorageState<Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorage =
            let config = azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupInstanceBlobStorage: missing required arguments. Must call: backup_policy_id, location, name, storage_account_id, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupInstanceBlobStorageState<_, _, _, _, _>) : azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorage =
            Unchecked.defaultof<azurerm.DataProtectionBackupInstanceBlobStorage.DataProtectionBackupInstanceBlobStorage>
