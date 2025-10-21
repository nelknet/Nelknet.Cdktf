using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappAccountEncryption
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeouts")]
    public class DataAzurermNetappAccountEncryptionTimeouts : azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#read DataAzurermNetappAccountEncryption#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
