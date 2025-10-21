namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailStaticIpAttachmentState<'InstanceName, 'StaticIpName> = { assignments: ResizeArray<aws.LightsailStaticIpAttachment.LightsailStaticIpAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip_attachment">aws_lightsail_static_ip_attachment</a>.
    /// </summary>
    type LightsailStaticIpAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailStaticIpAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailStaticIpAttachmentState<Missing, Missing>)

        member _.Zero(()) : LightsailStaticIpAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailStaticIpAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip_attachment#instance_name-1">LightsailStaticIpAttachment#instance_name</a>.
        /// </summary>
        [<CustomOperation "instance_name">]
        member _.InstanceName(state: LightsailStaticIpAttachmentState<Missing, 'StaticIpName>, value: string) : LightsailStaticIpAttachmentState<Present, 'StaticIpName> =
            state.assignments.Add(fun config -> config.InstanceName <- value)
            ({ assignments = state.assignments } : LightsailStaticIpAttachmentState<Present, 'StaticIpName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip_attachment#static_ip_name-1">LightsailStaticIpAttachment#static_ip_name</a>.
        /// </summary>
        [<CustomOperation "static_ip_name">]
        member _.StaticIpName(state: LightsailStaticIpAttachmentState<'InstanceName, Missing>, value: string) : LightsailStaticIpAttachmentState<'InstanceName, Present> =
            state.assignments.Add(fun config -> config.StaticIpName <- value)
            ({ assignments = state.assignments } : LightsailStaticIpAttachmentState<'InstanceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip_attachment#id-1">LightsailStaticIpAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailStaticIpAttachmentState<'InstanceName, 'StaticIpName>, value: string) : LightsailStaticIpAttachmentState<'InstanceName, 'StaticIpName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailStaticIpAttachmentState<'InstanceName, 'StaticIpName>

        member _.Run(state: LightsailStaticIpAttachmentState<Present, Present>) : aws.LightsailStaticIpAttachment.LightsailStaticIpAttachment =
            let config = aws.LightsailStaticIpAttachment.LightsailStaticIpAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailStaticIpAttachment.LightsailStaticIpAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailStaticIpAttachment: missing required arguments. Must call: instance_name, static_ip_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailStaticIpAttachmentState<_, _>) : aws.LightsailStaticIpAttachment.LightsailStaticIpAttachment =
            Unchecked.defaultof<aws.LightsailStaticIpAttachment.LightsailStaticIpAttachment>
