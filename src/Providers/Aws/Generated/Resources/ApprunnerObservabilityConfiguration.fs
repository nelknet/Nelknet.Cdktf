namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName> = { assignments: ResizeArray<aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration">aws_apprunner_observability_configuration</a>.
    /// </summary>
    type ApprunnerObservabilityConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerObservabilityConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerObservabilityConfigurationState<Missing>)

        member _.Zero(()) : ApprunnerObservabilityConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerObservabilityConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#observability_configuration_name-1">ApprunnerObservabilityConfiguration#observability_configuration_name</a>.
        /// </summary>
        [<CustomOperation "observability_configuration_name">]
        member _.ObservabilityConfigurationName(state: ApprunnerObservabilityConfigurationState<Missing>, value: string) : ApprunnerObservabilityConfigurationState<Present> =
            state.assignments.Add(fun config -> config.ObservabilityConfigurationName <- value)
            ({ assignments = state.assignments } : ApprunnerObservabilityConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#id-1">ApprunnerObservabilityConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>, value: string) : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#tags-1">ApprunnerObservabilityConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>, value: seq<string * string>) : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#tags_all-1">ApprunnerObservabilityConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>, value: seq<string * string>) : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>

        /// <summary>
        /// trace_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#trace_configuration-1">ApprunnerObservabilityConfiguration#trace_configuration</a>
        /// </summary>
        [<CustomOperation "trace_configuration">]
        member _.TraceConfiguration(state: ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>, value: aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfigurationTraceConfiguration) : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName> =
            state.assignments.Add(fun config -> config.TraceConfiguration <- value)
            state : ApprunnerObservabilityConfigurationState<'ObservabilityConfigurationName>

        member _.Run(state: ApprunnerObservabilityConfigurationState<Present>) : aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfiguration =
            let config = aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerObservabilityConfiguration: missing required arguments. Must call: observability_configuration_name.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerObservabilityConfigurationState<_>) : aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfiguration =
            Unchecked.defaultof<aws.ApprunnerObservabilityConfiguration.ApprunnerObservabilityConfiguration>
