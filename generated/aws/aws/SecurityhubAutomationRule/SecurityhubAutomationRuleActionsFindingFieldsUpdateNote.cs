using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateNote")]
    public class SecurityhubAutomationRuleActionsFindingFieldsUpdateNote : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateNote
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#text SecurityhubAutomationRule#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public string Text
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#updated_by SecurityhubAutomationRule#updated_by}.</summary>
        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public string UpdatedBy
        {
            get;
            set;
        }
    }
}
