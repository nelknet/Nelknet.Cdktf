namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> = { assignments: ResizeArray<azurerm.ManagedDisk.ManagedDiskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk">azurerm_managed_disk</a>.
    /// </summary>
    type ManagedDiskBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagedDiskState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedDiskState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ManagedDiskState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedDiskState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#create_option-1">ManagedDisk#create_option</a>.
        /// </summary>
        [<CustomOperation "create_option">]
        member _.CreateOption(state: ManagedDiskState<Missing, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.CreateOption <- value)
            ({ assignments = state.assignments } : ManagedDiskState<Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#location-1">ManagedDisk#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ManagedDiskState<'CreateOption, Missing, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, Present, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ManagedDiskState<'CreateOption, Present, 'Name, 'ResourceGroupName, 'StorageAccountType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#name-1">ManagedDisk#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagedDiskState<'CreateOption, 'Location, Missing, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, Present, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagedDiskState<'CreateOption, 'Location, Present, 'ResourceGroupName, 'StorageAccountType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#resource_group_name-1">ManagedDisk#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ManagedDiskState<'CreateOption, 'Location, 'Name, Missing, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, Present, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ManagedDiskState<'CreateOption, 'Location, 'Name, Present, 'StorageAccountType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#storage_account_type-1">ManagedDisk#storage_account_type</a>.
        /// </summary>
        [<CustomOperation "storage_account_type">]
        member _.StorageAccountType(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StorageAccountType <- value)
            ({ assignments = state.assignments } : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_access_id-1">ManagedDisk#disk_access_id</a>.
        /// </summary>
        [<CustomOperation "disk_access_id">]
        member _.DiskAccessId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskAccessId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_encryption_set_id-1">ManagedDisk#disk_encryption_set_id</a>.
        /// </summary>
        [<CustomOperation "disk_encryption_set_id">]
        member _.DiskEncryptionSetId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskEncryptionSetId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_iops_read_only-1">ManagedDisk#disk_iops_read_only</a>.
        /// </summary>
        [<CustomOperation "disk_iops_read_only">]
        member _.DiskIopsReadOnly(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskIopsReadOnly <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_iops_read_write-1">ManagedDisk#disk_iops_read_write</a>.
        /// </summary>
        [<CustomOperation "disk_iops_read_write">]
        member _.DiskIopsReadWrite(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskIopsReadWrite <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_mbps_read_only-1">ManagedDisk#disk_mbps_read_only</a>.
        /// </summary>
        [<CustomOperation "disk_mbps_read_only">]
        member _.DiskMbpsReadOnly(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskMbpsReadOnly <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_mbps_read_write-1">ManagedDisk#disk_mbps_read_write</a>.
        /// </summary>
        [<CustomOperation "disk_mbps_read_write">]
        member _.DiskMbpsReadWrite(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskMbpsReadWrite <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_size_gb-1">ManagedDisk#disk_size_gb</a>.
        /// </summary>
        [<CustomOperation "disk_size_gb">]
        member _.DiskSizeGb(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.DiskSizeGb <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#edge_zone-1">ManagedDisk#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// encryption_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#encryption_settings-1">ManagedDisk#encryption_settings</a>
        /// </summary>
        [<CustomOperation "encryption_settings">]
        member _.EncryptionSettings(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: azurerm.ManagedDisk.ManagedDiskEncryptionSettings) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.EncryptionSettings <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#gallery_image_reference_id-1">ManagedDisk#gallery_image_reference_id</a>.
        /// </summary>
        [<CustomOperation "gallery_image_reference_id">]
        member _.GalleryImageReferenceId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.GalleryImageReferenceId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#hyper_v_generation-1">ManagedDisk#hyper_v_generation</a>.
        /// </summary>
        [<CustomOperation "hyper_v_generation">]
        member _.HyperVGeneration(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.HyperVGeneration <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#id-1">ManagedDisk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#image_reference_id-1">ManagedDisk#image_reference_id</a>.
        /// </summary>
        [<CustomOperation "image_reference_id">]
        member _.ImageReferenceId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.ImageReferenceId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#logical_sector_size-1">ManagedDisk#logical_sector_size</a>.
        /// </summary>
        [<CustomOperation "logical_sector_size">]
        member _.LogicalSectorSize(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.LogicalSectorSize <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#max_shares-1">ManagedDisk#max_shares</a>.
        /// </summary>
        [<CustomOperation "max_shares">]
        member _.MaxShares(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.MaxShares <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#network_access_policy-1">ManagedDisk#network_access_policy</a>.
        /// </summary>
        [<CustomOperation "network_access_policy">]
        member _.NetworkAccessPolicy(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.NetworkAccessPolicy <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#on_demand_bursting_enabled-1">ManagedDisk#on_demand_bursting_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "on_demand_bursting_enabled">]
        member _.OnDemandBurstingEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: bool) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.OnDemandBurstingEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#on_demand_bursting_enabled-1">ManagedDisk#on_demand_bursting_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "on_demand_bursting_enabled">]
        member _.OnDemandBurstingEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: HashiCorp.Cdktf.IResolvable) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.OnDemandBurstingEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#optimized_frequent_attach_enabled-1">ManagedDisk#optimized_frequent_attach_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "optimized_frequent_attach_enabled">]
        member _.OptimizedFrequentAttachEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: bool) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.OptimizedFrequentAttachEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#optimized_frequent_attach_enabled-1">ManagedDisk#optimized_frequent_attach_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "optimized_frequent_attach_enabled">]
        member _.OptimizedFrequentAttachEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: HashiCorp.Cdktf.IResolvable) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.OptimizedFrequentAttachEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#os_type-1">ManagedDisk#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.OsType <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#performance_plus_enabled-1">ManagedDisk#performance_plus_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "performance_plus_enabled">]
        member _.PerformancePlusEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: bool) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.PerformancePlusEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#performance_plus_enabled-1">ManagedDisk#performance_plus_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "performance_plus_enabled">]
        member _.PerformancePlusEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: HashiCorp.Cdktf.IResolvable) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.PerformancePlusEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#public_network_access_enabled-1">ManagedDisk#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: bool) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#public_network_access_enabled-1">ManagedDisk#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: HashiCorp.Cdktf.IResolvable) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#secure_vm_disk_encryption_set_id-1">ManagedDisk#secure_vm_disk_encryption_set_id</a>.
        /// </summary>
        [<CustomOperation "secure_vm_disk_encryption_set_id">]
        member _.SecureVmDiskEncryptionSetId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.SecureVmDiskEncryptionSetId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#security_type-1">ManagedDisk#security_type</a>.
        /// </summary>
        [<CustomOperation "security_type">]
        member _.SecurityType(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.SecurityType <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#source_resource_id-1">ManagedDisk#source_resource_id</a>.
        /// </summary>
        [<CustomOperation "source_resource_id">]
        member _.SourceResourceId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.SourceResourceId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#source_uri-1">ManagedDisk#source_uri</a>.
        /// </summary>
        [<CustomOperation "source_uri">]
        member _.SourceUri(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.SourceUri <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#storage_account_id-1">ManagedDisk#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#tags-1">ManagedDisk#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: seq<string * string>) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#tier-1">ManagedDisk#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Tier <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#timeouts-1">ManagedDisk#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: azurerm.ManagedDisk.ManagedDiskTimeouts) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#trusted_launch_enabled-1">ManagedDisk#trusted_launch_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trusted_launch_enabled">]
        member _.TrustedLaunchEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: bool) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.TrustedLaunchEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#trusted_launch_enabled-1">ManagedDisk#trusted_launch_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trusted_launch_enabled">]
        member _.TrustedLaunchEnabled(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: HashiCorp.Cdktf.IResolvable) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.TrustedLaunchEnabled <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#upload_size_bytes-1">ManagedDisk#upload_size_bytes</a>.
        /// </summary>
        [<CustomOperation "upload_size_bytes">]
        member _.UploadSizeBytes(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: double) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.UploadSizeBytes <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#zone-1">ManagedDisk#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>, value: string) : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : ManagedDiskState<'CreateOption, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountType>

        member _.Run(state: ManagedDiskState<Present, Present, Present, Present, Present>) : azurerm.ManagedDisk.ManagedDisk =
            let config = azurerm.ManagedDisk.ManagedDiskConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagedDisk.ManagedDisk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managedDisk: missing required arguments. Must call: create_option, location, name, resource_group_name, storage_account_type.", 9999, IsError = true)>]
        member _.Run(_: ManagedDiskState<_, _, _, _, _>) : azurerm.ManagedDisk.ManagedDisk =
            Unchecked.defaultof<azurerm.ManagedDisk.ManagedDisk>
