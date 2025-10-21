using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServicebusSubscriptionRule
{
    [JsiiByValue(fqn: "azurerm.servicebusSubscriptionRule.ServicebusSubscriptionRuleCorrelationFilter")]
    public class ServicebusSubscriptionRuleCorrelationFilter : azurerm.ServicebusSubscriptionRule.IServicebusSubscriptionRuleCorrelationFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#content_type ServicebusSubscriptionRule#content_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#correlation_id ServicebusSubscriptionRule#correlation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "correlationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CorrelationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#label ServicebusSubscriptionRule#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#message_id ServicebusSubscriptionRule#message_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#properties ServicebusSubscriptionRule#properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#reply_to ServicebusSubscriptionRule#reply_to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replyTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplyTo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#reply_to_session_id ServicebusSubscriptionRule#reply_to_session_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replyToSessionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplyToSessionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#session_id ServicebusSubscriptionRule#session_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#to ServicebusSubscriptionRule#to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? To
        {
            get;
            set;
        }
    }
}
