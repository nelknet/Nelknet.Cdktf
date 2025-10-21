using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafRegexMatchSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafRegexMatchSet.WafRegexMatchSetRegexMatchTuple")]
    public class WafRegexMatchSetRegexMatchTuple : aws.WafRegexMatchSet.IWafRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set#field_to_match WafRegexMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafRegexMatchSet.WafRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
        public aws.WafRegexMatchSet.IWafRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set#regex_pattern_set_id WafRegexMatchSet#regex_pattern_set_id}.</summary>
        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
        public string RegexPatternSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set#text_transformation WafRegexMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        public string TextTransformation
        {
            get;
            set;
        }
    }
}
