namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingNotificationState<'GroupNames, 'Notifications, 'TopicArn> = { assignments: ResizeArray<aws.AutoscalingNotification.AutoscalingNotificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_notification">aws_autoscaling_notification</a>.
    /// </summary>
    type AutoscalingNotificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingNotificationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingNotificationState<Missing, Missing, Missing>)

        member _.Zero(()) : AutoscalingNotificationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingNotificationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_notification#group_names-1">AutoscalingNotification#group_names</a>.
        /// </summary>
        [<CustomOperation "group_names">]
        member _.GroupNames(state: AutoscalingNotificationState<Missing, 'Notifications, 'TopicArn>, value: seq<string>) : AutoscalingNotificationState<Present, 'Notifications, 'TopicArn> =
            state.assignments.Add(fun config -> config.GroupNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : AutoscalingNotificationState<Present, 'Notifications, 'TopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_notification#notifications-1">AutoscalingNotification#notifications</a>.
        /// </summary>
        [<CustomOperation "notifications">]
        member _.Notifications(state: AutoscalingNotificationState<'GroupNames, Missing, 'TopicArn>, value: seq<string>) : AutoscalingNotificationState<'GroupNames, Present, 'TopicArn> =
            state.assignments.Add(fun config -> config.Notifications <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : AutoscalingNotificationState<'GroupNames, Present, 'TopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_notification#topic_arn-1">AutoscalingNotification#topic_arn</a>.
        /// </summary>
        [<CustomOperation "topic_arn">]
        member _.TopicArn(state: AutoscalingNotificationState<'GroupNames, 'Notifications, Missing>, value: string) : AutoscalingNotificationState<'GroupNames, 'Notifications, Present> =
            state.assignments.Add(fun config -> config.TopicArn <- value)
            ({ assignments = state.assignments } : AutoscalingNotificationState<'GroupNames, 'Notifications, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_notification#id-1">AutoscalingNotification#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingNotificationState<'GroupNames, 'Notifications, 'TopicArn>, value: string) : AutoscalingNotificationState<'GroupNames, 'Notifications, 'TopicArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingNotificationState<'GroupNames, 'Notifications, 'TopicArn>

        member _.Run(state: AutoscalingNotificationState<Present, Present, Present>) : aws.AutoscalingNotification.AutoscalingNotification =
            let config = aws.AutoscalingNotification.AutoscalingNotificationConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingNotification.AutoscalingNotification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingNotification: missing required arguments. Must call: group_names, notifications, topic_arn.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingNotificationState<_, _, _>) : aws.AutoscalingNotification.AutoscalingNotification =
            Unchecked.defaultof<aws.AutoscalingNotification.AutoscalingNotification>
