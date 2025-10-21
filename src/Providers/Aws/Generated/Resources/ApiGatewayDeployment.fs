namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayDeploymentState<'RestApiId> = { assignments: ResizeArray<aws.ApiGatewayDeployment.ApiGatewayDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment">aws_api_gateway_deployment</a>.
    /// </summary>
    type ApiGatewayDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDeploymentState<Missing>)

        member _.Zero(()) : ApiGatewayDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDeploymentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#rest_api_id-1">ApiGatewayDeployment#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayDeploymentState<Missing>, value: string) : ApiGatewayDeploymentState<Present> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayDeploymentState<Present>)

        /// <summary>
        /// canary_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#canary_settings-1">ApiGatewayDeployment#canary_settings</a>
        /// </summary>
        [<CustomOperation "canary_settings">]
        member _.CanarySettings(state: ApiGatewayDeploymentState<'RestApiId>, value: aws.ApiGatewayDeployment.ApiGatewayDeploymentCanarySettings) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.CanarySettings <- value)
            state : ApiGatewayDeploymentState<'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#description-1">ApiGatewayDeployment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayDeploymentState<'RestApiId>, value: string) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayDeploymentState<'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#id-1">ApiGatewayDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayDeploymentState<'RestApiId>, value: string) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayDeploymentState<'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#stage_description-1">ApiGatewayDeployment#stage_description</a>.
        /// </summary>
        [<CustomOperation "stage_description">]
        member _.StageDescription(state: ApiGatewayDeploymentState<'RestApiId>, value: string) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.StageDescription <- value)
            state : ApiGatewayDeploymentState<'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#stage_name-1">ApiGatewayDeployment#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: ApiGatewayDeploymentState<'RestApiId>, value: string) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.StageName <- value)
            state : ApiGatewayDeploymentState<'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#triggers-1">ApiGatewayDeployment#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: ApiGatewayDeploymentState<'RestApiId>, value: seq<string * string>) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : ApiGatewayDeploymentState<'RestApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_deployment#variables-1">ApiGatewayDeployment#variables</a>.
        /// </summary>
        [<CustomOperation "variables">]
        member _.Variables(state: ApiGatewayDeploymentState<'RestApiId>, value: seq<string * string>) : ApiGatewayDeploymentState<'RestApiId> =
            state.assignments.Add(fun config -> config.Variables <- dict value)
            state : ApiGatewayDeploymentState<'RestApiId>

        member _.Run(state: ApiGatewayDeploymentState<Present>) : aws.ApiGatewayDeployment.ApiGatewayDeployment =
            let config = aws.ApiGatewayDeployment.ApiGatewayDeploymentConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayDeployment.ApiGatewayDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayDeployment: missing required arguments. Must call: rest_api_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayDeploymentState<_>) : aws.ApiGatewayDeployment.ApiGatewayDeployment =
            Unchecked.defaultof<aws.ApiGatewayDeployment.ApiGatewayDeployment>
