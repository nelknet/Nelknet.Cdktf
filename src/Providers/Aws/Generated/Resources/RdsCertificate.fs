namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsCertificateState<'CertificateIdentifier> = { assignments: ResizeArray<aws.RdsCertificate.RdsCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_certificate">aws_rds_certificate</a>.
    /// </summary>
    type RdsCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsCertificateState<Missing> =
            ({ assignments = ResizeArray() } : RdsCertificateState<Missing>)

        member _.Zero(()) : RdsCertificateState<Missing> =
            ({ assignments = ResizeArray() } : RdsCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_certificate#certificate_identifier-1">RdsCertificate#certificate_identifier</a>.
        /// </summary>
        [<CustomOperation "certificate_identifier">]
        member _.CertificateIdentifier(state: RdsCertificateState<Missing>, value: string) : RdsCertificateState<Present> =
            state.assignments.Add(fun config -> config.CertificateIdentifier <- value)
            ({ assignments = state.assignments } : RdsCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_certificate#id-1">RdsCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsCertificateState<'CertificateIdentifier>, value: string) : RdsCertificateState<'CertificateIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsCertificateState<'CertificateIdentifier>

        member _.Run(state: RdsCertificateState<Present>) : aws.RdsCertificate.RdsCertificate =
            let config = aws.RdsCertificate.RdsCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.RdsCertificate.RdsCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsCertificate: missing required arguments. Must call: certificate_identifier.", 9999, IsError = true)>]
        member _.Run(_: RdsCertificateState<_>) : aws.RdsCertificate.RdsCertificate =
            Unchecked.defaultof<aws.RdsCertificate.RdsCertificate>
