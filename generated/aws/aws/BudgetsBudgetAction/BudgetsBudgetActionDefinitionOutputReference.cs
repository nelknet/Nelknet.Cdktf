using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudgetAction
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionOutputReference), fullyQualifiedName: "aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BudgetsBudgetActionDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BudgetsBudgetActionDefinitionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BudgetsBudgetActionDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetActionDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIamActionDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinition\"}}]")]
        public virtual void PutIamActionDefinition(aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScpActionDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition\"}}]")]
        public virtual void PutScpActionDefinition(aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsmActionDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition\"}}]")]
        public virtual void PutSsmActionDefinition(aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIamActionDefinition")]
        public virtual void ResetIamActionDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScpActionDefinition")]
        public virtual void ResetScpActionDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsmActionDefinition")]
        public virtual void ResetSsmActionDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinitionOutputReference\"}")]
        public virtual aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinitionOutputReference IamActionDefinition
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinitionOutputReference\"}")]
        public virtual aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinitionOutputReference ScpActionDefinition
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinitionOutputReference\"}")]
        public virtual aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinitionOutputReference SsmActionDefinition
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinitionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamActionDefinitionInput", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
        public virtual aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinitionInput
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionIamActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scpActionDefinitionInput", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
        public virtual aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinitionInput
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionScpActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssmActionDefinitionInput", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
        public virtual aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinitionInput
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinitionSsmActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.budgetsBudgetAction.BudgetsBudgetActionDefinition\"}", isOptional: true)]
        public virtual aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.BudgetsBudgetAction.IBudgetsBudgetActionDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
