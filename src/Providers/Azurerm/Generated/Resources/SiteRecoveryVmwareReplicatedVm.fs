namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> = { assignments: ResizeArray<azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm">azurerm_site_recovery_vmware_replicated_vm</a>.
    /// </summary>
    type SiteRecoveryVmwareReplicatedVmBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryVmwareReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryVmwareReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryVmwareReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryVmwareReplicatedVmState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#appliance_name-1">SiteRecoveryVmwareReplicatedVm#appliance_name</a>.
        /// </summary>
        [<CustomOperation "appliance_name">]
        member _.ApplianceName(state: SiteRecoveryVmwareReplicatedVmState<Missing, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<Present, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.ApplianceName <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<Present, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#name-1">SiteRecoveryVmwareReplicatedVm#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, Missing, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, Present, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, Present, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#physical_server_credential_name-1">SiteRecoveryVmwareReplicatedVm#physical_server_credential_name</a>.
        /// </summary>
        [<CustomOperation "physical_server_credential_name">]
        member _.PhysicalServerCredentialName(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, Missing, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, Present, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.PhysicalServerCredentialName <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, Present, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#recovery_replication_policy_id-1">SiteRecoveryVmwareReplicatedVm#recovery_replication_policy_id</a>.
        /// </summary>
        [<CustomOperation "recovery_replication_policy_id">]
        member _.RecoveryReplicationPolicyId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, Missing, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, Present, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.RecoveryReplicationPolicyId <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, Present, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#recovery_vault_id-1">SiteRecoveryVmwareReplicatedVm#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, Missing, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, Present, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, Present, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#source_vm_name-1">SiteRecoveryVmwareReplicatedVm#source_vm_name</a>.
        /// </summary>
        [<CustomOperation "source_vm_name">]
        member _.SourceVmName(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, Missing, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, Present, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.SourceVmName <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, Present, 'TargetResourceGroupId, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_resource_group_id-1">SiteRecoveryVmwareReplicatedVm#target_resource_group_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_group_id">]
        member _.TargetResourceGroupId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, Missing, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, Present, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetResourceGroupId <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, Present, 'TargetVmName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_vm_name-1">SiteRecoveryVmwareReplicatedVm#target_vm_name</a>.
        /// </summary>
        [<CustomOperation "target_vm_name">]
        member _.TargetVmName(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, Missing>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, Present> =
            state.assignments.Add(fun config -> config.TargetVmName <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#default_log_storage_account_id-1">SiteRecoveryVmwareReplicatedVm#default_log_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "default_log_storage_account_id">]
        member _.DefaultLogStorageAccountId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.DefaultLogStorageAccountId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#default_recovery_disk_type-1">SiteRecoveryVmwareReplicatedVm#default_recovery_disk_type</a>.
        /// </summary>
        [<CustomOperation "default_recovery_disk_type">]
        member _.DefaultRecoveryDiskType(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.DefaultRecoveryDiskType <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#default_target_disk_encryption_set_id-1">SiteRecoveryVmwareReplicatedVm#default_target_disk_encryption_set_id</a>.
        /// </summary>
        [<CustomOperation "default_target_disk_encryption_set_id">]
        member _.DefaultTargetDiskEncryptionSetId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.DefaultTargetDiskEncryptionSetId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#id-1">SiteRecoveryVmwareReplicatedVm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#license_type-1">SiteRecoveryVmwareReplicatedVm#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// managed_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#managed_disk-1">SiteRecoveryVmwareReplicatedVm#managed_disk</a> Accepts: azurerm.IResolvable | azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmManagedDisk[]
        /// </summary>
        [<CustomOperation "managed_disk">]
        member _.ManagedDisk(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: HashiCorp.Cdktf.IResolvable) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.ManagedDisk <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#multi_vm_group_name-1">SiteRecoveryVmwareReplicatedVm#multi_vm_group_name</a>.
        /// </summary>
        [<CustomOperation "multi_vm_group_name">]
        member _.MultiVmGroupName(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.MultiVmGroupName <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#network_interface-1">SiteRecoveryVmwareReplicatedVm#network_interface</a> Accepts: azurerm.IResolvable | azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: HashiCorp.Cdktf.IResolvable) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_availability_set_id-1">SiteRecoveryVmwareReplicatedVm#target_availability_set_id</a>.
        /// </summary>
        [<CustomOperation "target_availability_set_id">]
        member _.TargetAvailabilitySetId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetAvailabilitySetId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_boot_diagnostics_storage_account_id-1">SiteRecoveryVmwareReplicatedVm#target_boot_diagnostics_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "target_boot_diagnostics_storage_account_id">]
        member _.TargetBootDiagnosticsStorageAccountId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetBootDiagnosticsStorageAccountId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_network_id-1">SiteRecoveryVmwareReplicatedVm#target_network_id</a>.
        /// </summary>
        [<CustomOperation "target_network_id">]
        member _.TargetNetworkId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetNetworkId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_proximity_placement_group_id-1">SiteRecoveryVmwareReplicatedVm#target_proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "target_proximity_placement_group_id">]
        member _.TargetProximityPlacementGroupId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetProximityPlacementGroupId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_vm_size-1">SiteRecoveryVmwareReplicatedVm#target_vm_size</a>.
        /// </summary>
        [<CustomOperation "target_vm_size">]
        member _.TargetVmSize(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetVmSize <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_zone-1">SiteRecoveryVmwareReplicatedVm#target_zone</a>.
        /// </summary>
        [<CustomOperation "target_zone">]
        member _.TargetZone(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TargetZone <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#test_network_id-1">SiteRecoveryVmwareReplicatedVm#test_network_id</a>.
        /// </summary>
        [<CustomOperation "test_network_id">]
        member _.TestNetworkId(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: string) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.TestNetworkId <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#timeouts-1">SiteRecoveryVmwareReplicatedVm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>, value: azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmTimeouts) : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryVmwareReplicatedVmState<'ApplianceName, 'Name, 'PhysicalServerCredentialName, 'RecoveryReplicationPolicyId, 'RecoveryVaultId, 'SourceVmName, 'TargetResourceGroupId, 'TargetVmName>

        member _.Run(state: SiteRecoveryVmwareReplicatedVmState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVm =
            let config = azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryVmwareReplicatedVm: missing required arguments. Must call: appliance_name, name, physical_server_credential_name, recovery_replication_policy_id, recovery_vault_id, source_vm_name, target_resource_group_id, target_vm_name.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryVmwareReplicatedVmState<_, _, _, _, _, _, _, _>) : azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVm =
            Unchecked.defaultof<azurerm.SiteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVm>
