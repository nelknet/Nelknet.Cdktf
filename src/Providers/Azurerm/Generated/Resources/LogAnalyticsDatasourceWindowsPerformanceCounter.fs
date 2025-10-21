namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> = { assignments: ResizeArray<azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter">azurerm_log_analytics_datasource_windows_performance_counter</a>.
    /// </summary>
    type LogAnalyticsDatasourceWindowsPerformanceCounterBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsDatasourceWindowsPerformanceCounterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsDatasourceWindowsPerformanceCounterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsDatasourceWindowsPerformanceCounterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsDatasourceWindowsPerformanceCounterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#counter_name-1">LogAnalyticsDatasourceWindowsPerformanceCounter#counter_name</a>.
        /// </summary>
        [<CustomOperation "counter_name">]
        member _.CounterName(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<Missing, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<Present, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.CounterName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<Present, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#instance_name-1">LogAnalyticsDatasourceWindowsPerformanceCounter#instance_name</a>.
        /// </summary>
        [<CustomOperation "instance_name">]
        member _.InstanceName(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, Missing, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, Present, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.InstanceName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, Present, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#interval_seconds-1">LogAnalyticsDatasourceWindowsPerformanceCounter#interval_seconds</a>.
        /// </summary>
        [<CustomOperation "interval_seconds">]
        member _.IntervalSeconds(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, Missing, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>, value: double) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, Present, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.IntervalSeconds <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, Present, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#name-1">LogAnalyticsDatasourceWindowsPerformanceCounter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, Missing, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, Present, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, Present, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#object_name-1">LogAnalyticsDatasourceWindowsPerformanceCounter#object_name</a>.
        /// </summary>
        [<CustomOperation "object_name">]
        member _.ObjectName(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, Missing, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, Present, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.ObjectName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, Present, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#resource_group_name-1">LogAnalyticsDatasourceWindowsPerformanceCounter#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, Missing, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, Present, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, Present, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#workspace_name-1">LogAnalyticsDatasourceWindowsPerformanceCounter#workspace_name</a>.
        /// </summary>
        [<CustomOperation "workspace_name">]
        member _.WorkspaceName(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, Missing>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.WorkspaceName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#id-1">LogAnalyticsDatasourceWindowsPerformanceCounter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_performance_counter#timeouts-1">LogAnalyticsDatasourceWindowsPerformanceCounter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>, value: azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounterTimeouts) : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsDatasourceWindowsPerformanceCounterState<'CounterName, 'InstanceName, 'IntervalSeconds, 'Name, 'ObjectName, 'ResourceGroupName, 'WorkspaceName>

        member _.Run(state: LogAnalyticsDatasourceWindowsPerformanceCounterState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounter =
            let config = azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounterConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsDatasourceWindowsPerformanceCounter: missing required arguments. Must call: counter_name, instance_name, interval_seconds, name, object_name, resource_group_name, workspace_name.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsDatasourceWindowsPerformanceCounterState<_, _, _, _, _, _, _>) : azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounter =
            Unchecked.defaultof<azurerm.LogAnalyticsDatasourceWindowsPerformanceCounter.LogAnalyticsDatasourceWindowsPerformanceCounter>
