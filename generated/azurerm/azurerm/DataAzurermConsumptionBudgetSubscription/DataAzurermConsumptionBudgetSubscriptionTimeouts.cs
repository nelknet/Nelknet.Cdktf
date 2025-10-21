using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermConsumptionBudgetSubscription
{
    [JsiiByValue(fqn: "azurerm.dataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscriptionTimeouts")]
    public class DataAzurermConsumptionBudgetSubscriptionTimeouts : azurerm.DataAzurermConsumptionBudgetSubscription.IDataAzurermConsumptionBudgetSubscriptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_subscription#read DataAzurermConsumptionBudgetSubscription#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
