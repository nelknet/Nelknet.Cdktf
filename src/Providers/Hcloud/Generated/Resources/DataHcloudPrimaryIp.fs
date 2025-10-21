namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudPrimaryIpState = { assignments: ResizeArray<hcloud.DataHcloudPrimaryIp.DataHcloudPrimaryIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip">hcloud_primary_ip</a>.
    /// </summary>
    type DataHcloudPrimaryIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudPrimaryIpState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudPrimaryIpState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#assignee_id-1">DataHcloudPrimaryIp#assignee_id</a>.
        /// </summary>
        [<CustomOperation "assignee_id">]
        member _.AssigneeId(state: DataHcloudPrimaryIpState, value: double) : DataHcloudPrimaryIpState =
            state.assignments.Add(fun config -> config.AssigneeId <- value)
            state : DataHcloudPrimaryIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#id-1">DataHcloudPrimaryIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudPrimaryIpState, value: double) : DataHcloudPrimaryIpState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudPrimaryIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#ip_address-1">DataHcloudPrimaryIp#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: DataHcloudPrimaryIpState, value: string) : DataHcloudPrimaryIpState =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : DataHcloudPrimaryIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#name-1">DataHcloudPrimaryIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudPrimaryIpState, value: string) : DataHcloudPrimaryIpState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudPrimaryIpState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#with_selector-1">DataHcloudPrimaryIp#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudPrimaryIpState, value: string) : DataHcloudPrimaryIpState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudPrimaryIpState

        member _.Run(state: DataHcloudPrimaryIpState) : hcloud.DataHcloudPrimaryIp.DataHcloudPrimaryIp =
            let config = hcloud.DataHcloudPrimaryIp.DataHcloudPrimaryIpConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudPrimaryIp.DataHcloudPrimaryIp(StackContext.get (), logicalId, config)
