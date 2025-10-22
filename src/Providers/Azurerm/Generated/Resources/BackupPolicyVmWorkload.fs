namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType> = { assignments: ResizeArray<azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkloadConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload">azurerm_backup_policy_vm_workload</a>.
    /// </summary>
    type BackupPolicyVmWorkloadBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupPolicyVmWorkloadState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPolicyVmWorkloadState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BackupPolicyVmWorkloadState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPolicyVmWorkloadState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#name-1">BackupPolicyVmWorkload#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupPolicyVmWorkloadState<Missing, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>, value: string) : BackupPolicyVmWorkloadState<Present, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupPolicyVmWorkloadState<Present, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>)

        /// <summary>
        /// protection_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#protection_policy-1">BackupPolicyVmWorkload#protection_policy</a> Accepts: azurerm.IResolvable | azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkloadProtectionPolicy[]
        /// </summary>
        [<CustomOperation "protection_policy">]
        member _.ProtectionPolicy(state: BackupPolicyVmWorkloadState<'Name, Missing, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>, value: HashiCorp.Cdktf.IResolvable) : BackupPolicyVmWorkloadState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType> =
            state.assignments.Add(fun config -> config.ProtectionPolicy <- value)
            ({ assignments = state.assignments } : BackupPolicyVmWorkloadState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#recovery_vault_name-1">BackupPolicyVmWorkload#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, Missing, 'ResourceGroupName, 'Settings, 'WorkloadType>, value: string) : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, Present, 'ResourceGroupName, 'Settings, 'WorkloadType> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, Present, 'ResourceGroupName, 'Settings, 'WorkloadType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#resource_group_name-1">BackupPolicyVmWorkload#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, Missing, 'Settings, 'WorkloadType>, value: string) : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, Present, 'Settings, 'WorkloadType> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, Present, 'Settings, 'WorkloadType>)

        /// <summary>
        /// settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#settings-1">BackupPolicyVmWorkload#settings</a>
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, Missing, 'WorkloadType>, value: azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkloadSettings) : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, Present, 'WorkloadType> =
            state.assignments.Add(fun config -> config.Settings <- value)
            ({ assignments = state.assignments } : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, Present, 'WorkloadType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#workload_type-1">BackupPolicyVmWorkload#workload_type</a>.
        /// </summary>
        [<CustomOperation "workload_type">]
        member _.WorkloadType(state: BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, Missing>, value: string) : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, Present> =
            state.assignments.Add(fun config -> config.WorkloadType <- value)
            ({ assignments = state.assignments } : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#id-1">BackupPolicyVmWorkload#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>, value: string) : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/backup_policy_vm_workload#timeouts-1">BackupPolicyVmWorkload#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>, value: azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkloadTimeouts) : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupPolicyVmWorkloadState<'Name, 'ProtectionPolicy, 'RecoveryVaultName, 'ResourceGroupName, 'Settings, 'WorkloadType>

        member _.Run(state: BackupPolicyVmWorkloadState<Present, Present, Present, Present, Present, Present>) : azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkload =
            let config = azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkloadConfig()
            for setter in state.assignments do
                setter config
            azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkload(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.backupPolicyVmWorkload: missing required arguments. Must call: name, protection_policy, recovery_vault_name, resource_group_name, settings, workload_type.", 9999, IsError = true)>]
        member _.Run(_: BackupPolicyVmWorkloadState<_, _, _, _, _, _>) : azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkload =
            Unchecked.defaultof<azurerm.BackupPolicyVmWorkload.BackupPolicyVmWorkload>
