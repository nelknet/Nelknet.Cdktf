namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_active_deployment">azurerm_spring_cloud_active_deployment</a>.
    /// </summary>
    type SpringCloudActiveDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudActiveDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudActiveDeploymentState<Missing, Missing>)

        member _.Zero(()) : SpringCloudActiveDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudActiveDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_active_deployment#deployment_name-1">SpringCloudActiveDeployment#deployment_name</a>.
        /// </summary>
        [<CustomOperation "deployment_name">]
        member _.DeploymentName(state: SpringCloudActiveDeploymentState<Missing, 'SpringCloudAppId>, value: string) : SpringCloudActiveDeploymentState<Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.DeploymentName <- value)
            ({ assignments = state.assignments } : SpringCloudActiveDeploymentState<Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_active_deployment#spring_cloud_app_id-1">SpringCloudActiveDeployment#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudActiveDeploymentState<'DeploymentName, Missing>, value: string) : SpringCloudActiveDeploymentState<'DeploymentName, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudActiveDeploymentState<'DeploymentName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_active_deployment#id-1">SpringCloudActiveDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId>, value: string) : SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_active_deployment#timeouts-1">SpringCloudActiveDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId>, value: azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeploymentTimeouts) : SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudActiveDeploymentState<'DeploymentName, 'SpringCloudAppId>

        member _.Run(state: SpringCloudActiveDeploymentState<Present, Present>) : azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeployment =
            let config = azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudActiveDeployment: missing required arguments. Must call: deployment_name, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudActiveDeploymentState<_, _>) : azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeployment =
            Unchecked.defaultof<azurerm.SpringCloudActiveDeployment.SpringCloudActiveDeployment>
