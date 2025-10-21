using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerRuleMatchHttpMatchPathMatch), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch")]
    public interface IVpclatticeListenerRuleMatchHttpMatchPathMatch
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#match VpclatticeListenerRule#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatchMatch\"}")]
        aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatchMatch Match
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#case_sensitive VpclatticeListenerRule#case_sensitive}.</summary>
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaseSensitive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerRuleMatchHttpMatchPathMatch), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#match VpclatticeListenerRule#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatchMatch\"}")]
            public aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatchMatch Match
            {
                get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatchMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#case_sensitive VpclatticeListenerRule#case_sensitive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CaseSensitive
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
