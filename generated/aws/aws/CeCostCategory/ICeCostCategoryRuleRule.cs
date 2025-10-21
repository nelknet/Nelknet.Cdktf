using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiInterface(nativeType: typeof(ICeCostCategoryRuleRule), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRule")]
    public interface ICeCostCategoryRuleRule
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#and CeCostCategory#and}
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? And
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory? CostCategory
        {
            get
            {
                return null;
            }
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleDimension? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#not CeCostCategory#not}
        /// </remarks>
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleNot? Not
        {
            get
            {
                return null;
            }
        }

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#or CeCostCategory#or}
        /// </remarks>
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Or
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeCostCategoryRuleRule), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRule")]
        internal sealed class _Proxy : DeputyBase, aws.CeCostCategory.ICeCostCategoryRuleRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#and CeCostCategory#and}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? And
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleCostCategory\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleDimension\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleDimension? Dimension
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleDimension?>();
            }

            /// <summary>not block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#not CeCostCategory#not}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNot\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleNot? Not
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNot?>();
            }

            /// <summary>or block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#or CeCostCategory#or}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Or
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleTags\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleTags? Tags
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleTags?>();
            }
        }
    }
}
