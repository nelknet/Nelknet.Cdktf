namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId> = { assignments: ResizeArray<azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_certificate">azurerm_web_pubsub_custom_certificate</a>.
    /// </summary>
    type WebPubsubCustomCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebPubsubCustomCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubCustomCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : WebPubsubCustomCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubCustomCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_certificate#custom_certificate_id-1">WebPubsubCustomCertificate#custom_certificate_id</a>.
        /// </summary>
        [<CustomOperation "custom_certificate_id">]
        member _.CustomCertificateId(state: WebPubsubCustomCertificateState<Missing, 'Name, 'WebPubsubId>, value: string) : WebPubsubCustomCertificateState<Present, 'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.CustomCertificateId <- value)
            ({ assignments = state.assignments } : WebPubsubCustomCertificateState<Present, 'Name, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_certificate#name-1">WebPubsubCustomCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WebPubsubCustomCertificateState<'CustomCertificateId, Missing, 'WebPubsubId>, value: string) : WebPubsubCustomCertificateState<'CustomCertificateId, Present, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WebPubsubCustomCertificateState<'CustomCertificateId, Present, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_certificate#web_pubsub_id-1">WebPubsubCustomCertificate#web_pubsub_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_id">]
        member _.WebPubsubId(state: WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, Missing>, value: string) : WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, Present> =
            state.assignments.Add(fun config -> config.WebPubsubId <- value)
            ({ assignments = state.assignments } : WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_certificate#id-1">WebPubsubCustomCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId>, value: string) : WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_certificate#timeouts-1">WebPubsubCustomCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId>, value: azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificateTimeouts) : WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebPubsubCustomCertificateState<'CustomCertificateId, 'Name, 'WebPubsubId>

        member _.Run(state: WebPubsubCustomCertificateState<Present, Present, Present>) : azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificate =
            let config = azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webPubsubCustomCertificate: missing required arguments. Must call: custom_certificate_id, name, web_pubsub_id.", 9999, IsError = true)>]
        member _.Run(_: WebPubsubCustomCertificateState<_, _, _>) : azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificate =
            Unchecked.defaultof<azurerm.WebPubsubCustomCertificate.WebPubsubCustomCertificate>
