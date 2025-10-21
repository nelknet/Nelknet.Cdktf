using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclDefaultActionAllow")]
    public class Wafv2WebAclDefaultActionAllow : aws.Wafv2WebAcl.IWafv2WebAclDefaultActionAllow
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionAllowCustomRequestHandling\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclDefaultActionAllowCustomRequestHandling? CustomRequestHandling
        {
            get;
            set;
        }
    }
}
