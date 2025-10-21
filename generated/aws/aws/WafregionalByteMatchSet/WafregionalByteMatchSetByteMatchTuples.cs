using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalByteMatchSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregionalByteMatchSet.WafregionalByteMatchSetByteMatchTuples")]
    public class WafregionalByteMatchSetByteMatchTuples : aws.WafregionalByteMatchSet.IWafregionalByteMatchSetByteMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#field_to_match WafregionalByteMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregionalByteMatchSet.WafregionalByteMatchSetByteMatchTuplesFieldToMatch\"}")]
        public aws.WafregionalByteMatchSet.IWafregionalByteMatchSetByteMatchTuplesFieldToMatch FieldToMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#positional_constraint WafregionalByteMatchSet#positional_constraint}.</summary>
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public string PositionalConstraint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#text_transformation WafregionalByteMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        public string TextTransformation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#target_string WafregionalByteMatchSet#target_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetString
        {
            get;
            set;
        }
    }
}
