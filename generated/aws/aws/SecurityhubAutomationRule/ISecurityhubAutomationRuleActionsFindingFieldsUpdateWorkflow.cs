using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow")]
    public interface ISecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#status SecurityhubAutomationRule#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#status SecurityhubAutomationRule#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
