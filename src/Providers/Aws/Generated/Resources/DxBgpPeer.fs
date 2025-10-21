namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId> = { assignments: ResizeArray<aws.DxBgpPeer.DxBgpPeerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer">aws_dx_bgp_peer</a>.
    /// </summary>
    type DxBgpPeerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxBgpPeerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxBgpPeerState<Missing, Missing, Missing>)

        member _.Zero(()) : DxBgpPeerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxBgpPeerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#address_family-1">DxBgpPeer#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxBgpPeerState<Missing, 'BgpAsn, 'VirtualInterfaceId>, value: string) : DxBgpPeerState<Present, 'BgpAsn, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxBgpPeerState<Present, 'BgpAsn, 'VirtualInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#bgp_asn-1">DxBgpPeer#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxBgpPeerState<'AddressFamily, Missing, 'VirtualInterfaceId>, value: double) : DxBgpPeerState<'AddressFamily, Present, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxBgpPeerState<'AddressFamily, Present, 'VirtualInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#virtual_interface_id-1">DxBgpPeer#virtual_interface_id</a>.
        /// </summary>
        [<CustomOperation "virtual_interface_id">]
        member _.VirtualInterfaceId(state: DxBgpPeerState<'AddressFamily, 'BgpAsn, Missing>, value: string) : DxBgpPeerState<'AddressFamily, 'BgpAsn, Present> =
            state.assignments.Add(fun config -> config.VirtualInterfaceId <- value)
            ({ assignments = state.assignments } : DxBgpPeerState<'AddressFamily, 'BgpAsn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#amazon_address-1">DxBgpPeer#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>, value: string) : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#bgp_auth_key-1">DxBgpPeer#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>, value: string) : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#customer_address-1">DxBgpPeer#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>, value: string) : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#id-1">DxBgpPeer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>, value: string) : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_bgp_peer#timeouts-1">DxBgpPeer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>, value: aws.DxBgpPeer.DxBgpPeerTimeouts) : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxBgpPeerState<'AddressFamily, 'BgpAsn, 'VirtualInterfaceId>

        member _.Run(state: DxBgpPeerState<Present, Present, Present>) : aws.DxBgpPeer.DxBgpPeer =
            let config = aws.DxBgpPeer.DxBgpPeerConfig()
            for setter in state.assignments do
                setter config
            aws.DxBgpPeer.DxBgpPeer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxBgpPeer: missing required arguments. Must call: address_family, bgp_asn, virtual_interface_id.", 9999, IsError = true)>]
        member _.Run(_: DxBgpPeerState<_, _, _>) : aws.DxBgpPeer.DxBgpPeer =
            Unchecked.defaultof<aws.DxBgpPeer.DxBgpPeer>
