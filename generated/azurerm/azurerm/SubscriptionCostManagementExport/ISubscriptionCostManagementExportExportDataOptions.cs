using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementExport
{
    [JsiiInterface(nativeType: typeof(ISubscriptionCostManagementExportExportDataOptions), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions")]
    public interface ISubscriptionCostManagementExportExportDataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#time_frame SubscriptionCostManagementExport#time_frame}.</summary>
        [JsiiProperty(name: "timeFrame", typeJson: "{\"primitive\":\"string\"}")]
        string TimeFrame
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#type SubscriptionCostManagementExport#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionCostManagementExportExportDataOptions), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#time_frame SubscriptionCostManagementExport#time_frame}.</summary>
            [JsiiProperty(name: "timeFrame", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeFrame
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#type SubscriptionCostManagementExport#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
