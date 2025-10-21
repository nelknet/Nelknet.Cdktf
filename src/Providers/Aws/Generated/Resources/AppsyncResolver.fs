namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncResolverState<'ApiId, 'Field, 'Type> = { assignments: ResizeArray<aws.AppsyncResolver.AppsyncResolverConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver">aws_appsync_resolver</a>.
    /// </summary>
    type AppsyncResolverBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncResolverState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncResolverState<Missing, Missing, Missing>)

        member _.Zero(()) : AppsyncResolverState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncResolverState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#api_id-1">AppsyncResolver#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncResolverState<Missing, 'Field, 'Type>, value: string) : AppsyncResolverState<Present, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncResolverState<Present, 'Field, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#field-1">AppsyncResolver#field</a>.
        /// </summary>
        [<CustomOperation "field">]
        member _.Field(state: AppsyncResolverState<'ApiId, Missing, 'Type>, value: string) : AppsyncResolverState<'ApiId, Present, 'Type> =
            state.assignments.Add(fun config -> config.Field <- value)
            ({ assignments = state.assignments } : AppsyncResolverState<'ApiId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#type-1">AppsyncResolver#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AppsyncResolverState<'ApiId, 'Field, Missing>, value: string) : AppsyncResolverState<'ApiId, 'Field, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : AppsyncResolverState<'ApiId, 'Field, Present>)

        /// <summary>
        /// caching_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#caching_config-1">AppsyncResolver#caching_config</a>
        /// </summary>
        [<CustomOperation "caching_config">]
        member _.CachingConfig(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: aws.AppsyncResolver.AppsyncResolverCachingConfig) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.CachingConfig <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#code-1">AppsyncResolver#code</a>.
        /// </summary>
        [<CustomOperation "code">]
        member _.Code(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: string) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.Code <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#data_source-1">AppsyncResolver#data_source</a>.
        /// </summary>
        [<CustomOperation "data_source">]
        member _.DataSource(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: string) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.DataSource <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#id-1">AppsyncResolver#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: string) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#kind-1">AppsyncResolver#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: string) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#max_batch_size-1">AppsyncResolver#max_batch_size</a>.
        /// </summary>
        [<CustomOperation "max_batch_size">]
        member _.MaxBatchSize(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: double) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.MaxBatchSize <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// pipeline_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#pipeline_config-1">AppsyncResolver#pipeline_config</a>
        /// </summary>
        [<CustomOperation "pipeline_config">]
        member _.PipelineConfig(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: aws.AppsyncResolver.AppsyncResolverPipelineConfig) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.PipelineConfig <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#request_template-1">AppsyncResolver#request_template</a>.
        /// </summary>
        [<CustomOperation "request_template">]
        member _.RequestTemplate(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: string) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.RequestTemplate <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#response_template-1">AppsyncResolver#response_template</a>.
        /// </summary>
        [<CustomOperation "response_template">]
        member _.ResponseTemplate(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: string) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.ResponseTemplate <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// runtime block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#runtime-1">AppsyncResolver#runtime</a>
        /// </summary>
        [<CustomOperation "runtime">]
        member _.Runtime(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: aws.AppsyncResolver.AppsyncResolverRuntime) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.Runtime <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        /// <summary>
        /// sync_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#sync_config-1">AppsyncResolver#sync_config</a>
        /// </summary>
        [<CustomOperation "sync_config">]
        member _.SyncConfig(state: AppsyncResolverState<'ApiId, 'Field, 'Type>, value: aws.AppsyncResolver.AppsyncResolverSyncConfig) : AppsyncResolverState<'ApiId, 'Field, 'Type> =
            state.assignments.Add(fun config -> config.SyncConfig <- value)
            state : AppsyncResolverState<'ApiId, 'Field, 'Type>

        member _.Run(state: AppsyncResolverState<Present, Present, Present>) : aws.AppsyncResolver.AppsyncResolver =
            let config = aws.AppsyncResolver.AppsyncResolverConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncResolver.AppsyncResolver(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncResolver: missing required arguments. Must call: api_id, field, type.", 9999, IsError = true)>]
        member _.Run(_: AppsyncResolverState<_, _, _>) : aws.AppsyncResolver.AppsyncResolver =
            Unchecked.defaultof<aws.AppsyncResolver.AppsyncResolver>
