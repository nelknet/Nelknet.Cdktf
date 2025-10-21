namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> = { assignments: ResizeArray<aws.Route53ResolverFirewallRule.Route53ResolverFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule">aws_route53_resolver_firewall_rule</a>.
    /// </summary>
    type Route53ResolverFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Route53ResolverFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#action-1">Route53ResolverFirewallRule#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: Route53ResolverFirewallRuleState<Missing, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<Present, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleState<Present, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#firewall_domain_list_id-1">Route53ResolverFirewallRule#firewall_domain_list_id</a>.
        /// </summary>
        [<CustomOperation "firewall_domain_list_id">]
        member _.FirewallDomainListId(state: Route53ResolverFirewallRuleState<'Action, Missing, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, Present, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.FirewallDomainListId <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleState<'Action, Present, 'FirewallRuleGroupId, 'Name, 'Priority>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#firewall_rule_group_id-1">Route53ResolverFirewallRule#firewall_rule_group_id</a>.
        /// </summary>
        [<CustomOperation "firewall_rule_group_id">]
        member _.FirewallRuleGroupId(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, Missing, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, Present, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.FirewallRuleGroupId <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, Present, 'Name, 'Priority>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#name-1">Route53ResolverFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, Missing, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, Present, 'Priority> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, Present, 'Priority>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#priority-1">Route53ResolverFirewallRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, Missing>, value: double) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#block_override_dns_type-1">Route53ResolverFirewallRule#block_override_dns_type</a>.
        /// </summary>
        [<CustomOperation "block_override_dns_type">]
        member _.BlockOverrideDnsType(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.BlockOverrideDnsType <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#block_override_domain-1">Route53ResolverFirewallRule#block_override_domain</a>.
        /// </summary>
        [<CustomOperation "block_override_domain">]
        member _.BlockOverrideDomain(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.BlockOverrideDomain <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#block_override_ttl-1">Route53ResolverFirewallRule#block_override_ttl</a>.
        /// </summary>
        [<CustomOperation "block_override_ttl">]
        member _.BlockOverrideTtl(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: double) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.BlockOverrideTtl <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#block_response-1">Route53ResolverFirewallRule#block_response</a>.
        /// </summary>
        [<CustomOperation "block_response">]
        member _.BlockResponse(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.BlockResponse <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#firewall_domain_redirection_action-1">Route53ResolverFirewallRule#firewall_domain_redirection_action</a>.
        /// </summary>
        [<CustomOperation "firewall_domain_redirection_action">]
        member _.FirewallDomainRedirectionAction(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.FirewallDomainRedirectionAction <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#id-1">Route53ResolverFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule#q_type-1">Route53ResolverFirewallRule#q_type</a>.
        /// </summary>
        [<CustomOperation "q_type">]
        member _.QType(state: Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>, value: string) : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.QType <- value)
            state : Route53ResolverFirewallRuleState<'Action, 'FirewallDomainListId, 'FirewallRuleGroupId, 'Name, 'Priority>

        member _.Run(state: Route53ResolverFirewallRuleState<Present, Present, Present, Present, Present>) : aws.Route53ResolverFirewallRule.Route53ResolverFirewallRule =
            let config = aws.Route53ResolverFirewallRule.Route53ResolverFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverFirewallRule.Route53ResolverFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverFirewallRule: missing required arguments. Must call: action, firewall_domain_list_id, firewall_rule_group_id, name, priority.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverFirewallRuleState<_, _, _, _, _>) : aws.Route53ResolverFirewallRule.Route53ResolverFirewallRule =
            Unchecked.defaultof<aws.Route53ResolverFirewallRule.Route53ResolverFirewallRule>
