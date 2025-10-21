using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountSas
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeouts")]
    public class DataAzurermStorageAccountSasTimeouts : azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#read DataAzurermStorageAccountSas#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
