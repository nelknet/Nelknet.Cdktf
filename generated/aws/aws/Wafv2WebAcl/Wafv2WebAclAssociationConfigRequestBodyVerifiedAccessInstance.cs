using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance")]
    public class Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance : aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#default_size_inspection_limit Wafv2WebAcl#default_size_inspection_limit}.</summary>
        [JsiiProperty(name: "defaultSizeInspectionLimit", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultSizeInspectionLimit
        {
            get;
            set;
        }
    }
}
