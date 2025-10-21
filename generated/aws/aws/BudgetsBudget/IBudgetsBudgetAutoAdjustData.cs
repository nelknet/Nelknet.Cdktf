using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetAutoAdjustData), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetAutoAdjustData")]
    public interface IBudgetsBudgetAutoAdjustData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#auto_adjust_type BudgetsBudget#auto_adjust_type}.</summary>
        [JsiiProperty(name: "autoAdjustType", typeJson: "{\"primitive\":\"string\"}")]
        string AutoAdjustType
        {
            get;
        }

        /// <summary>historical_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#historical_options BudgetsBudget#historical_options}
        /// </remarks>
        [JsiiProperty(name: "historicalOptions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions? HistoricalOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetAutoAdjustData), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetAutoAdjustData")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#auto_adjust_type BudgetsBudget#auto_adjust_type}.</summary>
            [JsiiProperty(name: "autoAdjustType", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoAdjustType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>historical_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#historical_options BudgetsBudget#historical_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "historicalOptions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions? HistoricalOptions
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions?>();
            }
        }
    }
}
