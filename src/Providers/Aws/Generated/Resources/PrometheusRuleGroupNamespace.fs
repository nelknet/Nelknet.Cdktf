namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId> = { assignments: ResizeArray<aws.PrometheusRuleGroupNamespace.PrometheusRuleGroupNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace">aws_prometheus_rule_group_namespace</a>.
    /// </summary>
    type PrometheusRuleGroupNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrometheusRuleGroupNamespaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrometheusRuleGroupNamespaceState<Missing, Missing, Missing>)

        member _.Zero(()) : PrometheusRuleGroupNamespaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrometheusRuleGroupNamespaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace#data-1">PrometheusRuleGroupNamespace#data</a>.
        /// </summary>
        [<CustomOperation "data">]
        member _.Data(state: PrometheusRuleGroupNamespaceState<Missing, 'Name, 'WorkspaceId>, value: string) : PrometheusRuleGroupNamespaceState<Present, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Data <- value)
            ({ assignments = state.assignments } : PrometheusRuleGroupNamespaceState<Present, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace#name-1">PrometheusRuleGroupNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrometheusRuleGroupNamespaceState<'Data, Missing, 'WorkspaceId>, value: string) : PrometheusRuleGroupNamespaceState<'Data, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrometheusRuleGroupNamespaceState<'Data, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace#workspace_id-1">PrometheusRuleGroupNamespace#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: PrometheusRuleGroupNamespaceState<'Data, 'Name, Missing>, value: string) : PrometheusRuleGroupNamespaceState<'Data, 'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : PrometheusRuleGroupNamespaceState<'Data, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace#id-1">PrometheusRuleGroupNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId>, value: string) : PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace#tags-1">PrometheusRuleGroupNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId>, value: seq<string * string>) : PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_rule_group_namespace#tags_all-1">PrometheusRuleGroupNamespace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId>, value: seq<string * string>) : PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : PrometheusRuleGroupNamespaceState<'Data, 'Name, 'WorkspaceId>

        member _.Run(state: PrometheusRuleGroupNamespaceState<Present, Present, Present>) : aws.PrometheusRuleGroupNamespace.PrometheusRuleGroupNamespace =
            let config = aws.PrometheusRuleGroupNamespace.PrometheusRuleGroupNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.PrometheusRuleGroupNamespace.PrometheusRuleGroupNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.prometheusRuleGroupNamespace: missing required arguments. Must call: data, name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: PrometheusRuleGroupNamespaceState<_, _, _>) : aws.PrometheusRuleGroupNamespace.PrometheusRuleGroupNamespace =
            Unchecked.defaultof<aws.PrometheusRuleGroupNamespace.PrometheusRuleGroupNamespace>
