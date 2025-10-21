using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiByValue(fqn: "aws.ceCostCategory.CeCostCategoryRule")]
    public class CeCostCategoryRule : aws.CeCostCategory.ICeCostCategoryRule
    {
        /// <summary>inherited_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#inherited_value CeCostCategory#inherited_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inheritedValue", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleInheritedValue\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleInheritedValue? InheritedValue
        {
            get;
            set;
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#rule CeCostCategory#rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRule\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRule? Rule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#type CeCostCategory#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#value CeCostCategory#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
