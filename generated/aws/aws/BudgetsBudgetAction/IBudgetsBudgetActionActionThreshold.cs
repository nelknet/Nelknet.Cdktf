using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionActionThreshold), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionActionThreshold")]
    public interface IBudgetsBudgetActionActionThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold_type BudgetsBudgetAction#action_threshold_type}.</summary>
        [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionThresholdType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold_value BudgetsBudgetAction#action_threshold_value}.</summary>
        [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}")]
        double ActionThresholdValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionActionThreshold), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionActionThreshold")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudgetAction.IBudgetsBudgetActionActionThreshold
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold_type BudgetsBudgetAction#action_threshold_type}.</summary>
            [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionThresholdType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold_value BudgetsBudgetAction#action_threshold_value}.</summary>
            [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}")]
            public double ActionThresholdValue
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
