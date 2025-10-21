namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> = { assignments: ResizeArray<aws.VolumeAttachment.VolumeAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment">aws_volume_attachment</a>.
    /// </summary>
    type VolumeAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VolumeAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VolumeAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : VolumeAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VolumeAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#device_name-1">VolumeAttachment#device_name</a>.
        /// </summary>
        [<CustomOperation "device_name">]
        member _.DeviceName(state: VolumeAttachmentState<Missing, 'InstanceId, 'VolumeId>, value: string) : VolumeAttachmentState<Present, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.DeviceName <- value)
            ({ assignments = state.assignments } : VolumeAttachmentState<Present, 'InstanceId, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#instance_id-1">VolumeAttachment#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: VolumeAttachmentState<'DeviceName, Missing, 'VolumeId>, value: string) : VolumeAttachmentState<'DeviceName, Present, 'VolumeId> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : VolumeAttachmentState<'DeviceName, Present, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#volume_id-1">VolumeAttachment#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: VolumeAttachmentState<'DeviceName, 'InstanceId, Missing>, value: string) : VolumeAttachmentState<'DeviceName, 'InstanceId, Present> =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            ({ assignments = state.assignments } : VolumeAttachmentState<'DeviceName, 'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#force_detach-1">VolumeAttachment#force_detach</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_detach">]
        member _.ForceDetach(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: bool) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.ForceDetach <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#force_detach-1">VolumeAttachment#force_detach</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_detach">]
        member _.ForceDetach(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: HashiCorp.Cdktf.IResolvable) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.ForceDetach <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#id-1">VolumeAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: string) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#skip_destroy-1">VolumeAttachment#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: bool) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#skip_destroy-1">VolumeAttachment#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: HashiCorp.Cdktf.IResolvable) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#stop_instance_before_detaching-1">VolumeAttachment#stop_instance_before_detaching</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "stop_instance_before_detaching">]
        member _.StopInstanceBeforeDetaching(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: bool) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.StopInstanceBeforeDetaching <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#stop_instance_before_detaching-1">VolumeAttachment#stop_instance_before_detaching</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "stop_instance_before_detaching">]
        member _.StopInstanceBeforeDetaching(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: HashiCorp.Cdktf.IResolvable) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.StopInstanceBeforeDetaching <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/volume_attachment#timeouts-1">VolumeAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>, value: aws.VolumeAttachment.VolumeAttachmentTimeouts) : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VolumeAttachmentState<'DeviceName, 'InstanceId, 'VolumeId>

        member _.Run(state: VolumeAttachmentState<Present, Present, Present>) : aws.VolumeAttachment.VolumeAttachment =
            let config = aws.VolumeAttachment.VolumeAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.VolumeAttachment.VolumeAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.volumeAttachment: missing required arguments. Must call: device_name, instance_id, volume_id.", 9999, IsError = true)>]
        member _.Run(_: VolumeAttachmentState<_, _, _>) : aws.VolumeAttachment.VolumeAttachment =
            Unchecked.defaultof<aws.VolumeAttachment.VolumeAttachment>
