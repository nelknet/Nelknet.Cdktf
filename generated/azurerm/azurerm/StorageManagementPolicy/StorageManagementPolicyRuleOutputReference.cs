using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.StorageManagementPolicy.StorageManagementPolicyRuleOutputReference), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class StorageManagementPolicyRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public StorageManagementPolicyRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageManagementPolicyRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageManagementPolicyRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions\"}}]")]
        public virtual void PutActions(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters\"}}]")]
        public virtual void PutFilters(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters)}, new object[]{@value});
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsOutputReference\"}")]
        public virtual azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsOutputReference Actions
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsOutputReference>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersOutputReference\"}")]
        public virtual azurerm.StorageManagementPolicy.StorageManagementPolicyRuleFiltersOutputReference Filters
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.StorageManagementPolicyRuleFiltersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsInput", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions? ActionsInput
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filtersInput", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters? FiltersInput
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.StorageManagementPolicy.IStorageManagementPolicyRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
