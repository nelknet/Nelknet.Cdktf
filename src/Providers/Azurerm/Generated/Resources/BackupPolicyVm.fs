namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BackupPolicyVm.BackupPolicyVmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm">azurerm_backup_policy_vm</a>.
    /// </summary>
    type BackupPolicyVmBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupPolicyVmState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPolicyVmState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BackupPolicyVmState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPolicyVmState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#backup-1">BackupPolicyVm#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: BackupPolicyVmState<Missing, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmBackup) : BackupPolicyVmState<Present, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Backup <- value)
            ({ assignments = state.assignments } : BackupPolicyVmState<Present, 'Name, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#name-1">BackupPolicyVm#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupPolicyVmState<'Backup, Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupPolicyVmState<'Backup, Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupPolicyVmState<'Backup, Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#recovery_vault_name-1">BackupPolicyVm#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: BackupPolicyVmState<'Backup, 'Name, Missing, 'ResourceGroupName>, value: string) : BackupPolicyVmState<'Backup, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : BackupPolicyVmState<'Backup, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#resource_group_name-1">BackupPolicyVm#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, Missing>, value: string) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#id-1">BackupPolicyVm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// instant_restore_resource_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#instant_restore_resource_group-1">BackupPolicyVm#instant_restore_resource_group</a>
        /// </summary>
        [<CustomOperation "instant_restore_resource_group">]
        member _.InstantRestoreResourceGroup(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmInstantRestoreResourceGroup) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InstantRestoreResourceGroup <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#instant_restore_retention_days-1">BackupPolicyVm#instant_restore_retention_days</a>.
        /// </summary>
        [<CustomOperation "instant_restore_retention_days">]
        member _.InstantRestoreRetentionDays(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: double) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InstantRestoreRetentionDays <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#policy_type-1">BackupPolicyVm#policy_type</a>.
        /// </summary>
        [<CustomOperation "policy_type">]
        member _.PolicyType(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PolicyType <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// retention_daily block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#retention_daily-1">BackupPolicyVm#retention_daily</a>
        /// </summary>
        [<CustomOperation "retention_daily">]
        member _.RetentionDaily(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmRetentionDaily) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionDaily <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// retention_monthly block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#retention_monthly-1">BackupPolicyVm#retention_monthly</a>
        /// </summary>
        [<CustomOperation "retention_monthly">]
        member _.RetentionMonthly(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmRetentionMonthly) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionMonthly <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// retention_weekly block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#retention_weekly-1">BackupPolicyVm#retention_weekly</a>
        /// </summary>
        [<CustomOperation "retention_weekly">]
        member _.RetentionWeekly(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmRetentionWeekly) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionWeekly <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// retention_yearly block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#retention_yearly-1">BackupPolicyVm#retention_yearly</a>
        /// </summary>
        [<CustomOperation "retention_yearly">]
        member _.RetentionYearly(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmRetentionYearly) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionYearly <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// tiering_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#tiering_policy-1">BackupPolicyVm#tiering_policy</a>
        /// </summary>
        [<CustomOperation "tiering_policy">]
        member _.TieringPolicy(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmTieringPolicy) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TieringPolicy <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#timeouts-1">BackupPolicyVm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupPolicyVm.BackupPolicyVmTimeouts) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm#timezone-1">BackupPolicyVm#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : BackupPolicyVmState<'Backup, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: BackupPolicyVmState<Present, Present, Present, Present>) : azurerm.BackupPolicyVm.BackupPolicyVm =
            let config = azurerm.BackupPolicyVm.BackupPolicyVmConfig()
            for setter in state.assignments do
                setter config
            azurerm.BackupPolicyVm.BackupPolicyVm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.backupPolicyVm: missing required arguments. Must call: backup, name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BackupPolicyVmState<_, _, _, _>) : azurerm.BackupPolicyVm.BackupPolicyVm =
            Unchecked.defaultof<azurerm.BackupPolicyVm.BackupPolicyVm>
