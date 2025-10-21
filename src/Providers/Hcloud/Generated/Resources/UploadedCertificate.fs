namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type UploadedCertificateState<'Certificate, 'Name, 'PrivateKey> = { assignments: ResizeArray<hcloud.UploadedCertificate.UploadedCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate">hcloud_uploaded_certificate</a>.
    /// </summary>
    type UploadedCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : UploadedCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : UploadedCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : UploadedCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : UploadedCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#certificate-1">UploadedCertificate#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: UploadedCertificateState<Missing, 'Name, 'PrivateKey>, value: string) : UploadedCertificateState<Present, 'Name, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            ({ assignments = state.assignments } : UploadedCertificateState<Present, 'Name, 'PrivateKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#name-1">UploadedCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: UploadedCertificateState<'Certificate, Missing, 'PrivateKey>, value: string) : UploadedCertificateState<'Certificate, Present, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : UploadedCertificateState<'Certificate, Present, 'PrivateKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#private_key-1">UploadedCertificate#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: UploadedCertificateState<'Certificate, 'Name, Missing>, value: string) : UploadedCertificateState<'Certificate, 'Name, Present> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            ({ assignments = state.assignments } : UploadedCertificateState<'Certificate, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#id-1">UploadedCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: UploadedCertificateState<'Certificate, 'Name, 'PrivateKey>, value: string) : UploadedCertificateState<'Certificate, 'Name, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : UploadedCertificateState<'Certificate, 'Name, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#labels-1">UploadedCertificate#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: UploadedCertificateState<'Certificate, 'Name, 'PrivateKey>, value: seq<string * string>) : UploadedCertificateState<'Certificate, 'Name, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : UploadedCertificateState<'Certificate, 'Name, 'PrivateKey>

        member _.Run(state: UploadedCertificateState<Present, Present, Present>) : hcloud.UploadedCertificate.UploadedCertificate =
            let config = hcloud.UploadedCertificate.UploadedCertificateConfig()
            for setter in state.assignments do
                setter config
            hcloud.UploadedCertificate.UploadedCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.uploadedCertificate: missing required arguments. Must call: certificate, name, private_key.", 9999, IsError = true)>]
        member _.Run(_: UploadedCertificateState<_, _, _>) : hcloud.UploadedCertificate.UploadedCertificate =
            Unchecked.defaultof<hcloud.UploadedCertificate.UploadedCertificate>
