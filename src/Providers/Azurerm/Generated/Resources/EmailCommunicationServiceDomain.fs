namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name> = { assignments: ResizeArray<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain">azurerm_email_communication_service_domain</a>.
    /// </summary>
    type EmailCommunicationServiceDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmailCommunicationServiceDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmailCommunicationServiceDomainState<Missing, Missing, Missing>)

        member _.Zero(()) : EmailCommunicationServiceDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmailCommunicationServiceDomainState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#domain_management-1">EmailCommunicationServiceDomain#domain_management</a>.
        /// </summary>
        [<CustomOperation "domain_management">]
        member _.DomainManagement(state: EmailCommunicationServiceDomainState<Missing, 'EmailServiceId, 'Name>, value: string) : EmailCommunicationServiceDomainState<Present, 'EmailServiceId, 'Name> =
            state.assignments.Add(fun config -> config.DomainManagement <- value)
            ({ assignments = state.assignments } : EmailCommunicationServiceDomainState<Present, 'EmailServiceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#email_service_id-1">EmailCommunicationServiceDomain#email_service_id</a>.
        /// </summary>
        [<CustomOperation "email_service_id">]
        member _.EmailServiceId(state: EmailCommunicationServiceDomainState<'DomainManagement, Missing, 'Name>, value: string) : EmailCommunicationServiceDomainState<'DomainManagement, Present, 'Name> =
            state.assignments.Add(fun config -> config.EmailServiceId <- value)
            ({ assignments = state.assignments } : EmailCommunicationServiceDomainState<'DomainManagement, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#name-1">EmailCommunicationServiceDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, Missing>, value: string) : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#id-1">EmailCommunicationServiceDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>, value: string) : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#tags-1">EmailCommunicationServiceDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>, value: seq<string * string>) : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#timeouts-1">EmailCommunicationServiceDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>, value: azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainTimeouts) : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#user_engagement_tracking_enabled-1">EmailCommunicationServiceDomain#user_engagement_tracking_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "user_engagement_tracking_enabled">]
        member _.UserEngagementTrackingEnabled(state: EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>, value: bool) : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name> =
            state.assignments.Add(fun config -> config.UserEngagementTrackingEnabled <- value)
            state : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/email_communication_service_domain#user_engagement_tracking_enabled-1">EmailCommunicationServiceDomain#user_engagement_tracking_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "user_engagement_tracking_enabled">]
        member _.UserEngagementTrackingEnabled(state: EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name> =
            state.assignments.Add(fun config -> config.UserEngagementTrackingEnabled <- value)
            state : EmailCommunicationServiceDomainState<'DomainManagement, 'EmailServiceId, 'Name>

        member _.Run(state: EmailCommunicationServiceDomainState<Present, Present, Present>) : azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomain =
            let config = azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.emailCommunicationServiceDomain: missing required arguments. Must call: domain_management, email_service_id, name.", 9999, IsError = true)>]
        member _.Run(_: EmailCommunicationServiceDomainState<_, _, _>) : azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomain =
            Unchecked.defaultof<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomain>
