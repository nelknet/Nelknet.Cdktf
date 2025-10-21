namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type> = { assignments: ResizeArray<aws.AppsyncApiCache.AppsyncApiCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache">aws_appsync_api_cache</a>.
    /// </summary>
    type AppsyncApiCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncApiCacheState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncApiCacheState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppsyncApiCacheState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncApiCacheState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#api_caching_behavior-1">AppsyncApiCache#api_caching_behavior</a>.
        /// </summary>
        [<CustomOperation "api_caching_behavior">]
        member _.ApiCachingBehavior(state: AppsyncApiCacheState<Missing, 'ApiId, 'Ttl, 'Type>, value: string) : AppsyncApiCacheState<Present, 'ApiId, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.ApiCachingBehavior <- value)
            ({ assignments = state.assignments } : AppsyncApiCacheState<Present, 'ApiId, 'Ttl, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#api_id-1">AppsyncApiCache#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncApiCacheState<'ApiCachingBehavior, Missing, 'Ttl, 'Type>, value: string) : AppsyncApiCacheState<'ApiCachingBehavior, Present, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncApiCacheState<'ApiCachingBehavior, Present, 'Ttl, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#ttl-1">AppsyncApiCache#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, Missing, 'Type>, value: double) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, Present, 'Type> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#type-1">AppsyncApiCache#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, Missing>, value: string) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#at_rest_encryption_enabled-1">AppsyncApiCache#at_rest_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "at_rest_encryption_enabled">]
        member _.AtRestEncryptionEnabled(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>, value: bool) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.AtRestEncryptionEnabled <- value)
            state : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#at_rest_encryption_enabled-1">AppsyncApiCache#at_rest_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "at_rest_encryption_enabled">]
        member _.AtRestEncryptionEnabled(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>, value: HashiCorp.Cdktf.IResolvable) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.AtRestEncryptionEnabled <- value)
            state : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#id-1">AppsyncApiCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>, value: string) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#transit_encryption_enabled-1">AppsyncApiCache#transit_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_encryption_enabled">]
        member _.TransitEncryptionEnabled(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>, value: bool) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.TransitEncryptionEnabled <- value)
            state : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_cache#transit_encryption_enabled-1">AppsyncApiCache#transit_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_encryption_enabled">]
        member _.TransitEncryptionEnabled(state: AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>, value: HashiCorp.Cdktf.IResolvable) : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type> =
            state.assignments.Add(fun config -> config.TransitEncryptionEnabled <- value)
            state : AppsyncApiCacheState<'ApiCachingBehavior, 'ApiId, 'Ttl, 'Type>

        member _.Run(state: AppsyncApiCacheState<Present, Present, Present, Present>) : aws.AppsyncApiCache.AppsyncApiCache =
            let config = aws.AppsyncApiCache.AppsyncApiCacheConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncApiCache.AppsyncApiCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncApiCache: missing required arguments. Must call: api_caching_behavior, api_id, ttl, type.", 9999, IsError = true)>]
        member _.Run(_: AppsyncApiCacheState<_, _, _, _>) : aws.AppsyncApiCache.AppsyncApiCache =
            Unchecked.defaultof<aws.AppsyncApiCache.AppsyncApiCache>
