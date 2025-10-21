namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> = { assignments: ResizeArray<aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface">aws_dx_hosted_private_virtual_interface</a>.
    /// </summary>
    type DxHostedPrivateVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxHostedPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DxHostedPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxHostedPrivateVirtualInterfaceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#address_family-1">DxHostedPrivateVirtualInterface#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: DxHostedPrivateVirtualInterfaceState<Missing, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceState<Present, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#bgp_asn-1">DxHostedPrivateVirtualInterface#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, Missing, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: double) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceState<'AddressFamily, Present, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#connection_id-1">DxHostedPrivateVirtualInterface#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, Missing, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, Present, 'Name, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#name-1">DxHostedPrivateVirtualInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Missing, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, Present, 'OwnerAccountId, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#owner_account_id-1">DxHostedPrivateVirtualInterface#owner_account_id</a>.
        /// </summary>
        [<CustomOperation "owner_account_id">]
        member _.OwnerAccountId(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Missing, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'Vlan> =
            state.assignments.Add(fun config -> config.OwnerAccountId <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, Present, 'Vlan>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#vlan-1">DxHostedPrivateVirtualInterface#vlan</a>.
        /// </summary>
        [<CustomOperation "vlan">]
        member _.Vlan(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Missing>, value: double) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Present> =
            state.assignments.Add(fun config -> config.Vlan <- value)
            ({ assignments = state.assignments } : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#amazon_address-1">DxHostedPrivateVirtualInterface#amazon_address</a>.
        /// </summary>
        [<CustomOperation "amazon_address">]
        member _.AmazonAddress(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.AmazonAddress <- value)
            state : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#bgp_auth_key-1">DxHostedPrivateVirtualInterface#bgp_auth_key</a>.
        /// </summary>
        [<CustomOperation "bgp_auth_key">]
        member _.BgpAuthKey(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.BgpAuthKey <- value)
            state : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#customer_address-1">DxHostedPrivateVirtualInterface#customer_address</a>.
        /// </summary>
        [<CustomOperation "customer_address">]
        member _.CustomerAddress(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.CustomerAddress <- value)
            state : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#id-1">DxHostedPrivateVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: string) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#mtu-1">DxHostedPrivateVirtualInterface#mtu</a>.
        /// </summary>
        [<CustomOperation "mtu">]
        member _.Mtu(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: double) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Mtu <- value)
            state : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#timeouts-1">DxHostedPrivateVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>, value: aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterfaceTimeouts) : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxHostedPrivateVirtualInterfaceState<'AddressFamily, 'BgpAsn, 'ConnectionId, 'Name, 'OwnerAccountId, 'Vlan>

        member _.Run(state: DxHostedPrivateVirtualInterfaceState<Present, Present, Present, Present, Present, Present>) : aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterface =
            let config = aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxHostedPrivateVirtualInterface: missing required arguments. Must call: address_family, bgp_asn, connection_id, name, owner_account_id, vlan.", 9999, IsError = true)>]
        member _.Run(_: DxHostedPrivateVirtualInterfaceState<_, _, _, _, _, _>) : aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterface =
            Unchecked.defaultof<aws.DxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterface>
