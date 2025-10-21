using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregation")]
    public class ResourceGroupCostManagementViewDatasetAggregation : azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#column_name ResourceGroupCostManagementView#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#name ResourceGroupCostManagementView#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
