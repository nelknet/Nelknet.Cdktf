namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkRouteState<'Destination, 'Gateway, 'NetworkId> = { assignments: ResizeArray<hcloud.NetworkRoute.NetworkRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route">hcloud_network_route</a>.
    /// </summary>
    type NetworkRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkRouteState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkRouteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#destination-1">NetworkRoute#destination</a>.
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: NetworkRouteState<Missing, 'Gateway, 'NetworkId>, value: string) : NetworkRouteState<Present, 'Gateway, 'NetworkId> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : NetworkRouteState<Present, 'Gateway, 'NetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#gateway-1">NetworkRoute#gateway</a>.
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: NetworkRouteState<'Destination, Missing, 'NetworkId>, value: string) : NetworkRouteState<'Destination, Present, 'NetworkId> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            ({ assignments = state.assignments } : NetworkRouteState<'Destination, Present, 'NetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#network_id-1">NetworkRoute#network_id</a>.
        /// </summary>
        [<CustomOperation "network_id">]
        member _.NetworkId(state: NetworkRouteState<'Destination, 'Gateway, Missing>, value: double) : NetworkRouteState<'Destination, 'Gateway, Present> =
            state.assignments.Add(fun config -> config.NetworkId <- value)
            ({ assignments = state.assignments } : NetworkRouteState<'Destination, 'Gateway, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#id-1">NetworkRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkRouteState<'Destination, 'Gateway, 'NetworkId>, value: string) : NetworkRouteState<'Destination, 'Gateway, 'NetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkRouteState<'Destination, 'Gateway, 'NetworkId>

        member _.Run(state: NetworkRouteState<Present, Present, Present>) : hcloud.NetworkRoute.NetworkRoute =
            let config = hcloud.NetworkRoute.NetworkRouteConfig()
            for setter in state.assignments do
                setter config
            hcloud.NetworkRoute.NetworkRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.networkRoute: missing required arguments. Must call: destination, gateway, network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkRouteState<_, _, _>) : hcloud.NetworkRoute.NetworkRoute =
            Unchecked.defaultof<hcloud.NetworkRoute.NetworkRoute>
