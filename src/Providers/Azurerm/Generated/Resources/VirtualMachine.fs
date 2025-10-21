namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> = { assignments: ResizeArray<azurerm.VirtualMachine.VirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine">azurerm_virtual_machine</a>.
    /// </summary>
    type VirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#location-1">VirtualMachine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualMachineState<Missing, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<Present, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualMachineState<Present, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#name-1">VirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineState<'Location, Missing, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, Present, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineState<'Location, Present, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#network_interface_ids-1">VirtualMachine#network_interface_ids</a>.
        /// </summary>
        [<CustomOperation "network_interface_ids">]
        member _.NetworkInterfaceIds(state: VirtualMachineState<'Location, 'Name, Missing, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: seq<string>) : VirtualMachineState<'Location, 'Name, Present, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.NetworkInterfaceIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VirtualMachineState<'Location, 'Name, Present, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#resource_group_name-1">VirtualMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, Missing, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, Present, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, Present, 'StorageOsDisk, 'VmSize>)

        /// <summary>
        /// storage_os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#storage_os_disk-1">VirtualMachine#storage_os_disk</a>
        /// </summary>
        [<CustomOperation "storage_os_disk">]
        member _.StorageOsDisk(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, Missing, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineStorageOsDisk) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, Present, 'VmSize> =
            state.assignments.Add(fun config -> config.StorageOsDisk <- value)
            ({ assignments = state.assignments } : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, Present, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#vm_size-1">VirtualMachine#vm_size</a>.
        /// </summary>
        [<CustomOperation "vm_size">]
        member _.VmSize(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, Missing>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, Present> =
            state.assignments.Add(fun config -> config.VmSize <- value)
            ({ assignments = state.assignments } : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, Present>)

        /// <summary>
        /// additional_capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#additional_capabilities-1">VirtualMachine#additional_capabilities</a>
        /// </summary>
        [<CustomOperation "additional_capabilities">]
        member _.AdditionalCapabilities(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineAdditionalCapabilities) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.AdditionalCapabilities <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#availability_set_id-1">VirtualMachine#availability_set_id</a>.
        /// </summary>
        [<CustomOperation "availability_set_id">]
        member _.AvailabilitySetId(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.AvailabilitySetId <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#boot_diagnostics-1">VirtualMachine#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineBootDiagnostics) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#delete_data_disks_on_termination-1">VirtualMachine#delete_data_disks_on_termination</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "delete_data_disks_on_termination">]
        member _.DeleteDataDisksOnTermination(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: bool) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.DeleteDataDisksOnTermination <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#delete_data_disks_on_termination-1">VirtualMachine#delete_data_disks_on_termination</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "delete_data_disks_on_termination">]
        member _.DeleteDataDisksOnTermination(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.DeleteDataDisksOnTermination <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#delete_os_disk_on_termination-1">VirtualMachine#delete_os_disk_on_termination</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "delete_os_disk_on_termination">]
        member _.DeleteOsDiskOnTermination(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: bool) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.DeleteOsDiskOnTermination <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#delete_os_disk_on_termination-1">VirtualMachine#delete_os_disk_on_termination</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "delete_os_disk_on_termination">]
        member _.DeleteOsDiskOnTermination(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.DeleteOsDiskOnTermination <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#id-1">VirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#identity-1">VirtualMachine#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineIdentity) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#license_type-1">VirtualMachine#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// os_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#os_profile-1">VirtualMachine#os_profile</a>
        /// </summary>
        [<CustomOperation "os_profile">]
        member _.OsProfile(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineOsProfile) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.OsProfile <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// os_profile_linux_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#os_profile_linux_config-1">VirtualMachine#os_profile_linux_config</a>
        /// </summary>
        [<CustomOperation "os_profile_linux_config">]
        member _.OsProfileLinuxConfig(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineOsProfileLinuxConfig) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.OsProfileLinuxConfig <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// os_profile_secrets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#os_profile_secrets-1">VirtualMachine#os_profile_secrets</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachine.VirtualMachineOsProfileSecrets[]
        /// </summary>
        [<CustomOperation "os_profile_secrets">]
        member _.OsProfileSecrets(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.OsProfileSecrets <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// os_profile_windows_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#os_profile_windows_config-1">VirtualMachine#os_profile_windows_config</a>
        /// </summary>
        [<CustomOperation "os_profile_windows_config">]
        member _.OsProfileWindowsConfig(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineOsProfileWindowsConfig) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.OsProfileWindowsConfig <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#plan-1">VirtualMachine#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachinePlan) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#primary_network_interface_id-1">VirtualMachine#primary_network_interface_id</a>.
        /// </summary>
        [<CustomOperation "primary_network_interface_id">]
        member _.PrimaryNetworkInterfaceId(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.PrimaryNetworkInterfaceId <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#proximity_placement_group_id-1">VirtualMachine#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: string) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// storage_data_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#storage_data_disk-1">VirtualMachine#storage_data_disk</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachine.VirtualMachineStorageDataDisk[]
        /// </summary>
        [<CustomOperation "storage_data_disk">]
        member _.StorageDataDisk(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.StorageDataDisk <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// storage_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#storage_image_reference-1">VirtualMachine#storage_image_reference</a>
        /// </summary>
        [<CustomOperation "storage_image_reference">]
        member _.StorageImageReference(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineStorageImageReference) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.StorageImageReference <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#tags-1">VirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: seq<string * string>) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#timeouts-1">VirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: azurerm.VirtualMachine.VirtualMachineTimeouts) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#zones-1">VirtualMachine#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>, value: seq<string>) : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : VirtualMachineState<'Location, 'Name, 'NetworkInterfaceIds, 'ResourceGroupName, 'StorageOsDisk, 'VmSize>

        member _.Run(state: VirtualMachineState<Present, Present, Present, Present, Present, Present>) : azurerm.VirtualMachine.VirtualMachine =
            let config = azurerm.VirtualMachine.VirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachine.VirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachine: missing required arguments. Must call: location, name, network_interface_ids, resource_group_name, storage_os_disk, vm_size.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineState<_, _, _, _, _, _>) : azurerm.VirtualMachine.VirtualMachine =
            Unchecked.defaultof<azurerm.VirtualMachine.VirtualMachine>
