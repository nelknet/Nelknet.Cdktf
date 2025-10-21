using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity")]
    public interface ISecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#label SecurityhubAutomationRule#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#product SecurityhubAutomationRule#product}.</summary>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Product
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#label SecurityhubAutomationRule#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#product SecurityhubAutomationRule#product}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Product
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
