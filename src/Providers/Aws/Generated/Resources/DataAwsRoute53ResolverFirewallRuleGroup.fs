namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverFirewallRuleGroupState<'FirewallRuleGroupId> = { assignments: ResizeArray<aws.DataAwsRoute53ResolverFirewallRuleGroup.DataAwsRoute53ResolverFirewallRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rule_group">aws_route53_resolver_firewall_rule_group</a>.
    /// </summary>
    type DataAwsRoute53ResolverFirewallRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverFirewallRuleGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallRuleGroupState<Missing>)

        member _.Zero(()) : DataAwsRoute53ResolverFirewallRuleGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallRuleGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rule_group#firewall_rule_group_id-1">DataAwsRoute53ResolverFirewallRuleGroup#firewall_rule_group_id</a>.
        /// </summary>
        [<CustomOperation "firewall_rule_group_id">]
        member _.FirewallRuleGroupId(state: DataAwsRoute53ResolverFirewallRuleGroupState<Missing>, value: string) : DataAwsRoute53ResolverFirewallRuleGroupState<Present> =
            state.assignments.Add(fun config -> config.FirewallRuleGroupId <- value)
            ({ assignments = state.assignments } : DataAwsRoute53ResolverFirewallRuleGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rule_group#id-1">DataAwsRoute53ResolverFirewallRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverFirewallRuleGroupState<'FirewallRuleGroupId>, value: string) : DataAwsRoute53ResolverFirewallRuleGroupState<'FirewallRuleGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverFirewallRuleGroupState<'FirewallRuleGroupId>

        member _.Run(state: DataAwsRoute53ResolverFirewallRuleGroupState<Present>) : aws.DataAwsRoute53ResolverFirewallRuleGroup.DataAwsRoute53ResolverFirewallRuleGroup =
            let config = aws.DataAwsRoute53ResolverFirewallRuleGroup.DataAwsRoute53ResolverFirewallRuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverFirewallRuleGroup.DataAwsRoute53ResolverFirewallRuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53ResolverFirewallRuleGroup: missing required arguments. Must call: firewall_rule_group_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53ResolverFirewallRuleGroupState<_>) : aws.DataAwsRoute53ResolverFirewallRuleGroup.DataAwsRoute53ResolverFirewallRuleGroup =
            Unchecked.defaultof<aws.DataAwsRoute53ResolverFirewallRuleGroup.DataAwsRoute53ResolverFirewallRuleGroup>
