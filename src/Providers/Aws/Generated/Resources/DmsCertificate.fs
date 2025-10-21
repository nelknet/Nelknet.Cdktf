namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsCertificateState<'CertificateId> = { assignments: ResizeArray<aws.DmsCertificate.DmsCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate">aws_dms_certificate</a>.
    /// </summary>
    type DmsCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsCertificateState<Missing> =
            ({ assignments = ResizeArray() } : DmsCertificateState<Missing>)

        member _.Zero(()) : DmsCertificateState<Missing> =
            ({ assignments = ResizeArray() } : DmsCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate#certificate_id-1">DmsCertificate#certificate_id</a>.
        /// </summary>
        [<CustomOperation "certificate_id">]
        member _.CertificateId(state: DmsCertificateState<Missing>, value: string) : DmsCertificateState<Present> =
            state.assignments.Add(fun config -> config.CertificateId <- value)
            ({ assignments = state.assignments } : DmsCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate#certificate_pem-1">DmsCertificate#certificate_pem</a>.
        /// </summary>
        [<CustomOperation "certificate_pem">]
        member _.CertificatePem(state: DmsCertificateState<'CertificateId>, value: string) : DmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.CertificatePem <- value)
            state : DmsCertificateState<'CertificateId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate#certificate_wallet-1">DmsCertificate#certificate_wallet</a>.
        /// </summary>
        [<CustomOperation "certificate_wallet">]
        member _.CertificateWallet(state: DmsCertificateState<'CertificateId>, value: string) : DmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.CertificateWallet <- value)
            state : DmsCertificateState<'CertificateId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate#id-1">DmsCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsCertificateState<'CertificateId>, value: string) : DmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsCertificateState<'CertificateId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate#tags-1">DmsCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsCertificateState<'CertificateId>, value: seq<string * string>) : DmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsCertificateState<'CertificateId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_certificate#tags_all-1">DmsCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsCertificateState<'CertificateId>, value: seq<string * string>) : DmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsCertificateState<'CertificateId>

        member _.Run(state: DmsCertificateState<Present>) : aws.DmsCertificate.DmsCertificate =
            let config = aws.DmsCertificate.DmsCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DmsCertificate.DmsCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsCertificate: missing required arguments. Must call: certificate_id.", 9999, IsError = true)>]
        member _.Run(_: DmsCertificateState<_>) : aws.DmsCertificate.DmsCertificate =
            Unchecked.defaultof<aws.DmsCertificate.DmsCertificate>
