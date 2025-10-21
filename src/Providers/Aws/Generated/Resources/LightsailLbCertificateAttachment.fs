namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailLbCertificateAttachmentState<'CertificateName, 'LbName> = { assignments: ResizeArray<aws.LightsailLbCertificateAttachment.LightsailLbCertificateAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate_attachment">aws_lightsail_lb_certificate_attachment</a>.
    /// </summary>
    type LightsailLbCertificateAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailLbCertificateAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbCertificateAttachmentState<Missing, Missing>)

        member _.Zero(()) : LightsailLbCertificateAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbCertificateAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate_attachment#certificate_name-1">LightsailLbCertificateAttachment#certificate_name</a>.
        /// </summary>
        [<CustomOperation "certificate_name">]
        member _.CertificateName(state: LightsailLbCertificateAttachmentState<Missing, 'LbName>, value: string) : LightsailLbCertificateAttachmentState<Present, 'LbName> =
            state.assignments.Add(fun config -> config.CertificateName <- value)
            ({ assignments = state.assignments } : LightsailLbCertificateAttachmentState<Present, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate_attachment#lb_name-1">LightsailLbCertificateAttachment#lb_name</a>.
        /// </summary>
        [<CustomOperation "lb_name">]
        member _.LbName(state: LightsailLbCertificateAttachmentState<'CertificateName, Missing>, value: string) : LightsailLbCertificateAttachmentState<'CertificateName, Present> =
            state.assignments.Add(fun config -> config.LbName <- value)
            ({ assignments = state.assignments } : LightsailLbCertificateAttachmentState<'CertificateName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate_attachment#id-1">LightsailLbCertificateAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailLbCertificateAttachmentState<'CertificateName, 'LbName>, value: string) : LightsailLbCertificateAttachmentState<'CertificateName, 'LbName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailLbCertificateAttachmentState<'CertificateName, 'LbName>

        member _.Run(state: LightsailLbCertificateAttachmentState<Present, Present>) : aws.LightsailLbCertificateAttachment.LightsailLbCertificateAttachment =
            let config = aws.LightsailLbCertificateAttachment.LightsailLbCertificateAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailLbCertificateAttachment.LightsailLbCertificateAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailLbCertificateAttachment: missing required arguments. Must call: certificate_name, lb_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailLbCertificateAttachmentState<_, _>) : aws.LightsailLbCertificateAttachment.LightsailLbCertificateAttachment =
            Unchecked.defaultof<aws.LightsailLbCertificateAttachment.LightsailLbCertificateAttachment>
