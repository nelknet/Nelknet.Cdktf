namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring">azurerm_spring_cloud_new_relic_application_performance_monitoring</a>.
    /// </summary>
    type SpringCloudNewRelicApplicationPerformanceMonitoringBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudNewRelicApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudNewRelicApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudNewRelicApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudNewRelicApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#app_name-1">SpringCloudNewRelicApplicationPerformanceMonitoring#app_name</a>.
        /// </summary>
        [<CustomOperation "app_name">]
        member _.AppName(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<Missing, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudNewRelicApplicationPerformanceMonitoringState<Present, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AppName <- value)
            ({ assignments = state.assignments } : SpringCloudNewRelicApplicationPerformanceMonitoringState<Present, 'LicenseKey, 'Name, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#license_key-1">SpringCloudNewRelicApplicationPerformanceMonitoring#license_key</a>.
        /// </summary>
        [<CustomOperation "license_key">]
        member _.LicenseKey(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, Missing, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, Present, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.LicenseKey <- value)
            ({ assignments = state.assignments } : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, Present, 'Name, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#name-1">SpringCloudNewRelicApplicationPerformanceMonitoring#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, Missing, 'SpringCloudServiceId>, value: string) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#spring_cloud_service_id-1">SpringCloudNewRelicApplicationPerformanceMonitoring#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, Missing>, value: string) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#agent_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#agent_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "agent_enabled">]
        member _.AgentEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#agent_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#agent_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "agent_enabled">]
        member _.AgentEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AgentEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#app_server_port-1">SpringCloudNewRelicApplicationPerformanceMonitoring#app_server_port</a>.
        /// </summary>
        [<CustomOperation "app_server_port">]
        member _.AppServerPort(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: double) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AppServerPort <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#audit_mode_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#audit_mode_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "audit_mode_enabled">]
        member _.AuditModeEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AuditModeEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#audit_mode_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#audit_mode_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "audit_mode_enabled">]
        member _.AuditModeEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AuditModeEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#auto_app_naming_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#auto_app_naming_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_app_naming_enabled">]
        member _.AutoAppNamingEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AutoAppNamingEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#auto_app_naming_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#auto_app_naming_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_app_naming_enabled">]
        member _.AutoAppNamingEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AutoAppNamingEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#auto_transaction_naming_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#auto_transaction_naming_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_transaction_naming_enabled">]
        member _.AutoTransactionNamingEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AutoTransactionNamingEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#auto_transaction_naming_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#auto_transaction_naming_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_transaction_naming_enabled">]
        member _.AutoTransactionNamingEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.AutoTransactionNamingEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#custom_tracing_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#custom_tracing_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "custom_tracing_enabled">]
        member _.CustomTracingEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.CustomTracingEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#custom_tracing_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#custom_tracing_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "custom_tracing_enabled">]
        member _.CustomTracingEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.CustomTracingEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#globally_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#globally_enabled-1">SpringCloudNewRelicApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#id-1">SpringCloudNewRelicApplicationPerformanceMonitoring#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: string) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#labels-1">SpringCloudNewRelicApplicationPerformanceMonitoring#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: seq<string * string>) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_new_relic_application_performance_monitoring#timeouts-1">SpringCloudNewRelicApplicationPerformanceMonitoring#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoringTimeouts) : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudNewRelicApplicationPerformanceMonitoringState<'AppName, 'LicenseKey, 'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudNewRelicApplicationPerformanceMonitoringState<Present, Present, Present, Present>) : azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoring =
            let config = azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoringConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoring(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudNewRelicApplicationPerformanceMonitoring: missing required arguments. Must call: app_name, license_key, name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudNewRelicApplicationPerformanceMonitoringState<_, _, _, _>) : azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoring =
            Unchecked.defaultof<azurerm.SpringCloudNewRelicApplicationPerformanceMonitoring.SpringCloudNewRelicApplicationPerformanceMonitoring>
