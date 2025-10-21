namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring">azurerm_spring_cloud_app_dynamics_application_performance_monitoring</a>.
    /// </summary>
    type SpringCloudAppDynamicsApplicationPerformanceMonitoringBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_account_access_key-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_account_access_key</a>.
        /// </summary>
        [<CustomOperation "agent_account_access_key">]
        member _.AgentAccountAccessKey(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Missing, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Present, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentAccountAccessKey <- value)
            ({ assignments = state.assignments } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Present, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_account_name-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_account_name</a>.
        /// </summary>
        [<CustomOperation "agent_account_name">]
        member _.AgentAccountName(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, Missing, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, Present, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentAccountName <- value)
            ({ assignments = state.assignments } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, Present, 'ControllerHostName, 'Name, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_host_name-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_host_name</a>.
        /// </summary>
        [<CustomOperation "controller_host_name">]
        member _.ControllerHostName(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, Missing, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, Present, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ControllerHostName <- value)
            ({ assignments = state.assignments } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, Present, 'Name, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#name-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, Missing, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#spring_cloud_service_id-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, Missing>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_application_name-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_application_name</a>.
        /// </summary>
        [<CustomOperation "agent_application_name">]
        member _.AgentApplicationName(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentApplicationName <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_node_name-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_node_name</a>.
        /// </summary>
        [<CustomOperation "agent_node_name">]
        member _.AgentNodeName(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentNodeName <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_tier_name-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_tier_name</a>.
        /// </summary>
        [<CustomOperation "agent_tier_name">]
        member _.AgentTierName(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentTierName <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_unique_host_id-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_unique_host_id</a>.
        /// </summary>
        [<CustomOperation "agent_unique_host_id">]
        member _.AgentUniqueHostId(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentUniqueHostId <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_port-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_port</a>.
        /// </summary>
        [<CustomOperation "controller_port">]
        member _.ControllerPort(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: double) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ControllerPort <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_ssl_enabled-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_ssl_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "controller_ssl_enabled">]
        member _.ControllerSslEnabled(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ControllerSslEnabled <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_ssl_enabled-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_ssl_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "controller_ssl_enabled">]
        member _.ControllerSslEnabled(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ControllerSslEnabled <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#globally_enabled-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#globally_enabled-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#id-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#timeouts-1">SpringCloudAppDynamicsApplicationPerformanceMonitoring#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringTimeouts) : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudAppDynamicsApplicationPerformanceMonitoringState<'AgentAccountAccessKey, 'AgentAccountName, 'ControllerHostName, 'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<Present, Present, Present, Present, Present>) : azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoring =
            let config = azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoring(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudAppDynamicsApplicationPerformanceMonitoring: missing required arguments. Must call: agent_account_access_key, agent_account_name, controller_host_name, name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudAppDynamicsApplicationPerformanceMonitoringState<_, _, _, _, _>) : azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoring =
            Unchecked.defaultof<azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoring>
