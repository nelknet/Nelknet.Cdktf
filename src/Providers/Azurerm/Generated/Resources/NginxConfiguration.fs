namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NginxConfigurationState<'NginxDeploymentId, 'RootFile> = { assignments: ResizeArray<azurerm.NginxConfiguration.NginxConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration">azurerm_nginx_configuration</a>.
    /// </summary>
    type NginxConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NginxConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NginxConfigurationState<Missing, Missing>)

        member _.Zero(()) : NginxConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NginxConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#nginx_deployment_id-1">NginxConfiguration#nginx_deployment_id</a>.
        /// </summary>
        [<CustomOperation "nginx_deployment_id">]
        member _.NginxDeploymentId(state: NginxConfigurationState<Missing, 'RootFile>, value: string) : NginxConfigurationState<Present, 'RootFile> =
            state.assignments.Add(fun config -> config.NginxDeploymentId <- value)
            ({ assignments = state.assignments } : NginxConfigurationState<Present, 'RootFile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#root_file-1">NginxConfiguration#root_file</a>.
        /// </summary>
        [<CustomOperation "root_file">]
        member _.RootFile(state: NginxConfigurationState<'NginxDeploymentId, Missing>, value: string) : NginxConfigurationState<'NginxDeploymentId, Present> =
            state.assignments.Add(fun config -> config.RootFile <- value)
            ({ assignments = state.assignments } : NginxConfigurationState<'NginxDeploymentId, Present>)

        /// <summary>
        /// config_file block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#config_file-1">NginxConfiguration#config_file</a> Accepts: azurerm.IResolvable | azurerm.NginxConfiguration.NginxConfigurationConfigFile[]
        /// </summary>
        [<CustomOperation "config_file">]
        member _.ConfigFile(state: NginxConfigurationState<'NginxDeploymentId, 'RootFile>, value: HashiCorp.Cdktf.IResolvable) : NginxConfigurationState<'NginxDeploymentId, 'RootFile> =
            state.assignments.Add(fun config -> config.ConfigFile <- value)
            state : NginxConfigurationState<'NginxDeploymentId, 'RootFile>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#id-1">NginxConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NginxConfigurationState<'NginxDeploymentId, 'RootFile>, value: string) : NginxConfigurationState<'NginxDeploymentId, 'RootFile> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NginxConfigurationState<'NginxDeploymentId, 'RootFile>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#package_data-1">NginxConfiguration#package_data</a>.
        /// </summary>
        [<CustomOperation "package_data">]
        member _.PackageData(state: NginxConfigurationState<'NginxDeploymentId, 'RootFile>, value: string) : NginxConfigurationState<'NginxDeploymentId, 'RootFile> =
            state.assignments.Add(fun config -> config.PackageData <- value)
            state : NginxConfigurationState<'NginxDeploymentId, 'RootFile>

        /// <summary>
        /// protected_file block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#protected_file-1">NginxConfiguration#protected_file</a> Accepts: azurerm.IResolvable | azurerm.NginxConfiguration.NginxConfigurationProtectedFile[]
        /// </summary>
        [<CustomOperation "protected_file">]
        member _.ProtectedFile(state: NginxConfigurationState<'NginxDeploymentId, 'RootFile>, value: HashiCorp.Cdktf.IResolvable) : NginxConfigurationState<'NginxDeploymentId, 'RootFile> =
            state.assignments.Add(fun config -> config.ProtectedFile <- value)
            state : NginxConfigurationState<'NginxDeploymentId, 'RootFile>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#timeouts-1">NginxConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NginxConfigurationState<'NginxDeploymentId, 'RootFile>, value: azurerm.NginxConfiguration.NginxConfigurationTimeouts) : NginxConfigurationState<'NginxDeploymentId, 'RootFile> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NginxConfigurationState<'NginxDeploymentId, 'RootFile>

        member _.Run(state: NginxConfigurationState<Present, Present>) : azurerm.NginxConfiguration.NginxConfiguration =
            let config = azurerm.NginxConfiguration.NginxConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NginxConfiguration.NginxConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.nginxConfiguration: missing required arguments. Must call: nginx_deployment_id, root_file.", 9999, IsError = true)>]
        member _.Run(_: NginxConfigurationState<_, _>) : azurerm.NginxConfiguration.NginxConfiguration =
            Unchecked.defaultof<azurerm.NginxConfiguration.NginxConfiguration>
