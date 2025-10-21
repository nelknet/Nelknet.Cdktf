namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId> = { assignments: ResizeArray<aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRulesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rules">aws_route53_resolver_firewall_rules</a>.
    /// </summary>
    type DataAwsRoute53ResolverFirewallRulesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverFirewallRulesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallRulesState<Missing>)

        member _.Zero(()) : DataAwsRoute53ResolverFirewallRulesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallRulesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rules#firewall_rule_group_id-1">DataAwsRoute53ResolverFirewallRules#firewall_rule_group_id</a>.
        /// </summary>
        [<CustomOperation "firewall_rule_group_id">]
        member _.FirewallRuleGroupId(state: DataAwsRoute53ResolverFirewallRulesState<Missing>, value: string) : DataAwsRoute53ResolverFirewallRulesState<Present> =
            state.assignments.Add(fun config -> config.FirewallRuleGroupId <- value)
            ({ assignments = state.assignments } : DataAwsRoute53ResolverFirewallRulesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rules#action-1">DataAwsRoute53ResolverFirewallRules#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId>, value: string) : DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rules#id-1">DataAwsRoute53ResolverFirewallRules#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId>, value: string) : DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rules#priority-1">DataAwsRoute53ResolverFirewallRules#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId>, value: double) : DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : DataAwsRoute53ResolverFirewallRulesState<'FirewallRuleGroupId>

        member _.Run(state: DataAwsRoute53ResolverFirewallRulesState<Present>) : aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRules =
            let config = aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRulesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRules(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53ResolverFirewallRules: missing required arguments. Must call: firewall_rule_group_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53ResolverFirewallRulesState<_>) : aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRules =
            Unchecked.defaultof<aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRules>
