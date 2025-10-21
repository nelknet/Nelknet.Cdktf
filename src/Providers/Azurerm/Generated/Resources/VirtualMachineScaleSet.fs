namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> = { assignments: ResizeArray<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set">azurerm_virtual_machine_scale_set</a>.
    /// </summary>
    type VirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineScaleSetState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#location-1">VirtualMachineScaleSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualMachineScaleSetState<Missing, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<Present, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<Present, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#name-1">VirtualMachineScaleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineScaleSetState<'Location, Missing, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, Present, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, Present, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#network_profile-1">VirtualMachineScaleSet#network_profile</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile[]
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: VirtualMachineScaleSetState<'Location, 'Name, Missing, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, Present, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, 'Name, Present, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>)

        /// <summary>
        /// os_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#os_profile-1">VirtualMachineScaleSet#os_profile</a>
        /// </summary>
        [<CustomOperation "os_profile">]
        member _.OsProfile(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, Missing, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfile) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, Present, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.OsProfile <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, Present, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#resource_group_name-1">VirtualMachineScaleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, Missing, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, Present, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, Present, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#sku-1">VirtualMachineScaleSet#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, Missing, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetSku) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, Present, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, Present, 'StorageProfileOsDisk, 'UpgradePolicyMode>)

        /// <summary>
        /// storage_profile_os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#storage_profile_os_disk-1">VirtualMachineScaleSet#storage_profile_os_disk</a>
        /// </summary>
        [<CustomOperation "storage_profile_os_disk">]
        member _.StorageProfileOsDisk(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, Missing, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, Present, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.StorageProfileOsDisk <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, Present, 'UpgradePolicyMode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#upgrade_policy_mode-1">VirtualMachineScaleSet#upgrade_policy_mode</a>.
        /// </summary>
        [<CustomOperation "upgrade_policy_mode">]
        member _.UpgradePolicyMode(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, Missing>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, Present> =
            state.assignments.Add(fun config -> config.UpgradePolicyMode <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#automatic_os_upgrade-1">VirtualMachineScaleSet#automatic_os_upgrade</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_os_upgrade">]
        member _.AutomaticOsUpgrade(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: bool) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.AutomaticOsUpgrade <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#automatic_os_upgrade-1">VirtualMachineScaleSet#automatic_os_upgrade</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_os_upgrade">]
        member _.AutomaticOsUpgrade(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.AutomaticOsUpgrade <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#boot_diagnostics-1">VirtualMachineScaleSet#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#eviction_policy-1">VirtualMachineScaleSet#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#extension-1">VirtualMachineScaleSet#extension</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetExtension[]
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#health_probe_id-1">VirtualMachineScaleSet#health_probe_id</a>.
        /// </summary>
        [<CustomOperation "health_probe_id">]
        member _.HealthProbeId(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.HealthProbeId <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#id-1">VirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#identity-1">VirtualMachineScaleSet#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetIdentity) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#license_type-1">VirtualMachineScaleSet#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// os_profile_linux_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#os_profile_linux_config-1">VirtualMachineScaleSet#os_profile_linux_config</a>
        /// </summary>
        [<CustomOperation "os_profile_linux_config">]
        member _.OsProfileLinuxConfig(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.OsProfileLinuxConfig <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// os_profile_secrets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#os_profile_secrets-1">VirtualMachineScaleSet#os_profile_secrets</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets[]
        /// </summary>
        [<CustomOperation "os_profile_secrets">]
        member _.OsProfileSecrets(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.OsProfileSecrets <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// os_profile_windows_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#os_profile_windows_config-1">VirtualMachineScaleSet#os_profile_windows_config</a>
        /// </summary>
        [<CustomOperation "os_profile_windows_config">]
        member _.OsProfileWindowsConfig(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.OsProfileWindowsConfig <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#overprovision-1">VirtualMachineScaleSet#overprovision</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overprovision">]
        member _.Overprovision(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: bool) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Overprovision <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#overprovision-1">VirtualMachineScaleSet#overprovision</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overprovision">]
        member _.Overprovision(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Overprovision <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#plan-1">VirtualMachineScaleSet#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetPlan) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#priority-1">VirtualMachineScaleSet#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#proximity_placement_group_id-1">VirtualMachineScaleSet#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: string) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// rolling_upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#rolling_upgrade_policy-1">VirtualMachineScaleSet#rolling_upgrade_policy</a>
        /// </summary>
        [<CustomOperation "rolling_upgrade_policy">]
        member _.RollingUpgradePolicy(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.RollingUpgradePolicy <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#single_placement_group-1">VirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: bool) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#single_placement_group-1">VirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// storage_profile_data_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#storage_profile_data_disk-1">VirtualMachineScaleSet#storage_profile_data_disk</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk[]
        /// </summary>
        [<CustomOperation "storage_profile_data_disk">]
        member _.StorageProfileDataDisk(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.StorageProfileDataDisk <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// storage_profile_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#storage_profile_image_reference-1">VirtualMachineScaleSet#storage_profile_image_reference</a>
        /// </summary>
        [<CustomOperation "storage_profile_image_reference">]
        member _.StorageProfileImageReference(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.StorageProfileImageReference <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#tags-1">VirtualMachineScaleSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: seq<string * string>) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#timeouts-1">VirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetTimeouts) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#zones-1">VirtualMachineScaleSet#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>, value: seq<string>) : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : VirtualMachineScaleSetState<'Location, 'Name, 'NetworkProfile, 'OsProfile, 'ResourceGroupName, 'Sku, 'StorageProfileOsDisk, 'UpgradePolicyMode>

        member _.Run(state: VirtualMachineScaleSetState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet =
            let config = azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineScaleSet: missing required arguments. Must call: location, name, network_profile, os_profile, resource_group_name, sku, storage_profile_os_disk, upgrade_policy_mode.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineScaleSetState<_, _, _, _, _, _, _, _>) : azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet>
