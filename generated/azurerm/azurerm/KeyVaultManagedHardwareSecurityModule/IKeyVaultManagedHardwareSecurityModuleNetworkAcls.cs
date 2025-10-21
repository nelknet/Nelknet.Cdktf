using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultManagedHardwareSecurityModule
{
    [JsiiInterface(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleNetworkAcls), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleNetworkAcls")]
    public interface IKeyVaultManagedHardwareSecurityModuleNetworkAcls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#bypass KeyVaultManagedHardwareSecurityModule#bypass}.</summary>
        [JsiiProperty(name: "bypass", typeJson: "{\"primitive\":\"string\"}")]
        string Bypass
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#default_action KeyVaultManagedHardwareSecurityModule#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultAction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleNetworkAcls), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleNetworkAcls")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultManagedHardwareSecurityModule.IKeyVaultManagedHardwareSecurityModuleNetworkAcls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#bypass KeyVaultManagedHardwareSecurityModule#bypass}.</summary>
            [JsiiProperty(name: "bypass", typeJson: "{\"primitive\":\"string\"}")]
            public string Bypass
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#default_action KeyVaultManagedHardwareSecurityModule#default_action}.</summary>
            [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultAction
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
