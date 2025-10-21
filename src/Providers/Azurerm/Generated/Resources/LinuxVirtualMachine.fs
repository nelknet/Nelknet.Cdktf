namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> = { assignments: ResizeArray<azurerm.LinuxVirtualMachine.LinuxVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine">azurerm_linux_virtual_machine</a>.
    /// </summary>
    type LinuxVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : LinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#admin_username-1">LinuxVirtualMachine#admin_username</a>.
        /// </summary>
        [<CustomOperation "admin_username">]
        member _.AdminUsername(state: LinuxVirtualMachineState<Missing, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<Present, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdminUsername <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineState<Present, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#location-1">LinuxVirtualMachine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LinuxVirtualMachineState<'AdminUsername, Missing, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, Present, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineState<'AdminUsername, Present, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#name-1">LinuxVirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LinuxVirtualMachineState<'AdminUsername, 'Location, Missing, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, Present, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineState<'AdminUsername, 'Location, Present, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#network_interface_ids-1">LinuxVirtualMachine#network_interface_ids</a>.
        /// </summary>
        [<CustomOperation "network_interface_ids">]
        member _.NetworkInterfaceIds(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, Missing, 'OsDisk, 'ResourceGroupName, 'Size>, value: seq<string>) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.NetworkInterfaceIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#os_disk-1">LinuxVirtualMachine#os_disk</a>
        /// </summary>
        [<CustomOperation "os_disk">]
        member _.OsDisk(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, Missing, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineOsDisk) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, Present, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.OsDisk <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, Present, 'ResourceGroupName, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#resource_group_name-1">LinuxVirtualMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, Missing, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, Present, 'Size> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, Present, 'Size>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#size-1">LinuxVirtualMachine#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, Missing>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Size <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, Present>)

        /// <summary>
        /// additional_capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#additional_capabilities-1">LinuxVirtualMachine#additional_capabilities</a>
        /// </summary>
        [<CustomOperation "additional_capabilities">]
        member _.AdditionalCapabilities(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilities) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdditionalCapabilities <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#admin_password-1">LinuxVirtualMachine#admin_password</a>.
        /// </summary>
        [<CustomOperation "admin_password">]
        member _.AdminPassword(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdminPassword <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// admin_ssh_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#admin_ssh_key-1">LinuxVirtualMachine#admin_ssh_key</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachine.LinuxVirtualMachineAdminSshKey[]
        /// </summary>
        [<CustomOperation "admin_ssh_key">]
        member _.AdminSshKey(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AdminSshKey <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#allow_extension_operations-1">LinuxVirtualMachine#allow_extension_operations</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_extension_operations">]
        member _.AllowExtensionOperations(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AllowExtensionOperations <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#allow_extension_operations-1">LinuxVirtualMachine#allow_extension_operations</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_extension_operations">]
        member _.AllowExtensionOperations(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AllowExtensionOperations <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#availability_set_id-1">LinuxVirtualMachine#availability_set_id</a>.
        /// </summary>
        [<CustomOperation "availability_set_id">]
        member _.AvailabilitySetId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.AvailabilitySetId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#boot_diagnostics-1">LinuxVirtualMachine#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineBootDiagnostics) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#bypass_platform_safety_checks_on_user_schedule_enabled-1">LinuxVirtualMachine#bypass_platform_safety_checks_on_user_schedule_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bypass_platform_safety_checks_on_user_schedule_enabled">]
        member _.BypassPlatformSafetyChecksOnUserScheduleEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.BypassPlatformSafetyChecksOnUserScheduleEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#bypass_platform_safety_checks_on_user_schedule_enabled-1">LinuxVirtualMachine#bypass_platform_safety_checks_on_user_schedule_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bypass_platform_safety_checks_on_user_schedule_enabled">]
        member _.BypassPlatformSafetyChecksOnUserScheduleEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.BypassPlatformSafetyChecksOnUserScheduleEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#capacity_reservation_group_id-1">LinuxVirtualMachine#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#computer_name-1">LinuxVirtualMachine#computer_name</a>.
        /// </summary>
        [<CustomOperation "computer_name">]
        member _.ComputerName(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ComputerName <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#custom_data-1">LinuxVirtualMachine#custom_data</a>.
        /// </summary>
        [<CustomOperation "custom_data">]
        member _.CustomData(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.CustomData <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#dedicated_host_group_id-1">LinuxVirtualMachine#dedicated_host_group_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_group_id">]
        member _.DedicatedHostGroupId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DedicatedHostGroupId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#dedicated_host_id-1">LinuxVirtualMachine#dedicated_host_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_id">]
        member _.DedicatedHostId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DedicatedHostId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#disable_password_authentication-1">LinuxVirtualMachine#disable_password_authentication</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_password_authentication">]
        member _.DisablePasswordAuthentication(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DisablePasswordAuthentication <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#disable_password_authentication-1">LinuxVirtualMachine#disable_password_authentication</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_password_authentication">]
        member _.DisablePasswordAuthentication(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DisablePasswordAuthentication <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#disk_controller_type-1">LinuxVirtualMachine#disk_controller_type</a>.
        /// </summary>
        [<CustomOperation "disk_controller_type">]
        member _.DiskControllerType(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.DiskControllerType <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#edge_zone-1">LinuxVirtualMachine#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#encryption_at_host_enabled-1">LinuxVirtualMachine#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#encryption_at_host_enabled-1">LinuxVirtualMachine#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#eviction_policy-1">LinuxVirtualMachine#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#extensions_time_budget-1">LinuxVirtualMachine#extensions_time_budget</a>.
        /// </summary>
        [<CustomOperation "extensions_time_budget">]
        member _.ExtensionsTimeBudget(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ExtensionsTimeBudget <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// gallery_application block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#gallery_application-1">LinuxVirtualMachine#gallery_application</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachine.LinuxVirtualMachineGalleryApplication[]
        /// </summary>
        [<CustomOperation "gallery_application">]
        member _.GalleryApplication(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.GalleryApplication <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#id-1">LinuxVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#identity-1">LinuxVirtualMachine#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineIdentity) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#license_type-1">LinuxVirtualMachine#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#max_bid_price-1">LinuxVirtualMachine#max_bid_price</a>.
        /// </summary>
        [<CustomOperation "max_bid_price">]
        member _.MaxBidPrice(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: double) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.MaxBidPrice <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// os_image_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#os_image_notification-1">LinuxVirtualMachine#os_image_notification</a>
        /// </summary>
        [<CustomOperation "os_image_notification">]
        member _.OsImageNotification(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineOsImageNotification) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.OsImageNotification <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#patch_assessment_mode-1">LinuxVirtualMachine#patch_assessment_mode</a>.
        /// </summary>
        [<CustomOperation "patch_assessment_mode">]
        member _.PatchAssessmentMode(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.PatchAssessmentMode <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#patch_mode-1">LinuxVirtualMachine#patch_mode</a>.
        /// </summary>
        [<CustomOperation "patch_mode">]
        member _.PatchMode(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.PatchMode <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#plan-1">LinuxVirtualMachine#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachinePlan) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#platform_fault_domain-1">LinuxVirtualMachine#platform_fault_domain</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain">]
        member _.PlatformFaultDomain(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: double) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.PlatformFaultDomain <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#priority-1">LinuxVirtualMachine#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#provision_vm_agent-1">LinuxVirtualMachine#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#provision_vm_agent-1">LinuxVirtualMachine#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#proximity_placement_group_id-1">LinuxVirtualMachine#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#reboot_setting-1">LinuxVirtualMachine#reboot_setting</a>.
        /// </summary>
        [<CustomOperation "reboot_setting">]
        member _.RebootSetting(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.RebootSetting <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#secret-1">LinuxVirtualMachine#secret</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachine.LinuxVirtualMachineSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#secure_boot_enabled-1">LinuxVirtualMachine#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#secure_boot_enabled-1">LinuxVirtualMachine#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#source_image_id-1">LinuxVirtualMachine#source_image_id</a>.
        /// </summary>
        [<CustomOperation "source_image_id">]
        member _.SourceImageId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SourceImageId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// source_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#source_image_reference-1">LinuxVirtualMachine#source_image_reference</a>
        /// </summary>
        [<CustomOperation "source_image_reference">]
        member _.SourceImageReference(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineSourceImageReference) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.SourceImageReference <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#tags-1">LinuxVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: seq<string * string>) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// termination_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#termination_notification-1">LinuxVirtualMachine#termination_notification</a>
        /// </summary>
        [<CustomOperation "termination_notification">]
        member _.TerminationNotification(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineTerminationNotification) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.TerminationNotification <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#timeouts-1">LinuxVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: azurerm.LinuxVirtualMachine.LinuxVirtualMachineTimeouts) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#user_data-1">LinuxVirtualMachine#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#virtual_machine_scale_set_id-1">LinuxVirtualMachine#virtual_machine_scale_set_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_scale_set_id">]
        member _.VirtualMachineScaleSetId(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VirtualMachineScaleSetId <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#vm_agent_platform_updates_enabled-1">LinuxVirtualMachine#vm_agent_platform_updates_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vm_agent_platform_updates_enabled">]
        member _.VmAgentPlatformUpdatesEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VmAgentPlatformUpdatesEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#vm_agent_platform_updates_enabled-1">LinuxVirtualMachine#vm_agent_platform_updates_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vm_agent_platform_updates_enabled">]
        member _.VmAgentPlatformUpdatesEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VmAgentPlatformUpdatesEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#vtpm_enabled-1">LinuxVirtualMachine#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: bool) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#vtpm_enabled-1">LinuxVirtualMachine#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#zone-1">LinuxVirtualMachine#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>, value: string) : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : LinuxVirtualMachineState<'AdminUsername, 'Location, 'Name, 'NetworkInterfaceIds, 'OsDisk, 'ResourceGroupName, 'Size>

        member _.Run(state: LinuxVirtualMachineState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.LinuxVirtualMachine.LinuxVirtualMachine =
            let config = azurerm.LinuxVirtualMachine.LinuxVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.LinuxVirtualMachine.LinuxVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.linuxVirtualMachine: missing required arguments. Must call: admin_username, location, name, network_interface_ids, os_disk, resource_group_name, size.", 9999, IsError = true)>]
        member _.Run(_: LinuxVirtualMachineState<_, _, _, _, _, _, _>) : azurerm.LinuxVirtualMachine.LinuxVirtualMachine =
            Unchecked.defaultof<azurerm.LinuxVirtualMachine.LinuxVirtualMachine>
