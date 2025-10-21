using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rbinRule.RbinRuleResourceTags")]
    public class RbinRuleResourceTags : aws.RbinRule.IRbinRuleResourceTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tag_key RbinRule#resource_tag_key}.</summary>
        [JsiiProperty(name: "resourceTagKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceTagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tag_value RbinRule#resource_tag_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceTagValue
        {
            get;
            set;
        }
    }
}
