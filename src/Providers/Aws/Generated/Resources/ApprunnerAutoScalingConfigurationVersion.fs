namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> = { assignments: ResizeArray<aws.ApprunnerAutoScalingConfigurationVersion.ApprunnerAutoScalingConfigurationVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version">aws_apprunner_auto_scaling_configuration_version</a>.
    /// </summary>
    type ApprunnerAutoScalingConfigurationVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerAutoScalingConfigurationVersionState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerAutoScalingConfigurationVersionState<Missing>)

        member _.Zero(()) : ApprunnerAutoScalingConfigurationVersionState<Missing> =
            ({ assignments = ResizeArray() } : ApprunnerAutoScalingConfigurationVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#auto_scaling_configuration_name-1">ApprunnerAutoScalingConfigurationVersion#auto_scaling_configuration_name</a>.
        /// </summary>
        [<CustomOperation "auto_scaling_configuration_name">]
        member _.AutoScalingConfigurationName(state: ApprunnerAutoScalingConfigurationVersionState<Missing>, value: string) : ApprunnerAutoScalingConfigurationVersionState<Present> =
            state.assignments.Add(fun config -> config.AutoScalingConfigurationName <- value)
            ({ assignments = state.assignments } : ApprunnerAutoScalingConfigurationVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#id-1">ApprunnerAutoScalingConfigurationVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>, value: string) : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#max_concurrency-1">ApprunnerAutoScalingConfigurationVersion#max_concurrency</a>.
        /// </summary>
        [<CustomOperation "max_concurrency">]
        member _.MaxConcurrency(state: ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>, value: double) : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> =
            state.assignments.Add(fun config -> config.MaxConcurrency <- value)
            state : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#max_size-1">ApprunnerAutoScalingConfigurationVersion#max_size</a>.
        /// </summary>
        [<CustomOperation "max_size">]
        member _.MaxSize(state: ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>, value: double) : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> =
            state.assignments.Add(fun config -> config.MaxSize <- value)
            state : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#min_size-1">ApprunnerAutoScalingConfigurationVersion#min_size</a>.
        /// </summary>
        [<CustomOperation "min_size">]
        member _.MinSize(state: ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>, value: double) : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> =
            state.assignments.Add(fun config -> config.MinSize <- value)
            state : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#tags-1">ApprunnerAutoScalingConfigurationVersion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>, value: seq<string * string>) : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_auto_scaling_configuration_version#tags_all-1">ApprunnerAutoScalingConfigurationVersion#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>, value: seq<string * string>) : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApprunnerAutoScalingConfigurationVersionState<'AutoScalingConfigurationName>

        member _.Run(state: ApprunnerAutoScalingConfigurationVersionState<Present>) : aws.ApprunnerAutoScalingConfigurationVersion.ApprunnerAutoScalingConfigurationVersion =
            let config = aws.ApprunnerAutoScalingConfigurationVersion.ApprunnerAutoScalingConfigurationVersionConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerAutoScalingConfigurationVersion.ApprunnerAutoScalingConfigurationVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerAutoScalingConfigurationVersion: missing required arguments. Must call: auto_scaling_configuration_name.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerAutoScalingConfigurationVersionState<_>) : aws.ApprunnerAutoScalingConfigurationVersion.ApprunnerAutoScalingConfigurationVersion =
            Unchecked.defaultof<aws.ApprunnerAutoScalingConfigurationVersion.ApprunnerAutoScalingConfigurationVersion>
