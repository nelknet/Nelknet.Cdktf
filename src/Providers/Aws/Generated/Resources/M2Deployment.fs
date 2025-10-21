namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start> = { assignments: ResizeArray<aws.M2Deployment.M2DeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment">aws_m2_deployment</a>.
    /// </summary>
    type M2DeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : M2DeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : M2DeploymentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : M2DeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : M2DeploymentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#application_id-1">M2Deployment#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: M2DeploymentState<Missing, 'ApplicationVersion, 'EnvironmentId, 'Start>, value: string) : M2DeploymentState<Present, 'ApplicationVersion, 'EnvironmentId, 'Start> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : M2DeploymentState<Present, 'ApplicationVersion, 'EnvironmentId, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#application_version-1">M2Deployment#application_version</a>.
        /// </summary>
        [<CustomOperation "application_version">]
        member _.ApplicationVersion(state: M2DeploymentState<'ApplicationId, Missing, 'EnvironmentId, 'Start>, value: double) : M2DeploymentState<'ApplicationId, Present, 'EnvironmentId, 'Start> =
            state.assignments.Add(fun config -> config.ApplicationVersion <- value)
            ({ assignments = state.assignments } : M2DeploymentState<'ApplicationId, Present, 'EnvironmentId, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#environment_id-1">M2Deployment#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: M2DeploymentState<'ApplicationId, 'ApplicationVersion, Missing, 'Start>, value: string) : M2DeploymentState<'ApplicationId, 'ApplicationVersion, Present, 'Start> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : M2DeploymentState<'ApplicationId, 'ApplicationVersion, Present, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#start-1">M2Deployment#start</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start">]
        member _.Start(state: M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, Missing>, value: bool) : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, Present> =
            state.assignments.Add(fun config -> config.Start <- value)
            ({ assignments = state.assignments } : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#start-1">M2Deployment#start</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start">]
        member _.Start(state: M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, Missing>, value: HashiCorp.Cdktf.IResolvable) : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, Present> =
            state.assignments.Add(fun config -> config.Start <- value)
            ({ assignments = state.assignments } : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#force_stop-1">M2Deployment#force_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_stop">]
        member _.ForceStop(state: M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start>, value: bool) : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start> =
            state.assignments.Add(fun config -> config.ForceStop <- value)
            state : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#force_stop-1">M2Deployment#force_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_stop">]
        member _.ForceStop(state: M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start>, value: HashiCorp.Cdktf.IResolvable) : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start> =
            state.assignments.Add(fun config -> config.ForceStop <- value)
            state : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_deployment#timeouts-1">M2Deployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start>, value: aws.M2Deployment.M2DeploymentTimeouts) : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : M2DeploymentState<'ApplicationId, 'ApplicationVersion, 'EnvironmentId, 'Start>

        member _.Run(state: M2DeploymentState<Present, Present, Present, Present>) : aws.M2Deployment.M2Deployment =
            let config = aws.M2Deployment.M2DeploymentConfig()
            for setter in state.assignments do
                setter config
            aws.M2Deployment.M2Deployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.m2Deployment: missing required arguments. Must call: application_id, application_version, environment_id, start.", 9999, IsError = true)>]
        member _.Run(_: M2DeploymentState<_, _, _, _>) : aws.M2Deployment.M2Deployment =
            Unchecked.defaultof<aws.M2Deployment.M2Deployment>
