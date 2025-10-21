using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiInterface(nativeType: typeof(ICeCostCategoryRuleRuleOrNot), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleOrNot")]
    public interface ICeCostCategoryRuleRuleOrNot
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory? CostCategory
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
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension? Dimension
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeCostCategoryRuleRuleOrNot), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleOrNot")]
        internal sealed class _Proxy : DeputyBase, aws.CeCostCategory.ICeCostCategoryRuleRuleOrNot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotCostCategory\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotDimension\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension? Dimension
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotTags\"}", isOptional: true)]
            public aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags? Tags
            {
                get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags?>();
            }
        }
    }
}
