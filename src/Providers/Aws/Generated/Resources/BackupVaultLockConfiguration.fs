namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupVaultLockConfigurationState<'BackupVaultName> = { assignments: ResizeArray<aws.BackupVaultLockConfiguration.BackupVaultLockConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_lock_configuration">aws_backup_vault_lock_configuration</a>.
    /// </summary>
    type BackupVaultLockConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupVaultLockConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : BackupVaultLockConfigurationState<Missing>)

        member _.Zero(()) : BackupVaultLockConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : BackupVaultLockConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_lock_configuration#backup_vault_name-1">BackupVaultLockConfiguration#backup_vault_name</a>.
        /// </summary>
        [<CustomOperation "backup_vault_name">]
        member _.BackupVaultName(state: BackupVaultLockConfigurationState<Missing>, value: string) : BackupVaultLockConfigurationState<Present> =
            state.assignments.Add(fun config -> config.BackupVaultName <- value)
            ({ assignments = state.assignments } : BackupVaultLockConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_lock_configuration#changeable_for_days-1">BackupVaultLockConfiguration#changeable_for_days</a>.
        /// </summary>
        [<CustomOperation "changeable_for_days">]
        member _.ChangeableForDays(state: BackupVaultLockConfigurationState<'BackupVaultName>, value: double) : BackupVaultLockConfigurationState<'BackupVaultName> =
            state.assignments.Add(fun config -> config.ChangeableForDays <- value)
            state : BackupVaultLockConfigurationState<'BackupVaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_lock_configuration#id-1">BackupVaultLockConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupVaultLockConfigurationState<'BackupVaultName>, value: string) : BackupVaultLockConfigurationState<'BackupVaultName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupVaultLockConfigurationState<'BackupVaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_lock_configuration#max_retention_days-1">BackupVaultLockConfiguration#max_retention_days</a>.
        /// </summary>
        [<CustomOperation "max_retention_days">]
        member _.MaxRetentionDays(state: BackupVaultLockConfigurationState<'BackupVaultName>, value: double) : BackupVaultLockConfigurationState<'BackupVaultName> =
            state.assignments.Add(fun config -> config.MaxRetentionDays <- value)
            state : BackupVaultLockConfigurationState<'BackupVaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_lock_configuration#min_retention_days-1">BackupVaultLockConfiguration#min_retention_days</a>.
        /// </summary>
        [<CustomOperation "min_retention_days">]
        member _.MinRetentionDays(state: BackupVaultLockConfigurationState<'BackupVaultName>, value: double) : BackupVaultLockConfigurationState<'BackupVaultName> =
            state.assignments.Add(fun config -> config.MinRetentionDays <- value)
            state : BackupVaultLockConfigurationState<'BackupVaultName>

        member _.Run(state: BackupVaultLockConfigurationState<Present>) : aws.BackupVaultLockConfiguration.BackupVaultLockConfiguration =
            let config = aws.BackupVaultLockConfiguration.BackupVaultLockConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.BackupVaultLockConfiguration.BackupVaultLockConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupVaultLockConfiguration: missing required arguments. Must call: backup_vault_name.", 9999, IsError = true)>]
        member _.Run(_: BackupVaultLockConfigurationState<_>) : aws.BackupVaultLockConfiguration.BackupVaultLockConfiguration =
            Unchecked.defaultof<aws.BackupVaultLockConfiguration.BackupVaultLockConfiguration>
