namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring">azurerm_spring_cloud_application_insights_application_performance_monitoring</a>.
    /// </summary>
    type SpringCloudApplicationInsightsApplicationPerformanceMonitoringBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Missing, Missing>)

        member _.Zero(()) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#name-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#spring_cloud_service_id-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, Missing>, value: string) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#connection_string-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#globally_enabled-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#globally_enabled-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#id-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#role_instance-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#role_instance</a>.
        /// </summary>
        [<CustomOperation "role_instance">]
        member _.RoleInstance(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.RoleInstance <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#role_name-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#sampling_percentage-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#sampling_percentage</a>.
        /// </summary>
        [<CustomOperation "sampling_percentage">]
        member _.SamplingPercentage(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: double) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.SamplingPercentage <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#sampling_requests_per_second-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#sampling_requests_per_second</a>.
        /// </summary>
        [<CustomOperation "sampling_requests_per_second">]
        member _.SamplingRequestsPerSecond(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: double) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.SamplingRequestsPerSecond <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_insights_application_performance_monitoring#timeouts-1">SpringCloudApplicationInsightsApplicationPerformanceMonitoring#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeouts) : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<Present, Present>) : azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoring =
            let config = azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoringConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoring(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudApplicationInsightsApplicationPerformanceMonitoring: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudApplicationInsightsApplicationPerformanceMonitoringState<_, _>) : azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoring =
            Unchecked.defaultof<azurerm.SpringCloudApplicationInsightsApplicationPerformanceMonitoring.SpringCloudApplicationInsightsApplicationPerformanceMonitoring>
