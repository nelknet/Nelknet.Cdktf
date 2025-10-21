using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriberNotification
{
    [JsiiByValue(fqn: "aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfiguration")]
    public class SecuritylakeSubscriberNotificationConfiguration : aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfiguration
    {
        private object? _httpsNotificationConfiguration;

        /// <summary>https_notification_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#https_notification_configuration SecuritylakeSubscriberNotification#https_notification_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpsNotificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpsNotificationConfiguration
        {
            get => _httpsNotificationConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpsNotificationConfiguration = value;
            }
        }

        private object? _sqsNotificationConfiguration;

        /// <summary>sqs_notification_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#sqs_notification_configuration SecuritylakeSubscriberNotification#sqs_notification_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqsNotificationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationSqsNotificationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SqsNotificationConfiguration
        {
            get => _sqsNotificationConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfigurationSqsNotificationConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfigurationSqsNotificationConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sqsNotificationConfiguration = value;
            }
        }
    }
}
