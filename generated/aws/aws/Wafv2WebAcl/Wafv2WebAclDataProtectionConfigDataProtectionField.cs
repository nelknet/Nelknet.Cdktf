using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtectionField")]
    public class Wafv2WebAclDataProtectionConfigDataProtectionField : aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtectionField
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field_type Wafv2WebAcl#field_type}.</summary>
        [JsiiProperty(name: "fieldType", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field_keys Wafv2WebAcl#field_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FieldKeys
        {
            get;
            set;
        }
    }
}
