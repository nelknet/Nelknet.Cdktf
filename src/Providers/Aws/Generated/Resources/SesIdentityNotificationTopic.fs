namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesIdentityNotificationTopicState<'Identity, 'NotificationType> = { assignments: ResizeArray<aws.SesIdentityNotificationTopic.SesIdentityNotificationTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic">aws_ses_identity_notification_topic</a>.
    /// </summary>
    type SesIdentityNotificationTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesIdentityNotificationTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SesIdentityNotificationTopicState<Missing, Missing>)

        member _.Zero(()) : SesIdentityNotificationTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SesIdentityNotificationTopicState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic#identity-1">SesIdentityNotificationTopic#identity</a>.
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SesIdentityNotificationTopicState<Missing, 'NotificationType>, value: string) : SesIdentityNotificationTopicState<Present, 'NotificationType> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : SesIdentityNotificationTopicState<Present, 'NotificationType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic#notification_type-1">SesIdentityNotificationTopic#notification_type</a>.
        /// </summary>
        [<CustomOperation "notification_type">]
        member _.NotificationType(state: SesIdentityNotificationTopicState<'Identity, Missing>, value: string) : SesIdentityNotificationTopicState<'Identity, Present> =
            state.assignments.Add(fun config -> config.NotificationType <- value)
            ({ assignments = state.assignments } : SesIdentityNotificationTopicState<'Identity, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic#id-1">SesIdentityNotificationTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesIdentityNotificationTopicState<'Identity, 'NotificationType>, value: string) : SesIdentityNotificationTopicState<'Identity, 'NotificationType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesIdentityNotificationTopicState<'Identity, 'NotificationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic#include_original_headers-1">SesIdentityNotificationTopic#include_original_headers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_original_headers">]
        member _.IncludeOriginalHeaders(state: SesIdentityNotificationTopicState<'Identity, 'NotificationType>, value: bool) : SesIdentityNotificationTopicState<'Identity, 'NotificationType> =
            state.assignments.Add(fun config -> config.IncludeOriginalHeaders <- value)
            state : SesIdentityNotificationTopicState<'Identity, 'NotificationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic#include_original_headers-1">SesIdentityNotificationTopic#include_original_headers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_original_headers">]
        member _.IncludeOriginalHeaders(state: SesIdentityNotificationTopicState<'Identity, 'NotificationType>, value: HashiCorp.Cdktf.IResolvable) : SesIdentityNotificationTopicState<'Identity, 'NotificationType> =
            state.assignments.Add(fun config -> config.IncludeOriginalHeaders <- value)
            state : SesIdentityNotificationTopicState<'Identity, 'NotificationType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_notification_topic#topic_arn-1">SesIdentityNotificationTopic#topic_arn</a>.
        /// </summary>
        [<CustomOperation "topic_arn">]
        member _.TopicArn(state: SesIdentityNotificationTopicState<'Identity, 'NotificationType>, value: string) : SesIdentityNotificationTopicState<'Identity, 'NotificationType> =
            state.assignments.Add(fun config -> config.TopicArn <- value)
            state : SesIdentityNotificationTopicState<'Identity, 'NotificationType>

        member _.Run(state: SesIdentityNotificationTopicState<Present, Present>) : aws.SesIdentityNotificationTopic.SesIdentityNotificationTopic =
            let config = aws.SesIdentityNotificationTopic.SesIdentityNotificationTopicConfig()
            for setter in state.assignments do
                setter config
            aws.SesIdentityNotificationTopic.SesIdentityNotificationTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesIdentityNotificationTopic: missing required arguments. Must call: identity, notification_type.", 9999, IsError = true)>]
        member _.Run(_: SesIdentityNotificationTopicState<_, _>) : aws.SesIdentityNotificationTopic.SesIdentityNotificationTopic =
            Unchecked.defaultof<aws.SesIdentityNotificationTopic.SesIdentityNotificationTopic>
