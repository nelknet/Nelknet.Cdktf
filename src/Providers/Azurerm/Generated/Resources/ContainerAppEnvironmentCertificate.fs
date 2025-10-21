namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name> = { assignments: ResizeArray<azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate">azurerm_container_app_environment_certificate</a>.
    /// </summary>
    type ContainerAppEnvironmentCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppEnvironmentCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentCertificateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppEnvironmentCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentCertificateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The Certificate Private Key as a base64 encoded PFX or PEM. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#certificate_blob_base64-1">ContainerAppEnvironmentCertificate#certificate_blob_base64</a>
        /// </summary>
        [<CustomOperation "certificate_blob_base64">]
        member _.CertificateBlobBase64(state: ContainerAppEnvironmentCertificateState<Missing, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>, value: string) : ContainerAppEnvironmentCertificateState<Present, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.CertificateBlobBase64 <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCertificateState<Present, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>)

        /// <summary>
        /// The password for the Certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#certificate_password-1">ContainerAppEnvironmentCertificate#certificate_password</a>
        /// </summary>
        [<CustomOperation "certificate_password">]
        member _.CertificatePassword(state: ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, Missing, 'ContainerAppEnvironmentId, 'Name>, value: string) : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, Present, 'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.CertificatePassword <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, Present, 'ContainerAppEnvironmentId, 'Name>)

        /// <summary>
        /// The Container App Managed Environment ID to configure this Certificate on. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#container_app_environment_id-1">ContainerAppEnvironmentCertificate#container_app_environment_id</a>
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, Missing, 'Name>, value: string) : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, Present, 'Name>)

        /// <summary>
        /// The name of the Container Apps Environment Certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#name-1">ContainerAppEnvironmentCertificate#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, Missing>, value: string) : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#id-1">ContainerAppEnvironmentCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>, value: string) : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#tags-1">ContainerAppEnvironmentCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>, value: seq<string * string>) : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_certificate#timeouts-1">ContainerAppEnvironmentCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>, value: azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateTimeouts) : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppEnvironmentCertificateState<'CertificateBlobBase64, 'CertificatePassword, 'ContainerAppEnvironmentId, 'Name>

        member _.Run(state: ContainerAppEnvironmentCertificateState<Present, Present, Present, Present>) : azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificate =
            let config = azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppEnvironmentCertificate: missing required arguments. Must call: certificate_blob_base64, certificate_password, container_app_environment_id, name.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppEnvironmentCertificateState<_, _, _, _>) : azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificate =
            Unchecked.defaultof<azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificate>
