using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupCostManagementExport.ResourceGroupCostManagementExportExportDataStorageLocation")]
    public class ResourceGroupCostManagementExportExportDataStorageLocation : azurerm.ResourceGroupCostManagementExport.IResourceGroupCostManagementExportExportDataStorageLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#container_id ResourceGroupCostManagementExport#container_id}.</summary>
        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#root_folder_path ResourceGroupCostManagementExport#root_folder_path}.</summary>
        [JsiiProperty(name: "rootFolderPath", typeJson: "{\"primitive\":\"string\"}")]
        public string RootFolderPath
        {
            get;
            set;
        }
    }
}
