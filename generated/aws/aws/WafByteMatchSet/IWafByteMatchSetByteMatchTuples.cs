using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafByteMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafByteMatchSetByteMatchTuples), fullyQualifiedName: "aws.wafByteMatchSet.WafByteMatchSetByteMatchTuples")]
    public interface IWafByteMatchSetByteMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#field_to_match WafByteMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafByteMatchSet.WafByteMatchSetByteMatchTuplesFieldToMatch\"}")]
        aws.WafByteMatchSet.IWafByteMatchSetByteMatchTuplesFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#positional_constraint WafByteMatchSet#positional_constraint}.</summary>
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        string PositionalConstraint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#text_transformation WafByteMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#target_string WafByteMatchSet#target_string}.</summary>
        [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafByteMatchSetByteMatchTuples), fullyQualifiedName: "aws.wafByteMatchSet.WafByteMatchSetByteMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.WafByteMatchSet.IWafByteMatchSetByteMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#field_to_match WafByteMatchSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafByteMatchSet.WafByteMatchSetByteMatchTuplesFieldToMatch\"}")]
            public aws.WafByteMatchSet.IWafByteMatchSetByteMatchTuplesFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.WafByteMatchSet.IWafByteMatchSetByteMatchTuplesFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#positional_constraint WafByteMatchSet#positional_constraint}.</summary>
            [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
            public string PositionalConstraint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#text_transformation WafByteMatchSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#target_string WafByteMatchSet#target_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetString
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
