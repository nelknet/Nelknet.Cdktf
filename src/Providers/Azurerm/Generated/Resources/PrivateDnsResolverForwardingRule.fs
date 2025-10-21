namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers> = { assignments: ResizeArray<azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule">azurerm_private_dns_resolver_forwarding_rule</a>.
    /// </summary>
    type PrivateDnsResolverForwardingRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsResolverForwardingRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverForwardingRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsResolverForwardingRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverForwardingRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#dns_forwarding_ruleset_id-1">PrivateDnsResolverForwardingRule#dns_forwarding_ruleset_id</a>.
        /// </summary>
        [<CustomOperation "dns_forwarding_ruleset_id">]
        member _.DnsForwardingRulesetId(state: PrivateDnsResolverForwardingRuleState<Missing, 'DomainName, 'Name, 'TargetDnsServers>, value: string) : PrivateDnsResolverForwardingRuleState<Present, 'DomainName, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.DnsForwardingRulesetId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverForwardingRuleState<Present, 'DomainName, 'Name, 'TargetDnsServers>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#domain_name-1">PrivateDnsResolverForwardingRule#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, Missing, 'Name, 'TargetDnsServers>, value: string) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, Present, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, Present, 'Name, 'TargetDnsServers>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#name-1">PrivateDnsResolverForwardingRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, Missing, 'TargetDnsServers>, value: string) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, Present, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, Present, 'TargetDnsServers>)

        /// <summary>
        /// target_dns_servers block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#target_dns_servers-1">PrivateDnsResolverForwardingRule#target_dns_servers</a> Accepts: azurerm.IResolvable | azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRuleTargetDnsServers[]
        /// </summary>
        [<CustomOperation "target_dns_servers">]
        member _.TargetDnsServers(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, Present> =
            state.assignments.Add(fun config -> config.TargetDnsServers <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#enabled-1">PrivateDnsResolverForwardingRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>, value: bool) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#enabled-1">PrivateDnsResolverForwardingRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>, value: HashiCorp.Cdktf.IResolvable) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#id-1">PrivateDnsResolverForwardingRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>, value: string) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#metadata-1">PrivateDnsResolverForwardingRule#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>, value: seq<string * string>) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_forwarding_rule#timeouts-1">PrivateDnsResolverForwardingRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>, value: azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRuleTimeouts) : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsResolverForwardingRuleState<'DnsForwardingRulesetId, 'DomainName, 'Name, 'TargetDnsServers>

        member _.Run(state: PrivateDnsResolverForwardingRuleState<Present, Present, Present, Present>) : azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRule =
            let config = azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsResolverForwardingRule: missing required arguments. Must call: dns_forwarding_ruleset_id, domain_name, name, target_dns_servers.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsResolverForwardingRuleState<_, _, _, _>) : azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRule =
            Unchecked.defaultof<azurerm.PrivateDnsResolverForwardingRule.PrivateDnsResolverForwardingRule>
