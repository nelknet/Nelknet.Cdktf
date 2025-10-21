namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrometheusWorkspaceConfigurationState<'WorkspaceId> = { assignments: ResizeArray<aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration">aws_prometheus_workspace_configuration</a>.
    /// </summary>
    type PrometheusWorkspaceConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrometheusWorkspaceConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : PrometheusWorkspaceConfigurationState<Missing>)

        member _.Zero(()) : PrometheusWorkspaceConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : PrometheusWorkspaceConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#workspace_id-1">PrometheusWorkspaceConfiguration#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: PrometheusWorkspaceConfigurationState<Missing>, value: string) : PrometheusWorkspaceConfigurationState<Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : PrometheusWorkspaceConfigurationState<Present>)

        /// <summary>
        /// limits_per_label_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#limits_per_label_set-1">PrometheusWorkspaceConfiguration#limits_per_label_set</a> Accepts: aws.IResolvable | aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationLimitsPerLabelSet[]
        /// </summary>
        [<CustomOperation "limits_per_label_set">]
        member _.LimitsPerLabelSet(state: PrometheusWorkspaceConfigurationState<'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : PrometheusWorkspaceConfigurationState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.LimitsPerLabelSet <- value)
            state : PrometheusWorkspaceConfigurationState<'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#retention_period_in_days-1">PrometheusWorkspaceConfiguration#retention_period_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_period_in_days">]
        member _.RetentionPeriodInDays(state: PrometheusWorkspaceConfigurationState<'WorkspaceId>, value: double) : PrometheusWorkspaceConfigurationState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.RetentionPeriodInDays <- value)
            state : PrometheusWorkspaceConfigurationState<'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#timeouts-1">PrometheusWorkspaceConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrometheusWorkspaceConfigurationState<'WorkspaceId>, value: aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationTimeouts) : PrometheusWorkspaceConfigurationState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrometheusWorkspaceConfigurationState<'WorkspaceId>

        member _.Run(state: PrometheusWorkspaceConfigurationState<Present>) : aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfiguration =
            let config = aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.prometheusWorkspaceConfiguration: missing required arguments. Must call: workspace_id.", 9999, IsError = true)>]
        member _.Run(_: PrometheusWorkspaceConfigurationState<_>) : aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfiguration =
            Unchecked.defaultof<aws.PrometheusWorkspaceConfiguration.PrometheusWorkspaceConfiguration>
