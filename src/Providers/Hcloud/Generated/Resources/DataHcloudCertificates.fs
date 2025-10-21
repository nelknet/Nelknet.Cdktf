namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudCertificatesState = { assignments: ResizeArray<hcloud.DataHcloudCertificates.DataHcloudCertificatesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificates">hcloud_certificates</a>.
    /// </summary>
    type DataHcloudCertificatesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudCertificatesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudCertificatesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificates#id-1">DataHcloudCertificates#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudCertificatesState, value: string) : DataHcloudCertificatesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudCertificatesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificates#with_selector-1">DataHcloudCertificates#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudCertificatesState, value: string) : DataHcloudCertificatesState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudCertificatesState

        member _.Run(state: DataHcloudCertificatesState) : hcloud.DataHcloudCertificates.DataHcloudCertificates =
            let config = hcloud.DataHcloudCertificates.DataHcloudCertificatesConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudCertificates.DataHcloudCertificates(StackContext.get (), logicalId, config)
