namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name> = { assignments: ResizeArray<azurerm.SecurityCenterContact.SecurityCenterContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact">azurerm_security_center_contact</a>.
    /// </summary>
    type SecurityCenterContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterContactState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterContactState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SecurityCenterContactState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterContactState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#alert_notifications-1">SecurityCenterContact#alert_notifications</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "alert_notifications">]
        member _.AlertNotifications(state: SecurityCenterContactState<Missing, 'AlertsToAdmins, 'Email, 'Name>, value: bool) : SecurityCenterContactState<Present, 'AlertsToAdmins, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.AlertNotifications <- value)
            ({ assignments = state.assignments } : SecurityCenterContactState<Present, 'AlertsToAdmins, 'Email, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#alert_notifications-1">SecurityCenterContact#alert_notifications</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "alert_notifications">]
        member _.AlertNotifications(state: SecurityCenterContactState<Missing, 'AlertsToAdmins, 'Email, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterContactState<Present, 'AlertsToAdmins, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.AlertNotifications <- value)
            ({ assignments = state.assignments } : SecurityCenterContactState<Present, 'AlertsToAdmins, 'Email, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#alerts_to_admins-1">SecurityCenterContact#alerts_to_admins</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "alerts_to_admins">]
        member _.AlertsToAdmins(state: SecurityCenterContactState<'AlertNotifications, Missing, 'Email, 'Name>, value: bool) : SecurityCenterContactState<'AlertNotifications, Present, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.AlertsToAdmins <- value)
            ({ assignments = state.assignments } : SecurityCenterContactState<'AlertNotifications, Present, 'Email, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#alerts_to_admins-1">SecurityCenterContact#alerts_to_admins</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "alerts_to_admins">]
        member _.AlertsToAdmins(state: SecurityCenterContactState<'AlertNotifications, Missing, 'Email, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterContactState<'AlertNotifications, Present, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.AlertsToAdmins <- value)
            ({ assignments = state.assignments } : SecurityCenterContactState<'AlertNotifications, Present, 'Email, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#email-1">SecurityCenterContact#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, Missing, 'Name>, value: string) : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, Present, 'Name> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#name-1">SecurityCenterContact#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, Missing>, value: string) : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#id-1">SecurityCenterContact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name>, value: string) : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#phone-1">SecurityCenterContact#phone</a>.
        /// </summary>
        [<CustomOperation "phone">]
        member _.Phone(state: SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name>, value: string) : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.Phone <- value)
            state : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_contact#timeouts-1">SecurityCenterContact#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name>, value: azurerm.SecurityCenterContact.SecurityCenterContactTimeouts) : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterContactState<'AlertNotifications, 'AlertsToAdmins, 'Email, 'Name>

        member _.Run(state: SecurityCenterContactState<Present, Present, Present, Present>) : azurerm.SecurityCenterContact.SecurityCenterContact =
            let config = azurerm.SecurityCenterContact.SecurityCenterContactConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterContact.SecurityCenterContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterContact: missing required arguments. Must call: alert_notifications, alerts_to_admins, email, name.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterContactState<_, _, _, _>) : azurerm.SecurityCenterContact.SecurityCenterContact =
            Unchecked.defaultof<azurerm.SecurityCenterContact.SecurityCenterContact>
