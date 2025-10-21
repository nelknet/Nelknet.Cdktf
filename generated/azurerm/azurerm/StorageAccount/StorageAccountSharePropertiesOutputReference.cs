using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiClass(nativeType: typeof(azurerm.StorageAccount.StorageAccountSharePropertiesOutputReference), fullyQualifiedName: "azurerm.storageAccount.StorageAccountSharePropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageAccountSharePropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageAccountSharePropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageAccountSharePropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountSharePropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCorsRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesCorsRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCorsRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StorageAccount.IStorageAccountSharePropertiesCorsRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountSharePropertiesCorsRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountSharePropertiesCorsRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetentionPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesRetentionPolicy\"}}]")]
        public virtual void PutRetentionPolicy(azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesSmb\"}}]")]
        public virtual void PutSmb(azurerm.StorageAccount.IStorageAccountSharePropertiesSmb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountSharePropertiesSmb)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPolicy")]
        public virtual void ResetRetentionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmb")]
        public virtual void ResetSmb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesCorsRuleList\"}")]
        public virtual azurerm.StorageAccount.StorageAccountSharePropertiesCorsRuleList CorsRule
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountSharePropertiesCorsRuleList>()!;
        }

        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesRetentionPolicyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountSharePropertiesRetentionPolicyOutputReference RetentionPolicy
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountSharePropertiesRetentionPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "smb", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesSmbOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountSharePropertiesSmbOutputReference Smb
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountSharePropertiesSmbOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy? RetentionPolicyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesSmb\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountSharePropertiesSmb? SmbInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSharePropertiesSmb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountShareProperties\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountShareProperties? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountShareProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
