using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalRuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafregionalRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.wafregionalRuleGroup.WafregionalRuleGroupActivatedRuleAction")]
    public interface IWafregionalRuleGroupActivatedRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#type WafregionalRuleGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.wafregionalRuleGroup.WafregionalRuleGroupActivatedRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalRuleGroup.IWafregionalRuleGroupActivatedRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#type WafregionalRuleGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
