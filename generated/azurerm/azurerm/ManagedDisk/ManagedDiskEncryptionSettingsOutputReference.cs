using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDisk
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDisk.ManagedDiskEncryptionSettingsOutputReference), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDiskEncryptionSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDiskEncryptionSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDiskEncryptionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDiskEncryptionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDiskEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey\"}}]")]
        public virtual void PutDiskEncryptionKey(azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey\"}}]")]
        public virtual void PutKeyEncryptionKey(azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKeyEncryptionKey")]
        public virtual void ResetKeyEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference\"}")]
        public virtual azurerm.ManagedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference DiskEncryptionKey
        {
            get => GetInstanceProperty<azurerm.ManagedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference>()!;
        }

        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKeyOutputReference\"}")]
        public virtual azurerm.ManagedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKeyOutputReference KeyEncryptionKey
        {
            get => GetInstanceProperty<azurerm.ManagedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionKeyInput", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKeyInput
        {
            get => GetInstanceProperty<azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKeyInput", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKeyInput
        {
            get => GetInstanceProperty<azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettings\"}", isOptional: true)]
        public virtual azurerm.ManagedDisk.IManagedDiskEncryptionSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDisk.IManagedDiskEncryptionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
