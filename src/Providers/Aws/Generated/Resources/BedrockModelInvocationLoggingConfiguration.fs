namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockModelInvocationLoggingConfigurationState = { assignments: ResizeArray<aws.BedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_model_invocation_logging_configuration">aws_bedrock_model_invocation_logging_configuration</a>.
    /// </summary>
    type BedrockModelInvocationLoggingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockModelInvocationLoggingConfigurationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : BedrockModelInvocationLoggingConfigurationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// logging_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_model_invocation_logging_configuration#logging_config-1">BedrockModelInvocationLoggingConfiguration#logging_config</a>
        /// </summary>
        [<CustomOperation "logging_config">]
        member _.LoggingConfig(state: BedrockModelInvocationLoggingConfigurationState, value: aws.BedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfig) : BedrockModelInvocationLoggingConfigurationState =
            state.assignments.Add(fun config -> config.LoggingConfig <- value)
            state : BedrockModelInvocationLoggingConfigurationState

        member _.Run(state: BedrockModelInvocationLoggingConfigurationState) : aws.BedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfiguration =
            let config = aws.BedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfiguration(StackContext.get (), logicalId, config)
