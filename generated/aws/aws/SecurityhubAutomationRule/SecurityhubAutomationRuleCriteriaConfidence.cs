using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidence")]
    public class SecurityhubAutomationRuleCriteriaConfidence : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaConfidence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#eq SecurityhubAutomationRule#eq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eq", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Eq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#gt SecurityhubAutomationRule#gt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Gt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#gte SecurityhubAutomationRule#gte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Gte
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#lt SecurityhubAutomationRule#lt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#lte SecurityhubAutomationRule#lte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lte
        {
            get;
            set;
        }
    }
}
