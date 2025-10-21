using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions")]
    public class BudgetsBudgetAutoAdjustDataHistoricalOptions : aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#budget_adjustment_period BudgetsBudget#budget_adjustment_period}.</summary>
        [JsiiProperty(name: "budgetAdjustmentPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public double BudgetAdjustmentPeriod
        {
            get;
            set;
        }
    }
}
