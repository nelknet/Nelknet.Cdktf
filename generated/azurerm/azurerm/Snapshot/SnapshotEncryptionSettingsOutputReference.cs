using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Snapshot
{
    [JsiiClass(nativeType: typeof(azurerm.Snapshot.SnapshotEncryptionSettingsOutputReference), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SnapshotEncryptionSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SnapshotEncryptionSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SnapshotEncryptionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnapshotEncryptionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDiskEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey\"}}]")]
        public virtual void PutDiskEncryptionKey(azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey\"}}]")]
        public virtual void PutKeyEncryptionKey(azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKeyEncryptionKey")]
        public virtual void ResetKeyEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKeyOutputReference\"}")]
        public virtual azurerm.Snapshot.SnapshotEncryptionSettingsDiskEncryptionKeyOutputReference DiskEncryptionKey
        {
            get => GetInstanceProperty<azurerm.Snapshot.SnapshotEncryptionSettingsDiskEncryptionKeyOutputReference>()!;
        }

        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKeyOutputReference\"}")]
        public virtual azurerm.Snapshot.SnapshotEncryptionSettingsKeyEncryptionKeyOutputReference KeyEncryptionKey
        {
            get => GetInstanceProperty<azurerm.Snapshot.SnapshotEncryptionSettingsKeyEncryptionKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionKeyInput", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey? DiskEncryptionKeyInput
        {
            get => GetInstanceProperty<azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKeyInput", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey? KeyEncryptionKeyInput
        {
            get => GetInstanceProperty<azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettings\"}", isOptional: true)]
        public virtual azurerm.Snapshot.ISnapshotEncryptionSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.Snapshot.ISnapshotEncryptionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
