namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDiskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk">azurerm_data_protection_backup_instance_disk</a>.
    /// </summary>
    type DataProtectionBackupInstanceDiskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupInstanceDiskState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstanceDiskState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupInstanceDiskState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstanceDiskState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#backup_policy_id-1">DataProtectionBackupInstanceDisk#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: DataProtectionBackupInstanceDiskState<Missing, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceDiskState<Present, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceDiskState<Present, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#disk_id-1">DataProtectionBackupInstanceDisk#disk_id</a>.
        /// </summary>
        [<CustomOperation "disk_id">]
        member _.DiskId(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, Missing, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, Present, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.DiskId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceDiskState<'BackupPolicyId, Present, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#location-1">DataProtectionBackupInstanceDisk#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, Missing, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, Present, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, Present, 'Name, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#name-1">DataProtectionBackupInstanceDisk#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, Missing, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, Present, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, Present, 'SnapshotResourceGroupName, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#snapshot_resource_group_name-1">DataProtectionBackupInstanceDisk#snapshot_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_resource_group_name">]
        member _.SnapshotResourceGroupName(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, Missing, 'VaultId>, value: string) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.SnapshotResourceGroupName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#vault_id-1">DataProtectionBackupInstanceDisk#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, Missing>, value: string) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#id-1">DataProtectionBackupInstanceDisk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: string) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_disk#timeouts-1">DataProtectionBackupInstanceDisk#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>, value: azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDiskTimeouts) : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupInstanceDiskState<'BackupPolicyId, 'DiskId, 'Location, 'Name, 'SnapshotResourceGroupName, 'VaultId>

        member _.Run(state: DataProtectionBackupInstanceDiskState<Present, Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDisk =
            let config = azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDiskConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDisk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupInstanceDisk: missing required arguments. Must call: backup_policy_id, disk_id, location, name, snapshot_resource_group_name, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupInstanceDiskState<_, _, _, _, _, _>) : azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDisk =
            Unchecked.defaultof<azurerm.DataProtectionBackupInstanceDisk.DataProtectionBackupInstanceDisk>
