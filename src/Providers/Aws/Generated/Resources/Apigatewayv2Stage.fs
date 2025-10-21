namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2StageState<'ApiId, 'Name> = { assignments: ResizeArray<aws.Apigatewayv2Stage.Apigatewayv2StageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage">aws_apigatewayv2_stage</a>.
    /// </summary>
    type Apigatewayv2StageBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2StageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2StageState<Missing, Missing>)

        member _.Zero(()) : Apigatewayv2StageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2StageState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#api_id-1">Apigatewayv2Stage#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2StageState<Missing, 'Name>, value: string) : Apigatewayv2StageState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2StageState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#name-1">Apigatewayv2Stage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Apigatewayv2StageState<'ApiId, Missing>, value: string) : Apigatewayv2StageState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Apigatewayv2StageState<'ApiId, Present>)

        /// <summary>
        /// access_log_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#access_log_settings-1">Apigatewayv2Stage#access_log_settings</a>
        /// </summary>
        [<CustomOperation "access_log_settings">]
        member _.AccessLogSettings(state: Apigatewayv2StageState<'ApiId, 'Name>, value: aws.Apigatewayv2Stage.Apigatewayv2StageAccessLogSettings) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.AccessLogSettings <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#auto_deploy-1">Apigatewayv2Stage#auto_deploy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_deploy">]
        member _.AutoDeploy(state: Apigatewayv2StageState<'ApiId, 'Name>, value: bool) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.AutoDeploy <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#auto_deploy-1">Apigatewayv2Stage#auto_deploy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_deploy">]
        member _.AutoDeploy(state: Apigatewayv2StageState<'ApiId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.AutoDeploy <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#client_certificate_id-1">Apigatewayv2Stage#client_certificate_id</a>.
        /// </summary>
        [<CustomOperation "client_certificate_id">]
        member _.ClientCertificateId(state: Apigatewayv2StageState<'ApiId, 'Name>, value: string) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.ClientCertificateId <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// default_route_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#default_route_settings-1">Apigatewayv2Stage#default_route_settings</a>
        /// </summary>
        [<CustomOperation "default_route_settings">]
        member _.DefaultRouteSettings(state: Apigatewayv2StageState<'ApiId, 'Name>, value: aws.Apigatewayv2Stage.Apigatewayv2StageDefaultRouteSettings) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.DefaultRouteSettings <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#deployment_id-1">Apigatewayv2Stage#deployment_id</a>.
        /// </summary>
        [<CustomOperation "deployment_id">]
        member _.DeploymentId(state: Apigatewayv2StageState<'ApiId, 'Name>, value: string) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.DeploymentId <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#description-1">Apigatewayv2Stage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Apigatewayv2StageState<'ApiId, 'Name>, value: string) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#id-1">Apigatewayv2Stage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2StageState<'ApiId, 'Name>, value: string) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// route_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#route_settings-1">Apigatewayv2Stage#route_settings</a> Accepts: aws.IResolvable | aws.Apigatewayv2Stage.Apigatewayv2StageRouteSettings[]
        /// </summary>
        [<CustomOperation "route_settings">]
        member _.RouteSettings(state: Apigatewayv2StageState<'ApiId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.RouteSettings <- value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#stage_variables-1">Apigatewayv2Stage#stage_variables</a>.
        /// </summary>
        [<CustomOperation "stage_variables">]
        member _.StageVariables(state: Apigatewayv2StageState<'ApiId, 'Name>, value: seq<string * string>) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.StageVariables <- dict value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#tags-1">Apigatewayv2Stage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Apigatewayv2StageState<'ApiId, 'Name>, value: seq<string * string>) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#tags_all-1">Apigatewayv2Stage#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Apigatewayv2StageState<'ApiId, 'Name>, value: seq<string * string>) : Apigatewayv2StageState<'ApiId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Apigatewayv2StageState<'ApiId, 'Name>

        member _.Run(state: Apigatewayv2StageState<Present, Present>) : aws.Apigatewayv2Stage.Apigatewayv2Stage =
            let config = aws.Apigatewayv2Stage.Apigatewayv2StageConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Stage.Apigatewayv2Stage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Stage: missing required arguments. Must call: api_id, name.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2StageState<_, _>) : aws.Apigatewayv2Stage.Apigatewayv2Stage =
            Unchecked.defaultof<aws.Apigatewayv2Stage.Apigatewayv2Stage>
