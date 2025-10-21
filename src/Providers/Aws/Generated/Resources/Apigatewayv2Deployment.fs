namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2DeploymentState<'ApiId> = { assignments: ResizeArray<aws.Apigatewayv2Deployment.Apigatewayv2DeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_deployment">aws_apigatewayv2_deployment</a>.
    /// </summary>
    type Apigatewayv2DeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2DeploymentState<Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2DeploymentState<Missing>)

        member _.Zero(()) : Apigatewayv2DeploymentState<Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2DeploymentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_deployment#api_id-1">Apigatewayv2Deployment#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2DeploymentState<Missing>, value: string) : Apigatewayv2DeploymentState<Present> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2DeploymentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_deployment#description-1">Apigatewayv2Deployment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Apigatewayv2DeploymentState<'ApiId>, value: string) : Apigatewayv2DeploymentState<'ApiId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Apigatewayv2DeploymentState<'ApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_deployment#id-1">Apigatewayv2Deployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2DeploymentState<'ApiId>, value: string) : Apigatewayv2DeploymentState<'ApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2DeploymentState<'ApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_deployment#triggers-1">Apigatewayv2Deployment#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: Apigatewayv2DeploymentState<'ApiId>, value: seq<string * string>) : Apigatewayv2DeploymentState<'ApiId> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : Apigatewayv2DeploymentState<'ApiId>

        member _.Run(state: Apigatewayv2DeploymentState<Present>) : aws.Apigatewayv2Deployment.Apigatewayv2Deployment =
            let config = aws.Apigatewayv2Deployment.Apigatewayv2DeploymentConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Deployment.Apigatewayv2Deployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Deployment: missing required arguments. Must call: api_id.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2DeploymentState<_>) : aws.Apigatewayv2Deployment.Apigatewayv2Deployment =
            Unchecked.defaultof<aws.Apigatewayv2Deployment.Apigatewayv2Deployment>
