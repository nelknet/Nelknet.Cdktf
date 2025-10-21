using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementView
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregation")]
    public class SubscriptionCostManagementViewDatasetAggregation : azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetAggregation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#column_name SubscriptionCostManagementView#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnName
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
