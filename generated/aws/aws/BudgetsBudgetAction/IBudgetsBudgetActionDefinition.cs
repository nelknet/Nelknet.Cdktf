using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionDefinition), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinition")]
    public interface IBudgetsBudgetActionDefinition
    {
        /// <summary>iam_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#iam_action_definition BudgetsBudgetAction#iam_action_definition}
        /// </remarks>
        [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>scp_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#scp_action_definition BudgetsBudgetAction#scp_action_definition}
        /// </remarks>
        [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssm_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#ssm_action_definition BudgetsBudgetAction#ssm_action_definition}
        /// </remarks>
        [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionDefinition), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>iam_action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#iam_action_definition BudgetsBudgetAction#iam_action_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
            public aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinition
            {
                get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition?>();
            }

            /// <summary>scp_action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#scp_action_definition BudgetsBudgetAction#scp_action_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
            public aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinition
            {
                get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition?>();
            }

            /// <summary>ssm_action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#ssm_action_definition BudgetsBudgetAction#ssm_action_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
            public aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinition
            {
                get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition?>();
            }
        }
    }
}
