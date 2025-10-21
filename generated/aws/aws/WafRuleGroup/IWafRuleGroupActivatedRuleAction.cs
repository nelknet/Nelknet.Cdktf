using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafRuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.wafRuleGroup.WafRuleGroupActivatedRuleAction")]
    public interface IWafRuleGroupActivatedRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#type WafRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.wafRuleGroup.WafRuleGroupActivatedRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.WafRuleGroup.IWafRuleGroupActivatedRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#type WafRuleGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
