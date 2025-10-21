namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity> = { assignments: ResizeArray<aws.AcmpcaCertificate.AcmpcaCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate">aws_acmpca_certificate</a>.
    /// </summary>
    type AcmpcaCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmpcaCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaCertificateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AcmpcaCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaCertificateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#certificate_authority_arn-1">AcmpcaCertificate#certificate_authority_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_authority_arn">]
        member _.CertificateAuthorityArn(state: AcmpcaCertificateState<Missing, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>, value: string) : AcmpcaCertificateState<Present, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity> =
            state.assignments.Add(fun config -> config.CertificateAuthorityArn <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateState<Present, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#certificate_signing_request-1">AcmpcaCertificate#certificate_signing_request</a>.
        /// </summary>
        [<CustomOperation "certificate_signing_request">]
        member _.CertificateSigningRequest(state: AcmpcaCertificateState<'CertificateAuthorityArn, Missing, 'SigningAlgorithm, 'Validity>, value: string) : AcmpcaCertificateState<'CertificateAuthorityArn, Present, 'SigningAlgorithm, 'Validity> =
            state.assignments.Add(fun config -> config.CertificateSigningRequest <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateState<'CertificateAuthorityArn, Present, 'SigningAlgorithm, 'Validity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#signing_algorithm-1">AcmpcaCertificate#signing_algorithm</a>.
        /// </summary>
        [<CustomOperation "signing_algorithm">]
        member _.SigningAlgorithm(state: AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, Missing, 'Validity>, value: string) : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, Present, 'Validity> =
            state.assignments.Add(fun config -> config.SigningAlgorithm <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, Present, 'Validity>)

        /// <summary>
        /// validity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#validity-1">AcmpcaCertificate#validity</a>
        /// </summary>
        [<CustomOperation "validity">]
        member _.Validity(state: AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, Missing>, value: aws.AcmpcaCertificate.AcmpcaCertificateValidity) : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, Present> =
            state.assignments.Add(fun config -> config.Validity <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#api_passthrough-1">AcmpcaCertificate#api_passthrough</a>.
        /// </summary>
        [<CustomOperation "api_passthrough">]
        member _.ApiPassthrough(state: AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>, value: string) : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity> =
            state.assignments.Add(fun config -> config.ApiPassthrough <- value)
            state : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#id-1">AcmpcaCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>, value: string) : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate#template_arn-1">AcmpcaCertificate#template_arn</a>.
        /// </summary>
        [<CustomOperation "template_arn">]
        member _.TemplateArn(state: AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>, value: string) : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity> =
            state.assignments.Add(fun config -> config.TemplateArn <- value)
            state : AcmpcaCertificateState<'CertificateAuthorityArn, 'CertificateSigningRequest, 'SigningAlgorithm, 'Validity>

        member _.Run(state: AcmpcaCertificateState<Present, Present, Present, Present>) : aws.AcmpcaCertificate.AcmpcaCertificate =
            let config = aws.AcmpcaCertificate.AcmpcaCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.AcmpcaCertificate.AcmpcaCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.acmpcaCertificate: missing required arguments. Must call: certificate_authority_arn, certificate_signing_request, signing_algorithm, validity.", 9999, IsError = true)>]
        member _.Run(_: AcmpcaCertificateState<_, _, _, _>) : aws.AcmpcaCertificate.AcmpcaCertificate =
            Unchecked.defaultof<aws.AcmpcaCertificate.AcmpcaCertificate>
