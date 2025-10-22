namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> = { assignments: ResizeArray<azurerm.BackupPolicyFileShare.BackupPolicyFileShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share">azurerm_backup_policy_file_share</a>.
    /// </summary>
    type BackupPolicyFileShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupPolicyFileShareState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPolicyFileShareState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BackupPolicyFileShareState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPolicyFileShareState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#backup-1">BackupPolicyFileShare#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: BackupPolicyFileShareState<Missing, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: azurerm.BackupPolicyFileShare.BackupPolicyFileShareBackup) : BackupPolicyFileShareState<Present, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.Backup <- value)
            ({ assignments = state.assignments } : BackupPolicyFileShareState<Present, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#name-1">BackupPolicyFileShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupPolicyFileShareState<'Backup, Missing, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: string) : BackupPolicyFileShareState<'Backup, Present, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupPolicyFileShareState<'Backup, Present, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#recovery_vault_name-1">BackupPolicyFileShare#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: BackupPolicyFileShareState<'Backup, 'Name, Missing, 'ResourceGroupName, 'RetentionDaily>, value: string) : BackupPolicyFileShareState<'Backup, 'Name, Present, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : BackupPolicyFileShareState<'Backup, 'Name, Present, 'ResourceGroupName, 'RetentionDaily>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#resource_group_name-1">BackupPolicyFileShare#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, Missing, 'RetentionDaily>, value: string) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, Present, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, Present, 'RetentionDaily>)

        /// <summary>
        /// retention_daily block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#retention_daily-1">BackupPolicyFileShare#retention_daily</a>
        /// </summary>
        [<CustomOperation "retention_daily">]
        member _.RetentionDaily(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, Missing>, value: azurerm.BackupPolicyFileShare.BackupPolicyFileShareRetentionDaily) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RetentionDaily <- value)
            ({ assignments = state.assignments } : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#id-1">BackupPolicyFileShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: string) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>

        /// <summary>
        /// retention_monthly block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#retention_monthly-1">BackupPolicyFileShare#retention_monthly</a>
        /// </summary>
        [<CustomOperation "retention_monthly">]
        member _.RetentionMonthly(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: azurerm.BackupPolicyFileShare.BackupPolicyFileShareRetentionMonthly) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.RetentionMonthly <- value)
            state : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>

        /// <summary>
        /// retention_weekly block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#retention_weekly-1">BackupPolicyFileShare#retention_weekly</a>
        /// </summary>
        [<CustomOperation "retention_weekly">]
        member _.RetentionWeekly(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: azurerm.BackupPolicyFileShare.BackupPolicyFileShareRetentionWeekly) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.RetentionWeekly <- value)
            state : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>

        /// <summary>
        /// retention_yearly block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#retention_yearly-1">BackupPolicyFileShare#retention_yearly</a>
        /// </summary>
        [<CustomOperation "retention_yearly">]
        member _.RetentionYearly(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: azurerm.BackupPolicyFileShare.BackupPolicyFileShareRetentionYearly) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.RetentionYearly <- value)
            state : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#timeouts-1">BackupPolicyFileShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: azurerm.BackupPolicyFileShare.BackupPolicyFileShareTimeouts) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_file_share#timezone-1">BackupPolicyFileShare#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>, value: string) : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : BackupPolicyFileShareState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName, 'RetentionDaily>

        member _.Run(state: BackupPolicyFileShareState<Present, Present, Present, Present, Present>) : azurerm.BackupPolicyFileShare.BackupPolicyFileShare =
            let config = azurerm.BackupPolicyFileShare.BackupPolicyFileShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.BackupPolicyFileShare.BackupPolicyFileShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.backupPolicyFileShare: missing required arguments. Must call: backup, name, recovery_vault_name, resource_group_name, retention_daily.", 9999, IsError = true)>]
        member _.Run(_: BackupPolicyFileShareState<_, _, _, _, _>) : azurerm.BackupPolicyFileShare.BackupPolicyFileShare =
            Unchecked.defaultof<azurerm.BackupPolicyFileShare.BackupPolicyFileShare>
