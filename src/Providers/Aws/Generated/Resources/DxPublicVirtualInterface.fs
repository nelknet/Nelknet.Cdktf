namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> = { assignments: ResizeArray<aws.DxPublicVirtualInterface.DxPublicVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface">aws_dx_public_virtual_interface</a>.
    /// </summary>
    type DxPublicVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxPublicVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#address_family-1">DxPublicVirtualInterface#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxPublicVirtualInterfaceState<Missing, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxPublicVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#bgp_asn-1">DxPublicVirtualInterface#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxPublicVirtualInterfaceState<'AddressFamily, Missing, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: double) : DxPublicVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxPublicVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#connection_id-1">DxPublicVirtualInterface#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, Missing, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#name-1">DxPublicVirtualInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Missing, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'RouteFilterPrefixes, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#route_filter_prefixes-1">DxPublicVirtualInterface#route_filter_prefixes</a>.
        /// </summary>
        [<CustomOperation "route_filter_prefixes">]
        member _.RouteFilterPrefixes(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Missing, 'Vlan>, value: seq<string>) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.RouteFilterPrefixes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#vlan-1">DxPublicVirtualInterface#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, Missing>, value: double) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#amazon_address-1">DxPublicVirtualInterface#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#bgp_auth_key-1">DxPublicVirtualInterface#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#customer_address-1">DxPublicVirtualInterface#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#id-1">DxPublicVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: string) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#tags-1">DxPublicVirtualInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: seq<string * string>) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#tags_all-1">DxPublicVirtualInterface#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: seq<string * string>) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_public_virtual_interface#timeouts-1">DxPublicVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>, value: aws.DxPublicVirtualInterface.DxPublicVirtualInterfaceTimeouts) : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxPublicVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'RouteFilterPrefixes, 'Vlan>

        member _.Run(state: DxPublicVirtualInterfaceState<Present, Present, Present, Present, Present, Present>) : aws.DxPublicVirtualInterface.DxPublicVirtualInterface =
            let config = aws.DxPublicVirtualInterface.DxPublicVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DxPublicVirtualInterface.DxPublicVirtualInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxPublicVirtualInterface: missing required arguments. Must call: address_family, bgp_asn, connection_id, name, route_filter_prefixes, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxPublicVirtualInterfaceState<_, _, _, _, _, _>) : aws.DxPublicVirtualInterface.DxPublicVirtualInterface =
            Unchecked.defaultof<aws.DxPublicVirtualInterface.DxPublicVirtualInterface>
