namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId> = { assignments: ResizeArray<azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_user">azurerm_api_management_notification_recipient_user</a>.
    /// </summary>
    type ApiManagementNotificationRecipientUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementNotificationRecipientUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementNotificationRecipientUserState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementNotificationRecipientUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementNotificationRecipientUserState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_user#api_management_id-1">ApiManagementNotificationRecipientUser#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementNotificationRecipientUserState<Missing, 'NotificationType, 'UserId>, value: string) : ApiManagementNotificationRecipientUserState<Present, 'NotificationType, 'UserId> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementNotificationRecipientUserState<Present, 'NotificationType, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_user#notification_type-1">ApiManagementNotificationRecipientUser#notification_type</a>.
        /// </summary>
        [<CustomOperation "notification_type">]
        member _.NotificationType(state: ApiManagementNotificationRecipientUserState<'ApiManagementId, Missing, 'UserId>, value: string) : ApiManagementNotificationRecipientUserState<'ApiManagementId, Present, 'UserId> =
            state.assignments.Add(fun config -> config.NotificationType <- value)
            ({ assignments = state.assignments } : ApiManagementNotificationRecipientUserState<'ApiManagementId, Present, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_user#user_id-1">ApiManagementNotificationRecipientUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, Missing>, value: string) : ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, Present> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_user#id-1">ApiManagementNotificationRecipientUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId>, value: string) : ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_notification_recipient_user#timeouts-1">ApiManagementNotificationRecipientUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId>, value: azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUserTimeouts) : ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementNotificationRecipientUserState<'ApiManagementId, 'NotificationType, 'UserId>

        member _.Run(state: ApiManagementNotificationRecipientUserState<Present, Present, Present>) : azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUser =
            let config = azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUserConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementNotificationRecipientUser: missing required arguments. Must call: api_management_id, notification_type, user_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementNotificationRecipientUserState<_, _, _>) : azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUser =
            Unchecked.defaultof<azurerm.ApiManagementNotificationRecipientUser.ApiManagementNotificationRecipientUser>
