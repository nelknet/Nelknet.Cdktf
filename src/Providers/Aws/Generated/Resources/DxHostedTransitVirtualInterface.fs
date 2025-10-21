namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> = { assignments: ResizeArray<aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface">aws_dx_hosted_transit_virtual_interface</a>.
    /// </summary>
    type DxHostedTransitVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxHostedTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedTransitVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#address_family-1">DxHostedTransitVirtualInterface#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxHostedTransitVirtualInterfaceState<Missing, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#bgp_asn-1">DxHostedTransitVirtualInterface#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, Missing, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: double) : DxHostedTransitVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#connection_id-1">DxHostedTransitVirtualInterface#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, Missing, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#name-1">DxHostedTransitVirtualInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Missing, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#owner_account_id-1">DxHostedTransitVirtualInterface#owner_account_id</a>.
        /// </summary>
        [<CustomOperation "owner_account_id">]
        member _.OwnerAccountId(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Missing, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.OwnerAccountId <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#vlan-1">DxHostedTransitVirtualInterface#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Missing>, value: double) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#amazon_address-1">DxHostedTransitVirtualInterface#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#bgp_auth_key-1">DxHostedTransitVirtualInterface#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#customer_address-1">DxHostedTransitVirtualInterface#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#id-1">DxHostedTransitVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#mtu-1">DxHostedTransitVirtualInterface#mtu</a>.
        /// </summary>
        [<CustomOperation "mtu">]
        member _.Mtu(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: double) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Mtu <- value)
            state : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#timeouts-1">DxHostedTransitVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterfaceTimeouts) : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxHostedTransitVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        member _.Run(state: DxHostedTransitVirtualInterfaceState<Present, Present, Present, Present, Present, Present>) : aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterface =
            let config = aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedTransitVirtualInterface: missing required arguments. Must call: address_family, bgp_asn, connection_id, name, owner_account_id, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxHostedTransitVirtualInterfaceState<_, _, _, _, _, _>) : aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterface =
            Unchecked.defaultof<aws.DxHostedTransitVirtualInterface.DxHostedTransitVirtualInterface>
