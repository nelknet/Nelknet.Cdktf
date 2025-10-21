using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow")]
    public class SecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#status SecurityhubAutomationRule#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
