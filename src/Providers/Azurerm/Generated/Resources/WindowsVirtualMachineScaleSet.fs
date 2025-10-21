namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set">azurerm_windows_virtual_machine_scale_set</a>.
    /// </summary>
    type WindowsVirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WindowsVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WindowsVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#admin_password-1">WindowsVirtualMachineScaleSet#admin_password</a>.
        /// </summary>
        [<CustomOperation "admin_password">]
        member _.AdminPassword(state: WindowsVirtualMachineScaleSetState<Missing, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<Present, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminPassword <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<Present, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#admin_username-1">WindowsVirtualMachineScaleSet#admin_username</a>.
        /// </summary>
        [<CustomOperation "admin_username">]
        member _.AdminUsername(state: WindowsVirtualMachineScaleSetState<'AdminPassword, Missing, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, Present, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminUsername <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, Present, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#instances-1">WindowsVirtualMachineScaleSet#instances</a>.
        /// </summary>
        [<CustomOperation "instances">]
        member _.Instances(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, Missing, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: double) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, Present, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Instances <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, Present, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#location-1">WindowsVirtualMachineScaleSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, Missing, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, Present, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, Present, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#name-1">WindowsVirtualMachineScaleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, Missing, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, Present, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, Present, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#network_interface-1">WindowsVirtualMachineScaleSet#network_interface</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, Missing, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#os_disk-1">WindowsVirtualMachineScaleSet#os_disk</a>
        /// </summary>
        [<CustomOperation "os_disk">]
        member _.OsDisk(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, Missing, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDisk) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.OsDisk <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#resource_group_name-1">WindowsVirtualMachineScaleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, Missing, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#sku-1">WindowsVirtualMachineScaleSet#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, Missing>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, Present>)

        /// <summary>
        /// additional_capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#additional_capabilities-1">WindowsVirtualMachineScaleSet#additional_capabilities</a>
        /// </summary>
        [<CustomOperation "additional_capabilities">]
        member _.AdditionalCapabilities(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilities) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdditionalCapabilities <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// additional_unattend_content block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#additional_unattend_content-1">WindowsVirtualMachineScaleSet#additional_unattend_content</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent[]
        /// </summary>
        [<CustomOperation "additional_unattend_content">]
        member _.AdditionalUnattendContent(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdditionalUnattendContent <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// automatic_instance_repair block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#automatic_instance_repair-1">WindowsVirtualMachineScaleSet#automatic_instance_repair</a>
        /// </summary>
        [<CustomOperation "automatic_instance_repair">]
        member _.AutomaticInstanceRepair(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepair) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutomaticInstanceRepair <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// automatic_os_upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#automatic_os_upgrade_policy-1">WindowsVirtualMachineScaleSet#automatic_os_upgrade_policy</a>
        /// </summary>
        [<CustomOperation "automatic_os_upgrade_policy">]
        member _.AutomaticOsUpgradePolicy(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutomaticOsUpgradePolicy <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#boot_diagnostics-1">WindowsVirtualMachineScaleSet#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#capacity_reservation_group_id-1">WindowsVirtualMachineScaleSet#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#computer_name_prefix-1">WindowsVirtualMachineScaleSet#computer_name_prefix</a>.
        /// </summary>
        [<CustomOperation "computer_name_prefix">]
        member _.ComputerNamePrefix(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ComputerNamePrefix <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#custom_data-1">WindowsVirtualMachineScaleSet#custom_data</a>.
        /// </summary>
        [<CustomOperation "custom_data">]
        member _.CustomData(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomData <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// data_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#data_disk-1">WindowsVirtualMachineScaleSet#data_disk</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDisk[]
        /// </summary>
        [<CustomOperation "data_disk">]
        member _.DataDisk(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DataDisk <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#do_not_run_extensions_on_overprovisioned_machines-1">WindowsVirtualMachineScaleSet#do_not_run_extensions_on_overprovisioned_machines</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "do_not_run_extensions_on_overprovisioned_machines">]
        member _.DoNotRunExtensionsOnOverprovisionedMachines(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DoNotRunExtensionsOnOverprovisionedMachines <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#do_not_run_extensions_on_overprovisioned_machines-1">WindowsVirtualMachineScaleSet#do_not_run_extensions_on_overprovisioned_machines</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "do_not_run_extensions_on_overprovisioned_machines">]
        member _.DoNotRunExtensionsOnOverprovisionedMachines(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DoNotRunExtensionsOnOverprovisionedMachines <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#edge_zone-1">WindowsVirtualMachineScaleSet#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#enable_automatic_updates-1">WindowsVirtualMachineScaleSet#enable_automatic_updates</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_automatic_updates">]
        member _.EnableAutomaticUpdates(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EnableAutomaticUpdates <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#enable_automatic_updates-1">WindowsVirtualMachineScaleSet#enable_automatic_updates</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_automatic_updates">]
        member _.EnableAutomaticUpdates(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EnableAutomaticUpdates <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#encryption_at_host_enabled-1">WindowsVirtualMachineScaleSet#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#encryption_at_host_enabled-1">WindowsVirtualMachineScaleSet#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#eviction_policy-1">WindowsVirtualMachineScaleSet#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#extension-1">WindowsVirtualMachineScaleSet#extension</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtension[]
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#extension_operations_enabled-1">WindowsVirtualMachineScaleSet#extension_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "extension_operations_enabled">]
        member _.ExtensionOperationsEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtensionOperationsEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#extension_operations_enabled-1">WindowsVirtualMachineScaleSet#extension_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "extension_operations_enabled">]
        member _.ExtensionOperationsEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtensionOperationsEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#extensions_time_budget-1">WindowsVirtualMachineScaleSet#extensions_time_budget</a>.
        /// </summary>
        [<CustomOperation "extensions_time_budget">]
        member _.ExtensionsTimeBudget(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtensionsTimeBudget <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// gallery_application block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#gallery_application-1">WindowsVirtualMachineScaleSet#gallery_application</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetGalleryApplication[]
        /// </summary>
        [<CustomOperation "gallery_application">]
        member _.GalleryApplication(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.GalleryApplication <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#health_probe_id-1">WindowsVirtualMachineScaleSet#health_probe_id</a>.
        /// </summary>
        [<CustomOperation "health_probe_id">]
        member _.HealthProbeId(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HealthProbeId <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#host_group_id-1">WindowsVirtualMachineScaleSet#host_group_id</a>.
        /// </summary>
        [<CustomOperation "host_group_id">]
        member _.HostGroupId(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HostGroupId <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#id-1">WindowsVirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#identity-1">WindowsVirtualMachineScaleSet#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetIdentity) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#license_type-1">WindowsVirtualMachineScaleSet#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#max_bid_price-1">WindowsVirtualMachineScaleSet#max_bid_price</a>.
        /// </summary>
        [<CustomOperation "max_bid_price">]
        member _.MaxBidPrice(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: double) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MaxBidPrice <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#overprovision-1">WindowsVirtualMachineScaleSet#overprovision</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overprovision">]
        member _.Overprovision(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Overprovision <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#overprovision-1">WindowsVirtualMachineScaleSet#overprovision</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overprovision">]
        member _.Overprovision(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Overprovision <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#plan-1">WindowsVirtualMachineScaleSet#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlan) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#platform_fault_domain_count-1">WindowsVirtualMachineScaleSet#platform_fault_domain_count</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain_count">]
        member _.PlatformFaultDomainCount(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: double) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PlatformFaultDomainCount <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#priority-1">WindowsVirtualMachineScaleSet#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#provision_vm_agent-1">WindowsVirtualMachineScaleSet#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#provision_vm_agent-1">WindowsVirtualMachineScaleSet#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#proximity_placement_group_id-1">WindowsVirtualMachineScaleSet#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// rolling_upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#rolling_upgrade_policy-1">WindowsVirtualMachineScaleSet#rolling_upgrade_policy</a>
        /// </summary>
        [<CustomOperation "rolling_upgrade_policy">]
        member _.RollingUpgradePolicy(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetRollingUpgradePolicy) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.RollingUpgradePolicy <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// scale_in block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#scale_in-1">WindowsVirtualMachineScaleSet#scale_in</a>
        /// </summary>
        [<CustomOperation "scale_in">]
        member _.ScaleIn(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetScaleIn) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ScaleIn <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#secret-1">WindowsVirtualMachineScaleSet#secret</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#secure_boot_enabled-1">WindowsVirtualMachineScaleSet#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#secure_boot_enabled-1">WindowsVirtualMachineScaleSet#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#single_placement_group-1">WindowsVirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#single_placement_group-1">WindowsVirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#source_image_id-1">WindowsVirtualMachineScaleSet#source_image_id</a>.
        /// </summary>
        [<CustomOperation "source_image_id">]
        member _.SourceImageId(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SourceImageId <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// source_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#source_image_reference-1">WindowsVirtualMachineScaleSet#source_image_reference</a>
        /// </summary>
        [<CustomOperation "source_image_reference">]
        member _.SourceImageReference(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReference) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SourceImageReference <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// spot_restore block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#spot_restore-1">WindowsVirtualMachineScaleSet#spot_restore</a>
        /// </summary>
        [<CustomOperation "spot_restore">]
        member _.SpotRestore(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSpotRestore) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SpotRestore <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#tags-1">WindowsVirtualMachineScaleSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// termination_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#termination_notification-1">WindowsVirtualMachineScaleSet#termination_notification</a>
        /// </summary>
        [<CustomOperation "termination_notification">]
        member _.TerminationNotification(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminationNotification) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TerminationNotification <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#timeouts-1">WindowsVirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeouts) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#timezone-1">WindowsVirtualMachineScaleSet#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#upgrade_mode-1">WindowsVirtualMachineScaleSet#upgrade_mode</a>.
        /// </summary>
        [<CustomOperation "upgrade_mode">]
        member _.UpgradeMode(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.UpgradeMode <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#user_data-1">WindowsVirtualMachineScaleSet#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#vtpm_enabled-1">WindowsVirtualMachineScaleSet#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#vtpm_enabled-1">WindowsVirtualMachineScaleSet#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// winrm_listener block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#winrm_listener-1">WindowsVirtualMachineScaleSet#winrm_listener</a> Accepts: azurerm.IResolvable | azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListener[]
        /// </summary>
        [<CustomOperation "winrm_listener">]
        member _.WinrmListener(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.WinrmListener <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#zone_balance-1">WindowsVirtualMachineScaleSet#zone_balance</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balance">]
        member _.ZoneBalance(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneBalance <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#zone_balance-1">WindowsVirtualMachineScaleSet#zone_balance</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balance">]
        member _.ZoneBalance(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneBalance <- value)
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#zones-1">WindowsVirtualMachineScaleSet#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: seq<string>) : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : WindowsVirtualMachineScaleSetState<'AdminPassword, 'AdminUsername, 'Instances, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        member _.Run(state: WindowsVirtualMachineScaleSetState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet =
            let config = azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.windowsVirtualMachineScaleSet: missing required arguments. Must call: admin_password, admin_username, instances, location, name, network_interface, os_disk, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: WindowsVirtualMachineScaleSetState<_, _, _, _, _, _, _, _, _>) : azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet>
