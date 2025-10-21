using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultCertificates
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificatesTimeouts")]
    public class DataAzurermKeyVaultCertificatesTimeouts : azurerm.DataAzurermKeyVaultCertificates.IDataAzurermKeyVaultCertificatesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates#read DataAzurermKeyVaultCertificates#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
