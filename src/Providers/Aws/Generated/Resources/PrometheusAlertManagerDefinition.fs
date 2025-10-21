namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrometheusAlertManagerDefinitionState<'Definition, 'WorkspaceId> = { assignments: ResizeArray<aws.PrometheusAlertManagerDefinition.PrometheusAlertManagerDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_alert_manager_definition">aws_prometheus_alert_manager_definition</a>.
    /// </summary>
    type PrometheusAlertManagerDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrometheusAlertManagerDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PrometheusAlertManagerDefinitionState<Missing, Missing>)

        member _.Zero(()) : PrometheusAlertManagerDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PrometheusAlertManagerDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_alert_manager_definition#definition-1">PrometheusAlertManagerDefinition#definition</a>.
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: PrometheusAlertManagerDefinitionState<Missing, 'WorkspaceId>, value: string) : PrometheusAlertManagerDefinitionState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Definition <- value)
            ({ assignments = state.assignments } : PrometheusAlertManagerDefinitionState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_alert_manager_definition#workspace_id-1">PrometheusAlertManagerDefinition#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: PrometheusAlertManagerDefinitionState<'Definition, Missing>, value: string) : PrometheusAlertManagerDefinitionState<'Definition, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : PrometheusAlertManagerDefinitionState<'Definition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_alert_manager_definition#id-1">PrometheusAlertManagerDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrometheusAlertManagerDefinitionState<'Definition, 'WorkspaceId>, value: string) : PrometheusAlertManagerDefinitionState<'Definition, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrometheusAlertManagerDefinitionState<'Definition, 'WorkspaceId>

        member _.Run(state: PrometheusAlertManagerDefinitionState<Present, Present>) : aws.PrometheusAlertManagerDefinition.PrometheusAlertManagerDefinition =
            let config = aws.PrometheusAlertManagerDefinition.PrometheusAlertManagerDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.PrometheusAlertManagerDefinition.PrometheusAlertManagerDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.prometheusAlertManagerDefinition: missing required arguments. Must call: definition, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: PrometheusAlertManagerDefinitionState<_, _>) : aws.PrometheusAlertManagerDefinition.PrometheusAlertManagerDefinition =
            Unchecked.defaultof<aws.PrometheusAlertManagerDefinition.PrometheusAlertManagerDefinition>
