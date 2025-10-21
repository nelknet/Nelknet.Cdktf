using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerRuleAction), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleAction")]
    public interface IVpclatticeListenerRuleAction
    {
        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#fixed_response VpclatticeListenerRule#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#forward VpclatticeListenerRule#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward? Forward
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerRuleAction), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListenerRule.IVpclatticeListenerRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#fixed_response VpclatticeListenerRule#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse\"}", isOptional: true)]
            public aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#forward VpclatticeListenerRule#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward\"}", isOptional: true)]
            public aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward? Forward
            {
                get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward?>();
            }
        }
    }
}
