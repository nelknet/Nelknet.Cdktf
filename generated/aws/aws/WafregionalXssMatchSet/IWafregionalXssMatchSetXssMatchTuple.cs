using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalXssMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafregionalXssMatchSetXssMatchTuple), fullyQualifiedName: "aws.wafregionalXssMatchSet.WafregionalXssMatchSetXssMatchTuple")]
    public interface IWafregionalXssMatchSetXssMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#field_to_match WafregionalXssMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregionalXssMatchSet.WafregionalXssMatchSetXssMatchTupleFieldToMatch\"}")]
        aws.WafregionalXssMatchSet.IWafregionalXssMatchSetXssMatchTupleFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#text_transformation WafregionalXssMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalXssMatchSetXssMatchTuple), fullyQualifiedName: "aws.wafregionalXssMatchSet.WafregionalXssMatchSetXssMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalXssMatchSet.IWafregionalXssMatchSetXssMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#field_to_match WafregionalXssMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregionalXssMatchSet.WafregionalXssMatchSetXssMatchTupleFieldToMatch\"}")]
            public aws.WafregionalXssMatchSet.IWafregionalXssMatchSetXssMatchTupleFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.WafregionalXssMatchSet.IWafregionalXssMatchSetXssMatchTupleFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#text_transformation WafregionalXssMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
