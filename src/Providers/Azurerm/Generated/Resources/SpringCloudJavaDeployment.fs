namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment">azurerm_spring_cloud_java_deployment</a>.
    /// </summary>
    type SpringCloudJavaDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudJavaDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudJavaDeploymentState<Missing, Missing>)

        member _.Zero(()) : SpringCloudJavaDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudJavaDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#name-1">SpringCloudJavaDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudJavaDeploymentState<Missing, 'SpringCloudAppId>, value: string) : SpringCloudJavaDeploymentState<Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudJavaDeploymentState<Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#spring_cloud_app_id-1">SpringCloudJavaDeployment#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudJavaDeploymentState<'Name, Missing>, value: string) : SpringCloudJavaDeploymentState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudJavaDeploymentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#environment_variables-1">SpringCloudJavaDeployment#environment_variables</a>.
        /// </summary>
        [<CustomOperation "environment_variables">]
        member _.EnvironmentVariables(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: seq<string * string>) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.EnvironmentVariables <- dict value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#id-1">SpringCloudJavaDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: string) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#instance_count-1">SpringCloudJavaDeployment#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: double) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#jvm_options-1">SpringCloudJavaDeployment#jvm_options</a>.
        /// </summary>
        [<CustomOperation "jvm_options">]
        member _.JvmOptions(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: string) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.JvmOptions <- value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// quota block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#quota-1">SpringCloudJavaDeployment#quota</a>
        /// </summary>
        [<CustomOperation "quota">]
        member _.Quota(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeploymentQuota) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Quota <- value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#runtime_version-1">SpringCloudJavaDeployment#runtime_version</a>.
        /// </summary>
        [<CustomOperation "runtime_version">]
        member _.RuntimeVersion(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: string) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.RuntimeVersion <- value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#timeouts-1">SpringCloudJavaDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>, value: azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeploymentTimeouts) : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudJavaDeploymentState<'Name, 'SpringCloudAppId>

        member _.Run(state: SpringCloudJavaDeploymentState<Present, Present>) : azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeployment =
            let config = azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudJavaDeployment: missing required arguments. Must call: name, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudJavaDeploymentState<_, _>) : azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeployment =
            Unchecked.defaultof<azurerm.SpringCloudJavaDeployment.SpringCloudJavaDeployment>
