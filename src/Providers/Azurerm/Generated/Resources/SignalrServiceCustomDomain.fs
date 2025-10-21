namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId> = { assignments: ResizeArray<azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain">azurerm_signalr_service_custom_domain</a>.
    /// </summary>
    type SignalrServiceCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignalrServiceCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceCustomDomainState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SignalrServiceCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceCustomDomainState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain#domain_name-1">SignalrServiceCustomDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: SignalrServiceCustomDomainState<Missing, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId>, value: string) : SignalrServiceCustomDomainState<Present, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomDomainState<Present, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain#name-1">SignalrServiceCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SignalrServiceCustomDomainState<'DomainName, Missing, 'SignalrCustomCertificateId, 'SignalrServiceId>, value: string) : SignalrServiceCustomDomainState<'DomainName, Present, 'SignalrCustomCertificateId, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomDomainState<'DomainName, Present, 'SignalrCustomCertificateId, 'SignalrServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain#signalr_custom_certificate_id-1">SignalrServiceCustomDomain#signalr_custom_certificate_id</a>.
        /// </summary>
        [<CustomOperation "signalr_custom_certificate_id">]
        member _.SignalrCustomCertificateId(state: SignalrServiceCustomDomainState<'DomainName, 'Name, Missing, 'SignalrServiceId>, value: string) : SignalrServiceCustomDomainState<'DomainName, 'Name, Present, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.SignalrCustomCertificateId <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomDomainState<'DomainName, 'Name, Present, 'SignalrServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain#signalr_service_id-1">SignalrServiceCustomDomain#signalr_service_id</a>.
        /// </summary>
        [<CustomOperation "signalr_service_id">]
        member _.SignalrServiceId(state: SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, Missing>, value: string) : SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, Present> =
            state.assignments.Add(fun config -> config.SignalrServiceId <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain#id-1">SignalrServiceCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId>, value: string) : SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_domain#timeouts-1">SignalrServiceCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId>, value: azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomainTimeouts) : SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SignalrServiceCustomDomainState<'DomainName, 'Name, 'SignalrCustomCertificateId, 'SignalrServiceId>

        member _.Run(state: SignalrServiceCustomDomainState<Present, Present, Present, Present>) : azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomain =
            let config = azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.signalrServiceCustomDomain: missing required arguments. Must call: domain_name, name, signalr_custom_certificate_id, signalr_service_id.", 9999, IsError = true)>]
        member _.Run(_: SignalrServiceCustomDomainState<_, _, _, _>) : azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomain =
            Unchecked.defaultof<azurerm.SignalrServiceCustomDomain.SignalrServiceCustomDomain>
