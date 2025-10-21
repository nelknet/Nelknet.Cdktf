using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineExtension
{
    [JsiiClass(nativeType: typeof(azurerm.VirtualMachineExtension.VirtualMachineExtensionProtectedSettingsFromKeyVaultOutputReference), fullyQualifiedName: "azurerm.virtualMachineExtension.VirtualMachineExtensionProtectedSettingsFromKeyVaultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualMachineExtensionProtectedSettingsFromKeyVaultOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualMachineExtensionProtectedSettingsFromKeyVaultOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualMachineExtensionProtectedSettingsFromKeyVaultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineExtensionProtectedSettingsFromKeyVaultOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.virtualMachineExtension.VirtualMachineExtensionProtectedSettingsFromKeyVault\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineExtension.IVirtualMachineExtensionProtectedSettingsFromKeyVault? InternalValue
        {
            get => GetInstanceProperty<azurerm.VirtualMachineExtension.IVirtualMachineExtensionProtectedSettingsFromKeyVault?>();
            set => SetInstanceProperty(value);
        }
    }
}
