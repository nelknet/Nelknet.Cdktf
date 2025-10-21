namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudFloatingIpsState = { assignments: ResizeArray<hcloud.DataHcloudFloatingIps.DataHcloudFloatingIpsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ips">hcloud_floating_ips</a>.
    /// </summary>
    type DataHcloudFloatingIpsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudFloatingIpsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudFloatingIpsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ips#id-1">DataHcloudFloatingIps#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudFloatingIpsState, value: string) : DataHcloudFloatingIpsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudFloatingIpsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ips#with_selector-1">DataHcloudFloatingIps#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudFloatingIpsState, value: string) : DataHcloudFloatingIpsState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudFloatingIpsState

        member _.Run(state: DataHcloudFloatingIpsState) : hcloud.DataHcloudFloatingIps.DataHcloudFloatingIps =
            let config = hcloud.DataHcloudFloatingIps.DataHcloudFloatingIpsConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudFloatingIps.DataHcloudFloatingIps(StackContext.get (), logicalId, config)
