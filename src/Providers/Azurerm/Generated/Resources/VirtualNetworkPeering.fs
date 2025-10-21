namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> = { assignments: ResizeArray<azurerm.VirtualNetworkPeering.VirtualNetworkPeeringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering">azurerm_virtual_network_peering</a>.
    /// </summary>
    type VirtualNetworkPeeringBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualNetworkPeeringState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkPeeringState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualNetworkPeeringState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkPeeringState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#name-1">VirtualNetworkPeering#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualNetworkPeeringState<Missing, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : VirtualNetworkPeeringState<Present, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualNetworkPeeringState<Present, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#remote_virtual_network_id-1">VirtualNetworkPeering#remote_virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "remote_virtual_network_id">]
        member _.RemoteVirtualNetworkId(state: VirtualNetworkPeeringState<'Name, Missing, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : VirtualNetworkPeeringState<'Name, Present, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.RemoteVirtualNetworkId <- value)
            ({ assignments = state.assignments } : VirtualNetworkPeeringState<'Name, Present, 'ResourceGroupName, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#resource_group_name-1">VirtualNetworkPeering#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, Missing, 'VirtualNetworkName>, value: string) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, Present, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, Present, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#virtual_network_name-1">VirtualNetworkPeering#virtual_network_name</a>.
        /// </summary>
        [<CustomOperation "virtual_network_name">]
        member _.VirtualNetworkName(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, Missing>, value: string) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkName <- value)
            ({ assignments = state.assignments } : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#allow_forwarded_traffic-1">VirtualNetworkPeering#allow_forwarded_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_forwarded_traffic">]
        member _.AllowForwardedTraffic(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AllowForwardedTraffic <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#allow_forwarded_traffic-1">VirtualNetworkPeering#allow_forwarded_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_forwarded_traffic">]
        member _.AllowForwardedTraffic(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AllowForwardedTraffic <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#allow_gateway_transit-1">VirtualNetworkPeering#allow_gateway_transit</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_gateway_transit">]
        member _.AllowGatewayTransit(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AllowGatewayTransit <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#allow_gateway_transit-1">VirtualNetworkPeering#allow_gateway_transit</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_gateway_transit">]
        member _.AllowGatewayTransit(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AllowGatewayTransit <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#allow_virtual_network_access-1">VirtualNetworkPeering#allow_virtual_network_access</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_virtual_network_access">]
        member _.AllowVirtualNetworkAccess(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AllowVirtualNetworkAccess <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#allow_virtual_network_access-1">VirtualNetworkPeering#allow_virtual_network_access</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_virtual_network_access">]
        member _.AllowVirtualNetworkAccess(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AllowVirtualNetworkAccess <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#id-1">VirtualNetworkPeering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#local_subnet_names-1">VirtualNetworkPeering#local_subnet_names</a>.
        /// </summary>
        [<CustomOperation "local_subnet_names">]
        member _.LocalSubnetNames(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: seq<string>) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.LocalSubnetNames <- (value |> Seq.toArray))
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#only_ipv6_peering_enabled-1">VirtualNetworkPeering#only_ipv6_peering_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "only_ipv6_peering_enabled">]
        member _.OnlyIpv6PeeringEnabled(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.OnlyIpv6PeeringEnabled <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#only_ipv6_peering_enabled-1">VirtualNetworkPeering#only_ipv6_peering_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "only_ipv6_peering_enabled">]
        member _.OnlyIpv6PeeringEnabled(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.OnlyIpv6PeeringEnabled <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#peer_complete_virtual_networks_enabled-1">VirtualNetworkPeering#peer_complete_virtual_networks_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "peer_complete_virtual_networks_enabled">]
        member _.PeerCompleteVirtualNetworksEnabled(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.PeerCompleteVirtualNetworksEnabled <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#peer_complete_virtual_networks_enabled-1">VirtualNetworkPeering#peer_complete_virtual_networks_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "peer_complete_virtual_networks_enabled">]
        member _.PeerCompleteVirtualNetworksEnabled(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.PeerCompleteVirtualNetworksEnabled <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#remote_subnet_names-1">VirtualNetworkPeering#remote_subnet_names</a>.
        /// </summary>
        [<CustomOperation "remote_subnet_names">]
        member _.RemoteSubnetNames(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: seq<string>) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.RemoteSubnetNames <- (value |> Seq.toArray))
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#timeouts-1">VirtualNetworkPeering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: azurerm.VirtualNetworkPeering.VirtualNetworkPeeringTimeouts) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#triggers-1">VirtualNetworkPeering#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: seq<string * string>) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#use_remote_gateways-1">VirtualNetworkPeering#use_remote_gateways</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_remote_gateways">]
        member _.UseRemoteGateways(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.UseRemoteGateways <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_peering#use_remote_gateways-1">VirtualNetworkPeering#use_remote_gateways</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_remote_gateways">]
        member _.UseRemoteGateways(state: VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.UseRemoteGateways <- value)
            state : VirtualNetworkPeeringState<'Name, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'VirtualNetworkName>

        member _.Run(state: VirtualNetworkPeeringState<Present, Present, Present, Present>) : azurerm.VirtualNetworkPeering.VirtualNetworkPeering =
            let config = azurerm.VirtualNetworkPeering.VirtualNetworkPeeringConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualNetworkPeering.VirtualNetworkPeering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualNetworkPeering: missing required arguments. Must call: name, remote_virtual_network_id, resource_group_name, virtual_network_name.", 9999, IsError = true)>]
        member _.Run(_: VirtualNetworkPeeringState<_, _, _, _>) : azurerm.VirtualNetworkPeering.VirtualNetworkPeering =
            Unchecked.defaultof<azurerm.VirtualNetworkPeering.VirtualNetworkPeering>
