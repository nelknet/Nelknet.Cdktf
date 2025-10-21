namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverRuleState = { assignments: ResizeArray<aws.DataAwsRoute53ResolverRule.DataAwsRoute53ResolverRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule">aws_route53_resolver_rule</a>.
    /// </summary>
    type DataAwsRoute53ResolverRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverRuleState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ResolverRuleState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#domain_name-1">DataAwsRoute53ResolverRule#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DataAwsRoute53ResolverRuleState, value: string) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : DataAwsRoute53ResolverRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#id-1">DataAwsRoute53ResolverRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverRuleState, value: string) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#name-1">DataAwsRoute53ResolverRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRoute53ResolverRuleState, value: string) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsRoute53ResolverRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#resolver_endpoint_id-1">DataAwsRoute53ResolverRule#resolver_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "resolver_endpoint_id">]
        member _.ResolverEndpointId(state: DataAwsRoute53ResolverRuleState, value: string) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.ResolverEndpointId <- value)
            state : DataAwsRoute53ResolverRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#resolver_rule_id-1">DataAwsRoute53ResolverRule#resolver_rule_id</a>.
        /// </summary>
        [<CustomOperation "resolver_rule_id">]
        member _.ResolverRuleId(state: DataAwsRoute53ResolverRuleState, value: string) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.ResolverRuleId <- value)
            state : DataAwsRoute53ResolverRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#rule_type-1">DataAwsRoute53ResolverRule#rule_type</a>.
        /// </summary>
        [<CustomOperation "rule_type">]
        member _.RuleType(state: DataAwsRoute53ResolverRuleState, value: string) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.RuleType <- value)
            state : DataAwsRoute53ResolverRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rule#tags-1">DataAwsRoute53ResolverRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRoute53ResolverRuleState, value: seq<string * string>) : DataAwsRoute53ResolverRuleState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRoute53ResolverRuleState

        member _.Run(state: DataAwsRoute53ResolverRuleState) : aws.DataAwsRoute53ResolverRule.DataAwsRoute53ResolverRule =
            let config = aws.DataAwsRoute53ResolverRule.DataAwsRoute53ResolverRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverRule.DataAwsRoute53ResolverRule(StackContext.get (), logicalId, config)
