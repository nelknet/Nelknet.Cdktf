namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailDiskAttachmentState<'DiskName, 'DiskPath, 'InstanceName> = { assignments: ResizeArray<aws.LightsailDiskAttachment.LightsailDiskAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk_attachment">aws_lightsail_disk_attachment</a>.
    /// </summary>
    type LightsailDiskAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailDiskAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDiskAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : LightsailDiskAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDiskAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk_attachment#disk_name-1">LightsailDiskAttachment#disk_name</a>.
        /// </summary>
        [<CustomOperation "disk_name">]
        member _.DiskName(state: LightsailDiskAttachmentState<Missing, 'DiskPath, 'InstanceName>, value: string) : LightsailDiskAttachmentState<Present, 'DiskPath, 'InstanceName> =
            state.assignments.Add(fun config -> config.DiskName <- value)
            ({ assignments = state.assignments } : LightsailDiskAttachmentState<Present, 'DiskPath, 'InstanceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk_attachment#disk_path-1">LightsailDiskAttachment#disk_path</a>.
        /// </summary>
        [<CustomOperation "disk_path">]
        member _.DiskPath(state: LightsailDiskAttachmentState<'DiskName, Missing, 'InstanceName>, value: string) : LightsailDiskAttachmentState<'DiskName, Present, 'InstanceName> =
            state.assignments.Add(fun config -> config.DiskPath <- value)
            ({ assignments = state.assignments } : LightsailDiskAttachmentState<'DiskName, Present, 'InstanceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk_attachment#instance_name-1">LightsailDiskAttachment#instance_name</a>.
        /// </summary>
        [<CustomOperation "instance_name">]
        member _.InstanceName(state: LightsailDiskAttachmentState<'DiskName, 'DiskPath, Missing>, value: string) : LightsailDiskAttachmentState<'DiskName, 'DiskPath, Present> =
            state.assignments.Add(fun config -> config.InstanceName <- value)
            ({ assignments = state.assignments } : LightsailDiskAttachmentState<'DiskName, 'DiskPath, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk_attachment#id-1">LightsailDiskAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailDiskAttachmentState<'DiskName, 'DiskPath, 'InstanceName>, value: string) : LightsailDiskAttachmentState<'DiskName, 'DiskPath, 'InstanceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailDiskAttachmentState<'DiskName, 'DiskPath, 'InstanceName>

        member _.Run(state: LightsailDiskAttachmentState<Present, Present, Present>) : aws.LightsailDiskAttachment.LightsailDiskAttachment =
            let config = aws.LightsailDiskAttachment.LightsailDiskAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailDiskAttachment.LightsailDiskAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailDiskAttachment: missing required arguments. Must call: disk_name, disk_path, instance_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailDiskAttachmentState<_, _, _>) : aws.LightsailDiskAttachment.LightsailDiskAttachment =
            Unchecked.defaultof<aws.LightsailDiskAttachment.LightsailDiskAttachment>
