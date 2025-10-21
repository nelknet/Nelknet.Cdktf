using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleCriteriaResourceTags), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTags")]
    public interface ISecurityhubAutomationRuleCriteriaResourceTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#comparison SecurityhubAutomationRule#comparison}.</summary>
        [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
        string Comparison
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#key SecurityhubAutomationRule#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#value SecurityhubAutomationRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleCriteriaResourceTags), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTags")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#comparison SecurityhubAutomationRule#comparison}.</summary>
            [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
            public string Comparison
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#key SecurityhubAutomationRule#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#value SecurityhubAutomationRule#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
