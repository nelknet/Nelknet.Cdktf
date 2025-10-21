using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateRelatedFindings")]
    public class SecurityhubAutomationRuleActionsFindingFieldsUpdateRelatedFindings : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdateRelatedFindings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#id SecurityhubAutomationRule#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#product_arn SecurityhubAutomationRule#product_arn}.</summary>
        [JsiiProperty(name: "productArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ProductArn
        {
            get;
            set;
        }
    }
}
