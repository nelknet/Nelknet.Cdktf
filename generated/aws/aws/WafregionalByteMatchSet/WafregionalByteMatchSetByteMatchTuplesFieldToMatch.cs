using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalByteMatchSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregionalByteMatchSet.WafregionalByteMatchSetByteMatchTuplesFieldToMatch")]
    public class WafregionalByteMatchSetByteMatchTuplesFieldToMatch : aws.WafregionalByteMatchSet.IWafregionalByteMatchSetByteMatchTuplesFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#type WafregionalByteMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#data WafregionalByteMatchSet#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }
    }
}
