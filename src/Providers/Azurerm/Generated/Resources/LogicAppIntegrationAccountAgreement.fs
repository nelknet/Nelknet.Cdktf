namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement">azurerm_logic_app_integration_account_agreement</a>.
    /// </summary>
    type LogicAppIntegrationAccountAgreementBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountAgreementState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountAgreementState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountAgreementState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountAgreementState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#agreement_type-1">LogicAppIntegrationAccountAgreement#agreement_type</a>.
        /// </summary>
        [<CustomOperation "agreement_type">]
        member _.AgreementType(state: LogicAppIntegrationAccountAgreementState<Missing, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<Present, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AgreementType <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<Present, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#content-1">LogicAppIntegrationAccountAgreement#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: LogicAppIntegrationAccountAgreementState<'AgreementType, Missing, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, Present, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, Present, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// guest_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#guest_identity-1">LogicAppIntegrationAccountAgreement#guest_identity</a>
        /// </summary>
        [<CustomOperation "guest_identity">]
        member _.GuestIdentity(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, Missing, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementGuestIdentity) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, Present, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GuestIdentity <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, Present, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#guest_partner_name-1">LogicAppIntegrationAccountAgreement#guest_partner_name</a>.
        /// </summary>
        [<CustomOperation "guest_partner_name">]
        member _.GuestPartnerName(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, Missing, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, Present, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GuestPartnerName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, Present, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// host_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#host_identity-1">LogicAppIntegrationAccountAgreement#host_identity</a>
        /// </summary>
        [<CustomOperation "host_identity">]
        member _.HostIdentity(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, Missing, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementHostIdentity) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, Present, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HostIdentity <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, Present, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#host_partner_name-1">LogicAppIntegrationAccountAgreement#host_partner_name</a>.
        /// </summary>
        [<CustomOperation "host_partner_name">]
        member _.HostPartnerName(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, Missing, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HostPartnerName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#integration_account_name-1">LogicAppIntegrationAccountAgreement#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#name-1">LogicAppIntegrationAccountAgreement#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#resource_group_name-1">LogicAppIntegrationAccountAgreement#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, Missing>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#id-1">LogicAppIntegrationAccountAgreement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#metadata-1">LogicAppIntegrationAccountAgreement#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#timeouts-1">LogicAppIntegrationAccountAgreement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementTimeouts) : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountAgreementState<'AgreementType, 'Content, 'GuestIdentity, 'GuestPartnerName, 'HostIdentity, 'HostPartnerName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountAgreementState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement =
            let config = azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountAgreement: missing required arguments. Must call: agreement_type, content, guest_identity, guest_partner_name, host_identity, host_partner_name, integration_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountAgreementState<_, _, _, _, _, _, _, _, _>) : azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement>
