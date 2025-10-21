namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server">azurerm_data_protection_backup_policy_postgresql_flexible_server</a>.
    /// </summary>
    type DataProtectionBackupPolicyPostgresqlFlexibleServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyPostgresqlFlexibleServerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyPostgresqlFlexibleServerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#backup_repeating_time_intervals-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#backup_repeating_time_intervals</a>.
        /// </summary>
        [<CustomOperation "backup_repeating_time_intervals">]
        member _.BackupRepeatingTimeIntervals(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<Missing, 'DefaultRetentionRule, 'Name, 'VaultId>, value: seq<string>) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<Present, 'DefaultRetentionRule, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupRepeatingTimeIntervals <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlFlexibleServerState<Present, 'DefaultRetentionRule, 'Name, 'VaultId>)

        /// <summary>
        /// default_retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#default_retention_rule-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#default_retention_rule</a>
        /// </summary>
        [<CustomOperation "default_retention_rule">]
        member _.DefaultRetentionRule(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, Missing, 'Name, 'VaultId>, value: azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRule) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, Present, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.DefaultRetentionRule <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, Present, 'Name, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#name-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, Missing, 'VaultId>, value: string) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#vault_id-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, Missing>, value: string) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#id-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>

        /// <summary>
        /// retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#retention_rule-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#retention_rule</a> Accepts: azurerm.IResolvable | azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerRetentionRule[]
        /// </summary>
        [<CustomOperation "retention_rule">]
        member _.RetentionRule(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>, value: HashiCorp.Cdktf.IResolvable) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.RetentionRule <- value)
            state : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#timeouts-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>, value: azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerTimeouts) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#time_zone-1">DataProtectionBackupPolicyPostgresqlFlexibleServer#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>, value: string) : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : DataProtectionBackupPolicyPostgresqlFlexibleServerState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'VaultId>

        member _.Run(state: DataProtectionBackupPolicyPostgresqlFlexibleServerState<Present, Present, Present, Present>) : azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServer =
            let config = azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupPolicyPostgresqlFlexibleServer: missing required arguments. Must call: backup_repeating_time_intervals, default_retention_rule, name, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupPolicyPostgresqlFlexibleServerState<_, _, _, _>) : azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServer =
            Unchecked.defaultof<azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServer>
