using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultManagedHardwareSecurityModule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.keyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleNetworkAcls")]
    public class KeyVaultManagedHardwareSecurityModuleNetworkAcls : azurerm.KeyVaultManagedHardwareSecurityModule.IKeyVaultManagedHardwareSecurityModuleNetworkAcls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#bypass KeyVaultManagedHardwareSecurityModule#bypass}.</summary>
        [JsiiProperty(name: "bypass", typeJson: "{\"primitive\":\"string\"}")]
        public string Bypass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#default_action KeyVaultManagedHardwareSecurityModule#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultAction
        {
            get;
            set;
        }
    }
}
