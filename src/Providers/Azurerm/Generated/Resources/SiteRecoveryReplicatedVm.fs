namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> = { assignments: ResizeArray<azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm">azurerm_site_recovery_replicated_vm</a>.
    /// </summary>
    type SiteRecoveryReplicatedVmBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#name-1">SiteRecoveryReplicatedVm#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryReplicatedVmState<Missing, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<Present, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<Present, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#recovery_replication_policy_id-1">SiteRecoveryReplicatedVm#recovery_replication_policy_id</a>.
        /// </summary>
        [<CustomOperation "recovery_replication_policy_id">]
        member _.RecoveryReplicationPolicyId(state: SiteRecoveryReplicatedVmState<'Name, Missing, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.RecoveryReplicationPolicyId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#recovery_vault_name-1">SiteRecoveryReplicatedVm#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, Missing, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, Present, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, Present, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#resource_group_name-1">SiteRecoveryReplicatedVm#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, Missing, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, Present, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, Present, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#source_recovery_fabric_name-1">SiteRecoveryReplicatedVm#source_recovery_fabric_name</a>.
        /// </summary>
        [<CustomOperation "source_recovery_fabric_name">]
        member _.SourceRecoveryFabricName(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, Missing, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, Present, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.SourceRecoveryFabricName <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, Present, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#source_recovery_protection_container_name-1">SiteRecoveryReplicatedVm#source_recovery_protection_container_name</a>.
        /// </summary>
        [<CustomOperation "source_recovery_protection_container_name">]
        member _.SourceRecoveryProtectionContainerName(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, Missing, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, Present, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.SourceRecoveryProtectionContainerName <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, Present, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#source_vm_id-1">SiteRecoveryReplicatedVm#source_vm_id</a>.
        /// </summary>
        [<CustomOperation "source_vm_id">]
        member _.SourceVmId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, Missing, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, Present, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.SourceVmId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, Present, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_recovery_fabric_id-1">SiteRecoveryReplicatedVm#target_recovery_fabric_id</a>.
        /// </summary>
        [<CustomOperation "target_recovery_fabric_id">]
        member _.TargetRecoveryFabricId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, Missing, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, Present, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetRecoveryFabricId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, Present, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_recovery_protection_container_id-1">SiteRecoveryReplicatedVm#target_recovery_protection_container_id</a>.
        /// </summary>
        [<CustomOperation "target_recovery_protection_container_id">]
        member _.TargetRecoveryProtectionContainerId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, Missing, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, Present, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetRecoveryProtectionContainerId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, Present, 'TargetResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_resource_group_id-1">SiteRecoveryReplicatedVm#target_resource_group_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_group_id">]
        member _.TargetResourceGroupId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, Missing>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, Present> =
            state.assignments.Add(fun config -> config.TargetResourceGroupId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#id-1">SiteRecoveryReplicatedVm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#managed_disk-1">SiteRecoveryReplicatedVm#managed_disk</a>. Accepts: azurerm.IResolvable | azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDisk[]
        /// </summary>
        [<CustomOperation "managed_disk">]
        member _.ManagedDisk(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.ManagedDisk <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#multi_vm_group_name-1">SiteRecoveryReplicatedVm#multi_vm_group_name</a>.
        /// </summary>
        [<CustomOperation "multi_vm_group_name">]
        member _.MultiVmGroupName(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.MultiVmGroupName <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#network_interface-1">SiteRecoveryReplicatedVm#network_interface</a>. Accepts: azurerm.IResolvable | azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVmNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_availability_set_id-1">SiteRecoveryReplicatedVm#target_availability_set_id</a>.
        /// </summary>
        [<CustomOperation "target_availability_set_id">]
        member _.TargetAvailabilitySetId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetAvailabilitySetId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_boot_diagnostic_storage_account_id-1">SiteRecoveryReplicatedVm#target_boot_diagnostic_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "target_boot_diagnostic_storage_account_id">]
        member _.TargetBootDiagnosticStorageAccountId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetBootDiagnosticStorageAccountId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_capacity_reservation_group_id-1">SiteRecoveryReplicatedVm#target_capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "target_capacity_reservation_group_id">]
        member _.TargetCapacityReservationGroupId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetCapacityReservationGroupId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_edge_zone-1">SiteRecoveryReplicatedVm#target_edge_zone</a>.
        /// </summary>
        [<CustomOperation "target_edge_zone">]
        member _.TargetEdgeZone(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetEdgeZone <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_network_id-1">SiteRecoveryReplicatedVm#target_network_id</a>.
        /// </summary>
        [<CustomOperation "target_network_id">]
        member _.TargetNetworkId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetNetworkId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_proximity_placement_group_id-1">SiteRecoveryReplicatedVm#target_proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "target_proximity_placement_group_id">]
        member _.TargetProximityPlacementGroupId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetProximityPlacementGroupId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_virtual_machine_scale_set_id-1">SiteRecoveryReplicatedVm#target_virtual_machine_scale_set_id</a>.
        /// </summary>
        [<CustomOperation "target_virtual_machine_scale_set_id">]
        member _.TargetVirtualMachineScaleSetId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetVirtualMachineScaleSetId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_zone-1">SiteRecoveryReplicatedVm#target_zone</a>.
        /// </summary>
        [<CustomOperation "target_zone">]
        member _.TargetZone(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TargetZone <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#test_network_id-1">SiteRecoveryReplicatedVm#test_network_id</a>.
        /// </summary>
        [<CustomOperation "test_network_id">]
        member _.TestNetworkId(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: string) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.TestNetworkId <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#timeouts-1">SiteRecoveryReplicatedVm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVmTimeouts) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#unmanaged_disk-1">SiteRecoveryReplicatedVm#unmanaged_disk</a>. Accepts: azurerm.IResolvable | azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVmUnmanagedDisk[]
        /// </summary>
        [<CustomOperation "unmanaged_disk">]
        member _.UnmanagedDisk(state: SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId> =
            state.assignments.Add(fun config -> config.UnmanagedDisk <- value)
            state : SiteRecoveryReplicatedVmState<'Name, 'RecoveryReplicationPolicyId, 'RecoveryVaultName, 'ResourceGroupName, 'SourceRecoveryFabricName, 'SourceRecoveryProtectionContainerName, 'SourceVmId, 'TargetRecoveryFabricId, 'TargetRecoveryProtectionContainerId, 'TargetResourceGroupId>

        member _.Run(state: SiteRecoveryReplicatedVmState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVm =
            let config = azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVmConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryReplicatedVm: missing required arguments. Must call: name, recovery_replication_policy_id, recovery_vault_name, resource_group_name, source_recovery_fabric_name, source_recovery_protection_container_name, source_vm_id, target_recovery_fabric_id, target_recovery_protection_container_id, target_resource_group_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryReplicatedVmState<_, _, _, _, _, _, _, _, _, _>) : azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVm =
            Unchecked.defaultof<azurerm.SiteRecoveryReplicatedVm.SiteRecoveryReplicatedVm>
