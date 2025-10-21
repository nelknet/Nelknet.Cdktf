using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts")]
    public interface IDataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#read DataAzurermKeyVaultManagedHardwareSecurityModule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.IDataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#read DataAzurermKeyVaultManagedHardwareSecurityModule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
