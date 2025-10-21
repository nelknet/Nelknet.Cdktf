using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafByteMatchSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafByteMatchSet.WafByteMatchSetByteMatchTuplesFieldToMatch")]
    public class WafByteMatchSetByteMatchTuplesFieldToMatch : aws.WafByteMatchSet.IWafByteMatchSetByteMatchTuplesFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#type WafByteMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#data WafByteMatchSet#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }
    }
}
