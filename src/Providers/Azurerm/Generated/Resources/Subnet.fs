namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> = { assignments: ResizeArray<azurerm.Subnet.SubnetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet">azurerm_subnet</a>.
    /// </summary>
    type SubnetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubnetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SubnetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#address_prefixes-1">Subnet#address_prefixes</a>.
        /// </summary>
        [<CustomOperation "address_prefixes">]
        member _.AddressPrefixes(state: SubnetState<Missing, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: seq<string>) : SubnetState<Present, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.AddressPrefixes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SubnetState<Present, 'Name, 'ResourceGroupName, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#name-1">Subnet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubnetState<'AddressPrefixes, Missing, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : SubnetState<'AddressPrefixes, Present, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubnetState<'AddressPrefixes, Present, 'ResourceGroupName, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#resource_group_name-1">Subnet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SubnetState<'AddressPrefixes, 'Name, Missing, 'VirtualNetworkName>, value: string) : SubnetState<'AddressPrefixes, 'Name, Present, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SubnetState<'AddressPrefixes, 'Name, Present, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#virtual_network_name-1">Subnet#virtual_network_name</a>.
        /// </summary>
        [<CustomOperation "virtual_network_name">]
        member _.VirtualNetworkName(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, Missing>, value: string) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkName <- value)
            ({ assignments = state.assignments } : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#default_outbound_access_enabled-1">Subnet#default_outbound_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "default_outbound_access_enabled">]
        member _.DefaultOutboundAccessEnabled(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.DefaultOutboundAccessEnabled <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#default_outbound_access_enabled-1">Subnet#default_outbound_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "default_outbound_access_enabled">]
        member _.DefaultOutboundAccessEnabled(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.DefaultOutboundAccessEnabled <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// delegation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#delegation-1">Subnet#delegation</a> Accepts: azurerm.IResolvable | azurerm.Subnet.SubnetDelegation[]
        /// </summary>
        [<CustomOperation "delegation">]
        member _.Delegation(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Delegation <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#id-1">Subnet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#private_endpoint_network_policies-1">Subnet#private_endpoint_network_policies</a>.
        /// </summary>
        [<CustomOperation "private_endpoint_network_policies">]
        member _.PrivateEndpointNetworkPolicies(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.PrivateEndpointNetworkPolicies <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#private_link_service_network_policies_enabled-1">Subnet#private_link_service_network_policies_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_link_service_network_policies_enabled">]
        member _.PrivateLinkServiceNetworkPoliciesEnabled(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: bool) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.PrivateLinkServiceNetworkPoliciesEnabled <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#private_link_service_network_policies_enabled-1">Subnet#private_link_service_network_policies_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_link_service_network_policies_enabled">]
        member _.PrivateLinkServiceNetworkPoliciesEnabled(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.PrivateLinkServiceNetworkPoliciesEnabled <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#service_endpoint_policy_ids-1">Subnet#service_endpoint_policy_ids</a>.
        /// </summary>
        [<CustomOperation "service_endpoint_policy_ids">]
        member _.ServiceEndpointPolicyIds(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: seq<string>) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.ServiceEndpointPolicyIds <- (value |> Seq.toArray))
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#service_endpoints-1">Subnet#service_endpoints</a>.
        /// </summary>
        [<CustomOperation "service_endpoints">]
        member _.ServiceEndpoints(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: seq<string>) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.ServiceEndpoints <- (value |> Seq.toArray))
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#timeouts-1">Subnet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: azurerm.Subnet.SubnetTimeouts) : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubnetState<'AddressPrefixes, 'Name, 'ResourceGroupName, 'VirtualNetworkName>

        member _.Run(state: SubnetState<Present, Present, Present, Present>) : azurerm.Subnet.Subnet =
            let config = azurerm.Subnet.SubnetConfig()
            for setter in state.assignments do
                setter config
            azurerm.Subnet.Subnet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subnet: missing required arguments. Must call: address_prefixes, name, resource_group_name, virtual_network_name.", 9999, IsError = true)>]
        member _.Run(_: SubnetState<_, _, _, _>) : azurerm.Subnet.Subnet =
            Unchecked.defaultof<azurerm.Subnet.Subnet>
