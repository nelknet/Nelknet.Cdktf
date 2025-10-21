namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk">azurerm_data_protection_backup_policy_disk</a>.
    /// </summary>
    type DataProtectionBackupPolicyDiskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupPolicyDiskState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyDiskState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupPolicyDiskState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyDiskState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#backup_repeating_time_intervals-1">DataProtectionBackupPolicyDisk#backup_repeating_time_intervals</a>.
        /// </summary>
        [<CustomOperation "backup_repeating_time_intervals">]
        member _.BackupRepeatingTimeIntervals(state: DataProtectionBackupPolicyDiskState<Missing, 'DefaultRetentionDuration, 'Name, 'VaultId>, value: seq<string>) : DataProtectionBackupPolicyDiskState<Present, 'DefaultRetentionDuration, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupRepeatingTimeIntervals <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataProtectionBackupPolicyDiskState<Present, 'DefaultRetentionDuration, 'Name, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#default_retention_duration-1">DataProtectionBackupPolicyDisk#default_retention_duration</a>.
        /// </summary>
        [<CustomOperation "default_retention_duration">]
        member _.DefaultRetentionDuration(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, Missing, 'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, Present, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.DefaultRetentionDuration <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, Present, 'Name, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#name-1">DataProtectionBackupPolicyDisk#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, Missing, 'VaultId>, value: string) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#vault_id-1">DataProtectionBackupPolicyDisk#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, Missing>, value: string) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#id-1">DataProtectionBackupPolicyDisk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>

        /// <summary>
        /// retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#retention_rule-1">DataProtectionBackupPolicyDisk#retention_rule</a> Accepts: azurerm.IResolvable | azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRule[]
        /// </summary>
        [<CustomOperation "retention_rule">]
        member _.RetentionRule(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>, value: HashiCorp.Cdktf.IResolvable) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.RetentionRule <- value)
            state : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#timeouts-1">DataProtectionBackupPolicyDisk#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>, value: azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskTimeouts) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#time_zone-1">DataProtectionBackupPolicyDisk#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : DataProtectionBackupPolicyDiskState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'VaultId>

        member _.Run(state: DataProtectionBackupPolicyDiskState<Present, Present, Present, Present>) : azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDisk =
            let config = azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDisk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupPolicyDisk: missing required arguments. Must call: backup_repeating_time_intervals, default_retention_duration, name, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupPolicyDiskState<_, _, _, _>) : azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDisk =
            Unchecked.defaultof<azurerm.DataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDisk>
