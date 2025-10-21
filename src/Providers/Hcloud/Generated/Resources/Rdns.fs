namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdnsState<'DnsPtr, 'IpAddress> = { assignments: ResizeArray<hcloud.Rdns.RdnsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns">hcloud_rdns</a>.
    /// </summary>
    type RdnsBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdnsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdnsState<Missing, Missing>)

        member _.Zero(()) : RdnsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdnsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#dns_ptr-1">Rdns#dns_ptr</a>.
        /// </summary>
        [<CustomOperation "dns_ptr">]
        member _.DnsPtr(state: RdnsState<Missing, 'IpAddress>, value: string) : RdnsState<Present, 'IpAddress> =
            state.assignments.Add(fun config -> config.DnsPtr <- value)
            ({ assignments = state.assignments } : RdnsState<Present, 'IpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#ip_address-1">Rdns#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: RdnsState<'DnsPtr, Missing>, value: string) : RdnsState<'DnsPtr, Present> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            ({ assignments = state.assignments } : RdnsState<'DnsPtr, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#floating_ip_id-1">Rdns#floating_ip_id</a>.
        /// </summary>
        [<CustomOperation "floating_ip_id">]
        member _.FloatingIpId(state: RdnsState<'DnsPtr, 'IpAddress>, value: double) : RdnsState<'DnsPtr, 'IpAddress> =
            state.assignments.Add(fun config -> config.FloatingIpId <- value)
            state : RdnsState<'DnsPtr, 'IpAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#id-1">Rdns#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdnsState<'DnsPtr, 'IpAddress>, value: string) : RdnsState<'DnsPtr, 'IpAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdnsState<'DnsPtr, 'IpAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#load_balancer_id-1">Rdns#load_balancer_id</a>.
        /// </summary>
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId(state: RdnsState<'DnsPtr, 'IpAddress>, value: double) : RdnsState<'DnsPtr, 'IpAddress> =
            state.assignments.Add(fun config -> config.LoadBalancerId <- value)
            state : RdnsState<'DnsPtr, 'IpAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#primary_ip_id-1">Rdns#primary_ip_id</a>.
        /// </summary>
        [<CustomOperation "primary_ip_id">]
        member _.PrimaryIpId(state: RdnsState<'DnsPtr, 'IpAddress>, value: double) : RdnsState<'DnsPtr, 'IpAddress> =
            state.assignments.Add(fun config -> config.PrimaryIpId <- value)
            state : RdnsState<'DnsPtr, 'IpAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#server_id-1">Rdns#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: RdnsState<'DnsPtr, 'IpAddress>, value: double) : RdnsState<'DnsPtr, 'IpAddress> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            state : RdnsState<'DnsPtr, 'IpAddress>

        member _.Run(state: RdnsState<Present, Present>) : hcloud.Rdns.Rdns =
            let config = hcloud.Rdns.RdnsConfig()
            for setter in state.assignments do
                setter config
            hcloud.Rdns.Rdns(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.rdns: missing required arguments. Must call: dns_ptr, ip_address.", 9999, IsError = true)>]
        member _.Run(_: RdnsState<_, _>) : hcloud.Rdns.Rdns =
            Unchecked.defaultof<hcloud.Rdns.Rdns>
