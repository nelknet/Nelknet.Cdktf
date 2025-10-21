namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontResponseHeadersPolicyState<'Name> = { assignments: ResizeArray<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy">aws_cloudfront_response_headers_policy</a>.
    /// </summary>
    type CloudfrontResponseHeadersPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontResponseHeadersPolicyState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontResponseHeadersPolicyState<Missing>)

        member _.Zero(()) : CloudfrontResponseHeadersPolicyState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontResponseHeadersPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#name-1">CloudfrontResponseHeadersPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontResponseHeadersPolicyState<Missing>, value: string) : CloudfrontResponseHeadersPolicyState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontResponseHeadersPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#comment-1">CloudfrontResponseHeadersPolicy#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontResponseHeadersPolicyState<'Name>, value: string) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// cors_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#cors_config-1">CloudfrontResponseHeadersPolicy#cors_config</a>
        /// </summary>
        [<CustomOperation "cors_config">]
        member _.CorsConfig(state: CloudfrontResponseHeadersPolicyState<'Name>, value: aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfig) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.CorsConfig <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// custom_headers_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#custom_headers_config-1">CloudfrontResponseHeadersPolicy#custom_headers_config</a>
        /// </summary>
        [<CustomOperation "custom_headers_config">]
        member _.CustomHeadersConfig(state: CloudfrontResponseHeadersPolicyState<'Name>, value: aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCustomHeadersConfig) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.CustomHeadersConfig <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#etag-1">CloudfrontResponseHeadersPolicy#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: CloudfrontResponseHeadersPolicyState<'Name>, value: string) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#id-1">CloudfrontResponseHeadersPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontResponseHeadersPolicyState<'Name>, value: string) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// remove_headers_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#remove_headers_config-1">CloudfrontResponseHeadersPolicy#remove_headers_config</a>
        /// </summary>
        [<CustomOperation "remove_headers_config">]
        member _.RemoveHeadersConfig(state: CloudfrontResponseHeadersPolicyState<'Name>, value: aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyRemoveHeadersConfig) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.RemoveHeadersConfig <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// security_headers_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#security_headers_config-1">CloudfrontResponseHeadersPolicy#security_headers_config</a>
        /// </summary>
        [<CustomOperation "security_headers_config">]
        member _.SecurityHeadersConfig(state: CloudfrontResponseHeadersPolicyState<'Name>, value: aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfig) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.SecurityHeadersConfig <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        /// <summary>
        /// server_timing_headers_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#server_timing_headers_config-1">CloudfrontResponseHeadersPolicy#server_timing_headers_config</a>
        /// </summary>
        [<CustomOperation "server_timing_headers_config">]
        member _.ServerTimingHeadersConfig(state: CloudfrontResponseHeadersPolicyState<'Name>, value: aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyServerTimingHeadersConfig) : CloudfrontResponseHeadersPolicyState<'Name> =
            state.assignments.Add(fun config -> config.ServerTimingHeadersConfig <- value)
            state : CloudfrontResponseHeadersPolicyState<'Name>

        member _.Run(state: CloudfrontResponseHeadersPolicyState<Present>) : aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicy =
            let config = aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontResponseHeadersPolicy: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontResponseHeadersPolicyState<_>) : aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicy =
            Unchecked.defaultof<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicy>
