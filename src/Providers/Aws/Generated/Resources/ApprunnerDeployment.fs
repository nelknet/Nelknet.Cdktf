namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerDeploymentState<'ServiceArn> = { assignments: ResizeArray<aws.ApprunnerDeployment.ApprunnerDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_deployment">aws_apprunner_deployment</a>.
    /// </summary>
    type ApprunnerDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerDeploymentState<Missing>)

        member _.Zero(()) : ApprunnerDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerDeploymentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_deployment#service_arn-1">ApprunnerDeployment#service_arn</a>.
        /// </summary>
        [<CustomOperation "service_arn">]
        member _.ServiceArn(state: ApprunnerDeploymentState<Missing>, value: string) : ApprunnerDeploymentState<Present> =
            state.assignments.Add(fun config -> config.ServiceArn <- value)
            ({ assignments = state.assignments } : ApprunnerDeploymentState<Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_deployment#timeouts-1">ApprunnerDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApprunnerDeploymentState<'ServiceArn>, value: aws.ApprunnerDeployment.ApprunnerDeploymentTimeouts) : ApprunnerDeploymentState<'ServiceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApprunnerDeploymentState<'ServiceArn>

        member _.Run(state: ApprunnerDeploymentState<Present>) : aws.ApprunnerDeployment.ApprunnerDeployment =
            let config = aws.ApprunnerDeployment.ApprunnerDeploymentConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerDeployment.ApprunnerDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerDeployment: missing required arguments. Must call: service_arn.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerDeploymentState<_>) : aws.ApprunnerDeployment.ApprunnerDeployment =
            Unchecked.defaultof<aws.ApprunnerDeployment.ApprunnerDeployment>
