namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring">azurerm_spring_cloud_elastic_application_performance_monitoring</a>.
    /// </summary>
    type SpringCloudElasticApplicationPerformanceMonitoringBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudElasticApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudElasticApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudElasticApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudElasticApplicationPerformanceMonitoringState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#application_packages-1">SpringCloudElasticApplicationPerformanceMonitoring#application_packages</a>.
        /// </summary>
        [<CustomOperation "application_packages">]
        member _.ApplicationPackages(state: SpringCloudElasticApplicationPerformanceMonitoringState<Missing, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>, value: seq<string>) : SpringCloudElasticApplicationPerformanceMonitoringState<Present, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationPackages <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SpringCloudElasticApplicationPerformanceMonitoringState<Present, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#name-1">SpringCloudElasticApplicationPerformanceMonitoring#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, Missing, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>, value: string) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, Present, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, Present, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#server_url-1">SpringCloudElasticApplicationPerformanceMonitoring#server_url</a>.
        /// </summary>
        [<CustomOperation "server_url">]
        member _.ServerUrl(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, Missing, 'ServiceName, 'SpringCloudServiceId>, value: string) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, Present, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ServerUrl <- value)
            ({ assignments = state.assignments } : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, Present, 'ServiceName, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#service_name-1">SpringCloudElasticApplicationPerformanceMonitoring#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, Missing, 'SpringCloudServiceId>, value: string) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#spring_cloud_service_id-1">SpringCloudElasticApplicationPerformanceMonitoring#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, Missing>, value: string) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#globally_enabled-1">SpringCloudElasticApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>, value: bool) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#globally_enabled-1">SpringCloudElasticApplicationPerformanceMonitoring#globally_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "globally_enabled">]
        member _.GloballyEnabled(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GloballyEnabled <- value)
            state : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#id-1">SpringCloudElasticApplicationPerformanceMonitoring#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>, value: string) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#timeouts-1">SpringCloudElasticApplicationPerformanceMonitoring#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>, value: azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoringTimeouts) : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudElasticApplicationPerformanceMonitoringState<'ApplicationPackages, 'Name, 'ServerUrl, 'ServiceName, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudElasticApplicationPerformanceMonitoringState<Present, Present, Present, Present, Present>) : azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoring =
            let config = azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoringConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoring(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudElasticApplicationPerformanceMonitoring: missing required arguments. Must call: application_packages, name, server_url, service_name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudElasticApplicationPerformanceMonitoringState<_, _, _, _, _>) : azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoring =
            Unchecked.defaultof<azurerm.SpringCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoring>
