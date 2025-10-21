using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudgetAction.BudgetsBudgetActionSubscriber")]
    public class BudgetsBudgetActionSubscriber : aws.BudgetsBudgetAction.IBudgetsBudgetActionSubscriber
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#address BudgetsBudgetAction#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#subscription_type BudgetsBudgetAction#subscription_type}.</summary>
        [JsiiProperty(name: "subscriptionType", typeJson: "{\"primitive\":\"string\"}")]
        public string SubscriptionType
        {
            get;
            set;
        }
    }
}
