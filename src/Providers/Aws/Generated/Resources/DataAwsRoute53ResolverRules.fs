namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverRulesState = { assignments: ResizeArray<aws.DataAwsRoute53ResolverRules.DataAwsRoute53ResolverRulesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules">aws_route53_resolver_rules</a>.
    /// </summary>
    type DataAwsRoute53ResolverRulesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverRulesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ResolverRulesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules#id-1">DataAwsRoute53ResolverRules#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverRulesState, value: string) : DataAwsRoute53ResolverRulesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverRulesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules#name_regex-1">DataAwsRoute53ResolverRules#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsRoute53ResolverRulesState, value: string) : DataAwsRoute53ResolverRulesState =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsRoute53ResolverRulesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules#owner_id-1">DataAwsRoute53ResolverRules#owner_id</a>.
        /// </summary>
        [<CustomOperation "owner_id">]
        member _.OwnerId(state: DataAwsRoute53ResolverRulesState, value: string) : DataAwsRoute53ResolverRulesState =
            state.assignments.Add(fun config -> config.OwnerId <- value)
            state : DataAwsRoute53ResolverRulesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules#resolver_endpoint_id-1">DataAwsRoute53ResolverRules#resolver_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "resolver_endpoint_id">]
        member _.ResolverEndpointId(state: DataAwsRoute53ResolverRulesState, value: string) : DataAwsRoute53ResolverRulesState =
            state.assignments.Add(fun config -> config.ResolverEndpointId <- value)
            state : DataAwsRoute53ResolverRulesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules#rule_type-1">DataAwsRoute53ResolverRules#rule_type</a>.
        /// </summary>
        [<CustomOperation "rule_type">]
        member _.RuleType(state: DataAwsRoute53ResolverRulesState, value: string) : DataAwsRoute53ResolverRulesState =
            state.assignments.Add(fun config -> config.RuleType <- value)
            state : DataAwsRoute53ResolverRulesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_rules#share_status-1">DataAwsRoute53ResolverRules#share_status</a>.
        /// </summary>
        [<CustomOperation "share_status">]
        member _.ShareStatus(state: DataAwsRoute53ResolverRulesState, value: string) : DataAwsRoute53ResolverRulesState =
            state.assignments.Add(fun config -> config.ShareStatus <- value)
            state : DataAwsRoute53ResolverRulesState

        member _.Run(state: DataAwsRoute53ResolverRulesState) : aws.DataAwsRoute53ResolverRules.DataAwsRoute53ResolverRules =
            let config = aws.DataAwsRoute53ResolverRules.DataAwsRoute53ResolverRulesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverRules.DataAwsRoute53ResolverRules(StackContext.get (), logicalId, config)
