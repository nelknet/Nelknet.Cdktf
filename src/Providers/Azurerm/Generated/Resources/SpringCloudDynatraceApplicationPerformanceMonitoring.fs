namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> = { assignments: ResizeArray<azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring">azurerm_spring_cloud_dynatrace_application_performance_monitoring</a>.
    /// </summary>
    type SpringCloudDynatraceApplicationPerformanceMonitoringBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudDynatraceApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudDynatraceApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudDynatraceApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudDynatraceApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#connection_point-1">SpringCloudDynatraceApplicationPerformanceMonitoring#connection_point</a>.
        /// </summary>
        [<CustomOperation "connection_point">]
        member _.ConnectionPoint(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<Missing, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<Present, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.ConnectionPoint <- value)
            ({ assignments = state.assignments } : SpringCloudDynatraceApplicationPerformanceMonitoringState<Present, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#name-1">SpringCloudDynatraceApplicationPerformanceMonitoring#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, Missing, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, Present, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, Present, 'SpringCloudServiceId, 'Tenant, 'TenantToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#spring_cloud_service_id-1">SpringCloudDynatraceApplicationPerformanceMonitoring#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, Missing, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, Present, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, Present, 'Tenant, 'TenantToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#tenant-1">SpringCloudDynatraceApplicationPerformanceMonitoring#tenant</a>.
        /// </summary>
        [<CustomOperation "tenant">]
        member _.Tenant(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, Missing, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, Present, 'TenantToken> =
            state.assignments.Add(fun config -> config.Tenant <- value)
            ({ assignments = state.assignments } : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, Present, 'TenantToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#tenant_token-1">SpringCloudDynatraceApplicationPerformanceMonitoring#tenant_token</a>.
        /// </summary>
        [<CustomOperation "tenant_token">]
        member _.TenantToken(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, Missing>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, Present> =
            state.assignments.Add(fun config -> config.TenantToken <- value)
            ({ assignments = state.assignments } : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#api_token-1">SpringCloudDynatraceApplicationPerformanceMonitoring#api_token</a>.
        /// </summary>
        [<CustomOperation "api_token">]
        member _.ApiToken(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.ApiToken <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#api_url-1">SpringCloudDynatraceApplicationPerformanceMonitoring#api_url</a>.
        /// </summary>
        [<CustomOperation "api_url">]
        member _.ApiUrl(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.ApiUrl <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#environment_id-1">SpringCloudDynatraceApplicationPerformanceMonitoring#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#globally_enabled-1">SpringCloudDynatraceApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: bool) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#globally_enabled-1">SpringCloudDynatraceApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#id-1">SpringCloudDynatraceApplicationPerformanceMonitoring#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: string) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dynatrace_application_performance_monitoring#timeouts-1">SpringCloudDynatraceApplicationPerformanceMonitoring#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>, value: azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoringTimeouts) : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudDynatraceApplicationPerformanceMonitoringState<'ConnectionPoint, 'Name, 'SpringCloudServiceId, 'Tenant, 'TenantToken>

        member _.Run(state: SpringCloudDynatraceApplicationPerformanceMonitoringState<Present, Present, Present, Present, Present>) : azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoring =
            let config = azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoringConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoring(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudDynatraceApplicationPerformanceMonitoring: missing required arguments. Must call: connection_point, name, spring_cloud_service_id, tenant, tenant_token.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudDynatraceApplicationPerformanceMonitoringState<_, _, _, _, _>) : azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoring =
            Unchecked.defaultof<azurerm.SpringCloudDynatraceApplicationPerformanceMonitoring.SpringCloudDynatraceApplicationPerformanceMonitoring>
