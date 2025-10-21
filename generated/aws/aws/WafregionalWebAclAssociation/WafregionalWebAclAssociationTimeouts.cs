using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAclAssociation
{
    [JsiiByValue(fqn: "aws.wafregionalWebAclAssociation.WafregionalWebAclAssociationTimeouts")]
    public class WafregionalWebAclAssociationTimeouts : aws.WafregionalWebAclAssociation.IWafregionalWebAclAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#create WafregionalWebAclAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
