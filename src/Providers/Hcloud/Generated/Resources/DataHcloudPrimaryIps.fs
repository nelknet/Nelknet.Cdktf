namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudPrimaryIpsState = { assignments: ResizeArray<hcloud.DataHcloudPrimaryIps.DataHcloudPrimaryIpsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ips">hcloud_primary_ips</a>.
    /// </summary>
    type DataHcloudPrimaryIpsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudPrimaryIpsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudPrimaryIpsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ips#id-1">DataHcloudPrimaryIps#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudPrimaryIpsState, value: string) : DataHcloudPrimaryIpsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudPrimaryIpsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ips#with_selector-1">DataHcloudPrimaryIps#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudPrimaryIpsState, value: string) : DataHcloudPrimaryIpsState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudPrimaryIpsState

        member _.Run(state: DataHcloudPrimaryIpsState) : hcloud.DataHcloudPrimaryIps.DataHcloudPrimaryIps =
            let config = hcloud.DataHcloudPrimaryIps.DataHcloudPrimaryIpsConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudPrimaryIps.DataHcloudPrimaryIps(StackContext.get (), logicalId, config)
