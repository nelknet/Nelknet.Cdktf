namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId> = { assignments: ResizeArray<aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule_association">aws_route53_resolver_rule_association</a>.
    /// </summary>
    type Route53ResolverRuleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverRuleAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverRuleAssociationState<Missing, Missing>)

        member _.Zero(()) : Route53ResolverRuleAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverRuleAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule_association#resolver_rule_id-1">Route53ResolverRuleAssociation#resolver_rule_id</a>.
        /// </summary>
        [<CustomOperation "resolver_rule_id">]
        member _.ResolverRuleId(state: Route53ResolverRuleAssociationState<Missing, 'VpcId>, value: string) : Route53ResolverRuleAssociationState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.ResolverRuleId <- value)
            ({ assignments = state.assignments } : Route53ResolverRuleAssociationState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule_association#vpc_id-1">Route53ResolverRuleAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Route53ResolverRuleAssociationState<'ResolverRuleId, Missing>, value: string) : Route53ResolverRuleAssociationState<'ResolverRuleId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Route53ResolverRuleAssociationState<'ResolverRuleId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule_association#id-1">Route53ResolverRuleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId>, value: string) : Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule_association#name-1">Route53ResolverRuleAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId>, value: string) : Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule_association#timeouts-1">Route53ResolverRuleAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId>, value: aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociationTimeouts) : Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ResolverRuleAssociationState<'ResolverRuleId, 'VpcId>

        member _.Run(state: Route53ResolverRuleAssociationState<Present, Present>) : aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociation =
            let config = aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverRuleAssociation: missing required arguments. Must call: resolver_rule_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverRuleAssociationState<_, _>) : aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociation =
            Unchecked.defaultof<aws.Route53ResolverRuleAssociation.Route53ResolverRuleAssociation>
