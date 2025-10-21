namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncGraphqlApiState<'AuthenticationType, 'Name> = { assignments: ResizeArray<aws.AppsyncGraphqlApi.AppsyncGraphqlApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api">aws_appsync_graphql_api</a>.
    /// </summary>
    type AppsyncGraphqlApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncGraphqlApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncGraphqlApiState<Missing, Missing>)

        member _.Zero(()) : AppsyncGraphqlApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncGraphqlApiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#authentication_type-1">AppsyncGraphqlApi#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: AppsyncGraphqlApiState<Missing, 'Name>, value: string) : AppsyncGraphqlApiState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            ({ assignments = state.assignments } : AppsyncGraphqlApiState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#name-1">AppsyncGraphqlApi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppsyncGraphqlApiState<'AuthenticationType, Missing>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppsyncGraphqlApiState<'AuthenticationType, Present>)

        /// <summary>
        /// additional_authentication_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#additional_authentication_provider-1">AppsyncGraphqlApi#additional_authentication_provider</a> Accepts: aws.IResolvable | aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProvider[]
        /// </summary>
        [<CustomOperation "additional_authentication_provider">]
        member _.AdditionalAuthenticationProvider(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalAuthenticationProvider <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#api_type-1">AppsyncGraphqlApi#api_type</a>.
        /// </summary>
        [<CustomOperation "api_type">]
        member _.ApiType(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.ApiType <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// enhanced_metrics_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#enhanced_metrics_config-1">AppsyncGraphqlApi#enhanced_metrics_config</a>
        /// </summary>
        [<CustomOperation "enhanced_metrics_config">]
        member _.EnhancedMetricsConfig(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: aws.AppsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfig) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.EnhancedMetricsConfig <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#id-1">AppsyncGraphqlApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#introspection_config-1">AppsyncGraphqlApi#introspection_config</a>.
        /// </summary>
        [<CustomOperation "introspection_config">]
        member _.IntrospectionConfig(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.IntrospectionConfig <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// lambda_authorizer_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#lambda_authorizer_config-1">AppsyncGraphqlApi#lambda_authorizer_config</a>
        /// </summary>
        [<CustomOperation "lambda_authorizer_config">]
        member _.LambdaAuthorizerConfig(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: aws.AppsyncGraphqlApi.AppsyncGraphqlApiLambdaAuthorizerConfig) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.LambdaAuthorizerConfig <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// log_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#log_config-1">AppsyncGraphqlApi#log_config</a>
        /// </summary>
        [<CustomOperation "log_config">]
        member _.LogConfig(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: aws.AppsyncGraphqlApi.AppsyncGraphqlApiLogConfig) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.LogConfig <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#merged_api_execution_role_arn-1">AppsyncGraphqlApi#merged_api_execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "merged_api_execution_role_arn">]
        member _.MergedApiExecutionRoleArn(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.MergedApiExecutionRoleArn <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// openid_connect_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#openid_connect_config-1">AppsyncGraphqlApi#openid_connect_config</a>
        /// </summary>
        [<CustomOperation "openid_connect_config">]
        member _.OpenidConnectConfig(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: aws.AppsyncGraphqlApi.AppsyncGraphqlApiOpenidConnectConfig) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.OpenidConnectConfig <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#query_depth_limit-1">AppsyncGraphqlApi#query_depth_limit</a>.
        /// </summary>
        [<CustomOperation "query_depth_limit">]
        member _.QueryDepthLimit(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: double) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.QueryDepthLimit <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#resolver_count_limit-1">AppsyncGraphqlApi#resolver_count_limit</a>.
        /// </summary>
        [<CustomOperation "resolver_count_limit">]
        member _.ResolverCountLimit(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: double) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.ResolverCountLimit <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#schema-1">AppsyncGraphqlApi#schema</a>.
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.Schema <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#tags-1">AppsyncGraphqlApi#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: seq<string * string>) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#tags_all-1">AppsyncGraphqlApi#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: seq<string * string>) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// user_pool_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#user_pool_config-1">AppsyncGraphqlApi#user_pool_config</a>
        /// </summary>
        [<CustomOperation "user_pool_config">]
        member _.UserPoolConfig(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: aws.AppsyncGraphqlApi.AppsyncGraphqlApiUserPoolConfig) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.UserPoolConfig <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#visibility-1">AppsyncGraphqlApi#visibility</a>.
        /// </summary>
        [<CustomOperation "visibility">]
        member _.Visibility(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: string) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.Visibility <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#xray_enabled-1">AppsyncGraphqlApi#xray_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "xray_enabled">]
        member _.XrayEnabled(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: bool) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.XrayEnabled <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#xray_enabled-1">AppsyncGraphqlApi#xray_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "xray_enabled">]
        member _.XrayEnabled(state: AppsyncGraphqlApiState<'AuthenticationType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppsyncGraphqlApiState<'AuthenticationType, 'Name> =
            state.assignments.Add(fun config -> config.XrayEnabled <- value)
            state : AppsyncGraphqlApiState<'AuthenticationType, 'Name>

        member _.Run(state: AppsyncGraphqlApiState<Present, Present>) : aws.AppsyncGraphqlApi.AppsyncGraphqlApi =
            let config = aws.AppsyncGraphqlApi.AppsyncGraphqlApiConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncGraphqlApi.AppsyncGraphqlApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncGraphqlApi: missing required arguments. Must call: authentication_type, name.", 9999, IsError = true)>]
        member _.Run(_: AppsyncGraphqlApiState<_, _>) : aws.AppsyncGraphqlApi.AppsyncGraphqlApi =
            Unchecked.defaultof<aws.AppsyncGraphqlApi.AppsyncGraphqlApi>
