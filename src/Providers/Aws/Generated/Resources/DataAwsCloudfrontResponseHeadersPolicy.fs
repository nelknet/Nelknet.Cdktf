namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontResponseHeadersPolicyState = { assignments: ResizeArray<aws.DataAwsCloudfrontResponseHeadersPolicy.DataAwsCloudfrontResponseHeadersPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_response_headers_policy">aws_cloudfront_response_headers_policy</a>.
    /// </summary>
    type DataAwsCloudfrontResponseHeadersPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontResponseHeadersPolicyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudfrontResponseHeadersPolicyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_response_headers_policy#id-1">DataAwsCloudfrontResponseHeadersPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontResponseHeadersPolicyState, value: string) : DataAwsCloudfrontResponseHeadersPolicyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontResponseHeadersPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_response_headers_policy#name-1">DataAwsCloudfrontResponseHeadersPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudfrontResponseHeadersPolicyState, value: string) : DataAwsCloudfrontResponseHeadersPolicyState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsCloudfrontResponseHeadersPolicyState

        member _.Run(state: DataAwsCloudfrontResponseHeadersPolicyState) : aws.DataAwsCloudfrontResponseHeadersPolicy.DataAwsCloudfrontResponseHeadersPolicy =
            let config = aws.DataAwsCloudfrontResponseHeadersPolicy.DataAwsCloudfrontResponseHeadersPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontResponseHeadersPolicy.DataAwsCloudfrontResponseHeadersPolicy(StackContext.get (), logicalId, config)
