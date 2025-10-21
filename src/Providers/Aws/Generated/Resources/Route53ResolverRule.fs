namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverRuleState<'DomainName, 'RuleType> = { assignments: ResizeArray<aws.Route53ResolverRule.Route53ResolverRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule">aws_route53_resolver_rule</a>.
    /// </summary>
    type Route53ResolverRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverRuleState<Missing, Missing>)

        member _.Zero(()) : Route53ResolverRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#domain_name-1">Route53ResolverRule#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Route53ResolverRuleState<Missing, 'RuleType>, value: string) : Route53ResolverRuleState<Present, 'RuleType> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Route53ResolverRuleState<Present, 'RuleType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#rule_type-1">Route53ResolverRule#rule_type</a>.
        /// </summary>
        [<CustomOperation "rule_type">]
        member _.RuleType(state: Route53ResolverRuleState<'DomainName, Missing>, value: string) : Route53ResolverRuleState<'DomainName, Present> =
            state.assignments.Add(fun config -> config.RuleType <- value)
            ({ assignments = state.assignments } : Route53ResolverRuleState<'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#id-1">Route53ResolverRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: string) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#name-1">Route53ResolverRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: string) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#resolver_endpoint_id-1">Route53ResolverRule#resolver_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "resolver_endpoint_id">]
        member _.ResolverEndpointId(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: string) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.ResolverEndpointId <- value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#tags-1">Route53ResolverRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: seq<string * string>) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#tags_all-1">Route53ResolverRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: seq<string * string>) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        /// <summary>
        /// target_ip block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#target_ip-1">Route53ResolverRule#target_ip</a> Accepts: aws.IResolvable | aws.Route53ResolverRule.Route53ResolverRuleTargetIp[]
        /// </summary>
        [<CustomOperation "target_ip">]
        member _.TargetIp(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: HashiCorp.Cdktf.IResolvable) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.TargetIp <- value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_rule#timeouts-1">Route53ResolverRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ResolverRuleState<'DomainName, 'RuleType>, value: aws.Route53ResolverRule.Route53ResolverRuleTimeouts) : Route53ResolverRuleState<'DomainName, 'RuleType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ResolverRuleState<'DomainName, 'RuleType>

        member _.Run(state: Route53ResolverRuleState<Present, Present>) : aws.Route53ResolverRule.Route53ResolverRule =
            let config = aws.Route53ResolverRule.Route53ResolverRuleConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverRule.Route53ResolverRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverRule: missing required arguments. Must call: domain_name, rule_type.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverRuleState<_, _>) : aws.Route53ResolverRule.Route53ResolverRule =
            Unchecked.defaultof<aws.Route53ResolverRule.Route53ResolverRule>
