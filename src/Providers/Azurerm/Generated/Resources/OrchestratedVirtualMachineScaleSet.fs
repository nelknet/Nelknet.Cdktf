namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set">azurerm_orchestrated_virtual_machine_scale_set</a>.
    /// </summary>
    type OrchestratedVirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrchestratedVirtualMachineScaleSetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrchestratedVirtualMachineScaleSetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OrchestratedVirtualMachineScaleSetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrchestratedVirtualMachineScaleSetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#location-1">OrchestratedVirtualMachineScaleSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: OrchestratedVirtualMachineScaleSetState<Missing, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<Present, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : OrchestratedVirtualMachineScaleSetState<Present, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#name-1">OrchestratedVirtualMachineScaleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrchestratedVirtualMachineScaleSetState<'Location, Missing, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, Present, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrchestratedVirtualMachineScaleSetState<'Location, Present, 'PlatformFaultDomainCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#platform_fault_domain_count-1">OrchestratedVirtualMachineScaleSet#platform_fault_domain_count</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain_count">]
        member _.PlatformFaultDomainCount(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, Missing, 'ResourceGroupName>, value: double) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PlatformFaultDomainCount <- value)
            ({ assignments = state.assignments } : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#resource_group_name-1">OrchestratedVirtualMachineScaleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, Missing>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, Present>)

        /// <summary>
        /// additional_capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#additional_capabilities-1">OrchestratedVirtualMachineScaleSet#additional_capabilities</a>
        /// </summary>
        [<CustomOperation "additional_capabilities">]
        member _.AdditionalCapabilities(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetAdditionalCapabilities) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdditionalCapabilities <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// automatic_instance_repair block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#automatic_instance_repair-1">OrchestratedVirtualMachineScaleSet#automatic_instance_repair</a>
        /// </summary>
        [<CustomOperation "automatic_instance_repair">]
        member _.AutomaticInstanceRepair(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetAutomaticInstanceRepair) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticInstanceRepair <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// boot_diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#boot_diagnostics-1">OrchestratedVirtualMachineScaleSet#boot_diagnostics</a>
        /// </summary>
        [<CustomOperation "boot_diagnostics">]
        member _.BootDiagnostics(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetBootDiagnostics) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BootDiagnostics <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#capacity_reservation_group_id-1">OrchestratedVirtualMachineScaleSet#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// data_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#data_disk-1">OrchestratedVirtualMachineScaleSet#data_disk</a> Accepts: azurerm.IResolvable | azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetDataDisk[]
        /// </summary>
        [<CustomOperation "data_disk">]
        member _.DataDisk(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataDisk <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#encryption_at_host_enabled-1">OrchestratedVirtualMachineScaleSet#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: bool) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#encryption_at_host_enabled-1">OrchestratedVirtualMachineScaleSet#encryption_at_host_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_at_host_enabled">]
        member _.EncryptionAtHostEnabled(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EncryptionAtHostEnabled <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#eviction_policy-1">OrchestratedVirtualMachineScaleSet#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#extension-1">OrchestratedVirtualMachineScaleSet#extension</a> Accepts: azurerm.IResolvable | azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetExtension[]
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#extension_operations_enabled-1">OrchestratedVirtualMachineScaleSet#extension_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "extension_operations_enabled">]
        member _.ExtensionOperationsEnabled(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: bool) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExtensionOperationsEnabled <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#extension_operations_enabled-1">OrchestratedVirtualMachineScaleSet#extension_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "extension_operations_enabled">]
        member _.ExtensionOperationsEnabled(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExtensionOperationsEnabled <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#extensions_time_budget-1">OrchestratedVirtualMachineScaleSet#extensions_time_budget</a>.
        /// </summary>
        [<CustomOperation "extensions_time_budget">]
        member _.ExtensionsTimeBudget(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExtensionsTimeBudget <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#id-1">OrchestratedVirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#identity-1">OrchestratedVirtualMachineScaleSet#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetIdentity) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#instances-1">OrchestratedVirtualMachineScaleSet#instances</a>.
        /// </summary>
        [<CustomOperation "instances">]
        member _.Instances(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: double) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Instances <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#license_type-1">OrchestratedVirtualMachineScaleSet#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#max_bid_price-1">OrchestratedVirtualMachineScaleSet#max_bid_price</a>.
        /// </summary>
        [<CustomOperation "max_bid_price">]
        member _.MaxBidPrice(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: double) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaxBidPrice <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#network_interface-1">OrchestratedVirtualMachineScaleSet#network_interface</a> Accepts: azurerm.IResolvable | azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#os_disk-1">OrchestratedVirtualMachineScaleSet#os_disk</a>
        /// </summary>
        [<CustomOperation "os_disk">]
        member _.OsDisk(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsDisk) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OsDisk <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// os_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#os_profile-1">OrchestratedVirtualMachineScaleSet#os_profile</a>
        /// </summary>
        [<CustomOperation "os_profile">]
        member _.OsProfile(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfile) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OsProfile <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#plan-1">OrchestratedVirtualMachineScaleSet#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetPlan) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#priority-1">OrchestratedVirtualMachineScaleSet#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// priority_mix block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#priority_mix-1">OrchestratedVirtualMachineScaleSet#priority_mix</a>
        /// </summary>
        [<CustomOperation "priority_mix">]
        member _.PriorityMix(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetPriorityMix) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PriorityMix <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#proximity_placement_group_id-1">OrchestratedVirtualMachineScaleSet#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#single_placement_group-1">OrchestratedVirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: bool) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#single_placement_group-1">OrchestratedVirtualMachineScaleSet#single_placement_group</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "single_placement_group">]
        member _.SinglePlacementGroup(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SinglePlacementGroup <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#sku_name-1">OrchestratedVirtualMachineScaleSet#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#source_image_id-1">OrchestratedVirtualMachineScaleSet#source_image_id</a>.
        /// </summary>
        [<CustomOperation "source_image_id">]
        member _.SourceImageId(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceImageId <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// source_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#source_image_reference-1">OrchestratedVirtualMachineScaleSet#source_image_reference</a>
        /// </summary>
        [<CustomOperation "source_image_reference">]
        member _.SourceImageReference(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetSourceImageReference) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceImageReference <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#tags-1">OrchestratedVirtualMachineScaleSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: seq<string * string>) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// termination_notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#termination_notification-1">OrchestratedVirtualMachineScaleSet#termination_notification</a>
        /// </summary>
        [<CustomOperation "termination_notification">]
        member _.TerminationNotification(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetTerminationNotification) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TerminationNotification <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#timeouts-1">OrchestratedVirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetTimeouts) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#user_data_base64-1">OrchestratedVirtualMachineScaleSet#user_data_base64</a>.
        /// </summary>
        [<CustomOperation "user_data_base64">]
        member _.UserDataBase64(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UserDataBase64 <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#zone_balance-1">OrchestratedVirtualMachineScaleSet#zone_balance</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balance">]
        member _.ZoneBalance(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: bool) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneBalance <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#zone_balance-1">OrchestratedVirtualMachineScaleSet#zone_balance</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balance">]
        member _.ZoneBalance(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneBalance <- value)
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#zones-1">OrchestratedVirtualMachineScaleSet#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: seq<string>) : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : OrchestratedVirtualMachineScaleSetState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        member _.Run(state: OrchestratedVirtualMachineScaleSetState<Present, Present, Present, Present>) : azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSet =
            let config = azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.orchestratedVirtualMachineScaleSet: missing required arguments. Must call: location, name, platform_fault_domain_count, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: OrchestratedVirtualMachineScaleSetState<_, _, _, _>) : azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.OrchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSet>
