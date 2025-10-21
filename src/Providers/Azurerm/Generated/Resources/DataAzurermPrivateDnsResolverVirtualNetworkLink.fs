namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_virtual_network_link">azurerm_private_dns_resolver_virtual_network_link</a>.
    /// </summary>
    type DataAzurermPrivateDnsResolverVirtualNetworkLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_virtual_network_link#dns_forwarding_ruleset_id-1">DataAzurermPrivateDnsResolverVirtualNetworkLink#dns_forwarding_ruleset_id</a>.
        /// </summary>
        [<CustomOperation "dns_forwarding_ruleset_id">]
        member _.DnsForwardingRulesetId(state: DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Missing, 'Name>, value: string) : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DnsForwardingRulesetId <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_virtual_network_link#name-1">DataAzurermPrivateDnsResolverVirtualNetworkLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, Missing>, value: string) : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_virtual_network_link#id-1">DataAzurermPrivateDnsResolverVirtualNetworkLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name>, value: string) : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_virtual_network_link#timeouts-1">DataAzurermPrivateDnsResolverVirtualNetworkLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name>, value: azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLinkTimeouts) : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsResolverVirtualNetworkLinkState<'DnsForwardingRulesetId, 'Name>

        member _.Run(state: DataAzurermPrivateDnsResolverVirtualNetworkLinkState<Present, Present>) : azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLink =
            let config = azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLinkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsResolverVirtualNetworkLink: missing required arguments. Must call: dns_forwarding_ruleset_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsResolverVirtualNetworkLinkState<_, _>) : azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLink =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsResolverVirtualNetworkLink.DataAzurermPrivateDnsResolverVirtualNetworkLink>
