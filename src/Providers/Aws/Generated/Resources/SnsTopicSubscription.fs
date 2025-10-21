namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> = { assignments: ResizeArray<aws.SnsTopicSubscription.SnsTopicSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription">aws_sns_topic_subscription</a>.
    /// </summary>
    type SnsTopicSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnsTopicSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsTopicSubscriptionState<Missing, Missing, Missing>)

        member _.Zero(()) : SnsTopicSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsTopicSubscriptionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#endpoint-1">SnsTopicSubscription#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: SnsTopicSubscriptionState<Missing, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<Present, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            ({ assignments = state.assignments } : SnsTopicSubscriptionState<Present, 'Protocol, 'TopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#protocol-1">SnsTopicSubscription#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: SnsTopicSubscriptionState<'Endpoint, Missing, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, Present, 'TopicArn> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : SnsTopicSubscriptionState<'Endpoint, Present, 'TopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#topic_arn-1">SnsTopicSubscription#topic_arn</a>.
        /// </summary>
        [<CustomOperation "topic_arn">]
        member _.TopicArn(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, Missing>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.TopicArn <- value)
            ({ assignments = state.assignments } : SnsTopicSubscriptionState<'Endpoint, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#confirmation_timeout_in_minutes-1">SnsTopicSubscription#confirmation_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "confirmation_timeout_in_minutes">]
        member _.ConfirmationTimeoutInMinutes(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: double) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.ConfirmationTimeoutInMinutes <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#delivery_policy-1">SnsTopicSubscription#delivery_policy</a>.
        /// </summary>
        [<CustomOperation "delivery_policy">]
        member _.DeliveryPolicy(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.DeliveryPolicy <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#endpoint_auto_confirms-1">SnsTopicSubscription#endpoint_auto_confirms</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "endpoint_auto_confirms">]
        member _.EndpointAutoConfirms(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: bool) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.EndpointAutoConfirms <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#endpoint_auto_confirms-1">SnsTopicSubscription#endpoint_auto_confirms</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "endpoint_auto_confirms">]
        member _.EndpointAutoConfirms(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: HashiCorp.Cdktf.IResolvable) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.EndpointAutoConfirms <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#filter_policy-1">SnsTopicSubscription#filter_policy</a>.
        /// </summary>
        [<CustomOperation "filter_policy">]
        member _.FilterPolicy(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.FilterPolicy <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#filter_policy_scope-1">SnsTopicSubscription#filter_policy_scope</a>.
        /// </summary>
        [<CustomOperation "filter_policy_scope">]
        member _.FilterPolicyScope(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.FilterPolicyScope <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#id-1">SnsTopicSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#raw_message_delivery-1">SnsTopicSubscription#raw_message_delivery</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "raw_message_delivery">]
        member _.RawMessageDelivery(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: bool) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.RawMessageDelivery <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#raw_message_delivery-1">SnsTopicSubscription#raw_message_delivery</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "raw_message_delivery">]
        member _.RawMessageDelivery(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: HashiCorp.Cdktf.IResolvable) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.RawMessageDelivery <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#redrive_policy-1">SnsTopicSubscription#redrive_policy</a>.
        /// </summary>
        [<CustomOperation "redrive_policy">]
        member _.RedrivePolicy(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.RedrivePolicy <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#replay_policy-1">SnsTopicSubscription#replay_policy</a>.
        /// </summary>
        [<CustomOperation "replay_policy">]
        member _.ReplayPolicy(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.ReplayPolicy <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_subscription#subscription_role_arn-1">SnsTopicSubscription#subscription_role_arn</a>.
        /// </summary>
        [<CustomOperation "subscription_role_arn">]
        member _.SubscriptionRoleArn(state: SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>, value: string) : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn> =
            state.assignments.Add(fun config -> config.SubscriptionRoleArn <- value)
            state : SnsTopicSubscriptionState<'Endpoint, 'Protocol, 'TopicArn>

        member _.Run(state: SnsTopicSubscriptionState<Present, Present, Present>) : aws.SnsTopicSubscription.SnsTopicSubscription =
            let config = aws.SnsTopicSubscription.SnsTopicSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.SnsTopicSubscription.SnsTopicSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.snsTopicSubscription: missing required arguments. Must call: endpoint, protocol, topic_arn.", 9999, IsError = true)>]
        member _.Run(_: SnsTopicSubscriptionState<_, _, _>) : aws.SnsTopicSubscription.SnsTopicSubscription =
            Unchecked.defaultof<aws.SnsTopicSubscription.SnsTopicSubscription>
