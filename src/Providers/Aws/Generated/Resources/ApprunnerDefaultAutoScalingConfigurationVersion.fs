namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerDefaultAutoScalingConfigurationVersionState<'AutoScalingConfigurationArn> = { assignments: ResizeArray<aws.ApprunnerDefaultAutoScalingConfigurationVersion.ApprunnerDefaultAutoScalingConfigurationVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_default_auto_scaling_configuration_version">aws_apprunner_default_auto_scaling_configuration_version</a>.
    /// </summary>
    type ApprunnerDefaultAutoScalingConfigurationVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerDefaultAutoScalingConfigurationVersionState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerDefaultAutoScalingConfigurationVersionState<Missing>)

        member _.Zero(()) : ApprunnerDefaultAutoScalingConfigurationVersionState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerDefaultAutoScalingConfigurationVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_default_auto_scaling_configuration_version#auto_scaling_configuration_arn-1">ApprunnerDefaultAutoScalingConfigurationVersion#auto_scaling_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "auto_scaling_configuration_arn">]
        member _.AutoScalingConfigurationArn(state: ApprunnerDefaultAutoScalingConfigurationVersionState<Missing>, value: string) : ApprunnerDefaultAutoScalingConfigurationVersionState<Present> =
            state.assignments.Add(fun config -> config.AutoScalingConfigurationArn <- value)
            ({ assignments = state.assignments } : ApprunnerDefaultAutoScalingConfigurationVersionState<Present>)

        member _.Run(state: ApprunnerDefaultAutoScalingConfigurationVersionState<Present>) : aws.ApprunnerDefaultAutoScalingConfigurationVersion.ApprunnerDefaultAutoScalingConfigurationVersion =
            let config = aws.ApprunnerDefaultAutoScalingConfigurationVersion.ApprunnerDefaultAutoScalingConfigurationVersionConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerDefaultAutoScalingConfigurationVersion.ApprunnerDefaultAutoScalingConfigurationVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerDefaultAutoScalingConfigurationVersion: missing required arguments. Must call: auto_scaling_configuration_arn.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerDefaultAutoScalingConfigurationVersionState<_>) : aws.ApprunnerDefaultAutoScalingConfigurationVersion.ApprunnerDefaultAutoScalingConfigurationVersion =
            Unchecked.defaultof<aws.ApprunnerDefaultAutoScalingConfigurationVersion.ApprunnerDefaultAutoScalingConfigurationVersion>
