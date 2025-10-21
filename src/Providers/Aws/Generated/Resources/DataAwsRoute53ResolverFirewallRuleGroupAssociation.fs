namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupAssociationId> = { assignments: ResizeArray<aws.DataAwsRoute53ResolverFirewallRuleGroupAssociation.DataAwsRoute53ResolverFirewallRuleGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rule_group_association">aws_route53_resolver_firewall_rule_group_association</a>.
    /// </summary>
    type DataAwsRoute53ResolverFirewallRuleGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Missing>)

        member _.Zero(()) : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rule_group_association#firewall_rule_group_association_id-1">DataAwsRoute53ResolverFirewallRuleGroupAssociation#firewall_rule_group_association_id</a>.
        /// </summary>
        [<CustomOperation "firewall_rule_group_association_id">]
        member _.FirewallRuleGroupAssociationId(state: DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Missing>, value: string) : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Present> =
            state.assignments.Add(fun config -> config.FirewallRuleGroupAssociationId <- value)
            ({ assignments = state.assignments } : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_rule_group_association#id-1">DataAwsRoute53ResolverFirewallRuleGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupAssociationId>, value: string) : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupAssociationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverFirewallRuleGroupAssociationState<'FirewallRuleGroupAssociationId>

        member _.Run(state: DataAwsRoute53ResolverFirewallRuleGroupAssociationState<Present>) : aws.DataAwsRoute53ResolverFirewallRuleGroupAssociation.DataAwsRoute53ResolverFirewallRuleGroupAssociation =
            let config = aws.DataAwsRoute53ResolverFirewallRuleGroupAssociation.DataAwsRoute53ResolverFirewallRuleGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverFirewallRuleGroupAssociation.DataAwsRoute53ResolverFirewallRuleGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53ResolverFirewallRuleGroupAssociation: missing required arguments. Must call: firewall_rule_group_association_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53ResolverFirewallRuleGroupAssociationState<_>) : aws.DataAwsRoute53ResolverFirewallRuleGroupAssociation.DataAwsRoute53ResolverFirewallRuleGroupAssociation =
            Unchecked.defaultof<aws.DataAwsRoute53ResolverFirewallRuleGroupAssociation.DataAwsRoute53ResolverFirewallRuleGroupAssociation>
