using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsVersionOutputReference), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageManagementPolicyRuleActionsVersionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageManagementPolicyRuleActionsVersionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageManagementPolicyRuleActionsVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageManagementPolicyRuleActionsVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetChangeTierToArchiveAfterDaysSinceCreation")]
        public virtual void ResetChangeTierToArchiveAfterDaysSinceCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChangeTierToCoolAfterDaysSinceCreation")]
        public virtual void ResetChangeTierToCoolAfterDaysSinceCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteAfterDaysSinceCreation")]
        public virtual void ResetDeleteAfterDaysSinceCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
        public virtual void ResetTierToArchiveAfterDaysSinceLastTierChangeGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToColdAfterDaysSinceCreationGreaterThan")]
        public virtual void ResetTierToColdAfterDaysSinceCreationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "changeTierToArchiveAfterDaysSinceCreationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChangeTierToArchiveAfterDaysSinceCreationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "changeTierToCoolAfterDaysSinceCreationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChangeTierToCoolAfterDaysSinceCreationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceCreationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeleteAfterDaysSinceCreationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastTierChangeGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToColdAfterDaysSinceCreationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "changeTierToArchiveAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChangeTierToArchiveAfterDaysSinceCreation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "changeTierToCoolAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChangeTierToCoolAfterDaysSinceCreation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceCreation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastTierChangeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToColdAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
