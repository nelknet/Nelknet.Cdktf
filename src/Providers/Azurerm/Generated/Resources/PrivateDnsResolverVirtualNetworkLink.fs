namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId> = { assignments: ResizeArray<azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link">azurerm_private_dns_resolver_virtual_network_link</a>.
    /// </summary>
    type PrivateDnsResolverVirtualNetworkLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsResolverVirtualNetworkLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverVirtualNetworkLinkState<Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsResolverVirtualNetworkLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverVirtualNetworkLinkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link#dns_forwarding_ruleset_id-1">PrivateDnsResolverVirtualNetworkLink#dns_forwarding_ruleset_id</a>.
        /// </summary>
        [<CustomOperation "dns_forwarding_ruleset_id">]
        member _.DnsForwardingRulesetId(state: PrivateDnsResolverVirtualNetworkLinkState<Missing, 'Name, 'VirtualNetworkId>, value: string) : PrivateDnsResolverVirtualNetworkLinkState<Present, 'Name, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.DnsForwardingRulesetId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverVirtualNetworkLinkState<Present, 'Name, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link#name-1">PrivateDnsResolverVirtualNetworkLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, Missing, 'VirtualNetworkId>, value: string) : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, Present, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, Present, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link#virtual_network_id-1">PrivateDnsResolverVirtualNetworkLink#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, Missing>, value: string) : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link#id-1">PrivateDnsResolverVirtualNetworkLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId>, value: string) : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link#metadata-1">PrivateDnsResolverVirtualNetworkLink#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId>, value: seq<string * string>) : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_virtual_network_link#timeouts-1">PrivateDnsResolverVirtualNetworkLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId>, value: azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLinkTimeouts) : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name, 'VirtualNetworkId>

        member _.Run(state: PrivateDnsResolverVirtualNetworkLinkState<Present, Present, Present>) : azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLink =
            let config = azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLinkConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsResolverVirtualNetworkLink: missing required arguments. Must call: dns_forwarding_ruleset_id, name, virtual_network_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsResolverVirtualNetworkLinkState<_, _, _>) : azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLink =
            Unchecked.defaultof<azurerm.PrivateDnsResolverVirtualNetworkLink.PrivateDnsResolverVirtualNetworkLink>
