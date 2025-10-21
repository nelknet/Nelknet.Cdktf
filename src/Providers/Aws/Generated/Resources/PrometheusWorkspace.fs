namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrometheusWorkspaceState = { assignments: ResizeArray<aws.PrometheusWorkspace.PrometheusWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace">aws_prometheus_workspace</a>.
    /// </summary>
    type PrometheusWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrometheusWorkspaceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : PrometheusWorkspaceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#alias-1">PrometheusWorkspace#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: PrometheusWorkspaceState, value: string) : PrometheusWorkspaceState =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : PrometheusWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#id-1">PrometheusWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrometheusWorkspaceState, value: string) : PrometheusWorkspaceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrometheusWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#kms_key_arn-1">PrometheusWorkspace#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: PrometheusWorkspaceState, value: string) : PrometheusWorkspaceState =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : PrometheusWorkspaceState

        /// <summary>
        /// logging_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#logging_configuration-1">PrometheusWorkspace#logging_configuration</a>
        /// </summary>
        [<CustomOperation "logging_configuration">]
        member _.LoggingConfiguration(state: PrometheusWorkspaceState, value: aws.PrometheusWorkspace.PrometheusWorkspaceLoggingConfiguration) : PrometheusWorkspaceState =
            state.assignments.Add(fun config -> config.LoggingConfiguration <- value)
            state : PrometheusWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#tags-1">PrometheusWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrometheusWorkspaceState, value: seq<string * string>) : PrometheusWorkspaceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrometheusWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#tags_all-1">PrometheusWorkspace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: PrometheusWorkspaceState, value: seq<string * string>) : PrometheusWorkspaceState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : PrometheusWorkspaceState

        member _.Run(state: PrometheusWorkspaceState) : aws.PrometheusWorkspace.PrometheusWorkspace =
            let config = aws.PrometheusWorkspace.PrometheusWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.PrometheusWorkspace.PrometheusWorkspace(StackContext.get (), logicalId, config)
