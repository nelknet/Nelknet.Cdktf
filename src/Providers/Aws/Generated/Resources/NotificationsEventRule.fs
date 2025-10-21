namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, 'Source> = { assignments: ResizeArray<aws.NotificationsEventRule.NotificationsEventRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_event_rule">aws_notifications_event_rule</a>.
    /// </summary>
    type NotificationsEventRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationsEventRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationsEventRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NotificationsEventRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationsEventRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_event_rule#event_type-1">NotificationsEventRule#event_type</a>.
        /// </summary>
        [<CustomOperation "event_type">]
        member _.EventType(state: NotificationsEventRuleState<Missing, 'NotificationConfigurationArn, 'Regions, 'Source>, value: string) : NotificationsEventRuleState<Present, 'NotificationConfigurationArn, 'Regions, 'Source> =
            state.assignments.Add(fun config -> config.EventType <- value)
            ({ assignments = state.assignments } : NotificationsEventRuleState<Present, 'NotificationConfigurationArn, 'Regions, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_event_rule#notification_configuration_arn-1">NotificationsEventRule#notification_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "notification_configuration_arn">]
        member _.NotificationConfigurationArn(state: NotificationsEventRuleState<'EventType, Missing, 'Regions, 'Source>, value: string) : NotificationsEventRuleState<'EventType, Present, 'Regions, 'Source> =
            state.assignments.Add(fun config -> config.NotificationConfigurationArn <- value)
            ({ assignments = state.assignments } : NotificationsEventRuleState<'EventType, Present, 'Regions, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_event_rule#regions-1">NotificationsEventRule#regions</a>.
        /// </summary>
        [<CustomOperation "regions">]
        member _.Regions(state: NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, Missing, 'Source>, value: seq<string>) : NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, Present, 'Source> =
            state.assignments.Add(fun config -> config.Regions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, Present, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_event_rule#source-1">NotificationsEventRule#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, Missing>, value: string) : NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notifications_event_rule#event_pattern-1">NotificationsEventRule#event_pattern</a>.
        /// </summary>
        [<CustomOperation "event_pattern">]
        member _.EventPattern(state: NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, 'Source>, value: string) : NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, 'Source> =
            state.assignments.Add(fun config -> config.EventPattern <- value)
            state : NotificationsEventRuleState<'EventType, 'NotificationConfigurationArn, 'Regions, 'Source>

        member _.Run(state: NotificationsEventRuleState<Present, Present, Present, Present>) : aws.NotificationsEventRule.NotificationsEventRule =
            let config = aws.NotificationsEventRule.NotificationsEventRuleConfig()
            for setter in state.assignments do
                setter config
            aws.NotificationsEventRule.NotificationsEventRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.notificationsEventRule: missing required arguments. Must call: event_type, notification_configuration_arn, regions, source.", 9999, IsError = true)>]
        member _.Run(_: NotificationsEventRuleState<_, _, _, _>) : aws.NotificationsEventRule.NotificationsEventRule =
            Unchecked.defaultof<aws.NotificationsEventRule.NotificationsEventRule>
