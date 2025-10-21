using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch")]
    public class VpclatticeListenerRuleMatchHttpMatchPathMatch : aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#match VpclatticeListenerRule#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatchMatch\"}")]
        public aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatchMatch Match
        {
            get;
            set;
        }

        private object? _caseSensitive;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#case_sensitive VpclatticeListenerRule#case_sensitive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CaseSensitive
        {
            get => _caseSensitive;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _caseSensitive = value;
            }
        }
    }
}
