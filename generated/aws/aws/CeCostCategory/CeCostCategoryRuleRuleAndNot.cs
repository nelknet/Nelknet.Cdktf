using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiByValue(fqn: "aws.ceCostCategory.CeCostCategoryRuleRuleAndNot")]
    public class CeCostCategoryRuleRuleAndNot : aws.CeCostCategory.ICeCostCategoryRuleRuleAndNot
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotCostCategory\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotDimension\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotTags\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotTags? Tags
        {
            get;
            set;
        }
    }
}
