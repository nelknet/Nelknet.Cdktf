namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule">azurerm_private_dns_resolver_forwarding_rule</a>.
    /// </summary>
    type DataAzurermPrivateDnsResolverForwardingRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsResolverForwardingRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverForwardingRuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsResolverForwardingRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverForwardingRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule#dns_forwarding_ruleset_id-1">DataAzurermPrivateDnsResolverForwardingRule#dns_forwarding_ruleset_id</a>.
        /// </summary>
        [<CustomOperation "dns_forwarding_ruleset_id">]
        member _.DnsForwardingRulesetId(state: DataAzurermPrivateDnsResolverForwardingRuleState<Missing, 'Name>, value: string) : DataAzurermPrivateDnsResolverForwardingRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DnsForwardingRulesetId <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverForwardingRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule#name-1">DataAzurermPrivateDnsResolverForwardingRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, Missing>, value: string) : DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule#id-1">DataAzurermPrivateDnsResolverForwardingRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name>, value: string) : DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_forwarding_rule#timeouts-1">DataAzurermPrivateDnsResolverForwardingRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name>, value: azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRuleTimeouts) : DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'Name>

        member _.Run(state: DataAzurermPrivateDnsResolverForwardingRuleState<Present, Present>) : azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRule =
            let config = azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsResolverForwardingRule: missing required arguments. Must call: dns_forwarding_ruleset_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsResolverForwardingRuleState<_, _>) : azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRule =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsResolverForwardingRule.DataAzurermPrivateDnsResolverForwardingRule>
