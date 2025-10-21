using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiByValue(fqn: "aws.ceCostCategory.CeCostCategoryRuleInheritedValue")]
    public class CeCostCategoryRuleInheritedValue : aws.CeCostCategory.ICeCostCategoryRuleInheritedValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension_key CeCostCategory#dimension_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimensionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DimensionKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension_name CeCostCategory#dimension_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DimensionName
        {
            get;
            set;
        }
    }
}
