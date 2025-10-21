namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverQueryLogConfigState = { assignments: ResizeArray<aws.DataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config">aws_route53_resolver_query_log_config</a>.
    /// </summary>
    type DataAwsRoute53ResolverQueryLogConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverQueryLogConfigState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ResolverQueryLogConfigState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#filter-1">DataAwsRoute53ResolverQueryLogConfig#filter</a> Accepts: aws.IResolvable | aws.DataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfigFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRoute53ResolverQueryLogConfigState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRoute53ResolverQueryLogConfigState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRoute53ResolverQueryLogConfigState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#id-1">DataAwsRoute53ResolverQueryLogConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverQueryLogConfigState, value: string) : DataAwsRoute53ResolverQueryLogConfigState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverQueryLogConfigState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#name-1">DataAwsRoute53ResolverQueryLogConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRoute53ResolverQueryLogConfigState, value: string) : DataAwsRoute53ResolverQueryLogConfigState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsRoute53ResolverQueryLogConfigState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#resolver_query_log_config_id-1">DataAwsRoute53ResolverQueryLogConfig#resolver_query_log_config_id</a>.
        /// </summary>
        [<CustomOperation "resolver_query_log_config_id">]
        member _.ResolverQueryLogConfigId(state: DataAwsRoute53ResolverQueryLogConfigState, value: string) : DataAwsRoute53ResolverQueryLogConfigState =
            state.assignments.Add(fun config -> config.ResolverQueryLogConfigId <- value)
            state : DataAwsRoute53ResolverQueryLogConfigState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#tags-1">DataAwsRoute53ResolverQueryLogConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRoute53ResolverQueryLogConfigState, value: seq<string * string>) : DataAwsRoute53ResolverQueryLogConfigState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRoute53ResolverQueryLogConfigState

        member _.Run(state: DataAwsRoute53ResolverQueryLogConfigState) : aws.DataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfig =
            let config = aws.DataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfig(StackContext.get (), logicalId, config)
