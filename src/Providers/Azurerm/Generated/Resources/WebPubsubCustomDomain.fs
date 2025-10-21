namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId> = { assignments: ResizeArray<azurerm.WebPubsubCustomDomain.WebPubsubCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain">azurerm_web_pubsub_custom_domain</a>.
    /// </summary>
    type WebPubsubCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebPubsubCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubCustomDomainState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WebPubsubCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubCustomDomainState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain#domain_name-1">WebPubsubCustomDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: WebPubsubCustomDomainState<Missing, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId>, value: string) : WebPubsubCustomDomainState<Present, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : WebPubsubCustomDomainState<Present, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain#name-1">WebPubsubCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WebPubsubCustomDomainState<'DomainName, Missing, 'WebPubsubCustomCertificateId, 'WebPubsubId>, value: string) : WebPubsubCustomDomainState<'DomainName, Present, 'WebPubsubCustomCertificateId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WebPubsubCustomDomainState<'DomainName, Present, 'WebPubsubCustomCertificateId, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain#web_pubsub_custom_certificate_id-1">WebPubsubCustomDomain#web_pubsub_custom_certificate_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_custom_certificate_id">]
        member _.WebPubsubCustomCertificateId(state: WebPubsubCustomDomainState<'DomainName, 'Name, Missing, 'WebPubsubId>, value: string) : WebPubsubCustomDomainState<'DomainName, 'Name, Present, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.WebPubsubCustomCertificateId <- value)
            ({ assignments = state.assignments } : WebPubsubCustomDomainState<'DomainName, 'Name, Present, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain#web_pubsub_id-1">WebPubsubCustomDomain#web_pubsub_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_id">]
        member _.WebPubsubId(state: WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, Missing>, value: string) : WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, Present> =
            state.assignments.Add(fun config -> config.WebPubsubId <- value)
            ({ assignments = state.assignments } : WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain#id-1">WebPubsubCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId>, value: string) : WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_custom_domain#timeouts-1">WebPubsubCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId>, value: azurerm.WebPubsubCustomDomain.WebPubsubCustomDomainTimeouts) : WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebPubsubCustomDomainState<'DomainName, 'Name, 'WebPubsubCustomCertificateId, 'WebPubsubId>

        member _.Run(state: WebPubsubCustomDomainState<Present, Present, Present, Present>) : azurerm.WebPubsubCustomDomain.WebPubsubCustomDomain =
            let config = azurerm.WebPubsubCustomDomain.WebPubsubCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebPubsubCustomDomain.WebPubsubCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webPubsubCustomDomain: missing required arguments. Must call: domain_name, name, web_pubsub_custom_certificate_id, web_pubsub_id.", 9999, IsError = true)>]
        member _.Run(_: WebPubsubCustomDomainState<_, _, _, _>) : azurerm.WebPubsubCustomDomain.WebPubsubCustomDomain =
            Unchecked.defaultof<azurerm.WebPubsubCustomDomain.WebPubsubCustomDomain>
