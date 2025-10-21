using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupCostManagementExport.ResourceGroupCostManagementExportExportDataOptions")]
    public class ResourceGroupCostManagementExportExportDataOptions : azurerm.ResourceGroupCostManagementExport.IResourceGroupCostManagementExportExportDataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#time_frame ResourceGroupCostManagementExport#time_frame}.</summary>
        [JsiiProperty(name: "timeFrame", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeFrame
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#type ResourceGroupCostManagementExport#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
