using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetPlannedLimit")]
    public class BudgetsBudgetPlannedLimit : aws.BudgetsBudget.IBudgetsBudgetPlannedLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#amount BudgetsBudget#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
        public string Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#start_time BudgetsBudget#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#unit BudgetsBudget#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public string Unit
        {
            get;
            set;
        }
    }
}
