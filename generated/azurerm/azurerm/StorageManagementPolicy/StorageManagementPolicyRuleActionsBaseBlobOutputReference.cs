using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlobOutputReference), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlobOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageManagementPolicyRuleActionsBaseBlobOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageManagementPolicyRuleActionsBaseBlobOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageManagementPolicyRuleActionsBaseBlobOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageManagementPolicyRuleActionsBaseBlobOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAutoTierToHotFromCoolEnabled")]
        public virtual void ResetAutoTierToHotFromCoolEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteAfterDaysSinceCreationGreaterThan")]
        public virtual void ResetDeleteAfterDaysSinceCreationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteAfterDaysSinceLastAccessTimeGreaterThan")]
        public virtual void ResetDeleteAfterDaysSinceLastAccessTimeGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteAfterDaysSinceModificationGreaterThan")]
        public virtual void ResetDeleteAfterDaysSinceModificationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToArchiveAfterDaysSinceCreationGreaterThan")]
        public virtual void ResetTierToArchiveAfterDaysSinceCreationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
        public virtual void ResetTierToArchiveAfterDaysSinceLastAccessTimeGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
        public virtual void ResetTierToArchiveAfterDaysSinceLastTierChangeGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToArchiveAfterDaysSinceModificationGreaterThan")]
        public virtual void ResetTierToArchiveAfterDaysSinceModificationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToColdAfterDaysSinceCreationGreaterThan")]
        public virtual void ResetTierToColdAfterDaysSinceCreationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
        public virtual void ResetTierToColdAfterDaysSinceLastAccessTimeGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToColdAfterDaysSinceModificationGreaterThan")]
        public virtual void ResetTierToColdAfterDaysSinceModificationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToCoolAfterDaysSinceCreationGreaterThan")]
        public virtual void ResetTierToCoolAfterDaysSinceCreationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
        public virtual void ResetTierToCoolAfterDaysSinceLastAccessTimeGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTierToCoolAfterDaysSinceModificationGreaterThan")]
        public virtual void ResetTierToCoolAfterDaysSinceModificationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoTierToHotFromCoolEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoTierToHotFromCoolEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceCreationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeleteAfterDaysSinceCreationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceLastAccessTimeGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeleteAfterDaysSinceLastAccessTimeGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceModificationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeleteAfterDaysSinceModificationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceCreationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToArchiveAfterDaysSinceCreationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastAccessTimeGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThanInput
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
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceModificationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToArchiveAfterDaysSinceModificationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToColdAfterDaysSinceCreationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceLastAccessTimeGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToColdAfterDaysSinceLastAccessTimeGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceModificationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToColdAfterDaysSinceModificationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToCoolAfterDaysSinceCreationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToCoolAfterDaysSinceCreationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToCoolAfterDaysSinceLastAccessTimeGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierToCoolAfterDaysSinceModificationGreaterThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TierToCoolAfterDaysSinceModificationGreaterThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "autoTierToHotFromCoolEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoTierToHotFromCoolEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "deleteAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan
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

        [JsiiProperty(name: "tierToArchiveAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToArchiveAfterDaysSinceModificationGreaterThan
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

        [JsiiProperty(name: "tierToColdAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToColdAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToColdAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToColdAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToCoolAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToCoolAfterDaysSinceCreationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToCoolAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToCoolAfterDaysSinceLastAccessTimeGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tierToCoolAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TierToCoolAfterDaysSinceModificationGreaterThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob?>();
            set => SetInstanceProperty(value);
        }
    }
}
