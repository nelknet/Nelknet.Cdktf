namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type> = { assignments: ResizeArray<hcloud.NetworkSubnet.NetworkSubnetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet">hcloud_network_subnet</a>.
    /// </summary>
    type NetworkSubnetBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkSubnetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkSubnetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkSubnetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkSubnetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#ip_range-1">NetworkSubnet#ip_range</a>.
        /// </summary>
        [<CustomOperation "ip_range">]
        member _.IpRange(state: NetworkSubnetState<Missing, 'NetworkId, 'NetworkZone, 'Type>, value: string) : NetworkSubnetState<Present, 'NetworkId, 'NetworkZone, 'Type> =
            state.assignments.Add(fun config -> config.IpRange <- value)
            ({ assignments = state.assignments } : NetworkSubnetState<Present, 'NetworkId, 'NetworkZone, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#network_id-1">NetworkSubnet#network_id</a>.
        /// </summary>
        [<CustomOperation "network_id">]
        member _.NetworkId(state: NetworkSubnetState<'IpRange, Missing, 'NetworkZone, 'Type>, value: double) : NetworkSubnetState<'IpRange, Present, 'NetworkZone, 'Type> =
            state.assignments.Add(fun config -> config.NetworkId <- value)
            ({ assignments = state.assignments } : NetworkSubnetState<'IpRange, Present, 'NetworkZone, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#network_zone-1">NetworkSubnet#network_zone</a>.
        /// </summary>
        [<CustomOperation "network_zone">]
        member _.NetworkZone(state: NetworkSubnetState<'IpRange, 'NetworkId, Missing, 'Type>, value: string) : NetworkSubnetState<'IpRange, 'NetworkId, Present, 'Type> =
            state.assignments.Add(fun config -> config.NetworkZone <- value)
            ({ assignments = state.assignments } : NetworkSubnetState<'IpRange, 'NetworkId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#type-1">NetworkSubnet#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, Missing>, value: string) : NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#id-1">NetworkSubnet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type>, value: string) : NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#vswitch_id-1">NetworkSubnet#vswitch_id</a>.
        /// </summary>
        [<CustomOperation "vswitch_id">]
        member _.VswitchId(state: NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type>, value: double) : NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type> =
            state.assignments.Add(fun config -> config.VswitchId <- value)
            state : NetworkSubnetState<'IpRange, 'NetworkId, 'NetworkZone, 'Type>

        member _.Run(state: NetworkSubnetState<Present, Present, Present, Present>) : hcloud.NetworkSubnet.NetworkSubnet =
            let config = hcloud.NetworkSubnet.NetworkSubnetConfig()
            for setter in state.assignments do
                setter config
            hcloud.NetworkSubnet.NetworkSubnet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.networkSubnet: missing required arguments. Must call: ip_range, network_id, network_zone, type.", 9999, IsError = true)>]
        member _.Run(_: NetworkSubnetState<_, _, _, _>) : hcloud.NetworkSubnet.NetworkSubnet =
            Unchecked.defaultof<hcloud.NetworkSubnet.NetworkSubnet>
