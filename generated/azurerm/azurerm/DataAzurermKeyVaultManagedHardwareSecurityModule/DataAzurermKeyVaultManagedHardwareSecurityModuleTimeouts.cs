using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts")]
    public class DataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.IDataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#read DataAzurermKeyVaultManagedHardwareSecurityModule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
