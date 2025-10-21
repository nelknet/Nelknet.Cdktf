using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodestarnotificationsNotificationRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codestarnotificationsNotificationRule.CodestarnotificationsNotificationRuleTarget")]
    public class CodestarnotificationsNotificationRuleTarget : aws.CodestarnotificationsNotificationRule.ICodestarnotificationsNotificationRuleTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#address CodestarnotificationsNotificationRule#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#type CodestarnotificationsNotificationRule#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
