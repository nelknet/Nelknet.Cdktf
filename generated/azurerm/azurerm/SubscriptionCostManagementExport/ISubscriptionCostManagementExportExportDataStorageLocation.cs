using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementExport
{
    [JsiiInterface(nativeType: typeof(ISubscriptionCostManagementExportExportDataStorageLocation), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation")]
    public interface ISubscriptionCostManagementExportExportDataStorageLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#container_id SubscriptionCostManagementExport#container_id}.</summary>
        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#root_folder_path SubscriptionCostManagementExport#root_folder_path}.</summary>
        [JsiiProperty(name: "rootFolderPath", typeJson: "{\"primitive\":\"string\"}")]
        string RootFolderPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionCostManagementExportExportDataStorageLocation), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#container_id SubscriptionCostManagementExport#container_id}.</summary>
            [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#root_folder_path SubscriptionCostManagementExport#root_folder_path}.</summary>
            [JsiiProperty(name: "rootFolderPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RootFolderPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
