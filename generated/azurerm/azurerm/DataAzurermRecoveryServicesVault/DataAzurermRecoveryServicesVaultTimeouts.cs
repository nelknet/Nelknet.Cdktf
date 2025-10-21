using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRecoveryServicesVault
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVaultTimeouts")]
    public class DataAzurermRecoveryServicesVaultTimeouts : azurerm.DataAzurermRecoveryServicesVault.IDataAzurermRecoveryServicesVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#read DataAzurermRecoveryServicesVault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
