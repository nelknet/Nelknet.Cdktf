using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleActionBlock), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlock")]
    public interface IWafv2RuleGroupRuleActionBlock
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#custom_response Wafv2RuleGroup#custom_response}
        /// </remarks>
        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlockCustomResponse? CustomResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleActionBlock), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlock")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlock
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#custom_response Wafv2RuleGroup#custom_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true)]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlockCustomResponse? CustomResponse
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlockCustomResponse?>();
            }
        }
    }
}
