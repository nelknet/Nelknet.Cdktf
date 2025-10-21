namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmCertificateValidationState<'CertificateArn> = { assignments: ResizeArray<aws.AcmCertificateValidation.AcmCertificateValidationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation">aws_acm_certificate_validation</a>.
    /// </summary>
    type AcmCertificateValidationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmCertificateValidationState<Missing> =
            ({ assignments = ResizeArray() } : AcmCertificateValidationState<Missing>)

        member _.Zero(()) : AcmCertificateValidationState<Missing> =
            ({ assignments = ResizeArray() } : AcmCertificateValidationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation#certificate_arn-1">AcmCertificateValidation#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: AcmCertificateValidationState<Missing>, value: string) : AcmCertificateValidationState<Present> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            ({ assignments = state.assignments } : AcmCertificateValidationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation#id-1">AcmCertificateValidation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmCertificateValidationState<'CertificateArn>, value: string) : AcmCertificateValidationState<'CertificateArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmCertificateValidationState<'CertificateArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation#timeouts-1">AcmCertificateValidation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AcmCertificateValidationState<'CertificateArn>, value: aws.AcmCertificateValidation.AcmCertificateValidationTimeouts) : AcmCertificateValidationState<'CertificateArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AcmCertificateValidationState<'CertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation#validation_record_fqdns-1">AcmCertificateValidation#validation_record_fqdns</a>.
        /// </summary>
        [<CustomOperation "validation_record_fqdns">]
        member _.ValidationRecordFqdns(state: AcmCertificateValidationState<'CertificateArn>, value: seq<string>) : AcmCertificateValidationState<'CertificateArn> =
            state.assignments.Add(fun config -> config.ValidationRecordFqdns <- (value |> Seq.toArray))
            state : AcmCertificateValidationState<'CertificateArn>

        member _.Run(state: AcmCertificateValidationState<Present>) : aws.AcmCertificateValidation.AcmCertificateValidation =
            let config = aws.AcmCertificateValidation.AcmCertificateValidationConfig()
            for setter in state.assignments do
                setter config
            aws.AcmCertificateValidation.AcmCertificateValidation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.acmCertificateValidation: missing required arguments. Must call: certificate_arn.", 9999, IsError = true)>]
        member _.Run(_: AcmCertificateValidationState<_>) : aws.AcmCertificateValidation.AcmCertificateValidation =
            Unchecked.defaultof<aws.AcmCertificateValidation.AcmCertificateValidation>
