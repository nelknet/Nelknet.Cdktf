namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId> = { assignments: ResizeArray<azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_netapp_volume_attachment">azurerm_vmware_netapp_volume_attachment</a>.
    /// </summary>
    type VmwareNetappVolumeAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VmwareNetappVolumeAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwareNetappVolumeAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : VmwareNetappVolumeAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwareNetappVolumeAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_netapp_volume_attachment#name-1">VmwareNetappVolumeAttachment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VmwareNetappVolumeAttachmentState<Missing, 'NetappVolumeId, 'VmwareClusterId>, value: string) : VmwareNetappVolumeAttachmentState<Present, 'NetappVolumeId, 'VmwareClusterId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VmwareNetappVolumeAttachmentState<Present, 'NetappVolumeId, 'VmwareClusterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_netapp_volume_attachment#netapp_volume_id-1">VmwareNetappVolumeAttachment#netapp_volume_id</a>.
        /// </summary>
        [<CustomOperation "netapp_volume_id">]
        member _.NetappVolumeId(state: VmwareNetappVolumeAttachmentState<'Name, Missing, 'VmwareClusterId>, value: string) : VmwareNetappVolumeAttachmentState<'Name, Present, 'VmwareClusterId> =
            state.assignments.Add(fun config -> config.NetappVolumeId <- value)
            ({ assignments = state.assignments } : VmwareNetappVolumeAttachmentState<'Name, Present, 'VmwareClusterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_netapp_volume_attachment#vmware_cluster_id-1">VmwareNetappVolumeAttachment#vmware_cluster_id</a>.
        /// </summary>
        [<CustomOperation "vmware_cluster_id">]
        member _.VmwareClusterId(state: VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, Missing>, value: string) : VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, Present> =
            state.assignments.Add(fun config -> config.VmwareClusterId <- value)
            ({ assignments = state.assignments } : VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_netapp_volume_attachment#id-1">VmwareNetappVolumeAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId>, value: string) : VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_netapp_volume_attachment#timeouts-1">VmwareNetappVolumeAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId>, value: azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachmentTimeouts) : VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VmwareNetappVolumeAttachmentState<'Name, 'NetappVolumeId, 'VmwareClusterId>

        member _.Run(state: VmwareNetappVolumeAttachmentState<Present, Present, Present>) : azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachment =
            let config = azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vmwareNetappVolumeAttachment: missing required arguments. Must call: name, netapp_volume_id, vmware_cluster_id.", 9999, IsError = true)>]
        member _.Run(_: VmwareNetappVolumeAttachmentState<_, _, _>) : azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachment =
            Unchecked.defaultof<azurerm.VmwareNetappVolumeAttachment.VmwareNetappVolumeAttachment>
