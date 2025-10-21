using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultKey
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKeyVaultKey.DataAzurermKeyVaultKeyTimeouts")]
    public class DataAzurermKeyVaultKeyTimeouts : azurerm.DataAzurermKeyVaultKey.IDataAzurermKeyVaultKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_key#read DataAzurermKeyVaultKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
