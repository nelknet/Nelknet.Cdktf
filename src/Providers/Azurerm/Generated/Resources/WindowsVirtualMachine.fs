namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> = { assignments: ResizeArray<azurerm.WindowsVirtualMachine.WindowsVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine">azurerm_windows_virtual_machine</a>.
    /// </summary>
    type WindowsVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : WindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#admin_password-1">WindowsVirtualMachine#admin_password</a>.
        /// </summary>
        [<CustomOperation "admin_password">]
        member _.AdminPassword(state: WindowsVirtualMachineState<Missing, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<Present, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdminPassword <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<Present, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#admin_username-1">WindowsVirtualMachine#admin_username</a>.
        /// </summary>
        [<CustomOperation "admin_username">]
        member _.AdminUsername(state: WindowsVirtualMachineState<'AdminPassword, Missing, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, Present, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdminUsername <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, Present, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#location-1">WindowsVirtualMachine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, Missing, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, Present, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, Present, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#name-1">WindowsVirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, Missing, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, Present, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, Present, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#network_interface_ids-1">WindowsVirtualMachine#network_interface_ids</a>.
        /// </summary>
        [<CustomOperation "network_interface_ids">]
        member _.NetworkInterfaceIds(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, Missing, 'OsDisk, 'ResourceGroupName, 'Size>, value: seq<string>) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.NetworkInterfaceIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#os_disk-1">WindowsVirtualMachine#os_disk</a>
        /// </summary>
        [<CustomOperation "os_disk">]
        member _.OsDisk(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, Missing, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineOsDisk) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, Present, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.OsDisk <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, Present, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#resource_group_name-1">WindowsVirtualMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, Missing, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, Present, 'Size> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, Present, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#size-1">WindowsVirtualMachine#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, Missing>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Size <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, Present>)

        /// <summary>
        /// additional_capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#additional_capabilities-1">WindowsVirtualMachine#additional_capabilities</a>
        /// </summary>
        [<CustomOperation "additional_capabilities">]
        member _.AdditionalCapabilities(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineAdditionalCapabilities) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdditionalCapabilities <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// additional_unattend_content block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#additional_unattend_content-1">WindowsVirtualMachine#additional_unattend_content</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContent[]
        /// </summary>
        [<CustomOperation "additional_unattend_content">]
        member _.AdditionalUnattendContent(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdditionalUnattendContent <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#allow_extension_operations-1">WindowsVirtualMachine#allow_extension_operations</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_extension_operations">]
        member _.AllowExtensionOperations(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AllowExtensionOperations <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#allow_extension_operations-1">WindowsVirtualMachine#allow_extension_operations</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_extension_operations">]
        member _.AllowExtensionOperations(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AllowExtensionOperations <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#availability_set_id-1">WindowsVirtualMachine#availability_set_id</a>.
        /// </summary>
        [<CustomOperation "availability_set_id">]
        member _.AvailabilitySetId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AvailabilitySetId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#boot_diagnostics-1">WindowsVirtualMachine#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineBootDiagnostics) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#bypass_platform_safety_checks_on_user_schedule_enabled-1">WindowsVirtualMachine#bypass_platform_safety_checks_on_user_schedule_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bypass_platform_safety_checks_on_user_schedule_enabled">]
        member _.BypassPlatformSafetyChecksOnUserScheduleEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.BypassPlatformSafetyChecksOnUserScheduleEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#bypass_platform_safety_checks_on_user_schedule_enabled-1">WindowsVirtualMachine#bypass_platform_safety_checks_on_user_schedule_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bypass_platform_safety_checks_on_user_schedule_enabled">]
        member _.BypassPlatformSafetyChecksOnUserScheduleEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.BypassPlatformSafetyChecksOnUserScheduleEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#capacity_reservation_group_id-1">WindowsVirtualMachine#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#computer_name-1">WindowsVirtualMachine#computer_name</a>.
        /// </summary>
        [<CustomOperation "computer_name">]
        member _.ComputerName(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ComputerName <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#custom_data-1">WindowsVirtualMachine#custom_data</a>.
        /// </summary>
        [<CustomOperation "custom_data">]
        member _.CustomData(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.CustomData <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#dedicated_host_group_id-1">WindowsVirtualMachine#dedicated_host_group_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_group_id">]
        member _.DedicatedHostGroupId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DedicatedHostGroupId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#dedicated_host_id-1">WindowsVirtualMachine#dedicated_host_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_id">]
        member _.DedicatedHostId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DedicatedHostId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#disk_controller_type-1">WindowsVirtualMachine#disk_controller_type</a>.
        /// </summary>
        [<CustomOperation "disk_controller_type">]
        member _.DiskControllerType(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DiskControllerType <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#edge_zone-1">WindowsVirtualMachine#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#enable_automatic_updates-1">WindowsVirtualMachine#enable_automatic_updates</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_automatic_updates">]
        member _.EnableAutomaticUpdates(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EnableAutomaticUpdates <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#enable_automatic_updates-1">WindowsVirtualMachine#enable_automatic_updates</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_automatic_updates">]
        member _.EnableAutomaticUpdates(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EnableAutomaticUpdates <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#encryption_at_host_enabled-1">WindowsVirtualMachine#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#encryption_at_host_enabled-1">WindowsVirtualMachine#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#eviction_policy-1">WindowsVirtualMachine#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#extensions_time_budget-1">WindowsVirtualMachine#extensions_time_budget</a>.
        /// </summary>
        [<CustomOperation "extensions_time_budget">]
        member _.ExtensionsTimeBudget(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ExtensionsTimeBudget <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// gallery_application block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#gallery_application-1">WindowsVirtualMachine#gallery_application</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachine.WindowsVirtualMachineGalleryApplication[]
        /// </summary>
        [<CustomOperation "gallery_application">]
        member _.GalleryApplication(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.GalleryApplication <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#hotpatching_enabled-1">WindowsVirtualMachine#hotpatching_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "hotpatching_enabled">]
        member _.HotpatchingEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.HotpatchingEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#hotpatching_enabled-1">WindowsVirtualMachine#hotpatching_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "hotpatching_enabled">]
        member _.HotpatchingEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.HotpatchingEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#id-1">WindowsVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#identity-1">WindowsVirtualMachine#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineIdentity) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#license_type-1">WindowsVirtualMachine#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#max_bid_price-1">WindowsVirtualMachine#max_bid_price</a>.
        /// </summary>
        [<CustomOperation "max_bid_price">]
        member _.MaxBidPrice(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: double) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.MaxBidPrice <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// os_image_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#os_image_notification-1">WindowsVirtualMachine#os_image_notification</a>
        /// </summary>
        [<CustomOperation "os_image_notification">]
        member _.OsImageNotification(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineOsImageNotification) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.OsImageNotification <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#patch_assessment_mode-1">WindowsVirtualMachine#patch_assessment_mode</a>.
        /// </summary>
        [<CustomOperation "patch_assessment_mode">]
        member _.PatchAssessmentMode(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.PatchAssessmentMode <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#patch_mode-1">WindowsVirtualMachine#patch_mode</a>.
        /// </summary>
        [<CustomOperation "patch_mode">]
        member _.PatchMode(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.PatchMode <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#plan-1">WindowsVirtualMachine#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachinePlan) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#platform_fault_domain-1">WindowsVirtualMachine#platform_fault_domain</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain">]
        member _.PlatformFaultDomain(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: double) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.PlatformFaultDomain <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#priority-1">WindowsVirtualMachine#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#provision_vm_agent-1">WindowsVirtualMachine#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#provision_vm_agent-1">WindowsVirtualMachine#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#proximity_placement_group_id-1">WindowsVirtualMachine#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#reboot_setting-1">WindowsVirtualMachine#reboot_setting</a>.
        /// </summary>
        [<CustomOperation "reboot_setting">]
        member _.RebootSetting(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.RebootSetting <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#secret-1">WindowsVirtualMachine#secret</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachine.WindowsVirtualMachineSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#secure_boot_enabled-1">WindowsVirtualMachine#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#secure_boot_enabled-1">WindowsVirtualMachine#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#source_image_id-1">WindowsVirtualMachine#source_image_id</a>.
        /// </summary>
        [<CustomOperation "source_image_id">]
        member _.SourceImageId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SourceImageId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// source_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#source_image_reference-1">WindowsVirtualMachine#source_image_reference</a>
        /// </summary>
        [<CustomOperation "source_image_reference">]
        member _.SourceImageReference(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineSourceImageReference) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SourceImageReference <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#tags-1">WindowsVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: seq<string * string>) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// termination_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#termination_notification-1">WindowsVirtualMachine#termination_notification</a>
        /// </summary>
        [<CustomOperation "termination_notification">]
        member _.TerminationNotification(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineTerminationNotification) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.TerminationNotification <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#timeouts-1">WindowsVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.WindowsVirtualMachine.WindowsVirtualMachineTimeouts) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#timezone-1">WindowsVirtualMachine#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#user_data-1">WindowsVirtualMachine#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#virtual_machine_scale_set_id-1">WindowsVirtualMachine#virtual_machine_scale_set_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_scale_set_id">]
        member _.VirtualMachineScaleSetId(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VirtualMachineScaleSetId <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#vm_agent_platform_updates_enabled-1">WindowsVirtualMachine#vm_agent_platform_updates_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vm_agent_platform_updates_enabled">]
        member _.VmAgentPlatformUpdatesEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VmAgentPlatformUpdatesEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#vm_agent_platform_updates_enabled-1">WindowsVirtualMachine#vm_agent_platform_updates_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vm_agent_platform_updates_enabled">]
        member _.VmAgentPlatformUpdatesEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VmAgentPlatformUpdatesEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#vtpm_enabled-1">WindowsVirtualMachine#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#vtpm_enabled-1">WindowsVirtualMachine#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// winrm_listener block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#winrm_listener-1">WindowsVirtualMachine#winrm_listener</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachine.WindowsVirtualMachineWinrmListener[]
        /// </summary>
        [<CustomOperation "winrm_listener">]
        member _.WinrmListener(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.WinrmListener <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#zone-1">WindowsVirtualMachine#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : WindowsVirtualMachineState<'AdminPassword, 'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        member _.Run(state: WindowsVirtualMachineState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.WindowsVirtualMachine.WindowsVirtualMachine =
            let config = azurerm.WindowsVirtualMachine.WindowsVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.WindowsVirtualMachine.WindowsVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.windowsVirtualMachine: missing required arguments. Must call: admin_password, admin_username, location, name, network_interface_ids, os_disk, resource_group_name, size.", 9999, IsError = true)>]
        member _.Run(_: WindowsVirtualMachineState<_, _, _, _, _, _, _, _>) : azurerm.WindowsVirtualMachine.WindowsVirtualMachine =
            Unchecked.defaultof<azurerm.WindowsVirtualMachine.WindowsVirtualMachine>
