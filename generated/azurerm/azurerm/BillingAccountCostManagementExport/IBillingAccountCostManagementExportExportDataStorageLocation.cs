using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BillingAccountCostManagementExport
{
    [JsiiInterface(nativeType: typeof(IBillingAccountCostManagementExportExportDataStorageLocation), fullyQualifiedName: "azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation")]
    public interface IBillingAccountCostManagementExportExportDataStorageLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#container_id BillingAccountCostManagementExport#container_id}.</summary>
        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#root_folder_path BillingAccountCostManagementExport#root_folder_path}.</summary>
        [JsiiProperty(name: "rootFolderPath", typeJson: "{\"primitive\":\"string\"}")]
        string RootFolderPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingAccountCostManagementExportExportDataStorageLocation), fullyQualifiedName: "azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation")]
        internal sealed class _Proxy : DeputyBase, azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#container_id BillingAccountCostManagementExport#container_id}.</summary>
            [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#root_folder_path BillingAccountCostManagementExport#root_folder_path}.</summary>
            [JsiiProperty(name: "rootFolderPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RootFolderPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
