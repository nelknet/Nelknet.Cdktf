using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalRegexMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafregionalRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.wafregionalRegexMatchSet.WafregionalRegexMatchSetRegexMatchTuple")]
    public interface IWafregionalRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#field_to_match WafregionalRegexMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregionalRegexMatchSet.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
        aws.WafregionalRegexMatchSet.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#regex_pattern_set_id WafregionalRegexMatchSet#regex_pattern_set_id}.</summary>
        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
        string RegexPatternSetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#text_transformation WafregionalRegexMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.wafregionalRegexMatchSet.WafregionalRegexMatchSetRegexMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalRegexMatchSet.IWafregionalRegexMatchSetRegexMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#field_to_match WafregionalRegexMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregionalRegexMatchSet.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"}")]
            public aws.WafregionalRegexMatchSet.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.WafregionalRegexMatchSet.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#regex_pattern_set_id WafregionalRegexMatchSet#regex_pattern_set_id}.</summary>
            [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegexPatternSetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#text_transformation WafregionalRegexMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
