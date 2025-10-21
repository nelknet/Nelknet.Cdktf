using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetAutoAdjustData")]
    public class BudgetsBudgetAutoAdjustData : aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#auto_adjust_type BudgetsBudget#auto_adjust_type}.</summary>
        [JsiiProperty(name: "autoAdjustType", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoAdjustType
        {
            get;
            set;
        }

        /// <summary>historical_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#historical_options BudgetsBudget#historical_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "historicalOptions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions? HistoricalOptions
        {
            get;
            set;
        }
    }
}
