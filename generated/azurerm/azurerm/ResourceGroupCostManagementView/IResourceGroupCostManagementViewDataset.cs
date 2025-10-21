using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    [JsiiInterface(nativeType: typeof(IResourceGroupCostManagementViewDataset), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset")]
    public interface IResourceGroupCostManagementViewDataset
    {
        /// <summary>aggregation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#aggregation ResourceGroupCostManagementView#aggregation}
        /// </remarks>
        [JsiiProperty(name: "aggregation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}")]
        object Aggregation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#granularity ResourceGroupCostManagementView#granularity}.</summary>
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        string Granularity
        {
            get;
        }

        /// <summary>grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#grouping ResourceGroupCostManagementView#grouping}
        /// </remarks>
        [JsiiProperty(name: "grouping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Grouping
        {
            get
            {
                return null;
            }
        }

        /// <summary>sorting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#sorting ResourceGroupCostManagementView#sorting}
        /// </remarks>
        [JsiiProperty(name: "sorting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sorting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceGroupCostManagementViewDataset), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aggregation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#aggregation ResourceGroupCostManagementView#aggregation}
            /// </remarks>
            [JsiiProperty(name: "aggregation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}")]
            public object Aggregation
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#granularity ResourceGroupCostManagementView#granularity}.</summary>
            [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
            public string Granularity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>grouping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#grouping ResourceGroupCostManagementView#grouping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grouping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Grouping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sorting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#sorting ResourceGroupCostManagementView#sorting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sorting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sorting
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
