namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share">azurerm_backup_policy_file_share</a>.
    /// </summary>
    type DataAzurermBackupPolicyFileShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBackupPolicyFileShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBackupPolicyFileShareState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBackupPolicyFileShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBackupPolicyFileShareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share#name-1">DataAzurermBackupPolicyFileShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBackupPolicyFileShareState<Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermBackupPolicyFileShareState<Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBackupPolicyFileShareState<Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share#recovery_vault_name-1">DataAzurermBackupPolicyFileShare#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: DataAzurermBackupPolicyFileShareState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermBackupPolicyFileShareState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : DataAzurermBackupPolicyFileShareState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share#resource_group_name-1">DataAzurermBackupPolicyFileShare#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, Missing>, value: string) : DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share#id-1">DataAzurermBackupPolicyFileShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share#timeouts-1">DataAzurermBackupPolicyFileShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShareTimeouts) : DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBackupPolicyFileShareState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: DataAzurermBackupPolicyFileShareState<Present, Present, Present>) : azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShare =
            let config = azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBackupPolicyFileShare: missing required arguments. Must call: name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBackupPolicyFileShareState<_, _, _>) : azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShare =
            Unchecked.defaultof<azurerm.DataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShare>
