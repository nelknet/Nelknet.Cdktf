namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> = { assignments: ResizeArray<azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group">azurerm_synapse_sql_pool_workload_group</a>.
    /// </summary>
    type SynapseSqlPoolWorkloadGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseSqlPoolWorkloadGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolWorkloadGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseSqlPoolWorkloadGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolWorkloadGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#max_resource_percent-1">SynapseSqlPoolWorkloadGroup#max_resource_percent</a>.
        /// </summary>
        [<CustomOperation "max_resource_percent">]
        member _.MaxResourcePercent(state: SynapseSqlPoolWorkloadGroupState<Missing, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: double) : SynapseSqlPoolWorkloadGroupState<Present, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.MaxResourcePercent <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadGroupState<Present, 'MinResourcePercent, 'Name, 'SqlPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#min_resource_percent-1">SynapseSqlPoolWorkloadGroup#min_resource_percent</a>.
        /// </summary>
        [<CustomOperation "min_resource_percent">]
        member _.MinResourcePercent(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, Missing, 'Name, 'SqlPoolId>, value: double) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, Present, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.MinResourcePercent <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, Present, 'Name, 'SqlPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#name-1">SynapseSqlPoolWorkloadGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, Missing, 'SqlPoolId>, value: string) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, Present, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, Present, 'SqlPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#sql_pool_id-1">SynapseSqlPoolWorkloadGroup#sql_pool_id</a>.
        /// </summary>
        [<CustomOperation "sql_pool_id">]
        member _.SqlPoolId(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, Missing>, value: string) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, Present> =
            state.assignments.Add(fun config -> config.SqlPoolId <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#id-1">SynapseSqlPoolWorkloadGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: string) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#importance-1">SynapseSqlPoolWorkloadGroup#importance</a>.
        /// </summary>
        [<CustomOperation "importance">]
        member _.Importance(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: string) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.Importance <- value)
            state : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#max_resource_percent_per_request-1">SynapseSqlPoolWorkloadGroup#max_resource_percent_per_request</a>.
        /// </summary>
        [<CustomOperation "max_resource_percent_per_request">]
        member _.MaxResourcePercentPerRequest(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: double) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.MaxResourcePercentPerRequest <- value)
            state : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#min_resource_percent_per_request-1">SynapseSqlPoolWorkloadGroup#min_resource_percent_per_request</a>.
        /// </summary>
        [<CustomOperation "min_resource_percent_per_request">]
        member _.MinResourcePercentPerRequest(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: double) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.MinResourcePercentPerRequest <- value)
            state : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#query_execution_timeout_in_seconds-1">SynapseSqlPoolWorkloadGroup#query_execution_timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "query_execution_timeout_in_seconds">]
        member _.QueryExecutionTimeoutInSeconds(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: double) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.QueryExecutionTimeoutInSeconds <- value)
            state : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_workload_group#timeouts-1">SynapseSqlPoolWorkloadGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>, value: azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroupTimeouts) : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseSqlPoolWorkloadGroupState<'MaxResourcePercent, 'MinResourcePercent, 'Name, 'SqlPoolId>

        member _.Run(state: SynapseSqlPoolWorkloadGroupState<Present, Present, Present, Present>) : azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroup =
            let config = azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseSqlPoolWorkloadGroup: missing required arguments. Must call: max_resource_percent, min_resource_percent, name, sql_pool_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseSqlPoolWorkloadGroupState<_, _, _, _>) : azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroup =
            Unchecked.defaultof<azurerm.SynapseSqlPoolWorkloadGroup.SynapseSqlPoolWorkloadGroup>
