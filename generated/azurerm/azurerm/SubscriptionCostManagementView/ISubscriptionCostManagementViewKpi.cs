using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementView
{
    [JsiiInterface(nativeType: typeof(ISubscriptionCostManagementViewKpi), fullyQualifiedName: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewKpi")]
    public interface ISubscriptionCostManagementViewKpi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#type SubscriptionCostManagementView#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionCostManagementViewKpi), fullyQualifiedName: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewKpi")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewKpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#type SubscriptionCostManagementView#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
