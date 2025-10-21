using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandling")]
    public class Wafv2WebAclRuleActionChallengeCustomRequestHandling : aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandling
    {
        private object _insertHeader;

        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}]}}")]
        public object InsertHeader
        {
            get => _insertHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandlingInsertHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandlingInsertHeader).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandlingInsertHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _insertHeader = value;
            }
        }
    }
}
