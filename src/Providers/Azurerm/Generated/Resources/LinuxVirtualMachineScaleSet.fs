namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set">azurerm_linux_virtual_machine_scale_set</a>.
    /// </summary>
    type LinuxVirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : LinuxVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LinuxVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxVirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#admin_username-1">LinuxVirtualMachineScaleSet#admin_username</a>.
        /// </summary>
        [<CustomOperation "admin_username">]
        member _.AdminUsername(state: LinuxVirtualMachineScaleSetState<Missing, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<Present, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminUsername <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<Present, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#location-1">LinuxVirtualMachineScaleSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LinuxVirtualMachineScaleSetState<'AdminUsername, Missing, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, Present, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<'AdminUsername, Present, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#name-1">LinuxVirtualMachineScaleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, Missing, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, Present, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, Present, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#network_interface-1">LinuxVirtualMachineScaleSet#network_interface</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, Missing, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, Present, 'OsDisk, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#os_disk-1">LinuxVirtualMachineScaleSet#os_disk</a>
        /// </summary>
        [<CustomOperation "os_disk">]
        member _.OsDisk(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, Missing, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDisk) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.OsDisk <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#resource_group_name-1">LinuxVirtualMachineScaleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, Missing, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#sku-1">LinuxVirtualMachineScaleSet#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, Missing>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, Present>)

        /// <summary>
        /// additional_capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#additional_capabilities-1">LinuxVirtualMachineScaleSet#additional_capabilities</a>
        /// </summary>
        [<CustomOperation "additional_capabilities">]
        member _.AdditionalCapabilities(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdditionalCapabilities <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#admin_password-1">LinuxVirtualMachineScaleSet#admin_password</a>.
        /// </summary>
        [<CustomOperation "admin_password">]
        member _.AdminPassword(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminPassword <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// admin_ssh_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#admin_ssh_key-1">LinuxVirtualMachineScaleSet#admin_ssh_key</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKey[]
        /// </summary>
        [<CustomOperation "admin_ssh_key">]
        member _.AdminSshKey(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminSshKey <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// automatic_instance_repair block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#automatic_instance_repair-1">LinuxVirtualMachineScaleSet#automatic_instance_repair</a>
        /// </summary>
        [<CustomOperation "automatic_instance_repair">]
        member _.AutomaticInstanceRepair(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepair) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutomaticInstanceRepair <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// automatic_os_upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#automatic_os_upgrade_policy-1">LinuxVirtualMachineScaleSet#automatic_os_upgrade_policy</a>
        /// </summary>
        [<CustomOperation "automatic_os_upgrade_policy">]
        member _.AutomaticOsUpgradePolicy(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutomaticOsUpgradePolicy <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#boot_diagnostics-1">LinuxVirtualMachineScaleSet#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#capacity_reservation_group_id-1">LinuxVirtualMachineScaleSet#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#computer_name_prefix-1">LinuxVirtualMachineScaleSet#computer_name_prefix</a>.
        /// </summary>
        [<CustomOperation "computer_name_prefix">]
        member _.ComputerNamePrefix(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ComputerNamePrefix <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#custom_data-1">LinuxVirtualMachineScaleSet#custom_data</a>.
        /// </summary>
        [<CustomOperation "custom_data">]
        member _.CustomData(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomData <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// data_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#data_disk-1">LinuxVirtualMachineScaleSet#data_disk</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDisk[]
        /// </summary>
        [<CustomOperation "data_disk">]
        member _.DataDisk(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DataDisk <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#disable_password_authentication-1">LinuxVirtualMachineScaleSet#disable_password_authentication</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_password_authentication">]
        member _.DisablePasswordAuthentication(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DisablePasswordAuthentication <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#disable_password_authentication-1">LinuxVirtualMachineScaleSet#disable_password_authentication</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_password_authentication">]
        member _.DisablePasswordAuthentication(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DisablePasswordAuthentication <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#do_not_run_extensions_on_overprovisioned_machines-1">LinuxVirtualMachineScaleSet#do_not_run_extensions_on_overprovisioned_machines</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "do_not_run_extensions_on_overprovisioned_machines">]
        member _.DoNotRunExtensionsOnOverprovisionedMachines(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DoNotRunExtensionsOnOverprovisionedMachines <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#do_not_run_extensions_on_overprovisioned_machines-1">LinuxVirtualMachineScaleSet#do_not_run_extensions_on_overprovisioned_machines</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "do_not_run_extensions_on_overprovisioned_machines">]
        member _.DoNotRunExtensionsOnOverprovisionedMachines(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DoNotRunExtensionsOnOverprovisionedMachines <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#edge_zone-1">LinuxVirtualMachineScaleSet#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#encryption_at_host_enabled-1">LinuxVirtualMachineScaleSet#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#encryption_at_host_enabled-1">LinuxVirtualMachineScaleSet#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#eviction_policy-1">LinuxVirtualMachineScaleSet#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#extension-1">LinuxVirtualMachineScaleSet#extension</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtension[]
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#extension_operations_enabled-1">LinuxVirtualMachineScaleSet#extension_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "extension_operations_enabled">]
        member _.ExtensionOperationsEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtensionOperationsEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#extension_operations_enabled-1">LinuxVirtualMachineScaleSet#extension_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "extension_operations_enabled">]
        member _.ExtensionOperationsEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtensionOperationsEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#extensions_time_budget-1">LinuxVirtualMachineScaleSet#extensions_time_budget</a>.
        /// </summary>
        [<CustomOperation "extensions_time_budget">]
        member _.ExtensionsTimeBudget(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtensionsTimeBudget <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// gallery_application block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#gallery_application-1">LinuxVirtualMachineScaleSet#gallery_application</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplication[]
        /// </summary>
        [<CustomOperation "gallery_application">]
        member _.GalleryApplication(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.GalleryApplication <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#health_probe_id-1">LinuxVirtualMachineScaleSet#health_probe_id</a>.
        /// </summary>
        [<CustomOperation "health_probe_id">]
        member _.HealthProbeId(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HealthProbeId <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#host_group_id-1">LinuxVirtualMachineScaleSet#host_group_id</a>.
        /// </summary>
        [<CustomOperation "host_group_id">]
        member _.HostGroupId(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HostGroupId <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#id-1">LinuxVirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#identity-1">LinuxVirtualMachineScaleSet#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentity) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#instances-1">LinuxVirtualMachineScaleSet#instances</a>.
        /// </summary>
        [<CustomOperation "instances">]
        member _.Instances(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: double) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Instances <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#max_bid_price-1">LinuxVirtualMachineScaleSet#max_bid_price</a>.
        /// </summary>
        [<CustomOperation "max_bid_price">]
        member _.MaxBidPrice(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: double) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MaxBidPrice <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#overprovision-1">LinuxVirtualMachineScaleSet#overprovision</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overprovision">]
        member _.Overprovision(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Overprovision <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#overprovision-1">LinuxVirtualMachineScaleSet#overprovision</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overprovision">]
        member _.Overprovision(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Overprovision <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#plan-1">LinuxVirtualMachineScaleSet#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#platform_fault_domain_count-1">LinuxVirtualMachineScaleSet#platform_fault_domain_count</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain_count">]
        member _.PlatformFaultDomainCount(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: double) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PlatformFaultDomainCount <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#priority-1">LinuxVirtualMachineScaleSet#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#provision_vm_agent-1">LinuxVirtualMachineScaleSet#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#provision_vm_agent-1">LinuxVirtualMachineScaleSet#provision_vm_agent</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "provision_vm_agent">]
        member _.ProvisionVmAgent(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ProvisionVmAgent <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#proximity_placement_group_id-1">LinuxVirtualMachineScaleSet#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// rolling_upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#rolling_upgrade_policy-1">LinuxVirtualMachineScaleSet#rolling_upgrade_policy</a>
        /// </summary>
        [<CustomOperation "rolling_upgrade_policy">]
        member _.RollingUpgradePolicy(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicy) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.RollingUpgradePolicy <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// scale_in block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#scale_in-1">LinuxVirtualMachineScaleSet#scale_in</a>
        /// </summary>
        [<CustomOperation "scale_in">]
        member _.ScaleIn(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleIn) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ScaleIn <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#secret-1">LinuxVirtualMachineScaleSet#secret</a> Accepts: azurerm.IResolvable | azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#secure_boot_enabled-1">LinuxVirtualMachineScaleSet#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#secure_boot_enabled-1">LinuxVirtualMachineScaleSet#secure_boot_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secure_boot_enabled">]
        member _.SecureBootEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SecureBootEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#single_placement_group-1">LinuxVirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#single_placement_group-1">LinuxVirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#source_image_id-1">LinuxVirtualMachineScaleSet#source_image_id</a>.
        /// </summary>
        [<CustomOperation "source_image_id">]
        member _.SourceImageId(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SourceImageId <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// source_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#source_image_reference-1">LinuxVirtualMachineScaleSet#source_image_reference</a>
        /// </summary>
        [<CustomOperation "source_image_reference">]
        member _.SourceImageReference(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReference) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SourceImageReference <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// spot_restore block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#spot_restore-1">LinuxVirtualMachineScaleSet#spot_restore</a>
        /// </summary>
        [<CustomOperation "spot_restore">]
        member _.SpotRestore(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestore) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SpotRestore <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#tags-1">LinuxVirtualMachineScaleSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// termination_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#termination_notification-1">LinuxVirtualMachineScaleSet#termination_notification</a>
        /// </summary>
        [<CustomOperation "termination_notification">]
        member _.TerminationNotification(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotification) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TerminationNotification <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#timeouts-1">LinuxVirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeouts) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#upgrade_mode-1">LinuxVirtualMachineScaleSet#upgrade_mode</a>.
        /// </summary>
        [<CustomOperation "upgrade_mode">]
        member _.UpgradeMode(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.UpgradeMode <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#user_data-1">LinuxVirtualMachineScaleSet#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: string) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#vtpm_enabled-1">LinuxVirtualMachineScaleSet#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#vtpm_enabled-1">LinuxVirtualMachineScaleSet#vtpm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vtpm_enabled">]
        member _.VtpmEnabled(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.VtpmEnabled <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#zone_balance-1">LinuxVirtualMachineScaleSet#zone_balance</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balance">]
        member _.ZoneBalance(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: bool) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneBalance <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#zone_balance-1">LinuxVirtualMachineScaleSet#zone_balance</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balance">]
        member _.ZoneBalance(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneBalance <- value)
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#zones-1">LinuxVirtualMachineScaleSet#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>, value: seq<string>) : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : LinuxVirtualMachineScaleSetState<'AdminUsername, 'Location, 'Name, 'NetworkInterface, 'OsDisk, 'ResourceGroupName, 'Sku>

        member _.Run(state: LinuxVirtualMachineScaleSetState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet =
            let config = azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.linuxVirtualMachineScaleSet: missing required arguments. Must call: admin_username, location, name, network_interface, os_disk, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: LinuxVirtualMachineScaleSetState<_, _, _, _, _, _, _>) : azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet>
