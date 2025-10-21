namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverQueryLogConfigState<'DestinationArn, 'Name> = { assignments: ResizeArray<aws.Route53ResolverQueryLogConfig.Route53ResolverQueryLogConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config">aws_route53_resolver_query_log_config</a>.
    /// </summary>
    type Route53ResolverQueryLogConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverQueryLogConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverQueryLogConfigState<Missing, Missing>)

        member _.Zero(()) : Route53ResolverQueryLogConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverQueryLogConfigState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config#destination_arn-1">Route53ResolverQueryLogConfig#destination_arn</a>.
        /// </summary>
        [<CustomOperation "destination_arn">]
        member _.DestinationArn(state: Route53ResolverQueryLogConfigState<Missing, 'Name>, value: string) : Route53ResolverQueryLogConfigState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DestinationArn <- value)
            ({ assignments = state.assignments } : Route53ResolverQueryLogConfigState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config#name-1">Route53ResolverQueryLogConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverQueryLogConfigState<'DestinationArn, Missing>, value: string) : Route53ResolverQueryLogConfigState<'DestinationArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ResolverQueryLogConfigState<'DestinationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config#id-1">Route53ResolverQueryLogConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverQueryLogConfigState<'DestinationArn, 'Name>, value: string) : Route53ResolverQueryLogConfigState<'DestinationArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverQueryLogConfigState<'DestinationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config#tags-1">Route53ResolverQueryLogConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ResolverQueryLogConfigState<'DestinationArn, 'Name>, value: seq<string * string>) : Route53ResolverQueryLogConfigState<'DestinationArn, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ResolverQueryLogConfigState<'DestinationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config#tags_all-1">Route53ResolverQueryLogConfig#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ResolverQueryLogConfigState<'DestinationArn, 'Name>, value: seq<string * string>) : Route53ResolverQueryLogConfigState<'DestinationArn, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ResolverQueryLogConfigState<'DestinationArn, 'Name>

        member _.Run(state: Route53ResolverQueryLogConfigState<Present, Present>) : aws.Route53ResolverQueryLogConfig.Route53ResolverQueryLogConfig =
            let config = aws.Route53ResolverQueryLogConfig.Route53ResolverQueryLogConfigConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverQueryLogConfig.Route53ResolverQueryLogConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverQueryLogConfig: missing required arguments. Must call: destination_arn, name.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverQueryLogConfigState<_, _>) : aws.Route53ResolverQueryLogConfig.Route53ResolverQueryLogConfig =
            Unchecked.defaultof<aws.Route53ResolverQueryLogConfig.Route53ResolverQueryLogConfig>
