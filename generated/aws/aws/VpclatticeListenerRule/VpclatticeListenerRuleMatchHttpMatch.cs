using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch")]
    public class VpclatticeListenerRuleMatchHttpMatch : aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch
    {
        private object? _headerMatches;

        /// <summary>header_matches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#header_matches VpclatticeListenerRule#header_matches}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerMatches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HeaderMatches
        {
            get => _headerMatches;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchHeaderMatches[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchHeaderMatches).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headerMatches = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#method VpclatticeListenerRule#method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Method
        {
            get;
            set;
        }

        /// <summary>path_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#path_match VpclatticeListenerRule#path_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch\"}", isOptional: true)]
        public aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch? PathMatch
        {
            get;
            set;
        }
    }
}
