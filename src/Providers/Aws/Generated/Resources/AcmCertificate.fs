namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmCertificateState = { assignments: ResizeArray<aws.AcmCertificate.AcmCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate">aws_acm_certificate</a>.
    /// </summary>
    type AcmCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmCertificateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AcmCertificateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#certificate_authority_arn-1">AcmCertificate#certificate_authority_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_authority_arn">]
        member _.CertificateAuthorityArn(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.CertificateAuthorityArn <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#certificate_body-1">AcmCertificate#certificate_body</a>.
        /// </summary>
        [<CustomOperation "certificate_body">]
        member _.CertificateBody(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.CertificateBody <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#certificate_chain-1">AcmCertificate#certificate_chain</a>.
        /// </summary>
        [<CustomOperation "certificate_chain">]
        member _.CertificateChain(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.CertificateChain <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#domain_name-1">AcmCertificate#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#early_renewal_duration-1">AcmCertificate#early_renewal_duration</a>.
        /// </summary>
        [<CustomOperation "early_renewal_duration">]
        member _.EarlyRenewalDuration(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.EarlyRenewalDuration <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#id-1">AcmCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#key_algorithm-1">AcmCertificate#key_algorithm</a>.
        /// </summary>
        [<CustomOperation "key_algorithm">]
        member _.KeyAlgorithm(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.KeyAlgorithm <- value)
            state : AcmCertificateState

        /// <summary>
        /// options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#options-1">AcmCertificate#options</a>
        /// </summary>
        [<CustomOperation "options">]
        member _.Options(state: AcmCertificateState, value: aws.AcmCertificate.AcmCertificateOptions) : AcmCertificateState =
            state.assignments.Add(fun config -> config.Options <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#private_key-1">AcmCertificate#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#subject_alternative_names-1">AcmCertificate#subject_alternative_names</a>.
        /// </summary>
        [<CustomOperation "subject_alternative_names">]
        member _.SubjectAlternativeNames(state: AcmCertificateState, value: seq<string>) : AcmCertificateState =
            state.assignments.Add(fun config -> config.SubjectAlternativeNames <- (value |> Seq.toArray))
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#tags-1">AcmCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AcmCertificateState, value: seq<string * string>) : AcmCertificateState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#tags_all-1">AcmCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AcmCertificateState, value: seq<string * string>) : AcmCertificateState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#validation_method-1">AcmCertificate#validation_method</a>.
        /// </summary>
        [<CustomOperation "validation_method">]
        member _.ValidationMethod(state: AcmCertificateState, value: string) : AcmCertificateState =
            state.assignments.Add(fun config -> config.ValidationMethod <- value)
            state : AcmCertificateState

        /// <summary>
        /// validation_option block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#validation_option-1">AcmCertificate#validation_option</a> Accepts: aws.IResolvable | aws.AcmCertificate.AcmCertificateValidationOption[]
        /// </summary>
        [<CustomOperation "validation_option">]
        member _.ValidationOption(state: AcmCertificateState, value: HashiCorp.Cdktf.IResolvable) : AcmCertificateState =
            state.assignments.Add(fun config -> config.ValidationOption <- value)
            state : AcmCertificateState

        member _.Run(state: AcmCertificateState) : aws.AcmCertificate.AcmCertificate =
            let config = aws.AcmCertificate.AcmCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.AcmCertificate.AcmCertificate(StackContext.get (), logicalId, config)
