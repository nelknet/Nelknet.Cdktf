namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment">azurerm_spring_cloud_container_deployment</a>.
    /// </summary>
    type SpringCloudContainerDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudContainerDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudContainerDeploymentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudContainerDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudContainerDeploymentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#image-1">SpringCloudContainerDeployment#image</a>.
        /// </summary>
        [<CustomOperation "image">]
        member _.Image(state: SpringCloudContainerDeploymentState<Missing, 'Name, 'Server, 'SpringCloudAppId>, value: string) : SpringCloudContainerDeploymentState<Present, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Image <- value)
            ({ assignments = state.assignments } : SpringCloudContainerDeploymentState<Present, 'Name, 'Server, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#name-1">SpringCloudContainerDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudContainerDeploymentState<'Image, Missing, 'Server, 'SpringCloudAppId>, value: string) : SpringCloudContainerDeploymentState<'Image, Present, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudContainerDeploymentState<'Image, Present, 'Server, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#server-1">SpringCloudContainerDeployment#server</a>.
        /// </summary>
        [<CustomOperation "server">]
        member _.Server(state: SpringCloudContainerDeploymentState<'Image, 'Name, Missing, 'SpringCloudAppId>, value: string) : SpringCloudContainerDeploymentState<'Image, 'Name, Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Server <- value)
            ({ assignments = state.assignments } : SpringCloudContainerDeploymentState<'Image, 'Name, Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#spring_cloud_app_id-1">SpringCloudContainerDeployment#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, Missing>, value: string) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#addon_json-1">SpringCloudContainerDeployment#addon_json</a>.
        /// </summary>
        [<CustomOperation "addon_json">]
        member _.AddonJson(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: string) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.AddonJson <- value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#application_performance_monitoring_ids-1">SpringCloudContainerDeployment#application_performance_monitoring_ids</a>.
        /// </summary>
        [<CustomOperation "application_performance_monitoring_ids">]
        member _.ApplicationPerformanceMonitoringIds(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: seq<string>) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.ApplicationPerformanceMonitoringIds <- (value |> Seq.toArray))
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#arguments-1">SpringCloudContainerDeployment#arguments</a>.
        /// </summary>
        [<CustomOperation "arguments">]
        member _.Arguments(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: seq<string>) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Arguments <- (value |> Seq.toArray))
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#commands-1">SpringCloudContainerDeployment#commands</a>.
        /// </summary>
        [<CustomOperation "commands">]
        member _.Commands(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: seq<string>) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Commands <- (value |> Seq.toArray))
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#environment_variables-1">SpringCloudContainerDeployment#environment_variables</a>.
        /// </summary>
        [<CustomOperation "environment_variables">]
        member _.EnvironmentVariables(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: seq<string * string>) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.EnvironmentVariables <- dict value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#id-1">SpringCloudContainerDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: string) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#instance_count-1">SpringCloudContainerDeployment#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: double) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#language_framework-1">SpringCloudContainerDeployment#language_framework</a>.
        /// </summary>
        [<CustomOperation "language_framework">]
        member _.LanguageFramework(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: string) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.LanguageFramework <- value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// quota block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#quota-1">SpringCloudContainerDeployment#quota</a>
        /// </summary>
        [<CustomOperation "quota">]
        member _.Quota(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeploymentQuota) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Quota <- value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#timeouts-1">SpringCloudContainerDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>, value: azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeploymentTimeouts) : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudContainerDeploymentState<'Image, 'Name, 'Server, 'SpringCloudAppId>

        member _.Run(state: SpringCloudContainerDeploymentState<Present, Present, Present, Present>) : azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeployment =
            let config = azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudContainerDeployment: missing required arguments. Must call: image, name, server, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudContainerDeploymentState<_, _, _, _>) : azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeployment =
            Unchecked.defaultof<azurerm.SpringCloudContainerDeployment.SpringCloudContainerDeployment>
