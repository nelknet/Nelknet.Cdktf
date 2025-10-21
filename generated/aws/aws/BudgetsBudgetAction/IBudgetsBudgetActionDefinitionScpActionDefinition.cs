using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionDefinitionScpActionDefinition), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition")]
    public interface IBudgetsBudgetActionDefinitionScpActionDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#policy_id BudgetsBudgetAction#policy_id}.</summary>
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#target_ids BudgetsBudgetAction#target_ids}.</summary>
        [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TargetIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionDefinitionScpActionDefinition), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#policy_id BudgetsBudgetAction#policy_id}.</summary>
            [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#target_ids BudgetsBudgetAction#target_ids}.</summary>
            [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TargetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
