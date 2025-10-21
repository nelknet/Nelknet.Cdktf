namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix> = { assignments: ResizeArray<azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain">azurerm_container_app_environment_custom_domain</a>.
    /// </summary>
    type ContainerAppEnvironmentCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppEnvironmentCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentCustomDomainState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppEnvironmentCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentCustomDomainState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The Custom Domain Certificate Private Key as a base64 encoded PFX or PEM. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain#certificate_blob_base64-1">ContainerAppEnvironmentCustomDomain#certificate_blob_base64</a>
        /// </summary>
        [<CustomOperation "certificate_blob_base64">]
        member _.CertificateBlobBase64(state: ContainerAppEnvironmentCustomDomainState<Missing, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix>, value: string) : ContainerAppEnvironmentCustomDomainState<Present, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix> =
            state.assignments.Add(fun config -> config.CertificateBlobBase64 <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCustomDomainState<Present, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix>)

        /// <summary>
        /// The Custom Domain Certificate password. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain#certificate_password-1">ContainerAppEnvironmentCustomDomain#certificate_password</a>
        /// </summary>
        [<CustomOperation "certificate_password">]
        member _.CertificatePassword(state: ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, Missing, 'ContainerAppEnvironmentId, 'DnsSuffix>, value: string) : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, Present, 'ContainerAppEnvironmentId, 'DnsSuffix> =
            state.assignments.Add(fun config -> config.CertificatePassword <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, Present, 'ContainerAppEnvironmentId, 'DnsSuffix>)

        /// <summary>
        /// The Container App Managed Environment ID to configure this Custom Domain on. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain#container_app_environment_id-1">ContainerAppEnvironmentCustomDomain#container_app_environment_id</a>
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, Missing, 'DnsSuffix>, value: string) : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, Present, 'DnsSuffix> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, Present, 'DnsSuffix>)

        /// <summary>
        /// The Custom Domain DNS suffix for this Container App Environment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain#dns_suffix-1">ContainerAppEnvironmentCustomDomain#dns_suffix</a>
        /// </summary>
        [<CustomOperation "dns_suffix">]
        member _.DnsSuffix(state: ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, Missing>, value: string) : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, Present> =
            state.assignments.Add(fun config -> config.DnsSuffix <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain#id-1">ContainerAppEnvironmentCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix>, value: string) : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_custom_domain#timeouts-1">ContainerAppEnvironmentCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix>, value: azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainTimeouts) : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppEnvironmentCustomDomainState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'DnsSuffix>

        member _.Run(state: ContainerAppEnvironmentCustomDomainState<Present, Present, Present, Present>) : azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomain =
            let config = azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppEnvironmentCustomDomain: missing required arguments. Must call: certificate_blob_base64, certificate_password, container_app_environment_id, dns_suffix.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppEnvironmentCustomDomainState<_, _, _, _>) : azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomain =
            Unchecked.defaultof<azurerm.ContainerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomain>
