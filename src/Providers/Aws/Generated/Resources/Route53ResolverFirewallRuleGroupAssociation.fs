namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId> = { assignments: ResizeArray<aws.Route53ResolverFirewallRuleGroupAssociation.Route53ResolverFirewallRuleGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association">aws_route53_resolver_firewall_rule_group_association</a>.
    /// </summary>
    type Route53ResolverFirewallRuleGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverFirewallRuleGroupAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallRuleGroupAssociationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Route53ResolverFirewallRuleGroupAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallRuleGroupAssociationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#firewall_rule_group_id-1">Route53ResolverFirewallRuleGroupAssociation#firewall_rule_group_id</a>.
        /// </summary>
        [<CustomOperation "firewall_rule_group_id">]
        member _.FirewallRuleGroupId(state: Route53ResolverFirewallRuleGroupAssociationState<Missing, 'Name, 'Priority, 'VpcId>, value: string) : Route53ResolverFirewallRuleGroupAssociationState<Present, 'Name, 'Priority, 'VpcId> =
            state.assignments.Add(fun config -> config.FirewallRuleGroupId <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleGroupAssociationState<Present, 'Name, 'Priority, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#name-1">Route53ResolverFirewallRuleGroupAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, Missing, 'Priority, 'VpcId>, value: string) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, Present, 'Priority, 'VpcId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, Present, 'Priority, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#priority-1">Route53ResolverFirewallRuleGroupAssociation#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, Missing, 'VpcId>, value: double) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#vpc_id-1">Route53ResolverFirewallRuleGroupAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, Missing>, value: string) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#id-1">Route53ResolverFirewallRuleGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>, value: string) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#mutation_protection-1">Route53ResolverFirewallRuleGroupAssociation#mutation_protection</a>.
        /// </summary>
        [<CustomOperation "mutation_protection">]
        member _.MutationProtection(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>, value: string) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId> =
            state.assignments.Add(fun config -> config.MutationProtection <- value)
            state : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#tags-1">Route53ResolverFirewallRuleGroupAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>, value: seq<string * string>) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_rule_group_association#tags_all-1">Route53ResolverFirewallRuleGroupAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>, value: seq<string * string>) : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupId, 'Name, 'Priority, 'VpcId>

        member _.Run(state: Route53ResolverFirewallRuleGroupAssociationState<Present, Present, Present, Present>) : aws.Route53ResolverFirewallRuleGroupAssociation.Route53ResolverFirewallRuleGroupAssociation =
            let config = aws.Route53ResolverFirewallRuleGroupAssociation.Route53ResolverFirewallRuleGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverFirewallRuleGroupAssociation.Route53ResolverFirewallRuleGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverFirewallRuleGroupAssociation: missing required arguments. Must call: firewall_rule_group_id, name, priority, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverFirewallRuleGroupAssociationState<_, _, _, _>) : aws.Route53ResolverFirewallRuleGroupAssociation.Route53ResolverFirewallRuleGroupAssociation =
            Unchecked.defaultof<aws.Route53ResolverFirewallRuleGroupAssociation.Route53ResolverFirewallRuleGroupAssociation>
