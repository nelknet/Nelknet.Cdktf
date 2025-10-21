namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> = { assignments: ResizeArray<azurerm.LogAnalyticsSolution.LogAnalyticsSolutionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution">azurerm_log_analytics_solution</a>.
    /// </summary>
    type LogAnalyticsSolutionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsSolutionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsSolutionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsSolutionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsSolutionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#location-1">LogAnalyticsSolution#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogAnalyticsSolutionState<Missing, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>, value: string) : LogAnalyticsSolutionState<Present, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogAnalyticsSolutionState<Present, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>)

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#plan-1">LogAnalyticsSolution#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: LogAnalyticsSolutionState<'Location, Missing, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>, value: azurerm.LogAnalyticsSolution.LogAnalyticsSolutionPlan) : LogAnalyticsSolutionState<'Location, Present, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Plan <- value)
            ({ assignments = state.assignments } : LogAnalyticsSolutionState<'Location, Present, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#resource_group_name-1">LogAnalyticsSolution#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsSolutionState<'Location, 'Plan, Missing, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>, value: string) : LogAnalyticsSolutionState<'Location, 'Plan, Present, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsSolutionState<'Location, 'Plan, Present, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#solution_name-1">LogAnalyticsSolution#solution_name</a>.
        /// </summary>
        [<CustomOperation "solution_name">]
        member _.SolutionName(state: LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, Missing, 'WorkspaceName, 'WorkspaceResourceId>, value: string) : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, Present, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.SolutionName <- value)
            ({ assignments = state.assignments } : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, Present, 'WorkspaceName, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#workspace_name-1">LogAnalyticsSolution#workspace_name</a>.
        /// </summary>
        [<CustomOperation "workspace_name">]
        member _.WorkspaceName(state: LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, Missing, 'WorkspaceResourceId>, value: string) : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, Present, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.WorkspaceName <- value)
            ({ assignments = state.assignments } : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, Present, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#workspace_resource_id-1">LogAnalyticsSolution#workspace_resource_id</a>.
        /// </summary>
        [<CustomOperation "workspace_resource_id">]
        member _.WorkspaceResourceId(state: LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, Missing>, value: string) : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, Present> =
            state.assignments.Add(fun config -> config.WorkspaceResourceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#id-1">LogAnalyticsSolution#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>, value: string) : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#tags-1">LogAnalyticsSolution#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>, value: seq<string * string>) : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_solution#timeouts-1">LogAnalyticsSolution#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>, value: azurerm.LogAnalyticsSolution.LogAnalyticsSolutionTimeouts) : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsSolutionState<'Location, 'Plan, 'ResourceGroupName, 'SolutionName, 'WorkspaceName, 'WorkspaceResourceId>

        member _.Run(state: LogAnalyticsSolutionState<Present, Present, Present, Present, Present, Present>) : azurerm.LogAnalyticsSolution.LogAnalyticsSolution =
            let config = azurerm.LogAnalyticsSolution.LogAnalyticsSolutionConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsSolution.LogAnalyticsSolution(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsSolution: missing required arguments. Must call: location, plan, resource_group_name, solution_name, workspace_name, workspace_resource_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsSolutionState<_, _, _, _, _, _>) : azurerm.LogAnalyticsSolution.LogAnalyticsSolution =
            Unchecked.defaultof<azurerm.LogAnalyticsSolution.LogAnalyticsSolution>
