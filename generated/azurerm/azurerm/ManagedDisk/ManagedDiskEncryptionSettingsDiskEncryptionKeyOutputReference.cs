using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDisk
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDiskEncryptionSettingsDiskEncryptionKeyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceVaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey?>();
            set => SetInstanceProperty(value);
        }
    }
}
