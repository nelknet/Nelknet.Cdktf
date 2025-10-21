using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerRuleMatchHttpMatch), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch")]
    public interface IVpclatticeListenerRuleMatchHttpMatch
    {
        /// <summary>header_matches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#header_matches VpclatticeListenerRule#header_matches}
        /// </remarks>
        [JsiiProperty(name: "headerMatches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HeaderMatches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#method VpclatticeListenerRule#method}.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#path_match VpclatticeListenerRule#path_match}
        /// </remarks>
        [JsiiProperty(name: "pathMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch? PathMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerRuleMatchHttpMatch), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>header_matches block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#header_matches VpclatticeListenerRule#header_matches}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerMatches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HeaderMatches
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#method VpclatticeListenerRule#method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>path_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#path_match VpclatticeListenerRule#path_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch\"}", isOptional: true)]
            public aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch? PathMatch
            {
                get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch?>();
            }
        }
    }
}
