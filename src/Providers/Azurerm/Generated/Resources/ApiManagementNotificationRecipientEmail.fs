namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType> = { assignments: ResizeArray<azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmailConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_email">azurerm_api_management_notification_recipient_email</a>.
    /// </summary>
    type ApiManagementNotificationRecipientEmailBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementNotificationRecipientEmailState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementNotificationRecipientEmailState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementNotificationRecipientEmailState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementNotificationRecipientEmailState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_email#api_management_id-1">ApiManagementNotificationRecipientEmail#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementNotificationRecipientEmailState<Missing, 'Email, 'NotificationType>, value: string) : ApiManagementNotificationRecipientEmailState<Present, 'Email, 'NotificationType> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementNotificationRecipientEmailState<Present, 'Email, 'NotificationType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_email#email-1">ApiManagementNotificationRecipientEmail#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: ApiManagementNotificationRecipientEmailState<'ApiManagementId, Missing, 'NotificationType>, value: string) : ApiManagementNotificationRecipientEmailState<'ApiManagementId, Present, 'NotificationType> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : ApiManagementNotificationRecipientEmailState<'ApiManagementId, Present, 'NotificationType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_email#notification_type-1">ApiManagementNotificationRecipientEmail#notification_type</a>.
        /// </summary>
        [<CustomOperation "notification_type">]
        member _.NotificationType(state: ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, Missing>, value: string) : ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, Present> =
            state.assignments.Add(fun config -> config.NotificationType <- value)
            ({ assignments = state.assignments } : ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_email#id-1">ApiManagementNotificationRecipientEmail#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType>, value: string) : ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_email#timeouts-1">ApiManagementNotificationRecipientEmail#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType>, value: azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmailTimeouts) : ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementNotificationRecipientEmailState<'ApiManagementId, 'Email, 'NotificationType>

        member _.Run(state: ApiManagementNotificationRecipientEmailState<Present, Present, Present>) : azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmail =
            let config = azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmailConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmail(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementNotificationRecipientEmail: missing required arguments. Must call: api_management_id, email, notification_type.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementNotificationRecipientEmailState<_, _, _>) : azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmail =
            Unchecked.defaultof<azurerm.ApiManagementNotificationRecipientEmail.ApiManagementNotificationRecipientEmail>
