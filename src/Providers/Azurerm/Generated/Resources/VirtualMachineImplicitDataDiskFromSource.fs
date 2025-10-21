namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source">azurerm_virtual_machine_implicit_data_disk_from_source</a>.
    /// </summary>
    type VirtualMachineImplicitDataDiskFromSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineImplicitDataDiskFromSourceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineImplicitDataDiskFromSourceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineImplicitDataDiskFromSourceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineImplicitDataDiskFromSourceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#create_option-1">VirtualMachineImplicitDataDiskFromSource#create_option</a>.
        /// </summary>
        [<CustomOperation "create_option">]
        member _.CreateOption(state: VirtualMachineImplicitDataDiskFromSourceState<Missing, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: string) : VirtualMachineImplicitDataDiskFromSourceState<Present, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.CreateOption <- value)
            ({ assignments = state.assignments } : VirtualMachineImplicitDataDiskFromSourceState<Present, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#disk_size_gb-1">VirtualMachineImplicitDataDiskFromSource#disk_size_gb</a>.
        /// </summary>
        [<CustomOperation "disk_size_gb">]
        member _.DiskSizeGb(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, Missing, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: double) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, Present, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.DiskSizeGb <- value)
            ({ assignments = state.assignments } : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, Present, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#lun-1">VirtualMachineImplicitDataDiskFromSource#lun</a>.
        /// </summary>
        [<CustomOperation "lun">]
        member _.Lun(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, Missing, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: double) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, Present, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Lun <- value)
            ({ assignments = state.assignments } : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, Present, 'Name, 'SourceResourceId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#name-1">VirtualMachineImplicitDataDiskFromSource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, Missing, 'SourceResourceId, 'VirtualMachineId>, value: string) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, Present, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, Present, 'SourceResourceId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#source_resource_id-1">VirtualMachineImplicitDataDiskFromSource#source_resource_id</a>.
        /// </summary>
        [<CustomOperation "source_resource_id">]
        member _.SourceResourceId(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, Missing, 'VirtualMachineId>, value: string) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SourceResourceId <- value)
            ({ assignments = state.assignments } : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#virtual_machine_id-1">VirtualMachineImplicitDataDiskFromSource#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, Missing>, value: string) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#caching-1">VirtualMachineImplicitDataDiskFromSource#caching</a>.
        /// </summary>
        [<CustomOperation "caching">]
        member _.Caching(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: string) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Caching <- value)
            state : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#id-1">VirtualMachineImplicitDataDiskFromSource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: string) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#timeouts-1">VirtualMachineImplicitDataDiskFromSource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSourceTimeouts) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#write_accelerator_enabled-1">VirtualMachineImplicitDataDiskFromSource#write_accelerator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "write_accelerator_enabled">]
        member _.WriteAcceleratorEnabled(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: bool) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.WriteAcceleratorEnabled <- value)
            state : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_implicit_data_disk_from_source#write_accelerator_enabled-1">VirtualMachineImplicitDataDiskFromSource#write_accelerator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "write_accelerator_enabled">]
        member _.WriteAcceleratorEnabled(state: VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.WriteAcceleratorEnabled <- value)
            state : VirtualMachineImplicitDataDiskFromSourceState<'CreateOption, 'DiskSizeGb, 'Lun, 'Name, 'SourceResourceId, 'VirtualMachineId>

        member _.Run(state: VirtualMachineImplicitDataDiskFromSourceState<Present, Present, Present, Present, Present, Present>) : azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSource =
            let config = azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSourceConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineImplicitDataDiskFromSource: missing required arguments. Must call: create_option, disk_size_gb, lun, name, source_resource_id, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineImplicitDataDiskFromSourceState<_, _, _, _, _, _>) : azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSource =
            Unchecked.defaultof<azurerm.VirtualMachineImplicitDataDiskFromSource.VirtualMachineImplicitDataDiskFromSource>
