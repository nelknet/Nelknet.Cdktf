using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition")]
    public class BudgetsBudgetActionDefinitionSsmActionDefinition : aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_sub_type BudgetsBudgetAction#action_sub_type}.</summary>
        [JsiiProperty(name: "actionSubType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionSubType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#instance_ids BudgetsBudgetAction#instance_ids}.</summary>
        [JsiiProperty(name: "instanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] InstanceIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#region BudgetsBudgetAction#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}
