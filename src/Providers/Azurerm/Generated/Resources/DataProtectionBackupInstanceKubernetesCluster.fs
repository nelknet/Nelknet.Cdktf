namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster">azurerm_data_protection_backup_instance_kubernetes_cluster</a>.
    /// </summary>
    type DataProtectionBackupInstanceKubernetesClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupInstanceKubernetesClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstanceKubernetesClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupInstanceKubernetesClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstanceKubernetesClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#backup_policy_id-1">DataProtectionBackupInstanceKubernetesCluster#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: DataProtectionBackupInstanceKubernetesClusterState<Missing, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<Present, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceKubernetesClusterState<Present, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#kubernetes_cluster_id-1">DataProtectionBackupInstanceKubernetesCluster#kubernetes_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_cluster_id">]
        member _.KubernetesClusterId(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, Missing, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, Present, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.KubernetesClusterId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, Present, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#location-1">DataProtectionBackupInstanceKubernetesCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, Missing, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, Present, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, Present, 'Name, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#name-1">DataProtectionBackupInstanceKubernetesCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, Missing, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, Present, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, Present, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#snapshot_resource_group_name-1">DataProtectionBackupInstanceKubernetesCluster#snapshot_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_resource_group_name">]
        member _.SnapshotResourceGroupName(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, Missing, 'VaultId>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.SnapshotResourceGroupName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#vault_id-1">DataProtectionBackupInstanceKubernetesCluster#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, Missing>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, Present>)

        /// <summary>
        /// backup_datasource_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#backup_datasource_parameters-1">DataProtectionBackupInstanceKubernetesCluster#backup_datasource_parameters</a>
        /// </summary>
        [<CustomOperation "backup_datasource_parameters">]
        member _.BackupDatasourceParameters(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesClusterBackupDatasourceParameters) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupDatasourceParameters <- value)
            state : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#id-1">DataProtectionBackupInstanceKubernetesCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_kubernetes_cluster#timeouts-1">DataProtectionBackupInstanceKubernetesCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesClusterTimeouts) : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupInstanceKubernetesClusterState<'BackupPolicyId, 'KubernetesClusterId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>

        member _.Run(state: DataProtectionBackupInstanceKubernetesClusterState<Present, Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesCluster =
            let config = azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupInstanceKubernetesCluster: missing required arguments. Must call: backup_policy_id, kubernetes_cluster_id, location, name, snapshot_resource_group_name, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupInstanceKubernetesClusterState<_, _, _, _, _, _>) : azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesCluster =
            Unchecked.defaultof<azurerm.DataProtectionBackupInstanceKubernetesCluster.DataProtectionBackupInstanceKubernetesCluster>
