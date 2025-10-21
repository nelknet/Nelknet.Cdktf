namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationsChannelAssociationState<'Arn, 'NotificationConfigurationArn> = { assignments: ResizeArray<aws.NotificationsChannelAssociation.NotificationsChannelAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_channel_association">aws_notifications_channel_association</a>.
    /// </summary>
    type NotificationsChannelAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationsChannelAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationsChannelAssociationState<Missing, Missing>)

        member _.Zero(()) : NotificationsChannelAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationsChannelAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_channel_association#arn-1">NotificationsChannelAssociation#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: NotificationsChannelAssociationState<Missing, 'NotificationConfigurationArn>, value: string) : NotificationsChannelAssociationState<Present, 'NotificationConfigurationArn> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : NotificationsChannelAssociationState<Present, 'NotificationConfigurationArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_channel_association#notification_configuration_arn-1">NotificationsChannelAssociation#notification_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "notification_configuration_arn">]
        member _.NotificationConfigurationArn(state: NotificationsChannelAssociationState<'Arn, Missing>, value: string) : NotificationsChannelAssociationState<'Arn, Present> =
            state.assignments.Add(fun config -> config.NotificationConfigurationArn <- value)
            ({ assignments = state.assignments } : NotificationsChannelAssociationState<'Arn, Present>)

        member _.Run(state: NotificationsChannelAssociationState<Present, Present>) : aws.NotificationsChannelAssociation.NotificationsChannelAssociation =
            let config = aws.NotificationsChannelAssociation.NotificationsChannelAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.NotificationsChannelAssociation.NotificationsChannelAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.notificationsChannelAssociation: missing required arguments. Must call: arn, notification_configuration_arn.", 9999, IsError = true)>]
        member _.Run(_: NotificationsChannelAssociationState<_, _>) : aws.NotificationsChannelAssociation.NotificationsChannelAssociation =
            Unchecked.defaultof<aws.NotificationsChannelAssociation.NotificationsChannelAssociation>
