using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiClass(nativeType: typeof(azurerm.StorageAccount.StorageAccountBlobPropertiesOutputReference), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageAccountBlobPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageAccountBlobPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageAccountBlobPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountBlobPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContainerDeleteRetentionPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicy\"}}]")]
        public virtual void PutContainerDeleteRetentionPolicy(azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCorsRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesCorsRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCorsRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StorageAccount.IStorageAccountBlobPropertiesCorsRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountBlobPropertiesCorsRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountBlobPropertiesCorsRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeleteRetentionPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy\"}}]")]
        public virtual void PutDeleteRetentionPolicy(azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestorePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy\"}}]")]
        public virtual void PutRestorePolicy(azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetChangeFeedEnabled")]
        public virtual void ResetChangeFeedEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChangeFeedRetentionInDays")]
        public virtual void ResetChangeFeedRetentionInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerDeleteRetentionPolicy")]
        public virtual void ResetContainerDeleteRetentionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultServiceVersion")]
        public virtual void ResetDefaultServiceVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteRetentionPolicy")]
        public virtual void ResetDeleteRetentionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastAccessTimeEnabled")]
        public virtual void ResetLastAccessTimeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestorePolicy")]
        public virtual void ResetRestorePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersioningEnabled")]
        public virtual void ResetVersioningEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containerDeleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicyOutputReference ContainerDeleteRetentionPolicy
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesCorsRuleList\"}")]
        public virtual azurerm.StorageAccount.StorageAccountBlobPropertiesCorsRuleList CorsRule
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountBlobPropertiesCorsRuleList>()!;
        }

        [JsiiProperty(name: "deleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicyOutputReference DeleteRetentionPolicy
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "restorePolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountBlobPropertiesRestorePolicyOutputReference RestorePolicy
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountBlobPropertiesRestorePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "changeFeedEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ChangeFeedEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "changeFeedRetentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChangeFeedRetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerDeleteRetentionPolicyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultServiceVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultServiceVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteRetentionPolicyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy? DeleteRetentionPolicyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastAccessTimeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LastAccessTimeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restorePolicyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy? RestorePolicyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versioningEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VersioningEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "changeFeedEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ChangeFeedEnabled
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

        [JsiiProperty(name: "changeFeedRetentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChangeFeedRetentionInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultServiceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultServiceVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastAccessTimeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LastAccessTimeEnabled
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

        [JsiiProperty(name: "versioningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object VersioningEnabled
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobProperties\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountBlobProperties? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
