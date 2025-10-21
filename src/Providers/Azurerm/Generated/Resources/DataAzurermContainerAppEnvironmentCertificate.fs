namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment_certificate">azurerm_container_app_environment_certificate</a>.
    /// </summary>
    type DataAzurermContainerAppEnvironmentCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerAppEnvironmentCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerAppEnvironmentCertificateState<Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerAppEnvironmentCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerAppEnvironmentCertificateState<Missing, Missing>)

        /// <summary>
        /// The Container App Managed Environment ID to configure this Certificate on. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment_certificate#container_app_environment_id-1">DataAzurermContainerAppEnvironmentCertificate#container_app_environment_id</a>
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: DataAzurermContainerAppEnvironmentCertificateState<Missing, 'Name>, value: string) : DataAzurermContainerAppEnvironmentCertificateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : DataAzurermContainerAppEnvironmentCertificateState<Present, 'Name>)

        /// <summary>
        /// The name of the Container Apps Certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment_certificate#name-1">DataAzurermContainerAppEnvironmentCertificate#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, Missing>, value: string) : DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment_certificate#id-1">DataAzurermContainerAppEnvironmentCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name>, value: string) : DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment_certificate#timeouts-1">DataAzurermContainerAppEnvironmentCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name>, value: azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificateTimeouts) : DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerAppEnvironmentCertificateState<'ContainerAppEnvironmentId, 'Name>

        member _.Run(state: DataAzurermContainerAppEnvironmentCertificateState<Present, Present>) : azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificate =
            let config = azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerAppEnvironmentCertificate: missing required arguments. Must call: container_app_environment_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerAppEnvironmentCertificateState<_, _>) : azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificate =
            Unchecked.defaultof<azurerm.DataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificate>
