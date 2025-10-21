using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodestarnotificationsNotificationRule
{
    [JsiiInterface(nativeType: typeof(ICodestarnotificationsNotificationRuleTarget), fullyQualifiedName: "aws.codestarnotificationsNotificationRule.CodestarnotificationsNotificationRuleTarget")]
    public interface ICodestarnotificationsNotificationRuleTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#address CodestarnotificationsNotificationRule#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#type CodestarnotificationsNotificationRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodestarnotificationsNotificationRuleTarget), fullyQualifiedName: "aws.codestarnotificationsNotificationRule.CodestarnotificationsNotificationRuleTarget")]
        internal sealed class _Proxy : DeputyBase, aws.CodestarnotificationsNotificationRule.ICodestarnotificationsNotificationRuleTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#address CodestarnotificationsNotificationRule#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#type CodestarnotificationsNotificationRule#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
