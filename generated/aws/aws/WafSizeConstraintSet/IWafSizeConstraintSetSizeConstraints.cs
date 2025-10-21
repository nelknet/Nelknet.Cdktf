using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafSizeConstraintSet
{
    [JsiiInterface(nativeType: typeof(IWafSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.wafSizeConstraintSet.WafSizeConstraintSetSizeConstraints")]
    public interface IWafSizeConstraintSetSizeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#comparison_operator WafSizeConstraintSet#comparison_operator}.</summary>
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#field_to_match WafSizeConstraintSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafSizeConstraintSet.WafSizeConstraintSetSizeConstraintsFieldToMatch\"}")]
        aws.WafSizeConstraintSet.IWafSizeConstraintSetSizeConstraintsFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#size WafSizeConstraintSet#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#text_transformation WafSizeConstraintSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.wafSizeConstraintSet.WafSizeConstraintSetSizeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.WafSizeConstraintSet.IWafSizeConstraintSetSizeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#comparison_operator WafSizeConstraintSet#comparison_operator}.</summary>
            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#field_to_match WafSizeConstraintSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafSizeConstraintSet.WafSizeConstraintSetSizeConstraintsFieldToMatch\"}")]
            public aws.WafSizeConstraintSet.IWafSizeConstraintSetSizeConstraintsFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.WafSizeConstraintSet.IWafSizeConstraintSetSizeConstraintsFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#size WafSizeConstraintSet#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#text_transformation WafSizeConstraintSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
