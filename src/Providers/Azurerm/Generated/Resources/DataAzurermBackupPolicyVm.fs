namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm">azurerm_backup_policy_vm</a>.
    /// </summary>
    type DataAzurermBackupPolicyVmBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBackupPolicyVmState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBackupPolicyVmState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBackupPolicyVmState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBackupPolicyVmState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#name-1">DataAzurermBackupPolicyVm#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBackupPolicyVmState<Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermBackupPolicyVmState<Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBackupPolicyVmState<Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#recovery_vault_name-1">DataAzurermBackupPolicyVm#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: DataAzurermBackupPolicyVmState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermBackupPolicyVmState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : DataAzurermBackupPolicyVmState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#resource_group_name-1">DataAzurermBackupPolicyVm#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, Missing>, value: string) : DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#id-1">DataAzurermBackupPolicyVm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_vm#timeouts-1">DataAzurermBackupPolicyVm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVmTimeouts) : DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBackupPolicyVmState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: DataAzurermBackupPolicyVmState<Present, Present, Present>) : azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVm =
            let config = azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVmConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBackupPolicyVm: missing required arguments. Must call: name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBackupPolicyVmState<_, _, _>) : azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVm =
            Unchecked.defaultof<azurerm.DataAzurermBackupPolicyVm.DataAzurermBackupPolicyVm>
