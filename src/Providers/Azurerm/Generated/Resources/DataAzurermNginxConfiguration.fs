namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNginxConfigurationState<'NginxDeploymentId> = { assignments: ResizeArray<azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_configuration">azurerm_nginx_configuration</a>.
    /// </summary>
    type DataAzurermNginxConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNginxConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNginxConfigurationState<Missing>)

        member _.Zero(()) : DataAzurermNginxConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNginxConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_configuration#nginx_deployment_id-1">DataAzurermNginxConfiguration#nginx_deployment_id</a>.
        /// </summary>
        [<CustomOperation "nginx_deployment_id">]
        member _.NginxDeploymentId(state: DataAzurermNginxConfigurationState<Missing>, value: string) : DataAzurermNginxConfigurationState<Present> =
            state.assignments.Add(fun config -> config.NginxDeploymentId <- value)
            ({ assignments = state.assignments } : DataAzurermNginxConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_configuration#id-1">DataAzurermNginxConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNginxConfigurationState<'NginxDeploymentId>, value: string) : DataAzurermNginxConfigurationState<'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNginxConfigurationState<'NginxDeploymentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_configuration#timeouts-1">DataAzurermNginxConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNginxConfigurationState<'NginxDeploymentId>, value: azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfigurationTimeouts) : DataAzurermNginxConfigurationState<'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNginxConfigurationState<'NginxDeploymentId>

        member _.Run(state: DataAzurermNginxConfigurationState<Present>) : azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfiguration =
            let config = azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNginxConfiguration: missing required arguments. Must call: nginx_deployment_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNginxConfigurationState<_>) : azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfiguration =
            Unchecked.defaultof<azurerm.DataAzurermNginxConfiguration.DataAzurermNginxConfiguration>
