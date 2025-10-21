namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment">azurerm_spring_cloud_build_deployment</a>.
    /// </summary>
    type SpringCloudBuildDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudBuildDeploymentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudBuildDeploymentState<Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudBuildDeploymentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudBuildDeploymentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#build_result_id-1">SpringCloudBuildDeployment#build_result_id</a>.
        /// </summary>
        [<CustomOperation "build_result_id">]
        member _.BuildResultId(state: SpringCloudBuildDeploymentState<Missing, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudBuildDeploymentState<Present, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.BuildResultId <- value)
            ({ assignments = state.assignments } : SpringCloudBuildDeploymentState<Present, 'Name, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#name-1">SpringCloudBuildDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudBuildDeploymentState<'BuildResultId, Missing, 'SpringCloudAppId>, value: string) : SpringCloudBuildDeploymentState<'BuildResultId, Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudBuildDeploymentState<'BuildResultId, Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#spring_cloud_app_id-1">SpringCloudBuildDeployment#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, Missing>, value: string) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#addon_json-1">SpringCloudBuildDeployment#addon_json</a>.
        /// </summary>
        [<CustomOperation "addon_json">]
        member _.AddonJson(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.AddonJson <- value)
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#application_performance_monitoring_ids-1">SpringCloudBuildDeployment#application_performance_monitoring_ids</a>.
        /// </summary>
        [<CustomOperation "application_performance_monitoring_ids">]
        member _.ApplicationPerformanceMonitoringIds(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: seq<string>) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.ApplicationPerformanceMonitoringIds <- (value |> Seq.toArray))
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#environment_variables-1">SpringCloudBuildDeployment#environment_variables</a>.
        /// </summary>
        [<CustomOperation "environment_variables">]
        member _.EnvironmentVariables(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: seq<string * string>) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.EnvironmentVariables <- dict value)
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#id-1">SpringCloudBuildDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#instance_count-1">SpringCloudBuildDeployment#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: double) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// quota block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#quota-1">SpringCloudBuildDeployment#quota</a>
        /// </summary>
        [<CustomOperation "quota">]
        member _.Quota(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeploymentQuota) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Quota <- value)
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#timeouts-1">SpringCloudBuildDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>, value: azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeploymentTimeouts) : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudBuildDeploymentState<'BuildResultId, 'Name, 'SpringCloudAppId>

        member _.Run(state: SpringCloudBuildDeploymentState<Present, Present, Present>) : azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeployment =
            let config = azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudBuildDeployment: missing required arguments. Must call: build_result_id, name, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudBuildDeploymentState<_, _, _>) : azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeployment =
            Unchecked.defaultof<azurerm.SpringCloudBuildDeployment.SpringCloudBuildDeployment>
