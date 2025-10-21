using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudgetAction.BudgetsBudgetActionActionThreshold")]
    public class BudgetsBudgetActionActionThreshold : aws.BudgetsBudgetAction.IBudgetsBudgetActionActionThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold_type BudgetsBudgetAction#action_threshold_type}.</summary>
        [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionThresholdType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold_value BudgetsBudgetAction#action_threshold_value}.</summary>
        [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}")]
        public double ActionThresholdValue
        {
            get;
            set;
        }
    }
}
