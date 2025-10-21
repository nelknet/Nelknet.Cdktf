using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetResourceGroup
{
    [JsiiByValue(fqn: "azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter")]
    public class ConsumptionBudgetResourceGroupFilter : azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter
    {
        private object? _dimension;

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#dimension ConsumptionBudgetResourceGroup#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dimension
        {
            get => _dimension;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterDimension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterDimension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dimension = value;
            }
        }

        private object? _tag;

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#tag ConsumptionBudgetResourceGroup#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tag
        {
            get => _tag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tag = value;
            }
        }
    }
}
