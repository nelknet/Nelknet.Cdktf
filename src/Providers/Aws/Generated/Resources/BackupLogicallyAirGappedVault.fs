namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name> = { assignments: ResizeArray<aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_logically_air_gapped_vault">aws_backup_logically_air_gapped_vault</a>.
    /// </summary>
    type BackupLogicallyAirGappedVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupLogicallyAirGappedVaultState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupLogicallyAirGappedVaultState<Missing, Missing, Missing>)

        member _.Zero(()) : BackupLogicallyAirGappedVaultState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupLogicallyAirGappedVaultState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_logically_air_gapped_vault#max_retention_days-1">BackupLogicallyAirGappedVault#max_retention_days</a>.
        /// </summary>
        [<CustomOperation "max_retention_days">]
        member _.MaxRetentionDays(state: BackupLogicallyAirGappedVaultState<Missing, 'MinRetentionDays, 'Name>, value: double) : BackupLogicallyAirGappedVaultState<Present, 'MinRetentionDays, 'Name> =
            state.assignments.Add(fun config -> config.MaxRetentionDays <- value)
            ({ assignments = state.assignments } : BackupLogicallyAirGappedVaultState<Present, 'MinRetentionDays, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_logically_air_gapped_vault#min_retention_days-1">BackupLogicallyAirGappedVault#min_retention_days</a>.
        /// </summary>
        [<CustomOperation "min_retention_days">]
        member _.MinRetentionDays(state: BackupLogicallyAirGappedVaultState<'MaxRetentionDays, Missing, 'Name>, value: double) : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, Present, 'Name> =
            state.assignments.Add(fun config -> config.MinRetentionDays <- value)
            ({ assignments = state.assignments } : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_logically_air_gapped_vault#name-1">BackupLogicallyAirGappedVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, Missing>, value: string) : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_logically_air_gapped_vault#tags-1">BackupLogicallyAirGappedVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name>, value: seq<string * string>) : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_logically_air_gapped_vault#timeouts-1">BackupLogicallyAirGappedVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name>, value: aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVaultTimeouts) : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupLogicallyAirGappedVaultState<'MaxRetentionDays, 'MinRetentionDays, 'Name>

        member _.Run(state: BackupLogicallyAirGappedVaultState<Present, Present, Present>) : aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVault =
            let config = aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVaultConfig()
            for setter in state.assignments do
                setter config
            aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupLogicallyAirGappedVault: missing required arguments. Must call: max_retention_days, min_retention_days, name.", 9999, IsError = true)>]
        member _.Run(_: BackupLogicallyAirGappedVaultState<_, _, _>) : aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVault =
            Unchecked.defaultof<aws.BackupLogicallyAirGappedVault.BackupLogicallyAirGappedVault>
