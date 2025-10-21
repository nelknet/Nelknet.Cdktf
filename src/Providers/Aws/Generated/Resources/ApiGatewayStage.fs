namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> = { assignments: ResizeArray<aws.ApiGatewayStage.ApiGatewayStageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage">aws_api_gateway_stage</a>.
    /// </summary>
    type ApiGatewayStageBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayStageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayStageState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayStageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayStageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#deployment_id-1">ApiGatewayStage#deployment_id</a>.
        /// </summary>
        [<CustomOperation "deployment_id">]
        member _.DeploymentId(state: ApiGatewayStageState<Missing, 'RestApiId, 'StageName>, value: string) : ApiGatewayStageState<Present, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.DeploymentId <- value)
            ({ assignments = state.assignments } : ApiGatewayStageState<Present, 'RestApiId, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#rest_api_id-1">ApiGatewayStage#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayStageState<'DeploymentId, Missing, 'StageName>, value: string) : ApiGatewayStageState<'DeploymentId, Present, 'StageName> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayStageState<'DeploymentId, Present, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#stage_name-1">ApiGatewayStage#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, Missing>, value: string) : ApiGatewayStageState<'DeploymentId, 'RestApiId, Present> =
            state.assignments.Add(fun config -> config.StageName <- value)
            ({ assignments = state.assignments } : ApiGatewayStageState<'DeploymentId, 'RestApiId, Present>)

        /// <summary>
        /// access_log_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#access_log_settings-1">ApiGatewayStage#access_log_settings</a>
        /// </summary>
        [<CustomOperation "access_log_settings">]
        member _.AccessLogSettings(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: aws.ApiGatewayStage.ApiGatewayStageAccessLogSettings) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.AccessLogSettings <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#cache_cluster_enabled-1">ApiGatewayStage#cache_cluster_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cache_cluster_enabled">]
        member _.CacheClusterEnabled(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: bool) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.CacheClusterEnabled <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#cache_cluster_enabled-1">ApiGatewayStage#cache_cluster_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cache_cluster_enabled">]
        member _.CacheClusterEnabled(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.CacheClusterEnabled <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#cache_cluster_size-1">ApiGatewayStage#cache_cluster_size</a>.
        /// </summary>
        [<CustomOperation "cache_cluster_size">]
        member _.CacheClusterSize(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: string) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.CacheClusterSize <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// canary_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#canary_settings-1">ApiGatewayStage#canary_settings</a>
        /// </summary>
        [<CustomOperation "canary_settings">]
        member _.CanarySettings(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: aws.ApiGatewayStage.ApiGatewayStageCanarySettings) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.CanarySettings <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#client_certificate_id-1">ApiGatewayStage#client_certificate_id</a>.
        /// </summary>
        [<CustomOperation "client_certificate_id">]
        member _.ClientCertificateId(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: string) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.ClientCertificateId <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#description-1">ApiGatewayStage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: string) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#documentation_version-1">ApiGatewayStage#documentation_version</a>.
        /// </summary>
        [<CustomOperation "documentation_version">]
        member _.DocumentationVersion(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: string) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.DocumentationVersion <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#id-1">ApiGatewayStage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: string) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#tags-1">ApiGatewayStage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: seq<string * string>) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#tags_all-1">ApiGatewayStage#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: seq<string * string>) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#variables-1">ApiGatewayStage#variables</a>.
        /// </summary>
        [<CustomOperation "variables">]
        member _.Variables(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: seq<string * string>) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Variables <- dict value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#xray_tracing_enabled-1">ApiGatewayStage#xray_tracing_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "xray_tracing_enabled">]
        member _.XrayTracingEnabled(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: bool) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.XrayTracingEnabled <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_stage#xray_tracing_enabled-1">ApiGatewayStage#xray_tracing_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "xray_tracing_enabled">]
        member _.XrayTracingEnabled(state: ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.XrayTracingEnabled <- value)
            state : ApiGatewayStageState<'DeploymentId, 'RestApiId, 'StageName>

        member _.Run(state: ApiGatewayStageState<Present, Present, Present>) : aws.ApiGatewayStage.ApiGatewayStage =
            let config = aws.ApiGatewayStage.ApiGatewayStageConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayStage.ApiGatewayStage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayStage: missing required arguments. Must call: deployment_id, rest_api_id, stage_name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayStageState<_, _, _>) : aws.ApiGatewayStage.ApiGatewayStage =
            Unchecked.defaultof<aws.ApiGatewayStage.ApiGatewayStage>
