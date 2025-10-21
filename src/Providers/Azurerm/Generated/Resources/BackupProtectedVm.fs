namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BackupProtectedVm.BackupProtectedVmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm">azurerm_backup_protected_vm</a>.
    /// </summary>
    type BackupProtectedVmBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupProtectedVmState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupProtectedVmState<Missing, Missing>)

        member _.Zero(()) : BackupProtectedVmState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupProtectedVmState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#recovery_vault_name-1">BackupProtectedVm#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: BackupProtectedVmState<Missing, 'ResourceGroupName>, value: string) : BackupProtectedVmState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : BackupProtectedVmState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#resource_group_name-1">BackupProtectedVm#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BackupProtectedVmState<'RecoveryVaultName, Missing>, value: string) : BackupProtectedVmState<'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BackupProtectedVmState<'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#backup_policy_id-1">BackupProtectedVm#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#exclude_disk_luns-1">BackupProtectedVm#exclude_disk_luns</a>.
        /// </summary>
        [<CustomOperation "exclude_disk_luns">]
        member _.ExcludeDiskLuns(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: seq<double>) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExcludeDiskLuns <- (value |> Seq.toArray))
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#id-1">BackupProtectedVm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#include_disk_luns-1">BackupProtectedVm#include_disk_luns</a>.
        /// </summary>
        [<CustomOperation "include_disk_luns">]
        member _.IncludeDiskLuns(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: seq<double>) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IncludeDiskLuns <- (value |> Seq.toArray))
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#protection_state-1">BackupProtectedVm#protection_state</a>.
        /// </summary>
        [<CustomOperation "protection_state">]
        member _.ProtectionState(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProtectionState <- value)
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#source_vm_id-1">BackupProtectedVm#source_vm_id</a>.
        /// </summary>
        [<CustomOperation "source_vm_id">]
        member _.SourceVmId(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: string) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceVmId <- value)
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_protected_vm#timeouts-1">BackupProtectedVm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.BackupProtectedVm.BackupProtectedVmTimeouts) : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupProtectedVmState<'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: BackupProtectedVmState<Present, Present>) : azurerm.BackupProtectedVm.BackupProtectedVm =
            let config = azurerm.BackupProtectedVm.BackupProtectedVmConfig()
            for setter in state.assignments do
                setter config
            azurerm.BackupProtectedVm.BackupProtectedVm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.backupProtectedVm: missing required arguments. Must call: recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BackupProtectedVmState<_, _>) : azurerm.BackupProtectedVm.BackupProtectedVm =
            Unchecked.defaultof<azurerm.BackupProtectedVm.BackupProtectedVm>
