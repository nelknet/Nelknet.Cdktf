using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartition")]
    public class SecurityhubAutomationRuleCriteriaResourcePartition : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourcePartition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#comparison SecurityhubAutomationRule#comparison}.</summary>
        [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
        public string Comparison
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#value SecurityhubAutomationRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
