using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerRuleActionForward), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward")]
    public interface IVpclatticeListenerRuleActionForward
    {
        /// <summary>target_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#target_groups VpclatticeListenerRule#target_groups}
        /// </remarks>
        [JsiiProperty(name: "targetGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForwardTargetGroups\"},\"kind\":\"array\"}}]}}")]
        object TargetGroups
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerRuleActionForward), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#target_groups VpclatticeListenerRule#target_groups}
            /// </remarks>
            [JsiiProperty(name: "targetGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForwardTargetGroups\"},\"kind\":\"array\"}}]}}")]
            public object TargetGroups
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
