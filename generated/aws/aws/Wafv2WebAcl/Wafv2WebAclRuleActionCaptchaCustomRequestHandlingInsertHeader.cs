using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandlingInsertHeader")]
    public class Wafv2WebAclRuleActionCaptchaCustomRequestHandlingInsertHeader : aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptchaCustomRequestHandlingInsertHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#value Wafv2WebAcl#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
