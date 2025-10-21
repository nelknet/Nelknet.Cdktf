namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncFunctionState<'ApiId, 'DataSource, 'Name> = { assignments: ResizeArray<aws.AppsyncFunction.AppsyncFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function">aws_appsync_function</a>.
    /// </summary>
    type AppsyncFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncFunctionState<Missing, Missing, Missing>)

        member _.Zero(()) : AppsyncFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncFunctionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#api_id-1">AppsyncFunction#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncFunctionState<Missing, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<Present, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncFunctionState<Present, 'DataSource, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#data_source-1">AppsyncFunction#data_source</a>.
        /// </summary>
        [<CustomOperation "data_source">]
        member _.DataSource(state: AppsyncFunctionState<'ApiId, Missing, 'Name>, value: string) : AppsyncFunctionState<'ApiId, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataSource <- value)
            ({ assignments = state.assignments } : AppsyncFunctionState<'ApiId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#name-1">AppsyncFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppsyncFunctionState<'ApiId, 'DataSource, Missing>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppsyncFunctionState<'ApiId, 'DataSource, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#code-1">AppsyncFunction#code</a>.
        /// </summary>
        [<CustomOperation "code">]
        member _.Code(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.Code <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#description-1">AppsyncFunction#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#function_version-1">AppsyncFunction#function_version</a>.
        /// </summary>
        [<CustomOperation "function_version">]
        member _.FunctionVersion(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.FunctionVersion <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#id-1">AppsyncFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#max_batch_size-1">AppsyncFunction#max_batch_size</a>.
        /// </summary>
        [<CustomOperation "max_batch_size">]
        member _.MaxBatchSize(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: double) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.MaxBatchSize <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#request_mapping_template-1">AppsyncFunction#request_mapping_template</a>.
        /// </summary>
        [<CustomOperation "request_mapping_template">]
        member _.RequestMappingTemplate(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.RequestMappingTemplate <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#response_mapping_template-1">AppsyncFunction#response_mapping_template</a>.
        /// </summary>
        [<CustomOperation "response_mapping_template">]
        member _.ResponseMappingTemplate(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: string) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.ResponseMappingTemplate <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// runtime block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#runtime-1">AppsyncFunction#runtime</a>
        /// </summary>
        [<CustomOperation "runtime">]
        member _.Runtime(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: aws.AppsyncFunction.AppsyncFunctionRuntime) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.Runtime <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        /// <summary>
        /// sync_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#sync_config-1">AppsyncFunction#sync_config</a>
        /// </summary>
        [<CustomOperation "sync_config">]
        member _.SyncConfig(state: AppsyncFunctionState<'ApiId, 'DataSource, 'Name>, value: aws.AppsyncFunction.AppsyncFunctionSyncConfig) : AppsyncFunctionState<'ApiId, 'DataSource, 'Name> =
            state.assignments.Add(fun config -> config.SyncConfig <- value)
            state : AppsyncFunctionState<'ApiId, 'DataSource, 'Name>

        member _.Run(state: AppsyncFunctionState<Present, Present, Present>) : aws.AppsyncFunction.AppsyncFunction =
            let config = aws.AppsyncFunction.AppsyncFunctionConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncFunction.AppsyncFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncFunction: missing required arguments. Must call: api_id, data_source, name.", 9999, IsError = true)>]
        member _.Run(_: AppsyncFunctionState<_, _, _>) : aws.AppsyncFunction.AppsyncFunction =
            Unchecked.defaultof<aws.AppsyncFunction.AppsyncFunction>
