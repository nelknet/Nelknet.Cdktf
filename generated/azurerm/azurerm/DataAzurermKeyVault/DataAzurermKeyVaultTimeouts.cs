using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVault
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKeyVault.DataAzurermKeyVaultTimeouts")]
    public class DataAzurermKeyVaultTimeouts : azurerm.DataAzurermKeyVault.IDataAzurermKeyVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault#read DataAzurermKeyVault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
