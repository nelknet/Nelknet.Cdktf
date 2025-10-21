using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    [JsiiByValue(fqn: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinition")]
    public class BudgetsBudgetActionDefinition : aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinition
    {
        /// <summary>iam_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#iam_action_definition BudgetsBudgetAction#iam_action_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
        public aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinition
        {
            get;
            set;
        }

        /// <summary>scp_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#scp_action_definition BudgetsBudgetAction#scp_action_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
        public aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinition
        {
            get;
            set;
        }

        /// <summary>ssm_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#ssm_action_definition BudgetsBudgetAction#ssm_action_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
        public aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinition
        {
            get;
            set;
        }
    }
}
