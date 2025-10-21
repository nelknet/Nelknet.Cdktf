namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName> = { assignments: ResizeArray<azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql">azurerm_data_protection_backup_policy_postgresql</a>.
    /// </summary>
    type DataProtectionBackupPolicyPostgresqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupPolicyPostgresqlState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyPostgresqlState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupPolicyPostgresqlState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyPostgresqlState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#backup_repeating_time_intervals-1">DataProtectionBackupPolicyPostgresql#backup_repeating_time_intervals</a>.
        /// </summary>
        [<CustomOperation "backup_repeating_time_intervals">]
        member _.BackupRepeatingTimeIntervals(state: DataProtectionBackupPolicyPostgresqlState<Missing, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>, value: seq<string>) : DataProtectionBackupPolicyPostgresqlState<Present, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.BackupRepeatingTimeIntervals <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlState<Present, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#default_retention_duration-1">DataProtectionBackupPolicyPostgresql#default_retention_duration</a>.
        /// </summary>
        [<CustomOperation "default_retention_duration">]
        member _.DefaultRetentionDuration(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, Missing, 'Name, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, Present, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.DefaultRetentionDuration <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, Present, 'Name, 'ResourceGroupName, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#name-1">DataProtectionBackupPolicyPostgresql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, Missing, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, Present, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, Present, 'ResourceGroupName, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#resource_group_name-1">DataProtectionBackupPolicyPostgresql#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, Missing, 'VaultName>, value: string) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, Present, 'VaultName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, Present, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#vault_name-1">DataProtectionBackupPolicyPostgresql#vault_name</a>.
        /// </summary>
        [<CustomOperation "vault_name">]
        member _.VaultName(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, Missing>, value: string) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VaultName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#id-1">DataProtectionBackupPolicyPostgresql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>

        /// <summary>
        /// retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#retention_rule-1">DataProtectionBackupPolicyPostgresql#retention_rule</a> Accepts: azurerm.IResolvable | azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresqlRetentionRule[]
        /// </summary>
        [<CustomOperation "retention_rule">]
        member _.RetentionRule(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>, value: HashiCorp.Cdktf.IResolvable) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.RetentionRule <- value)
            state : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#timeouts-1">DataProtectionBackupPolicyPostgresql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>, value: azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresqlTimeouts) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql#time_zone-1">DataProtectionBackupPolicyPostgresql#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : DataProtectionBackupPolicyPostgresqlState<'BackupRepeatingTimeIntervals, 'DefaultRetentionDuration, 'Name, 'ResourceGroupName, 'VaultName>

        member _.Run(state: DataProtectionBackupPolicyPostgresqlState<Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresql =
            let config = azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupPolicyPostgresql: missing required arguments. Must call: backup_repeating_time_intervals, default_retention_duration, name, resource_group_name, vault_name.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupPolicyPostgresqlState<_, _, _, _, _>) : azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresql =
            Unchecked.defaultof<azurerm.DataProtectionBackupPolicyPostgresql.DataProtectionBackupPolicyPostgresql>
