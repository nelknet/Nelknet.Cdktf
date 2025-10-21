namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> = { assignments: ResizeArray<aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface">aws_dx_hosted_public_virtual_interface</a>.
    /// </summary>
    type DxHostedPublicVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxHostedPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#address_family-1">DxHostedPublicVirtualInterface#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxHostedPublicVirtualInterfaceState<Missing, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#bgp_asn-1">DxHostedPublicVirtualInterface#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, Missing, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: double) : DxHostedPublicVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#connection_id-1">DxHostedPublicVirtualInterface#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, Missing, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#name-1">DxHostedPublicVirtualInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Missing, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#owner_account_id-1">DxHostedPublicVirtualInterface#owner_account_id</a>.
        /// </summary>
        [<CustomOperation "owner_account_id">]
        member _.OwnerAccountId(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Missing, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.OwnerAccountId <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#route_filter_prefixes-1">DxHostedPublicVirtualInterface#route_filter_prefixes</a>.
        /// </summary>
        [<CustomOperation "route_filter_prefixes">]
        member _.RouteFilterPrefixes(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Missing, 'Vlan>, value: seq<string>) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.RouteFilterPrefixes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#vlan-1">DxHostedPublicVirtualInterface#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, Missing>, value: double) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#amazon_address-1">DxHostedPublicVirtualInterface#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#bgp_auth_key-1">DxHostedPublicVirtualInterface#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#customer_address-1">DxHostedPublicVirtualInterface#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#id-1">DxHostedPublicVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#timeouts-1">DxHostedPublicVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>, value: aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterfaceTimeouts) : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxHostedPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'RouteFilterPrefixes, 'Vlan>

        member _.Run(state: DxHostedPublicVirtualInterfaceState<Present, Present, Present, Present, Present, Present, Present>) : aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterface =
            let config = aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedPublicVirtualInterface: missing required arguments. Must call: address_family, bgp_asn, connection_id, name, owner_account_id, route_filter_prefixes, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxHostedPublicVirtualInterfaceState<_, _, _, _, _, _, _>) : aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterface =
            Unchecked.defaultof<aws.DxHostedPublicVirtualInterface.DxHostedPublicVirtualInterface>
