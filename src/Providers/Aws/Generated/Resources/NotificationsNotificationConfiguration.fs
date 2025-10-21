namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationsNotificationConfigurationState<'Description, 'Name> = { assignments: ResizeArray<aws.NotificationsNotificationConfiguration.NotificationsNotificationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_configuration">aws_notifications_notification_configuration</a>.
    /// </summary>
    type NotificationsNotificationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationsNotificationConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationsNotificationConfigurationState<Missing, Missing>)

        member _.Zero(()) : NotificationsNotificationConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationsNotificationConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_configuration#description-1">NotificationsNotificationConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NotificationsNotificationConfigurationState<Missing, 'Name>, value: string) : NotificationsNotificationConfigurationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : NotificationsNotificationConfigurationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_configuration#name-1">NotificationsNotificationConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NotificationsNotificationConfigurationState<'Description, Missing>, value: string) : NotificationsNotificationConfigurationState<'Description, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NotificationsNotificationConfigurationState<'Description, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_configuration#aggregation_duration-1">NotificationsNotificationConfiguration#aggregation_duration</a>.
        /// </summary>
        [<CustomOperation "aggregation_duration">]
        member _.AggregationDuration(state: NotificationsNotificationConfigurationState<'Description, 'Name>, value: string) : NotificationsNotificationConfigurationState<'Description, 'Name> =
            state.assignments.Add(fun config -> config.AggregationDuration <- value)
            state : NotificationsNotificationConfigurationState<'Description, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_notification_configuration#tags-1">NotificationsNotificationConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NotificationsNotificationConfigurationState<'Description, 'Name>, value: seq<string * string>) : NotificationsNotificationConfigurationState<'Description, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NotificationsNotificationConfigurationState<'Description, 'Name>

        member _.Run(state: NotificationsNotificationConfigurationState<Present, Present>) : aws.NotificationsNotificationConfiguration.NotificationsNotificationConfiguration =
            let config = aws.NotificationsNotificationConfiguration.NotificationsNotificationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.NotificationsNotificationConfiguration.NotificationsNotificationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.notificationsNotificationConfiguration: missing required arguments. Must call: description, name.", 9999, IsError = true)>]
        member _.Run(_: NotificationsNotificationConfigurationState<_, _>) : aws.NotificationsNotificationConfiguration.NotificationsNotificationConfiguration =
            Unchecked.defaultof<aws.NotificationsNotificationConfiguration.NotificationsNotificationConfiguration>
