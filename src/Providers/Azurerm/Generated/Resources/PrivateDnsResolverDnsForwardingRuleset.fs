namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRulesetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset">azurerm_private_dns_resolver_dns_forwarding_ruleset</a>.
    /// </summary>
    type PrivateDnsResolverDnsForwardingRulesetBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsResolverDnsForwardingRulesetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverDnsForwardingRulesetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsResolverDnsForwardingRulesetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverDnsForwardingRulesetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#location-1">PrivateDnsResolverDnsForwardingRuleset#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PrivateDnsResolverDnsForwardingRulesetState<Missing, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>, value: string) : PrivateDnsResolverDnsForwardingRulesetState<Present, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverDnsForwardingRulesetState<Present, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#name-1">PrivateDnsResolverDnsForwardingRuleset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsResolverDnsForwardingRulesetState<'Location, Missing, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>, value: string) : PrivateDnsResolverDnsForwardingRulesetState<'Location, Present, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverDnsForwardingRulesetState<'Location, Present, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#private_dns_resolver_outbound_endpoint_ids-1">PrivateDnsResolverDnsForwardingRuleset#private_dns_resolver_outbound_endpoint_ids</a>.
        /// </summary>
        [<CustomOperation "private_dns_resolver_outbound_endpoint_ids">]
        member _.PrivateDnsResolverOutboundEndpointIds(state: PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, Missing, 'ResourceGroupName>, value: seq<string>) : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateDnsResolverOutboundEndpointIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#resource_group_name-1">PrivateDnsResolverDnsForwardingRuleset#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, Missing>, value: string) : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#id-1">PrivateDnsResolverDnsForwardingRuleset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>, value: string) : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#tags-1">PrivateDnsResolverDnsForwardingRuleset#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>, value: seq<string * string>) : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_dns_forwarding_ruleset#timeouts-1">PrivateDnsResolverDnsForwardingRuleset#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>, value: azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRulesetTimeouts) : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsResolverDnsForwardingRulesetState<'Location, 'Name, 'PrivateDnsResolverOutboundEndpointIds, 'ResourceGroupName>

        member _.Run(state: PrivateDnsResolverDnsForwardingRulesetState<Present, Present, Present, Present>) : azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRuleset =
            let config = azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRulesetConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRuleset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsResolverDnsForwardingRuleset: missing required arguments. Must call: location, name, private_dns_resolver_outbound_endpoint_ids, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsResolverDnsForwardingRulesetState<_, _, _, _>) : azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRuleset =
            Unchecked.defaultof<azurerm.PrivateDnsResolverDnsForwardingRuleset.PrivateDnsResolverDnsForwardingRuleset>
