using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiInterface(nativeType: typeof(ICeCostCategoryRuleRuleNotOr), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleNotOr")]
    public interface ICeCostCategoryRuleRuleNotOr
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrCostCategory? CostCategory
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
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrDimension? Dimension
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeCostCategoryRuleRuleNotOr), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleNotOr")]
        internal sealed class _Proxy : DeputyBase, aws.CeCostCategory.ICeCostCategoryRuleRuleNotOr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrCostCategory\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrDimension\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrDimension? Dimension
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrDimension?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrTags\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrTags? Tags
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotOrTags?>();
            }
        }
    }
}
