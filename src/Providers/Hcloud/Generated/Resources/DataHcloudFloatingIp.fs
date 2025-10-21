namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudFloatingIpState = { assignments: ResizeArray<hcloud.DataHcloudFloatingIp.DataHcloudFloatingIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip">hcloud_floating_ip</a>.
    /// </summary>
    type DataHcloudFloatingIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudFloatingIpState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudFloatingIpState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#id-1">DataHcloudFloatingIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudFloatingIpState, value: double) : DataHcloudFloatingIpState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudFloatingIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#ip_address-1">DataHcloudFloatingIp#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: DataHcloudFloatingIpState, value: string) : DataHcloudFloatingIpState =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : DataHcloudFloatingIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#name-1">DataHcloudFloatingIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudFloatingIpState, value: string) : DataHcloudFloatingIpState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudFloatingIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#selector-1">DataHcloudFloatingIp#selector</a>.
        /// </summary>
        [<CustomOperation "selector">]
        member _.Selector(state: DataHcloudFloatingIpState, value: string) : DataHcloudFloatingIpState =
            state.assignments.Add(fun config -> config.Selector <- value)
            state : DataHcloudFloatingIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#with_selector-1">DataHcloudFloatingIp#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudFloatingIpState, value: string) : DataHcloudFloatingIpState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudFloatingIpState

        member _.Run(state: DataHcloudFloatingIpState) : hcloud.DataHcloudFloatingIp.DataHcloudFloatingIp =
            let config = hcloud.DataHcloudFloatingIp.DataHcloudFloatingIpConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudFloatingIp.DataHcloudFloatingIp(StackContext.get (), logicalId, config)
