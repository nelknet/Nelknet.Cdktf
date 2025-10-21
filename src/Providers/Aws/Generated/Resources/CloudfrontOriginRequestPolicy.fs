namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig> = { assignments: ResizeArray<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy">aws_cloudfront_origin_request_policy</a>.
    /// </summary>
    type CloudfrontOriginRequestPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontOriginRequestPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontOriginRequestPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudfrontOriginRequestPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontOriginRequestPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// cookies_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#cookies_config-1">CloudfrontOriginRequestPolicy#cookies_config</a>
        /// </summary>
        [<CustomOperation "cookies_config">]
        member _.CookiesConfig(state: CloudfrontOriginRequestPolicyState<Missing, 'HeadersConfig, 'Name, 'QueryStringsConfig>, value: aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfig) : CloudfrontOriginRequestPolicyState<Present, 'HeadersConfig, 'Name, 'QueryStringsConfig> =
            state.assignments.Add(fun config -> config.CookiesConfig <- value)
            ({ assignments = state.assignments } : CloudfrontOriginRequestPolicyState<Present, 'HeadersConfig, 'Name, 'QueryStringsConfig>)

        /// <summary>
        /// headers_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#headers_config-1">CloudfrontOriginRequestPolicy#headers_config</a>
        /// </summary>
        [<CustomOperation "headers_config">]
        member _.HeadersConfig(state: CloudfrontOriginRequestPolicyState<'CookiesConfig, Missing, 'Name, 'QueryStringsConfig>, value: aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfig) : CloudfrontOriginRequestPolicyState<'CookiesConfig, Present, 'Name, 'QueryStringsConfig> =
            state.assignments.Add(fun config -> config.HeadersConfig <- value)
            ({ assignments = state.assignments } : CloudfrontOriginRequestPolicyState<'CookiesConfig, Present, 'Name, 'QueryStringsConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#name-1">CloudfrontOriginRequestPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, Missing, 'QueryStringsConfig>, value: string) : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, Present, 'QueryStringsConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, Present, 'QueryStringsConfig>)

        /// <summary>
        /// query_strings_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_strings_config-1">CloudfrontOriginRequestPolicy#query_strings_config</a>
        /// </summary>
        [<CustomOperation "query_strings_config">]
        member _.QueryStringsConfig(state: CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, Missing>, value: aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig) : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, Present> =
            state.assignments.Add(fun config -> config.QueryStringsConfig <- value)
            ({ assignments = state.assignments } : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#comment-1">CloudfrontOriginRequestPolicy#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig>, value: string) : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#id-1">CloudfrontOriginRequestPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig>, value: string) : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontOriginRequestPolicyState<'CookiesConfig, 'HeadersConfig, 'Name, 'QueryStringsConfig>

        member _.Run(state: CloudfrontOriginRequestPolicyState<Present, Present, Present, Present>) : aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy =
            let config = aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontOriginRequestPolicy: missing required arguments. Must call: cookies_config, headers_config, name, query_strings_config.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontOriginRequestPolicyState<_, _, _, _>) : aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy =
            Unchecked.defaultof<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy>
