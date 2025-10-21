namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontCachePolicyState = { assignments: ResizeArray<aws.DataAwsCloudfrontCachePolicy.DataAwsCloudfrontCachePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_cache_policy">aws_cloudfront_cache_policy</a>.
    /// </summary>
    type DataAwsCloudfrontCachePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontCachePolicyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudfrontCachePolicyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_cache_policy#id-1">DataAwsCloudfrontCachePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontCachePolicyState, value: string) : DataAwsCloudfrontCachePolicyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontCachePolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_cache_policy#name-1">DataAwsCloudfrontCachePolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudfrontCachePolicyState, value: string) : DataAwsCloudfrontCachePolicyState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsCloudfrontCachePolicyState

        member _.Run(state: DataAwsCloudfrontCachePolicyState) : aws.DataAwsCloudfrontCachePolicy.DataAwsCloudfrontCachePolicy =
            let config = aws.DataAwsCloudfrontCachePolicy.DataAwsCloudfrontCachePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontCachePolicy.DataAwsCloudfrontCachePolicy(StackContext.get (), logicalId, config)
