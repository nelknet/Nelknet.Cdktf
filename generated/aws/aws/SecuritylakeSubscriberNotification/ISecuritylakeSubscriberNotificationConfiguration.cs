using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriberNotification
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeSubscriberNotificationConfiguration), fullyQualifiedName: "aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfiguration")]
    public interface ISecuritylakeSubscriberNotificationConfiguration
    {
        /// <summary>https_notification_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#https_notification_configuration SecuritylakeSubscriberNotification#https_notification_configuration}
        /// </remarks>
        [JsiiProperty(name: "httpsNotificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsNotificationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs_notification_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#sqs_notification_configuration SecuritylakeSubscriberNotification#sqs_notification_configuration}
        /// </remarks>
        [JsiiProperty(name: "sqsNotificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationSqsNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SqsNotificationConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeSubscriberNotificationConfiguration), fullyQualifiedName: "aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>https_notification_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#https_notification_configuration SecuritylakeSubscriberNotification#https_notification_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsNotificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpsNotificationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sqs_notification_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#sqs_notification_configuration SecuritylakeSubscriberNotification#sqs_notification_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsNotificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationSqsNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SqsNotificationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
