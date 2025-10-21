namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferCertificateState<'Certificate, 'Usage> = { assignments: ResizeArray<aws.TransferCertificate.TransferCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate">aws_transfer_certificate</a>.
    /// </summary>
    type TransferCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferCertificateState<Missing, Missing>)

        member _.Zero(()) : TransferCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#certificate-1">TransferCertificate#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: TransferCertificateState<Missing, 'Usage>, value: string) : TransferCertificateState<Present, 'Usage> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            ({ assignments = state.assignments } : TransferCertificateState<Present, 'Usage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#usage-1">TransferCertificate#usage</a>.
        /// </summary>
        [<CustomOperation "usage">]
        member _.Usage(state: TransferCertificateState<'Certificate, Missing>, value: string) : TransferCertificateState<'Certificate, Present> =
            state.assignments.Add(fun config -> config.Usage <- value)
            ({ assignments = state.assignments } : TransferCertificateState<'Certificate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#certificate_chain-1">TransferCertificate#certificate_chain</a>.
        /// </summary>
        [<CustomOperation "certificate_chain">]
        member _.CertificateChain(state: TransferCertificateState<'Certificate, 'Usage>, value: string) : TransferCertificateState<'Certificate, 'Usage> =
            state.assignments.Add(fun config -> config.CertificateChain <- value)
            state : TransferCertificateState<'Certificate, 'Usage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#description-1">TransferCertificate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: TransferCertificateState<'Certificate, 'Usage>, value: string) : TransferCertificateState<'Certificate, 'Usage> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : TransferCertificateState<'Certificate, 'Usage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#id-1">TransferCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferCertificateState<'Certificate, 'Usage>, value: string) : TransferCertificateState<'Certificate, 'Usage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferCertificateState<'Certificate, 'Usage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#private_key-1">TransferCertificate#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: TransferCertificateState<'Certificate, 'Usage>, value: string) : TransferCertificateState<'Certificate, 'Usage> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            state : TransferCertificateState<'Certificate, 'Usage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#tags-1">TransferCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferCertificateState<'Certificate, 'Usage>, value: seq<string * string>) : TransferCertificateState<'Certificate, 'Usage> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferCertificateState<'Certificate, 'Usage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_certificate#tags_all-1">TransferCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferCertificateState<'Certificate, 'Usage>, value: seq<string * string>) : TransferCertificateState<'Certificate, 'Usage> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferCertificateState<'Certificate, 'Usage>

        member _.Run(state: TransferCertificateState<Present, Present>) : aws.TransferCertificate.TransferCertificate =
            let config = aws.TransferCertificate.TransferCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.TransferCertificate.TransferCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferCertificate: missing required arguments. Must call: certificate, usage.", 9999, IsError = true)>]
        member _.Run(_: TransferCertificateState<_, _>) : aws.TransferCertificate.TransferCertificate =
            Unchecked.defaultof<aws.TransferCertificate.TransferCertificate>
