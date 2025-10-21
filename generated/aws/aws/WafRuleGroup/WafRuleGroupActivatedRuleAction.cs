using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafRuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafRuleGroup.WafRuleGroupActivatedRuleAction")]
    public class WafRuleGroupActivatedRuleAction : aws.WafRuleGroup.IWafRuleGroupActivatedRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#type WafRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
