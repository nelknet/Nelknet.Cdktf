namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment">azurerm_virtual_machine_data_disk_attachment</a>.
    /// </summary>
    type VirtualMachineDataDiskAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineDataDiskAttachmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineDataDiskAttachmentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineDataDiskAttachmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineDataDiskAttachmentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#caching-1">VirtualMachineDataDiskAttachment#caching</a>.
        /// </summary>
        [<CustomOperation "caching">]
        member _.Caching(state: VirtualMachineDataDiskAttachmentState<Missing, 'Lun, 'ManagedDiskId, 'VirtualMachineId>, value: string) : VirtualMachineDataDiskAttachmentState<Present, 'Lun, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Caching <- value)
            ({ assignments = state.assignments } : VirtualMachineDataDiskAttachmentState<Present, 'Lun, 'ManagedDiskId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#lun-1">VirtualMachineDataDiskAttachment#lun</a>.
        /// </summary>
        [<CustomOperation "lun">]
        member _.Lun(state: VirtualMachineDataDiskAttachmentState<'Caching, Missing, 'ManagedDiskId, 'VirtualMachineId>, value: double) : VirtualMachineDataDiskAttachmentState<'Caching, Present, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Lun <- value)
            ({ assignments = state.assignments } : VirtualMachineDataDiskAttachmentState<'Caching, Present, 'ManagedDiskId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#managed_disk_id-1">VirtualMachineDataDiskAttachment#managed_disk_id</a>.
        /// </summary>
        [<CustomOperation "managed_disk_id">]
        member _.ManagedDiskId(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, Missing, 'VirtualMachineId>, value: string) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ManagedDiskId <- value)
            ({ assignments = state.assignments } : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#virtual_machine_id-1">VirtualMachineDataDiskAttachment#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, Missing>, value: string) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#create_option-1">VirtualMachineDataDiskAttachment#create_option</a>.
        /// </summary>
        [<CustomOperation "create_option">]
        member _.CreateOption(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>, value: string) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.CreateOption <- value)
            state : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#id-1">VirtualMachineDataDiskAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>, value: string) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#timeouts-1">VirtualMachineDataDiskAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>, value: azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachmentTimeouts) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#write_accelerator_enabled-1">VirtualMachineDataDiskAttachment#write_accelerator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "write_accelerator_enabled">]
        member _.WriteAcceleratorEnabled(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>, value: bool) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.WriteAcceleratorEnabled <- value)
            state : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_data_disk_attachment#write_accelerator_enabled-1">VirtualMachineDataDiskAttachment#write_accelerator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "write_accelerator_enabled">]
        member _.WriteAcceleratorEnabled(state: VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.WriteAcceleratorEnabled <- value)
            state : VirtualMachineDataDiskAttachmentState<'Caching, 'Lun, 'ManagedDiskId, 'VirtualMachineId>

        member _.Run(state: VirtualMachineDataDiskAttachmentState<Present, Present, Present, Present>) : azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachment =
            let config = azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineDataDiskAttachment: missing required arguments. Must call: caching, lun, managed_disk_id, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineDataDiskAttachmentState<_, _, _, _>) : azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachment =
            Unchecked.defaultof<azurerm.VirtualMachineDataDiskAttachment.VirtualMachineDataDiskAttachment>
