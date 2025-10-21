namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkState<'IpRange, 'Name> = { assignments: ResizeArray<hcloud.Network.NetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network">hcloud_network</a>.
    /// </summary>
    type NetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkState<Missing, Missing>)

        member _.Zero(()) : NetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#ip_range-1">Network#ip_range</a>.
        /// </summary>
        [<CustomOperation "ip_range">]
        member _.IpRange(state: NetworkState<Missing, 'Name>, value: string) : NetworkState<Present, 'Name> =
            state.assignments.Add(fun config -> config.IpRange <- value)
            ({ assignments = state.assignments } : NetworkState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#name-1">Network#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkState<'IpRange, Missing>, value: string) : NetworkState<'IpRange, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkState<'IpRange, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#delete_protection-1">Network#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: NetworkState<'IpRange, 'Name>, value: bool) : NetworkState<'IpRange, 'Name> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : NetworkState<'IpRange, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#delete_protection-1">Network#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: NetworkState<'IpRange, 'Name>, value: HashiCorp.Cdktf.IResolvable) : NetworkState<'IpRange, 'Name> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : NetworkState<'IpRange, 'Name>

        /// <summary>
        /// Enable or disable exposing the routes to the vSwitch connection. The exposing only takes effect if a vSwitch connection is active. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#expose_routes_to_vswitch-1">Network#expose_routes_to_vswitch</a> Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "expose_routes_to_vswitch">]
        member _.ExposeRoutesToVswitch(state: NetworkState<'IpRange, 'Name>, value: bool) : NetworkState<'IpRange, 'Name> =
            state.assignments.Add(fun config -> config.ExposeRoutesToVswitch <- value)
            state : NetworkState<'IpRange, 'Name>

        /// <summary>
        /// Enable or disable exposing the routes to the vSwitch connection. The exposing only takes effect if a vSwitch connection is active. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#expose_routes_to_vswitch-1">Network#expose_routes_to_vswitch</a> Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "expose_routes_to_vswitch">]
        member _.ExposeRoutesToVswitch(state: NetworkState<'IpRange, 'Name>, value: HashiCorp.Cdktf.IResolvable) : NetworkState<'IpRange, 'Name> =
            state.assignments.Add(fun config -> config.ExposeRoutesToVswitch <- value)
            state : NetworkState<'IpRange, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#id-1">Network#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkState<'IpRange, 'Name>, value: string) : NetworkState<'IpRange, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkState<'IpRange, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#labels-1">Network#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: NetworkState<'IpRange, 'Name>, value: seq<string * string>) : NetworkState<'IpRange, 'Name> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : NetworkState<'IpRange, 'Name>

        member _.Run(state: NetworkState<Present, Present>) : hcloud.Network.Network =
            let config = hcloud.Network.NetworkConfig()
            for setter in state.assignments do
                setter config
            hcloud.Network.Network(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.network: missing required arguments. Must call: ip_range, name.", 9999, IsError = true)>]
        member _.Run(_: NetworkState<_, _>) : hcloud.Network.Network =
            Unchecked.defaultof<hcloud.Network.Network>
