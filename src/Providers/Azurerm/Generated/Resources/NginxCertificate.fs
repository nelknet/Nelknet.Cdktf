namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId> = { assignments: ResizeArray<azurerm.NginxCertificate.NginxCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate">azurerm_nginx_certificate</a>.
    /// </summary>
    type NginxCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : NginxCertificateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NginxCertificateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NginxCertificateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NginxCertificateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#certificate_virtual_path-1">NginxCertificate#certificate_virtual_path</a>.
        /// </summary>
        [<CustomOperation "certificate_virtual_path">]
        member _.CertificateVirtualPath(state: NginxCertificateState<Missing, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>, value: string) : NginxCertificateState<Present, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.CertificateVirtualPath <- value)
            ({ assignments = state.assignments } : NginxCertificateState<Present, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#key_vault_secret_id-1">NginxCertificate#key_vault_secret_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_secret_id">]
        member _.KeyVaultSecretId(state: NginxCertificateState<'CertificateVirtualPath, Missing, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>, value: string) : NginxCertificateState<'CertificateVirtualPath, Present, 'KeyVirtualPath, 'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.KeyVaultSecretId <- value)
            ({ assignments = state.assignments } : NginxCertificateState<'CertificateVirtualPath, Present, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#key_virtual_path-1">NginxCertificate#key_virtual_path</a>.
        /// </summary>
        [<CustomOperation "key_virtual_path">]
        member _.KeyVirtualPath(state: NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, Missing, 'Name, 'NginxDeploymentId>, value: string) : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, Present, 'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.KeyVirtualPath <- value)
            ({ assignments = state.assignments } : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, Present, 'Name, 'NginxDeploymentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#name-1">NginxCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, Missing, 'NginxDeploymentId>, value: string) : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, Present, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, Present, 'NginxDeploymentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#nginx_deployment_id-1">NginxCertificate#nginx_deployment_id</a>.
        /// </summary>
        [<CustomOperation "nginx_deployment_id">]
        member _.NginxDeploymentId(state: NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, Missing>, value: string) : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, Present> =
            state.assignments.Add(fun config -> config.NginxDeploymentId <- value)
            ({ assignments = state.assignments } : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#id-1">NginxCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>, value: string) : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_certificate#timeouts-1">NginxCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>, value: azurerm.NginxCertificate.NginxCertificateTimeouts) : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NginxCertificateState<'CertificateVirtualPath, 'KeyVaultSecretId, 'KeyVirtualPath, 'Name, 'NginxDeploymentId>

        member _.Run(state: NginxCertificateState<Present, Present, Present, Present, Present>) : azurerm.NginxCertificate.NginxCertificate =
            let config = azurerm.NginxCertificate.NginxCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.NginxCertificate.NginxCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.nginxCertificate: missing required arguments. Must call: certificate_virtual_path, key_vault_secret_id, key_virtual_path, name, nginx_deployment_id.", 9999, IsError = true)>]
        member _.Run(_: NginxCertificateState<_, _, _, _, _>) : azurerm.NginxCertificate.NginxCertificate =
            Unchecked.defaultof<azurerm.NginxCertificate.NginxCertificate>
