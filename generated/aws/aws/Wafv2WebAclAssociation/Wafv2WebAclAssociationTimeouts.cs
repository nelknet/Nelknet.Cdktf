using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclAssociation
{
    [JsiiByValue(fqn: "aws.wafv2WebAclAssociation.Wafv2WebAclAssociationTimeouts")]
    public class Wafv2WebAclAssociationTimeouts : aws.Wafv2WebAclAssociation.IWafv2WebAclAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#create Wafv2WebAclAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
