using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionDefinitionSsmActionDefinition), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition")]
    public interface IBudgetsBudgetActionDefinitionSsmActionDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_sub_type BudgetsBudgetAction#action_sub_type}.</summary>
        [JsiiProperty(name: "actionSubType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionSubType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#instance_ids BudgetsBudgetAction#instance_ids}.</summary>
        [JsiiProperty(name: "instanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] InstanceIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#region BudgetsBudgetAction#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionDefinitionSsmActionDefinition), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_sub_type BudgetsBudgetAction#action_sub_type}.</summary>
            [JsiiProperty(name: "actionSubType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionSubType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#instance_ids BudgetsBudgetAction#instance_ids}.</summary>
            [JsiiProperty(name: "instanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] InstanceIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#region BudgetsBudgetAction#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
