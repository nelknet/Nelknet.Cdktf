namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CertificateState<'Certificate, 'Name, 'PrivateKey> = { assignments: ResizeArray<hcloud.Certificate.CertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate">hcloud_certificate</a>.
    /// </summary>
    type CertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : CertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : CertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#certificate-1">Certificate#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: CertificateState<Missing, 'Name, 'PrivateKey>, value: string) : CertificateState<Present, 'Name, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            ({ assignments = state.assignments } : CertificateState<Present, 'Name, 'PrivateKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#name-1">Certificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CertificateState<'Certificate, Missing, 'PrivateKey>, value: string) : CertificateState<'Certificate, Present, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CertificateState<'Certificate, Present, 'PrivateKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#private_key-1">Certificate#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: CertificateState<'Certificate, 'Name, Missing>, value: string) : CertificateState<'Certificate, 'Name, Present> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            ({ assignments = state.assignments } : CertificateState<'Certificate, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#id-1">Certificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CertificateState<'Certificate, 'Name, 'PrivateKey>, value: string) : CertificateState<'Certificate, 'Name, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CertificateState<'Certificate, 'Name, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#labels-1">Certificate#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: CertificateState<'Certificate, 'Name, 'PrivateKey>, value: seq<string * string>) : CertificateState<'Certificate, 'Name, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : CertificateState<'Certificate, 'Name, 'PrivateKey>

        member _.Run(state: CertificateState<Present, Present, Present>) : hcloud.Certificate.Certificate_ =
            let config = hcloud.Certificate.CertificateConfig()
            for setter in state.assignments do
                setter config
            hcloud.Certificate.Certificate_(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.certificate: missing required arguments. Must call: certificate, name, private_key.", 9999, IsError = true)>]
        member _.Run(_: CertificateState<_, _, _>) : hcloud.Certificate.Certificate_ =
            Unchecked.defaultof<hcloud.Certificate.Certificate_>
