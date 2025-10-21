namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VolumeAttachmentState<'ServerId, 'VolumeId> = { assignments: ResizeArray<hcloud.VolumeAttachment.VolumeAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment">hcloud_volume_attachment</a>.
    /// </summary>
    type VolumeAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VolumeAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VolumeAttachmentState<Missing, Missing>)

        member _.Zero(()) : VolumeAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VolumeAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#server_id-1">VolumeAttachment#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: VolumeAttachmentState<Missing, 'VolumeId>, value: double) : VolumeAttachmentState<Present, 'VolumeId> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : VolumeAttachmentState<Present, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#volume_id-1">VolumeAttachment#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: VolumeAttachmentState<'ServerId, Missing>, value: double) : VolumeAttachmentState<'ServerId, Present> =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            ({ assignments = state.assignments } : VolumeAttachmentState<'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#automount-1">VolumeAttachment#automount</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "automount">]
        member _.Automount(state: VolumeAttachmentState<'ServerId, 'VolumeId>, value: bool) : VolumeAttachmentState<'ServerId, 'VolumeId> =
            state.assignments.Add(fun config -> config.Automount <- value)
            state : VolumeAttachmentState<'ServerId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#automount-1">VolumeAttachment#automount</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "automount">]
        member _.Automount(state: VolumeAttachmentState<'ServerId, 'VolumeId>, value: HashiCorp.Cdktf.IResolvable) : VolumeAttachmentState<'ServerId, 'VolumeId> =
            state.assignments.Add(fun config -> config.Automount <- value)
            state : VolumeAttachmentState<'ServerId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#id-1">VolumeAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VolumeAttachmentState<'ServerId, 'VolumeId>, value: string) : VolumeAttachmentState<'ServerId, 'VolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VolumeAttachmentState<'ServerId, 'VolumeId>

        member _.Run(state: VolumeAttachmentState<Present, Present>) : hcloud.VolumeAttachment.VolumeAttachment =
            let config = hcloud.VolumeAttachment.VolumeAttachmentConfig()
            for setter in state.assignments do
                setter config
            hcloud.VolumeAttachment.VolumeAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.volumeAttachment: missing required arguments. Must call: server_id, volume_id.", 9999, IsError = true)>]
        member _.Run(_: VolumeAttachmentState<_, _>) : hcloud.VolumeAttachment.VolumeAttachment =
            Unchecked.defaultof<hcloud.VolumeAttachment.VolumeAttachment>
