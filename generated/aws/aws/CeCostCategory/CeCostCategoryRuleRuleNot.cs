using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiByValue(fqn: "aws.ceCostCategory.CeCostCategoryRuleRuleNot")]
    public class CeCostCategoryRuleRuleNot : aws.CeCostCategory.ICeCostCategoryRuleRuleNot
    {
        private object? _and;

        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#and CeCostCategory#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? And
        {
            get => _and;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CeCostCategory.ICeCostCategoryRuleRuleNotAnd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotAnd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _and = value;
            }
        }

        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#cost_category CeCostCategory#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotCostCategory\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleNotCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#dimension CeCostCategory#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotDimension\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleNotDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#not CeCostCategory#not}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotNot\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleNotNot? Not
        {
            get;
            set;
        }

        private object? _or;

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#or CeCostCategory#or}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Or
        {
            get => _or;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CeCostCategory.ICeCostCategoryRuleRuleNotOr[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotOr).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _or = value;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags CeCostCategory#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotTags\"}", isOptional: true)]
        public aws.CeCostCategory.ICeCostCategoryRuleRuleNotTags? Tags
        {
            get;
            set;
        }
    }
}
