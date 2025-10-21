namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecuritylakeSubscriberNotificationState<'SubscriberId> = { assignments: ResizeArray<aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification">aws_securitylake_subscriber_notification</a>.
    /// </summary>
    type SecuritylakeSubscriberNotificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecuritylakeSubscriberNotificationState<Missing> =
            ({ assignments = ResizeArray() } : SecuritylakeSubscriberNotificationState<Missing>)

        member _.Zero(()) : SecuritylakeSubscriberNotificationState<Missing> =
            ({ assignments = ResizeArray() } : SecuritylakeSubscriberNotificationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#subscriber_id-1">SecuritylakeSubscriberNotification#subscriber_id</a>.
        /// </summary>
        [<CustomOperation "subscriber_id">]
        member _.SubscriberId(state: SecuritylakeSubscriberNotificationState<Missing>, value: string) : SecuritylakeSubscriberNotificationState<Present> =
            state.assignments.Add(fun config -> config.SubscriberId <- value)
            ({ assignments = state.assignments } : SecuritylakeSubscriberNotificationState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#configuration-1">SecuritylakeSubscriberNotification#configuration</a> Accepts: aws.IResolvable | aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfiguration[]
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: SecuritylakeSubscriberNotificationState<'SubscriberId>, value: HashiCorp.Cdktf.IResolvable) : SecuritylakeSubscriberNotificationState<'SubscriberId> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : SecuritylakeSubscriberNotificationState<'SubscriberId>

        member _.Run(state: SecuritylakeSubscriberNotificationState<Present>) : aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotification =
            let config = aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfig()
            for setter in state.assignments do
                setter config
            aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securitylakeSubscriberNotification: missing required arguments. Must call: subscriber_id.", 9999, IsError = true)>]
        member _.Run(_: SecuritylakeSubscriberNotificationState<_>) : aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotification =
            Unchecked.defaultof<aws.SecuritylakeSubscriberNotification.SecuritylakeSubscriberNotification>
