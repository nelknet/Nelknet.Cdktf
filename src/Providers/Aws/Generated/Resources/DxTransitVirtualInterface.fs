namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> = { assignments: ResizeArray<aws.DxTransitVirtualInterface.DxTransitVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface">aws_dx_transit_virtual_interface</a>.
    /// </summary>
    type DxTransitVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#address_family-1">DxTransitVirtualInterface#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxTransitVirtualInterfaceState<Missing, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxTransitVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#bgp_asn-1">DxTransitVirtualInterface#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxTransitVirtualInterfaceState<'AddressFamily, Missing, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: double) : DxTransitVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxTransitVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#connection_id-1">DxTransitVirtualInterface#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, Missing, 'DxGatewayId, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'DxGatewayId, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#dx_gateway_id-1">DxTransitVirtualInterface#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Missing, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            ({ assignments = state.assignments } : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#name-1">DxTransitVirtualInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, Missing, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#vlan-1">DxTransitVirtualInterface#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, Missing>, value: double) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#amazon_address-1">DxTransitVirtualInterface#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#bgp_auth_key-1">DxTransitVirtualInterface#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#customer_address-1">DxTransitVirtualInterface#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#id-1">DxTransitVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: string) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#mtu-1">DxTransitVirtualInterface#mtu</a>.
        /// </summary>
        [<CustomOperation "mtu">]
        member _.Mtu(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: double) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Mtu <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#sitelink_enabled-1">DxTransitVirtualInterface#sitelink_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sitelink_enabled">]
        member _.SitelinkEnabled(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: bool) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.SitelinkEnabled <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#sitelink_enabled-1">DxTransitVirtualInterface#sitelink_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sitelink_enabled">]
        member _.SitelinkEnabled(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: HashiCorp.Cdktf.IResolvable) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.SitelinkEnabled <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#tags-1">DxTransitVirtualInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: seq<string * string>) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#tags_all-1">DxTransitVirtualInterface#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: seq<string * string>) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_transit_virtual_interface#timeouts-1">DxTransitVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>, value: aws.DxTransitVirtualInterface.DxTransitVirtualInterfaceTimeouts) : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'DxGatewayId, 'Name, 'Vlan>

        member _.Run(state: DxTransitVirtualInterfaceState<Present, Present, Present, Present, Present, Present>) : aws.DxTransitVirtualInterface.DxTransitVirtualInterface =
            let config = aws.DxTransitVirtualInterface.DxTransitVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DxTransitVirtualInterface.DxTransitVirtualInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxTransitVirtualInterface: missing required arguments. Must call: address_family, bgp_asn, connection_id, dx_gateway_id, name, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxTransitVirtualInterfaceState<_, _, _, _, _, _>) : aws.DxTransitVirtualInterface.DxTransitVirtualInterface =
            Unchecked.defaultof<aws.DxTransitVirtualInterface.DxTransitVirtualInterface>
