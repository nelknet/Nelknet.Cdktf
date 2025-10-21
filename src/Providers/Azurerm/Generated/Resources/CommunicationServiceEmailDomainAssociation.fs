namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId> = { assignments: ResizeArray<azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association">azurerm_communication_service_email_domain_association</a>.
    /// </summary>
    type CommunicationServiceEmailDomainAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CommunicationServiceEmailDomainAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CommunicationServiceEmailDomainAssociationState<Missing, Missing>)

        member _.Zero(()) : CommunicationServiceEmailDomainAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CommunicationServiceEmailDomainAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#communication_service_id-1">CommunicationServiceEmailDomainAssociation#communication_service_id</a>.
        /// </summary>
        [<CustomOperation "communication_service_id">]
        member _.CommunicationServiceId(state: CommunicationServiceEmailDomainAssociationState<Missing, 'EmailServiceDomainId>, value: string) : CommunicationServiceEmailDomainAssociationState<Present, 'EmailServiceDomainId> =
            state.assignments.Add(fun config -> config.CommunicationServiceId <- value)
            ({ assignments = state.assignments } : CommunicationServiceEmailDomainAssociationState<Present, 'EmailServiceDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#email_service_domain_id-1">CommunicationServiceEmailDomainAssociation#email_service_domain_id</a>.
        /// </summary>
        [<CustomOperation "email_service_domain_id">]
        member _.EmailServiceDomainId(state: CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, Missing>, value: string) : CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, Present> =
            state.assignments.Add(fun config -> config.EmailServiceDomainId <- value)
            ({ assignments = state.assignments } : CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#id-1">CommunicationServiceEmailDomainAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId>, value: string) : CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#timeouts-1">CommunicationServiceEmailDomainAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId>, value: azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociationTimeouts) : CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CommunicationServiceEmailDomainAssociationState<'CommunicationServiceId, 'EmailServiceDomainId>

        member _.Run(state: CommunicationServiceEmailDomainAssociationState<Present, Present>) : azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociation =
            let config = azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.communicationServiceEmailDomainAssociation: missing required arguments. Must call: communication_service_id, email_service_domain_id.", 9999, IsError = true)>]
        member _.Run(_: CommunicationServiceEmailDomainAssociationState<_, _>) : azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociation =
            Unchecked.defaultof<azurerm.CommunicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociation>
