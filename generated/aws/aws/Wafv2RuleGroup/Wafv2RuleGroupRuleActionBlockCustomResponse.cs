using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlockCustomResponse")]
    public class Wafv2RuleGroupRuleActionBlockCustomResponse : aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlockCustomResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#response_code Wafv2RuleGroup#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
        public double ResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#custom_response_body_key Wafv2RuleGroup#custom_response_body_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomResponseBodyKey
        {
            get;
            set;
        }

        private object? _responseHeader;

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#response_header Wafv2RuleGroup#response_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseHeader
        {
            get => _responseHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseHeader = value;
            }
        }
    }
}
