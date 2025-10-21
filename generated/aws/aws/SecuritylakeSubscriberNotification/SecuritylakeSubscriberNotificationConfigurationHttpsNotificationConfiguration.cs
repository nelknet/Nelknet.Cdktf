using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriberNotification
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securitylakeSubscriberNotification.SecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration")]
    public class SecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration : aws.SecuritylakeSubscriberNotification.ISecuritylakeSubscriberNotificationConfigurationHttpsNotificationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#endpoint SecuritylakeSubscriberNotification#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#target_role_arn SecuritylakeSubscriberNotification#target_role_arn}.</summary>
        [JsiiProperty(name: "targetRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#authorization_api_key_name SecuritylakeSubscriberNotification#authorization_api_key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationApiKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizationApiKeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#authorization_api_key_value SecuritylakeSubscriberNotification#authorization_api_key_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationApiKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizationApiKeyValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber_notification#http_method SecuritylakeSubscriberNotification#http_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpMethod
        {
            get;
            set;
        }
    }
}
