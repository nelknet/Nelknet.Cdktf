namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId> = { assignments: ResizeArray<azurerm.BackupProtectedFileShare.BackupProtectedFileShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share">azurerm_backup_protected_file_share</a>.
    /// </summary>
    type BackupProtectedFileShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupProtectedFileShareState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupProtectedFileShareState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BackupProtectedFileShareState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupProtectedFileShareState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#backup_policy_id-1">BackupProtectedFileShare#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: BackupProtectedFileShareState<Missing, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>, value: string) : BackupProtectedFileShareState<Present, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            ({ assignments = state.assignments } : BackupProtectedFileShareState<Present, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#recovery_vault_name-1">BackupProtectedFileShare#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: BackupProtectedFileShareState<'BackupPolicyId, Missing, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>, value: string) : BackupProtectedFileShareState<'BackupPolicyId, Present, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : BackupProtectedFileShareState<'BackupPolicyId, Present, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#resource_group_name-1">BackupProtectedFileShare#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, Missing, 'SourceFileShareName, 'SourceStorageAccountId>, value: string) : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, Present, 'SourceFileShareName, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, Present, 'SourceFileShareName, 'SourceStorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#source_file_share_name-1">BackupProtectedFileShare#source_file_share_name</a>.
        /// </summary>
        [<CustomOperation "source_file_share_name">]
        member _.SourceFileShareName(state: BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, Missing, 'SourceStorageAccountId>, value: string) : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, Present, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.SourceFileShareName <- value)
            ({ assignments = state.assignments } : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, Present, 'SourceStorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#source_storage_account_id-1">BackupProtectedFileShare#source_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "source_storage_account_id">]
        member _.SourceStorageAccountId(state: BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, Missing>, value: string) : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, Present> =
            state.assignments.Add(fun config -> config.SourceStorageAccountId <- value)
            ({ assignments = state.assignments } : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#id-1">BackupProtectedFileShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>, value: string) : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_file_share#timeouts-1">BackupProtectedFileShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>, value: azurerm.BackupProtectedFileShare.BackupProtectedFileShareTimeouts) : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupProtectedFileShareState<'BackupPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceFileShareName, 'SourceStorageAccountId>

        member _.Run(state: BackupProtectedFileShareState<Present, Present, Present, Present, Present>) : azurerm.BackupProtectedFileShare.BackupProtectedFileShare =
            let config = azurerm.BackupProtectedFileShare.BackupProtectedFileShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.BackupProtectedFileShare.BackupProtectedFileShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.backupProtectedFileShare: missing required arguments. Must call: backup_policy_id, recovery_vault_name, resource_group_name, source_file_share_name, source_storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: BackupProtectedFileShareState<_, _, _, _, _>) : azurerm.BackupProtectedFileShare.BackupProtectedFileShare =
            Unchecked.defaultof<azurerm.BackupProtectedFileShare.BackupProtectedFileShare>
