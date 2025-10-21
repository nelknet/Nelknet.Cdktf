using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetAutoAdjustDataHistoricalOptions), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions")]
    public interface IBudgetsBudgetAutoAdjustDataHistoricalOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#budget_adjustment_period BudgetsBudget#budget_adjustment_period}.</summary>
        [JsiiProperty(name: "budgetAdjustmentPeriod", typeJson: "{\"primitive\":\"number\"}")]
        double BudgetAdjustmentPeriod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetAutoAdjustDataHistoricalOptions), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#budget_adjustment_period BudgetsBudget#budget_adjustment_period}.</summary>
            [JsiiProperty(name: "budgetAdjustmentPeriod", typeJson: "{\"primitive\":\"number\"}")]
            public double BudgetAdjustmentPeriod
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
