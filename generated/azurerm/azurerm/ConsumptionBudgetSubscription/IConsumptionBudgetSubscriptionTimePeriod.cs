using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetSubscription
{
    [JsiiInterface(nativeType: typeof(IConsumptionBudgetSubscriptionTimePeriod), fullyQualifiedName: "azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriod")]
    public interface IConsumptionBudgetSubscriptionTimePeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#start_date ConsumptionBudgetSubscription#start_date}.</summary>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
        string StartDate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#end_date ConsumptionBudgetSubscription#end_date}.</summary>
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConsumptionBudgetSubscriptionTimePeriod), fullyQualifiedName: "azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriod")]
        internal sealed class _Proxy : DeputyBase, azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimePeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#start_date ConsumptionBudgetSubscription#start_date}.</summary>
            [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
            public string StartDate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#end_date ConsumptionBudgetSubscription#end_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
