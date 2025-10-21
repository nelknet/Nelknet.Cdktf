namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagedCertificateState<'DomainNames, 'Name> = { assignments: ResizeArray<hcloud.ManagedCertificate.ManagedCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate">hcloud_managed_certificate</a>.
    /// </summary>
    type ManagedCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagedCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedCertificateState<Missing, Missing>)

        member _.Zero(()) : ManagedCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#domain_names-1">ManagedCertificate#domain_names</a>.
        /// </summary>
        [<CustomOperation "domain_names">]
        member _.DomainNames(state: ManagedCertificateState<Missing, 'Name>, value: seq<string>) : ManagedCertificateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DomainNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ManagedCertificateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#name-1">ManagedCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagedCertificateState<'DomainNames, Missing>, value: string) : ManagedCertificateState<'DomainNames, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagedCertificateState<'DomainNames, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#id-1">ManagedCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagedCertificateState<'DomainNames, 'Name>, value: string) : ManagedCertificateState<'DomainNames, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagedCertificateState<'DomainNames, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#labels-1">ManagedCertificate#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: ManagedCertificateState<'DomainNames, 'Name>, value: seq<string * string>) : ManagedCertificateState<'DomainNames, 'Name> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : ManagedCertificateState<'DomainNames, 'Name>

        member _.Run(state: ManagedCertificateState<Present, Present>) : hcloud.ManagedCertificate.ManagedCertificate =
            let config = hcloud.ManagedCertificate.ManagedCertificateConfig()
            for setter in state.assignments do
                setter config
            hcloud.ManagedCertificate.ManagedCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.managedCertificate: missing required arguments. Must call: domain_names, name.", 9999, IsError = true)>]
        member _.Run(_: ManagedCertificateState<_, _>) : hcloud.ManagedCertificate.ManagedCertificate =
            Unchecked.defaultof<hcloud.ManagedCertificate.ManagedCertificate>
