using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerRuleMatch), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatch")]
    public interface IVpclatticeListenerRuleMatch
    {
        /// <summary>http_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#http_match VpclatticeListenerRule#http_match}
        /// </remarks>
        [JsiiProperty(name: "httpMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch\"}")]
        aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch HttpMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerRuleMatch), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatch")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>http_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#http_match VpclatticeListenerRule#http_match}
            /// </remarks>
            [JsiiProperty(name: "httpMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch\"}")]
            public aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch HttpMatch
            {
                get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch>()!;
            }
        }
    }
}
