namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationsNotificationHubState<'NotificationHubRegion> = { assignments: ResizeArray<aws.NotificationsNotificationHub.NotificationsNotificationHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_hub">aws_notifications_notification_hub</a>.
    /// </summary>
    type NotificationsNotificationHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationsNotificationHubState<Missing> =
            ({ assignments = ResizeArray() } : NotificationsNotificationHubState<Missing>)

        member _.Zero(()) : NotificationsNotificationHubState<Missing> =
            ({ assignments = ResizeArray() } : NotificationsNotificationHubState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_hub#notification_hub_region-1">NotificationsNotificationHub#notification_hub_region</a>.
        /// </summary>
        [<CustomOperation "notification_hub_region">]
        member _.NotificationHubRegion(state: NotificationsNotificationHubState<Missing>, value: string) : NotificationsNotificationHubState<Present> =
            state.assignments.Add(fun config -> config.NotificationHubRegion <- value)
            ({ assignments = state.assignments } : NotificationsNotificationHubState<Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_hub#timeouts-1">NotificationsNotificationHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NotificationsNotificationHubState<'NotificationHubRegion>, value: aws.NotificationsNotificationHub.NotificationsNotificationHubTimeouts) : NotificationsNotificationHubState<'NotificationHubRegion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NotificationsNotificationHubState<'NotificationHubRegion>

        member _.Run(state: NotificationsNotificationHubState<Present>) : aws.NotificationsNotificationHub.NotificationsNotificationHub =
            let config = aws.NotificationsNotificationHub.NotificationsNotificationHubConfig()
            for setter in state.assignments do
                setter config
            aws.NotificationsNotificationHub.NotificationsNotificationHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.notificationsNotificationHub: missing required arguments. Must call: notification_hub_region.", 9999, IsError = true)>]
        member _.Run(_: NotificationsNotificationHubState<_>) : aws.NotificationsNotificationHub.NotificationsNotificationHub =
            Unchecked.defaultof<aws.NotificationsNotificationHub.NotificationsNotificationHub>
