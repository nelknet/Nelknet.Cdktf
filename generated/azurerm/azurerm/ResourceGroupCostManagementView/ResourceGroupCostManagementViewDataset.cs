using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset")]
    public class ResourceGroupCostManagementViewDataset : azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset
    {
        private object _aggregation;

        /// <summary>aggregation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#aggregation ResourceGroupCostManagementView#aggregation}
        /// </remarks>
        [JsiiProperty(name: "aggregation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}")]
        public object Aggregation
        {
            get => _aggregation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _aggregation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#granularity ResourceGroupCostManagementView#granularity}.</summary>
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        public string Granularity
        {
            get;
            set;
        }

        private object? _grouping;

        /// <summary>grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#grouping ResourceGroupCostManagementView#grouping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grouping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Grouping
        {
            get => _grouping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetGrouping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetGrouping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _grouping = value;
            }
        }

        private object? _sorting;

        /// <summary>sorting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#sorting ResourceGroupCostManagementView#sorting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sorting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Sorting
        {
            get => _sorting;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetSorting[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetSorting).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sorting = value;
            }
        }
    }
}
