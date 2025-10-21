using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiInterface(nativeType: typeof(ICeCostCategoryRuleRuleOrAnd), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleOrAnd")]
    public interface ICeCostCategoryRuleRuleOrAnd
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndCostCategory? CostCategory
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
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndDimension? Dimension
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeCostCategoryRuleRuleOrAnd), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleOrAnd")]
        internal sealed class _Proxy : DeputyBase, aws.CeCostCategory.ICeCostCategoryRuleRuleOrAnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndCostCategory\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndDimension\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndDimension? Dimension
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndDimension?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndTags\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndTags? Tags
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndTags?>();
            }
        }
    }
}
