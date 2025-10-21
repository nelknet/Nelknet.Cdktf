namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage">azurerm_data_protection_backup_policy_blob_storage</a>.
    /// </summary>
    type DataProtectionBackupPolicyBlobStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupPolicyBlobStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyBlobStorageState<Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupPolicyBlobStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyBlobStorageState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#name-1">DataProtectionBackupPolicyBlobStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupPolicyBlobStorageState<Missing, 'VaultId>, value: string) : DataProtectionBackupPolicyBlobStorageState<Present, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyBlobStorageState<Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#vault_id-1">DataProtectionBackupPolicyBlobStorage#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupPolicyBlobStorageState<'Name, Missing>, value: string) : DataProtectionBackupPolicyBlobStorageState<'Name, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyBlobStorageState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#backup_repeating_time_intervals-1">DataProtectionBackupPolicyBlobStorage#backup_repeating_time_intervals</a>.
        /// </summary>
        [<CustomOperation "backup_repeating_time_intervals">]
        member _.BackupRepeatingTimeIntervals(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: seq<string>) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupRepeatingTimeIntervals <- (value |> Seq.toArray))
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#id-1">DataProtectionBackupPolicyBlobStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#operational_default_retention_duration-1">DataProtectionBackupPolicyBlobStorage#operational_default_retention_duration</a>.
        /// </summary>
        [<CustomOperation "operational_default_retention_duration">]
        member _.OperationalDefaultRetentionDuration(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.OperationalDefaultRetentionDuration <- value)
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        /// <summary>
        /// retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#retention_rule-1">DataProtectionBackupPolicyBlobStorage#retention_rule</a> Accepts: azurerm.IResolvable | azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageRetentionRule[]
        /// </summary>
        [<CustomOperation "retention_rule">]
        member _.RetentionRule(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: HashiCorp.Cdktf.IResolvable) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.RetentionRule <- value)
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#timeouts-1">DataProtectionBackupPolicyBlobStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageTimeouts) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#time_zone-1">DataProtectionBackupPolicyBlobStorage#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#vault_default_retention_duration-1">DataProtectionBackupPolicyBlobStorage#vault_default_retention_duration</a>.
        /// </summary>
        [<CustomOperation "vault_default_retention_duration">]
        member _.VaultDefaultRetentionDuration(state: DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.VaultDefaultRetentionDuration <- value)
            state : DataProtectionBackupPolicyBlobStorageState<'Name, 'VaultId>

        member _.Run(state: DataProtectionBackupPolicyBlobStorageState<Present, Present>) : azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorage =
            let config = azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupPolicyBlobStorage: missing required arguments. Must call: name, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupPolicyBlobStorageState<_, _>) : azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorage =
            Unchecked.defaultof<azurerm.DataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorage>
