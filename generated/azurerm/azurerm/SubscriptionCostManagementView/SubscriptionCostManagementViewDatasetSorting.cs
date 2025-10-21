using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementView
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetSorting")]
    public class SubscriptionCostManagementViewDatasetSorting : azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetSorting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#direction SubscriptionCostManagementView#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public string Direction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#name SubscriptionCostManagementView#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
