namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin> = { assignments: ResizeArray<aws.CloudfrontCachePolicy.CloudfrontCachePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy">aws_cloudfront_cache_policy</a>.
    /// </summary>
    type CloudfrontCachePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontCachePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontCachePolicyState<Missing, Missing>)

        member _.Zero(()) : CloudfrontCachePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontCachePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#name-1">CloudfrontCachePolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontCachePolicyState<Missing, 'ParametersInCacheKeyAndForwardedToOrigin>, value: string) : CloudfrontCachePolicyState<Present, 'ParametersInCacheKeyAndForwardedToOrigin> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontCachePolicyState<Present, 'ParametersInCacheKeyAndForwardedToOrigin>)

        /// <summary>
        /// parameters_in_cache_key_and_forwarded_to_origin block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#parameters_in_cache_key_and_forwarded_to_origin-1">CloudfrontCachePolicy#parameters_in_cache_key_and_forwarded_to_origin</a>
        /// </summary>
        [<CustomOperation "parameters_in_cache_key_and_forwarded_to_origin">]
        member _.ParametersInCacheKeyAndForwardedToOrigin(state: CloudfrontCachePolicyState<'Name, Missing>, value: aws.CloudfrontCachePolicy.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin) : CloudfrontCachePolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.ParametersInCacheKeyAndForwardedToOrigin <- value)
            ({ assignments = state.assignments } : CloudfrontCachePolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#comment-1">CloudfrontCachePolicy#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>, value: string) : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#default_ttl-1">CloudfrontCachePolicy#default_ttl</a>.
        /// </summary>
        [<CustomOperation "default_ttl">]
        member _.DefaultTtl(state: CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>, value: double) : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin> =
            state.assignments.Add(fun config -> config.DefaultTtl <- value)
            state : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#id-1">CloudfrontCachePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>, value: string) : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#max_ttl-1">CloudfrontCachePolicy#max_ttl</a>.
        /// </summary>
        [<CustomOperation "max_ttl">]
        member _.MaxTtl(state: CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>, value: double) : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin> =
            state.assignments.Add(fun config -> config.MaxTtl <- value)
            state : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#min_ttl-1">CloudfrontCachePolicy#min_ttl</a>.
        /// </summary>
        [<CustomOperation "min_ttl">]
        member _.MinTtl(state: CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>, value: double) : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin> =
            state.assignments.Add(fun config -> config.MinTtl <- value)
            state : CloudfrontCachePolicyState<'Name, 'ParametersInCacheKeyAndForwardedToOrigin>

        member _.Run(state: CloudfrontCachePolicyState<Present, Present>) : aws.CloudfrontCachePolicy.CloudfrontCachePolicy =
            let config = aws.CloudfrontCachePolicy.CloudfrontCachePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontCachePolicy.CloudfrontCachePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontCachePolicy: missing required arguments. Must call: name, parameters_in_cache_key_and_forwarded_to_origin.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontCachePolicyState<_, _>) : aws.CloudfrontCachePolicy.CloudfrontCachePolicy =
            Unchecked.defaultof<aws.CloudfrontCachePolicy.CloudfrontCachePolicy>
