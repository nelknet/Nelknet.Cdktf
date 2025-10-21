namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> = { assignments: ResizeArray<azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier">azurerm_synapse_sql_pool_workload_classifier</a>.
    /// </summary>
    type SynapseSqlPoolWorkloadClassifierBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseSqlPoolWorkloadClassifierState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolWorkloadClassifierState<Missing, Missing, Missing>)

        member _.Zero(()) : SynapseSqlPoolWorkloadClassifierState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolWorkloadClassifierState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#member_name-1">SynapseSqlPoolWorkloadClassifier#member_name</a>.
        /// </summary>
        [<CustomOperation "member_name">]
        member _.MemberName(state: SynapseSqlPoolWorkloadClassifierState<Missing, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<Present, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.MemberName <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadClassifierState<Present, 'Name, 'WorkloadGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#name-1">SynapseSqlPoolWorkloadClassifier#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, Missing, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, Present, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadClassifierState<'MemberName, Present, 'WorkloadGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#workload_group_id-1">SynapseSqlPoolWorkloadClassifier#workload_group_id</a>.
        /// </summary>
        [<CustomOperation "workload_group_id">]
        member _.WorkloadGroupId(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, Missing>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, Present> =
            state.assignments.Add(fun config -> config.WorkloadGroupId <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#context-1">SynapseSqlPoolWorkloadClassifier#context</a>.
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.Context <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#end_time-1">SynapseSqlPoolWorkloadClassifier#end_time</a>.
        /// </summary>
        [<CustomOperation "end_time">]
        member _.EndTime(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.EndTime <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#id-1">SynapseSqlPoolWorkloadClassifier#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#importance-1">SynapseSqlPoolWorkloadClassifier#importance</a>.
        /// </summary>
        [<CustomOperation "importance">]
        member _.Importance(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.Importance <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#label-1">SynapseSqlPoolWorkloadClassifier#label</a>.
        /// </summary>
        [<CustomOperation "label">]
        member _.Label(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.Label <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#start_time-1">SynapseSqlPoolWorkloadClassifier#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: string) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_classifier#timeouts-1">SynapseSqlPoolWorkloadClassifier#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>, value: azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierTimeouts) : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseSqlPoolWorkloadClassifierState<'MemberName, 'Name, 'WorkloadGroupId>

        member _.Run(state: SynapseSqlPoolWorkloadClassifierState<Present, Present, Present>) : azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifier =
            let config = azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifier(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseSqlPoolWorkloadClassifier: missing required arguments. Must call: member_name, name, workload_group_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseSqlPoolWorkloadClassifierState<_, _, _>) : azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifier =
            Unchecked.defaultof<azurerm.SynapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifier>
