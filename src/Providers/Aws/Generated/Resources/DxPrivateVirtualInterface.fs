namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> = { assignments: ResizeArray<aws.DxPrivateVirtualInterface.DxPrivateVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface">aws_dx_private_virtual_interface</a>.
    /// </summary>
    type DxPrivateVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#address_family-1">DxPrivateVirtualInterface#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxPrivateVirtualInterfaceState<Missing, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxPrivateVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#bgp_asn-1">DxPrivateVirtualInterface#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxPrivateVirtualInterfaceState<'AddressFamily, Missing, 'ConnectionId, 'Name, 'Vlan>, value: double) : DxPrivateVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxPrivateVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#connection_id-1">DxPrivateVirtualInterface#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, Missing, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#name-1">DxPrivateVirtualInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Missing, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#vlan-1">DxPrivateVirtualInterface#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Missing>, value: double) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#amazon_address-1">DxPrivateVirtualInterface#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#bgp_auth_key-1">DxPrivateVirtualInterface#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#customer_address-1">DxPrivateVirtualInterface#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#dx_gateway_id-1">DxPrivateVirtualInterface#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#id-1">DxPrivateVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#mtu-1">DxPrivateVirtualInterface#mtu</a>.
        /// </summary>
        [<CustomOperation "mtu">]
        member _.Mtu(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: double) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Mtu <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#sitelink_enabled-1">DxPrivateVirtualInterface#sitelink_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sitelink_enabled">]
        member _.SitelinkEnabled(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: bool) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.SitelinkEnabled <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#sitelink_enabled-1">DxPrivateVirtualInterface#sitelink_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sitelink_enabled">]
        member _.SitelinkEnabled(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: HashiCorp.Cdktf.IResolvable) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.SitelinkEnabled <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#tags-1">DxPrivateVirtualInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: seq<string * string>) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#tags_all-1">DxPrivateVirtualInterface#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: seq<string * string>) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#timeouts-1">DxPrivateVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: aws.DxPrivateVirtualInterface.DxPrivateVirtualInterfaceTimeouts) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_private_virtual_interface#vpn_gateway_id-1">DxPrivateVirtualInterface#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>, value: string) : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            state : DxPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'Vlan>

        member _.Run(state: DxPrivateVirtualInterfaceState<Present, Present, Present, Present, Present>) : aws.DxPrivateVirtualInterface.DxPrivateVirtualInterface =
            let config = aws.DxPrivateVirtualInterface.DxPrivateVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DxPrivateVirtualInterface.DxPrivateVirtualInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxPrivateVirtualInterface: missing required arguments. Must call: address_family, bgp_asn, connection_id, name, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxPrivateVirtualInterfaceState<_, _, _, _, _>) : aws.DxPrivateVirtualInterface.DxPrivateVirtualInterface =
            Unchecked.defaultof<aws.DxPrivateVirtualInterface.DxPrivateVirtualInterface>
