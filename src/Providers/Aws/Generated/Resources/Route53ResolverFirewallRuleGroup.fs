namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverFirewallRuleGroupState<'Name> = { assignments: ResizeArray<aws.Route53ResolverFirewallRuleGroup.Route53ResolverFirewallRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group">aws_route53_resolver_firewall_rule_group</a>.
    /// </summary>
    type Route53ResolverFirewallRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverFirewallRuleGroupState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallRuleGroupState<Missing>)

        member _.Zero(()) : Route53ResolverFirewallRuleGroupState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallRuleGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group#name-1">Route53ResolverFirewallRuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverFirewallRuleGroupState<Missing>, value: string) : Route53ResolverFirewallRuleGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group#id-1">Route53ResolverFirewallRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverFirewallRuleGroupState<'Name>, value: string) : Route53ResolverFirewallRuleGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverFirewallRuleGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group#tags-1">Route53ResolverFirewallRuleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ResolverFirewallRuleGroupState<'Name>, value: seq<string * string>) : Route53ResolverFirewallRuleGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ResolverFirewallRuleGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group#tags_all-1">Route53ResolverFirewallRuleGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ResolverFirewallRuleGroupState<'Name>, value: seq<string * string>) : Route53ResolverFirewallRuleGroupState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ResolverFirewallRuleGroupState<'Name>

        member _.Run(state: Route53ResolverFirewallRuleGroupState<Present>) : aws.Route53ResolverFirewallRuleGroup.Route53ResolverFirewallRuleGroup =
            let config = aws.Route53ResolverFirewallRuleGroup.Route53ResolverFirewallRuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverFirewallRuleGroup.Route53ResolverFirewallRuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverFirewallRuleGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverFirewallRuleGroupState<_>) : aws.Route53ResolverFirewallRuleGroup.Route53ResolverFirewallRuleGroup =
            Unchecked.defaultof<aws.Route53ResolverFirewallRuleGroup.Route53ResolverFirewallRuleGroup>
