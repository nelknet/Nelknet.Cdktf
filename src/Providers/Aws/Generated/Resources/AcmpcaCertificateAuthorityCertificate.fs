namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn> = { assignments: ResizeArray<aws.AcmpcaCertificateAuthorityCertificate.AcmpcaCertificateAuthorityCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority_certificate">aws_acmpca_certificate_authority_certificate</a>.
    /// </summary>
    type AcmpcaCertificateAuthorityCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmpcaCertificateAuthorityCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaCertificateAuthorityCertificateState<Missing, Missing>)

        member _.Zero(()) : AcmpcaCertificateAuthorityCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaCertificateAuthorityCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority_certificate#certificate-1">AcmpcaCertificateAuthorityCertificate#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: AcmpcaCertificateAuthorityCertificateState<Missing, 'CertificateAuthorityArn>, value: string) : AcmpcaCertificateAuthorityCertificateState<Present, 'CertificateAuthorityArn> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateAuthorityCertificateState<Present, 'CertificateAuthorityArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority_certificate#certificate_authority_arn-1">AcmpcaCertificateAuthorityCertificate#certificate_authority_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_authority_arn">]
        member _.CertificateAuthorityArn(state: AcmpcaCertificateAuthorityCertificateState<'Certificate, Missing>, value: string) : AcmpcaCertificateAuthorityCertificateState<'Certificate, Present> =
            state.assignments.Add(fun config -> config.CertificateAuthorityArn <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateAuthorityCertificateState<'Certificate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority_certificate#certificate_chain-1">AcmpcaCertificateAuthorityCertificate#certificate_chain</a>.
        /// </summary>
        [<CustomOperation "certificate_chain">]
        member _.CertificateChain(state: AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn>, value: string) : AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn> =
            state.assignments.Add(fun config -> config.CertificateChain <- value)
            state : AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority_certificate#id-1">AcmpcaCertificateAuthorityCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn>, value: string) : AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmpcaCertificateAuthorityCertificateState<'Certificate, 'CertificateAuthorityArn>

        member _.Run(state: AcmpcaCertificateAuthorityCertificateState<Present, Present>) : aws.AcmpcaCertificateAuthorityCertificate.AcmpcaCertificateAuthorityCertificate =
            let config = aws.AcmpcaCertificateAuthorityCertificate.AcmpcaCertificateAuthorityCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.AcmpcaCertificateAuthorityCertificate.AcmpcaCertificateAuthorityCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.acmpcaCertificateAuthorityCertificate: missing required arguments. Must call: certificate, certificate_authority_arn.", 9999, IsError = true)>]
        member _.Run(_: AcmpcaCertificateAuthorityCertificateState<_, _>) : aws.AcmpcaCertificateAuthorityCertificate.AcmpcaCertificateAuthorityCertificate =
            Unchecked.defaultof<aws.AcmpcaCertificateAuthorityCertificate.AcmpcaCertificateAuthorityCertificate>
