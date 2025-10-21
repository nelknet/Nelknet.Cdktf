using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRuleActionBlock")]
    public class Wafv2WebAclRuleActionBlock : aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlock
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#custom_response Wafv2WebAcl#custom_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionBlockCustomResponse\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlockCustomResponse? CustomResponse
        {
            get;
            set;
        }
    }
}
