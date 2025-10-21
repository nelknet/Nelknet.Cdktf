using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition")]
    public class BudgetsBudgetActionDefinitionScpActionDefinition : aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#policy_id BudgetsBudgetAction#policy_id}.</summary>
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#target_ids BudgetsBudgetAction#target_ids}.</summary>
        [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TargetIds
        {
            get;
            set;
        }
    }
}
