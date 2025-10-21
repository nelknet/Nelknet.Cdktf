namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId> = { assignments: ResizeArray<azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate">azurerm_nginx_certificate</a>.
    /// </summary>
    type DataAzurermNginxCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNginxCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNginxCertificateState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNginxCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNginxCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#name-1">DataAzurermNginxCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNginxCertificateState<Missing, 'NginxDeploymentId>, value: string) : DataAzurermNginxCertificateState<Present, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNginxCertificateState<Present, 'NginxDeploymentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#nginx_deployment_id-1">DataAzurermNginxCertificate#nginx_deployment_id</a>.
        /// </summary>
        [<CustomOperation "nginx_deployment_id">]
        member _.NginxDeploymentId(state: DataAzurermNginxCertificateState<'Name, Missing>, value: string) : DataAzurermNginxCertificateState<'Name, Present> =
            state.assignments.Add(fun config -> config.NginxDeploymentId <- value)
            ({ assignments = state.assignments } : DataAzurermNginxCertificateState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#id-1">DataAzurermNginxCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId>, value: string) : DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#timeouts-1">DataAzurermNginxCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId>, value: azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificateTimeouts) : DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNginxCertificateState<'Name, 'NginxDeploymentId>

        member _.Run(state: DataAzurermNginxCertificateState<Present, Present>) : azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificate =
            let config = azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNginxCertificate: missing required arguments. Must call: name, nginx_deployment_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNginxCertificateState<_, _>) : azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificate =
            Unchecked.defaultof<azurerm.DataAzurermNginxCertificate.DataAzurermNginxCertificate>
