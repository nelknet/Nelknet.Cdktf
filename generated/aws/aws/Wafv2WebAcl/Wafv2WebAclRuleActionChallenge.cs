using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRuleActionChallenge")]
    public class Wafv2WebAclRuleActionChallenge : aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandling\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandling? CustomRequestHandling
        {
            get;
            set;
        }
    }
}
