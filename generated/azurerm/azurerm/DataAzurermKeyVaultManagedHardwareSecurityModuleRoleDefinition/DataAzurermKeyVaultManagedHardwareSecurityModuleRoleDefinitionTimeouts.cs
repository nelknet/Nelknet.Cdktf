using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts")]
    public class DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.IDataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition#read DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
