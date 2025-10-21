namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudCertificateState = { assignments: ResizeArray<hcloud.DataHcloudCertificate.DataHcloudCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate">hcloud_certificate</a>.
    /// </summary>
    type DataHcloudCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudCertificateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudCertificateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate#id-1">DataHcloudCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudCertificateState, value: double) : DataHcloudCertificateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate#name-1">DataHcloudCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudCertificateState, value: string) : DataHcloudCertificateState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate#with_selector-1">DataHcloudCertificate#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudCertificateState, value: string) : DataHcloudCertificateState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudCertificateState

        member _.Run(state: DataHcloudCertificateState) : hcloud.DataHcloudCertificate.DataHcloudCertificate =
            let config = hcloud.DataHcloudCertificate.DataHcloudCertificateConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudCertificate.DataHcloudCertificate(StackContext.get (), logicalId, config)
