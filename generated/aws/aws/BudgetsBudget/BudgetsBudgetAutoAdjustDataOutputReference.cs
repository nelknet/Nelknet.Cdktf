using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget.BudgetsBudgetAutoAdjustDataOutputReference), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetAutoAdjustDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BudgetsBudgetAutoAdjustDataOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BudgetsBudgetAutoAdjustDataOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetAutoAdjustDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetAutoAdjustDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHistoricalOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions\"}}]")]
        public virtual void PutHistoricalOptions(aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHistoricalOptions")]
        public virtual void ResetHistoricalOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "historicalOptions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptionsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptionsOutputReference HistoricalOptions
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "lastAutoAdjustTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAutoAdjustTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAdjustTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoAdjustTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "historicalOptionsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustDataHistoricalOptions\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions? HistoricalOptionsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetAutoAdjustDataHistoricalOptions?>();
        }

        [JsiiProperty(name: "autoAdjustType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoAdjustType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustData\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData? InternalValue
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData?>();
            set => SetInstanceProperty(value);
        }
    }
}
