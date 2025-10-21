using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafXssMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafXssMatchSetXssMatchTuples), fullyQualifiedName: "aws.wafXssMatchSet.WafXssMatchSetXssMatchTuples")]
    public interface IWafXssMatchSetXssMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#field_to_match WafXssMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafXssMatchSet.WafXssMatchSetXssMatchTuplesFieldToMatch\"}")]
        aws.WafXssMatchSet.IWafXssMatchSetXssMatchTuplesFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#text_transformation WafXssMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafXssMatchSetXssMatchTuples), fullyQualifiedName: "aws.wafXssMatchSet.WafXssMatchSetXssMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.WafXssMatchSet.IWafXssMatchSetXssMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#field_to_match WafXssMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafXssMatchSet.WafXssMatchSetXssMatchTuplesFieldToMatch\"}")]
            public aws.WafXssMatchSet.IWafXssMatchSetXssMatchTuplesFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.WafXssMatchSet.IWafXssMatchSetXssMatchTuplesFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#text_transformation WafXssMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
