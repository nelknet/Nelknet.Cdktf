using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdateNote), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateNote")]
    public interface ISecurityhubAutomationRuleActionsFindingFieldsUpdateNote
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#text SecurityhubAutomationRule#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        string Text
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#updated_by SecurityhubAutomationRule#updated_by}.</summary>
        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        string UpdatedBy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdateNote), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateNote")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateNote
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#text SecurityhubAutomationRule#text}.</summary>
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
            public string Text
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#updated_by SecurityhubAutomationRule#updated_by}.</summary>
            [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
            public string UpdatedBy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
