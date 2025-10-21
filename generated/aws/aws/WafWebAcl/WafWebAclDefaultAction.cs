using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafWebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafWebAcl.WafWebAclDefaultAction")]
    public class WafWebAclDefaultAction : aws.WafWebAcl.IWafWebAclDefaultAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#type WafWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
