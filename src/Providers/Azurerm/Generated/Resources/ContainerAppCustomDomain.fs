namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppCustomDomainState<'ContainerAppId, 'Name> = { assignments: ResizeArray<azurerm.ContainerAppCustomDomain.ContainerAppCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain">azurerm_container_app_custom_domain</a>.
    /// </summary>
    type ContainerAppCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppCustomDomainState<Missing, Missing>)

        member _.Zero(()) : ContainerAppCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppCustomDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain#container_app_id-1">ContainerAppCustomDomain#container_app_id</a>.
        /// </summary>
        [<CustomOperation "container_app_id">]
        member _.ContainerAppId(state: ContainerAppCustomDomainState<Missing, 'Name>, value: string) : ContainerAppCustomDomainState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerAppId <- value)
            ({ assignments = state.assignments } : ContainerAppCustomDomainState<Present, 'Name>)

        /// <summary>
        /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain#name-1">ContainerAppCustomDomain#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppCustomDomainState<'ContainerAppId, Missing>, value: string) : ContainerAppCustomDomainState<'ContainerAppId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppCustomDomainState<'ContainerAppId, Present>)

        /// <summary>
        /// The Binding type. Possible values include `Disabled` and `SniEnabled`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain#certificate_binding_type-1">ContainerAppCustomDomain#certificate_binding_type</a>
        /// </summary>
        [<CustomOperation "certificate_binding_type">]
        member _.CertificateBindingType(state: ContainerAppCustomDomainState<'ContainerAppId, 'Name>, value: string) : ContainerAppCustomDomainState<'ContainerAppId, 'Name> =
            state.assignments.Add(fun config -> config.CertificateBindingType <- value)
            state : ContainerAppCustomDomainState<'ContainerAppId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain#container_app_environment_certificate_id-1">ContainerAppCustomDomain#container_app_environment_certificate_id</a>.
        /// </summary>
        [<CustomOperation "container_app_environment_certificate_id">]
        member _.ContainerAppEnvironmentCertificateId(state: ContainerAppCustomDomainState<'ContainerAppId, 'Name>, value: string) : ContainerAppCustomDomainState<'ContainerAppId, 'Name> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentCertificateId <- value)
            state : ContainerAppCustomDomainState<'ContainerAppId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain#id-1">ContainerAppCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppCustomDomainState<'ContainerAppId, 'Name>, value: string) : ContainerAppCustomDomainState<'ContainerAppId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppCustomDomainState<'ContainerAppId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_custom_domain#timeouts-1">ContainerAppCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppCustomDomainState<'ContainerAppId, 'Name>, value: azurerm.ContainerAppCustomDomain.ContainerAppCustomDomainTimeouts) : ContainerAppCustomDomainState<'ContainerAppId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppCustomDomainState<'ContainerAppId, 'Name>

        member _.Run(state: ContainerAppCustomDomainState<Present, Present>) : azurerm.ContainerAppCustomDomain.ContainerAppCustomDomain =
            let config = azurerm.ContainerAppCustomDomain.ContainerAppCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppCustomDomain.ContainerAppCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppCustomDomain: missing required arguments. Must call: container_app_id, name.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppCustomDomainState<_, _>) : azurerm.ContainerAppCustomDomain.ContainerAppCustomDomain =
            Unchecked.defaultof<azurerm.ContainerAppCustomDomain.ContainerAppCustomDomain>
