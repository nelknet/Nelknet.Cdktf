namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAcmpcaCertificateState<'Arn, 'CertificateAuthorityArn> = { assignments: ResizeArray<aws.DataAwsAcmpcaCertificate.DataAwsAcmpcaCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate">aws_acmpca_certificate</a>.
    /// </summary>
    type DataAwsAcmpcaCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAcmpcaCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAcmpcaCertificateState<Missing, Missing>)

        member _.Zero(()) : DataAwsAcmpcaCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAcmpcaCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate#arn-1">DataAwsAcmpcaCertificate#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsAcmpcaCertificateState<Missing, 'CertificateAuthorityArn>, value: string) : DataAwsAcmpcaCertificateState<Present, 'CertificateAuthorityArn> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsAcmpcaCertificateState<Present, 'CertificateAuthorityArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate#certificate_authority_arn-1">DataAwsAcmpcaCertificate#certificate_authority_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_authority_arn">]
        member _.CertificateAuthorityArn(state: DataAwsAcmpcaCertificateState<'Arn, Missing>, value: string) : DataAwsAcmpcaCertificateState<'Arn, Present> =
            state.assignments.Add(fun config -> config.CertificateAuthorityArn <- value)
            ({ assignments = state.assignments } : DataAwsAcmpcaCertificateState<'Arn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate#id-1">DataAwsAcmpcaCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAcmpcaCertificateState<'Arn, 'CertificateAuthorityArn>, value: string) : DataAwsAcmpcaCertificateState<'Arn, 'CertificateAuthorityArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAcmpcaCertificateState<'Arn, 'CertificateAuthorityArn>

        member _.Run(state: DataAwsAcmpcaCertificateState<Present, Present>) : aws.DataAwsAcmpcaCertificate.DataAwsAcmpcaCertificate =
            let config = aws.DataAwsAcmpcaCertificate.DataAwsAcmpcaCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAcmpcaCertificate.DataAwsAcmpcaCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAcmpcaCertificate: missing required arguments. Must call: arn, certificate_authority_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAcmpcaCertificateState<_, _>) : aws.DataAwsAcmpcaCertificate.DataAwsAcmpcaCertificate =
            Unchecked.defaultof<aws.DataAwsAcmpcaCertificate.DataAwsAcmpcaCertificate>
