using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleRuleLabel")]
    public class Wafv2RuleGroupRuleRuleLabel : aws.Wafv2RuleGroup.IWafv2RuleGroupRuleRuleLabel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#name Wafv2RuleGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
