using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementExport
{
    [JsiiInterface(nativeType: typeof(IResourceGroupCostManagementExportExportDataOptions), fullyQualifiedName: "azurerm.resourceGroupCostManagementExport.ResourceGroupCostManagementExportExportDataOptions")]
    public interface IResourceGroupCostManagementExportExportDataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#time_frame ResourceGroupCostManagementExport#time_frame}.</summary>
        [JsiiProperty(name: "timeFrame", typeJson: "{\"primitive\":\"string\"}")]
        string TimeFrame
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#type ResourceGroupCostManagementExport#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceGroupCostManagementExportExportDataOptions), fullyQualifiedName: "azurerm.resourceGroupCostManagementExport.ResourceGroupCostManagementExportExportDataOptions")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceGroupCostManagementExport.IResourceGroupCostManagementExportExportDataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#time_frame ResourceGroupCostManagementExport#time_frame}.</summary>
            [JsiiProperty(name: "timeFrame", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeFrame
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#type ResourceGroupCostManagementExport#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
