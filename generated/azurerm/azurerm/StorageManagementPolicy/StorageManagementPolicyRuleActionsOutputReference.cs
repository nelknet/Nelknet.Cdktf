using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsOutputReference), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageManagementPolicyRuleActionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageManagementPolicyRuleActionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageManagementPolicyRuleActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageManagementPolicyRuleActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBaseBlob", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob\"}}]")]
        public virtual void PutBaseBlob(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshot\"}}]")]
        public virtual void PutSnapshot(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion\"}}]")]
        public virtual void PutVersion(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBaseBlob")]
        public virtual void ResetBaseBlob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshot")]
        public virtual void ResetSnapshot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "baseBlob", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlobOutputReference\"}")]
        public virtual azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlobOutputReference BaseBlob
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlobOutputReference>()!;
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshotOutputReference\"}")]
        public virtual azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsSnapshotOutputReference Snapshot
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsSnapshotOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersionOutputReference\"}")]
        public virtual azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsVersionOutputReference Version
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.StorageManagementPolicyRuleActionsVersionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseBlobInput", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob? BaseBlobInput
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotInput", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshot\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot? SnapshotInput
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion? VersionInput
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions\"}", isOptional: true)]
        public virtual azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
