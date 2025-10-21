using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.StorageManagementPolicy.StorageManagementPolicyRuleFiltersOutputReference), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageManagementPolicyRuleFiltersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageManagementPolicyRuleFiltersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageManagementPolicyRuleFiltersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageManagementPolicyRuleFiltersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMatchBlobIndexTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMatchBlobIndexTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMatchBlobIndexTag")]
        public virtual void ResetMatchBlobIndexTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefixMatch")]
        public virtual void ResetPrefixMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "matchBlobIndexTag", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTagList\"}")]
        public virtual azurerm.StorageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTagList MatchBlobIndexTag
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTagList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blobTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BlobTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchBlobIndexTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MatchBlobIndexTagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixMatchInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PrefixMatchInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "blobTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BlobTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefixMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrefixMatch
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters?>();
            set => SetInstanceProperty(value);
        }
    }
}
