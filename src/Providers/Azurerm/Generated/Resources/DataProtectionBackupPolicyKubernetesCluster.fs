namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName> = { assignments: ResizeArray<azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster">azurerm_data_protection_backup_policy_kubernetes_cluster</a>.
    /// </summary>
    type DataProtectionBackupPolicyKubernetesClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupPolicyKubernetesClusterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyKubernetesClusterState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupPolicyKubernetesClusterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupPolicyKubernetesClusterState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#backup_repeating_time_intervals-1">DataProtectionBackupPolicyKubernetesCluster#backup_repeating_time_intervals</a>.
        /// </summary>
        [<CustomOperation "backup_repeating_time_intervals">]
        member _.BackupRepeatingTimeIntervals(state: DataProtectionBackupPolicyKubernetesClusterState<Missing, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>, value: seq<string>) : DataProtectionBackupPolicyKubernetesClusterState<Present, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.BackupRepeatingTimeIntervals <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataProtectionBackupPolicyKubernetesClusterState<Present, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>)

        /// <summary>
        /// default_retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#default_retention_rule-1">DataProtectionBackupPolicyKubernetesCluster#default_retention_rule</a>
        /// </summary>
        [<CustomOperation "default_retention_rule">]
        member _.DefaultRetentionRule(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, Missing, 'Name, 'ResourceGroupName, 'VaultName>, value: azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterDefaultRetentionRule) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, Present, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.DefaultRetentionRule <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, Present, 'Name, 'ResourceGroupName, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#name-1">DataProtectionBackupPolicyKubernetesCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, Missing, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, Present, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, Present, 'ResourceGroupName, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#resource_group_name-1">DataProtectionBackupPolicyKubernetesCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, Missing, 'VaultName>, value: string) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, Present, 'VaultName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, Present, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#vault_name-1">DataProtectionBackupPolicyKubernetesCluster#vault_name</a>.
        /// </summary>
        [<CustomOperation "vault_name">]
        member _.VaultName(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, Missing>, value: string) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VaultName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#id-1">DataProtectionBackupPolicyKubernetesCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>

        /// <summary>
        /// retention_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#retention_rule-1">DataProtectionBackupPolicyKubernetesCluster#retention_rule</a> Accepts: azurerm.IResolvable | azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterRetentionRule[]
        /// </summary>
        [<CustomOperation "retention_rule">]
        member _.RetentionRule(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>, value: HashiCorp.Cdktf.IResolvable) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.RetentionRule <- value)
            state : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#timeouts-1">DataProtectionBackupPolicyKubernetesCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>, value: azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterTimeouts) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_kubernetes_cluster#time_zone-1">DataProtectionBackupPolicyKubernetesCluster#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>, value: string) : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : DataProtectionBackupPolicyKubernetesClusterState<'BackupRepeatingTimeIntervals, 'DefaultRetentionRule, 'Name, 'ResourceGroupName, 'VaultName>

        member _.Run(state: DataProtectionBackupPolicyKubernetesClusterState<Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesCluster =
            let config = azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupPolicyKubernetesCluster: missing required arguments. Must call: backup_repeating_time_intervals, default_retention_rule, name, resource_group_name, vault_name.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupPolicyKubernetesClusterState<_, _, _, _, _>) : azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesCluster =
            Unchecked.defaultof<azurerm.DataProtectionBackupPolicyKubernetesCluster.DataProtectionBackupPolicyKubernetesCluster>
