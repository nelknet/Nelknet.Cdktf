namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId> = { assignments: ResizeArray<azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_certificate">azurerm_signalr_service_custom_certificate</a>.
    /// </summary>
    type SignalrServiceCustomCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignalrServiceCustomCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceCustomCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : SignalrServiceCustomCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceCustomCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_certificate#custom_certificate_id-1">SignalrServiceCustomCertificate#custom_certificate_id</a>.
        /// </summary>
        [<CustomOperation "custom_certificate_id">]
        member _.CustomCertificateId(state: SignalrServiceCustomCertificateState<Missing, 'Name, 'SignalrServiceId>, value: string) : SignalrServiceCustomCertificateState<Present, 'Name, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.CustomCertificateId <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomCertificateState<Present, 'Name, 'SignalrServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_certificate#name-1">SignalrServiceCustomCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SignalrServiceCustomCertificateState<'CustomCertificateId, Missing, 'SignalrServiceId>, value: string) : SignalrServiceCustomCertificateState<'CustomCertificateId, Present, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomCertificateState<'CustomCertificateId, Present, 'SignalrServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_certificate#signalr_service_id-1">SignalrServiceCustomCertificate#signalr_service_id</a>.
        /// </summary>
        [<CustomOperation "signalr_service_id">]
        member _.SignalrServiceId(state: SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, Missing>, value: string) : SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SignalrServiceId <- value)
            ({ assignments = state.assignments } : SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_certificate#id-1">SignalrServiceCustomCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId>, value: string) : SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_custom_certificate#timeouts-1">SignalrServiceCustomCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId>, value: azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificateTimeouts) : SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SignalrServiceCustomCertificateState<'CustomCertificateId, 'Name, 'SignalrServiceId>

        member _.Run(state: SignalrServiceCustomCertificateState<Present, Present, Present>) : azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificate =
            let config = azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.signalrServiceCustomCertificate: missing required arguments. Must call: custom_certificate_id, name, signalr_service_id.", 9999, IsError = true)>]
        member _.Run(_: SignalrServiceCustomCertificateState<_, _, _>) : azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificate =
            Unchecked.defaultof<azurerm.SignalrServiceCustomCertificate.SignalrServiceCustomCertificate>
