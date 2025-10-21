namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql">azurerm_data_protection_backup_instance_postgresql</a>.
    /// </summary>
    type DataProtectionBackupInstancePostgresqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupInstancePostgresqlState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstancePostgresqlState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupInstancePostgresqlState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstancePostgresqlState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#backup_policy_id-1">DataProtectionBackupInstancePostgresql#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: DataProtectionBackupInstancePostgresqlState<Missing, 'DatabaseId, 'Location, 'Name, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlState<Present, 'DatabaseId, 'Location, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlState<Present, 'DatabaseId, 'Location, 'Name, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#database_id-1">DataProtectionBackupInstancePostgresql#database_id</a>.
        /// </summary>
        [<CustomOperation "database_id">]
        member _.DatabaseId(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, Missing, 'Location, 'Name, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, Present, 'Location, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.DatabaseId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, Present, 'Location, 'Name, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#location-1">DataProtectionBackupInstancePostgresql#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, Missing, 'Name, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, Present, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, Present, 'Name, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#name-1">DataProtectionBackupInstancePostgresql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, Missing, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#vault_id-1">DataProtectionBackupInstancePostgresql#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, Missing>, value: string) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#database_credential_key_vault_secret_id-1">DataProtectionBackupInstancePostgresql#database_credential_key_vault_secret_id</a>.
        /// </summary>
        [<CustomOperation "database_credential_key_vault_secret_id">]
        member _.DatabaseCredentialKeyVaultSecretId(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.DatabaseCredentialKeyVaultSecretId <- value)
            state : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#id-1">DataProtectionBackupInstancePostgresql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql#timeouts-1">DataProtectionBackupInstancePostgresql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId>, value: azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresqlTimeouts) : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupInstancePostgresqlState<'BackupPolicyId, 'DatabaseId, 'Location, 'Name, 'VaultId>

        member _.Run(state: DataProtectionBackupInstancePostgresqlState<Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresql =
            let config = azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupInstancePostgresql: missing required arguments. Must call: backup_policy_id, database_id, location, name, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupInstancePostgresqlState<_, _, _, _, _>) : azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresql =
            Unchecked.defaultof<azurerm.DataProtectionBackupInstancePostgresql.DataProtectionBackupInstancePostgresql>
