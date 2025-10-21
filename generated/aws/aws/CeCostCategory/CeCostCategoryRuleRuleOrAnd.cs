using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiByValue(fqn: "aws.ceCostCategory.CeCostCategoryRuleRuleOrAnd")]
    public class CeCostCategoryRuleRuleOrAnd : aws.CeCostCategory.ICeCostCategoryRuleRuleOrAnd
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndCostCategory\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndDimension\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrAndTags\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleOrAndTags? Tags
        {
            get;
            set;
        }
    }
}
