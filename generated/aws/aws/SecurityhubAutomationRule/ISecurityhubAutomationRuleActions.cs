using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleActions), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActions")]
    public interface ISecurityhubAutomationRuleActions
    {
        /// <summary>finding_fields_update block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#finding_fields_update SecurityhubAutomationRule#finding_fields_update}
        /// </remarks>
        [JsiiProperty(name: "findingFieldsUpdate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingFieldsUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#type SecurityhubAutomationRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleActions), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActions")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>finding_fields_update block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#finding_fields_update SecurityhubAutomationRule#finding_fields_update}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingFieldsUpdate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingFieldsUpdate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#type SecurityhubAutomationRule#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
