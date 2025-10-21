using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiInterface(nativeType: typeof(ICeCostCategoryRuleInheritedValue), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleInheritedValue")]
    public interface ICeCostCategoryRuleInheritedValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension_key CeCostCategory#dimension_key}.</summary>
        [JsiiProperty(name: "dimensionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DimensionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension_name CeCostCategory#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DimensionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeCostCategoryRuleInheritedValue), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleInheritedValue")]
        internal sealed class _Proxy : DeputyBase, aws.CeCostCategory.ICeCostCategoryRuleInheritedValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension_key CeCostCategory#dimension_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dimensionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DimensionKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension_name CeCostCategory#dimension_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DimensionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
