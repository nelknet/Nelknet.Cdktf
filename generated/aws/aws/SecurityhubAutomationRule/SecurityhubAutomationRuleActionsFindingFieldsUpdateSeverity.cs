using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity")]
    public class SecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#label SecurityhubAutomationRule#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#product SecurityhubAutomationRule#product}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Product
        {
            get;
            set;
        }
    }
}
