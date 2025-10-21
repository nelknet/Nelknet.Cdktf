using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    [JsiiInterface(nativeType: typeof(IResourceGroupCostManagementViewKpi), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpi")]
    public interface IResourceGroupCostManagementViewKpi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#type ResourceGroupCostManagementView#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceGroupCostManagementViewKpi), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpi")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewKpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#type ResourceGroupCostManagementView#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
