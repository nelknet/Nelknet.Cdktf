using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineExtension
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineExtensionProtectedSettingsFromKeyVault), fullyQualifiedName: "azurerm.virtualMachineExtension.VirtualMachineExtensionProtectedSettingsFromKeyVault")]
    public interface IVirtualMachineExtensionProtectedSettingsFromKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#secret_url VirtualMachineExtension#secret_url}.</summary>
        [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SecretUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#source_vault_id VirtualMachineExtension#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineExtensionProtectedSettingsFromKeyVault), fullyQualifiedName: "azurerm.virtualMachineExtension.VirtualMachineExtensionProtectedSettingsFromKeyVault")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineExtension.IVirtualMachineExtensionProtectedSettingsFromKeyVault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#secret_url VirtualMachineExtension#secret_url}.</summary>
            [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#source_vault_id VirtualMachineExtension#source_vault_id}.</summary>
            [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
