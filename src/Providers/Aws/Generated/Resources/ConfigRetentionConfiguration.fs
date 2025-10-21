namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigRetentionConfigurationState<'RetentionPeriodInDays> = { assignments: ResizeArray<aws.ConfigRetentionConfiguration.ConfigRetentionConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_retention_configuration">aws_config_retention_configuration</a>.
    /// </summary>
    type ConfigRetentionConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigRetentionConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : ConfigRetentionConfigurationState<Missing>)

        member _.Zero(()) : ConfigRetentionConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : ConfigRetentionConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_retention_configuration#retention_period_in_days-1">ConfigRetentionConfiguration#retention_period_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_period_in_days">]
        member _.RetentionPeriodInDays(state: ConfigRetentionConfigurationState<Missing>, value: double) : ConfigRetentionConfigurationState<Present> =
            state.assignments.Add(fun config -> config.RetentionPeriodInDays <- value)
            ({ assignments = state.assignments } : ConfigRetentionConfigurationState<Present>)

        member _.Run(state: ConfigRetentionConfigurationState<Present>) : aws.ConfigRetentionConfiguration.ConfigRetentionConfiguration =
            let config = aws.ConfigRetentionConfiguration.ConfigRetentionConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigRetentionConfiguration.ConfigRetentionConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configRetentionConfiguration: missing required arguments. Must call: retention_period_in_days.", 9999, IsError = true)>]
        member _.Run(_: ConfigRetentionConfigurationState<_>) : aws.ConfigRetentionConfiguration.ConfigRetentionConfiguration =
            Unchecked.defaultof<aws.ConfigRetentionConfiguration.ConfigRetentionConfiguration>
