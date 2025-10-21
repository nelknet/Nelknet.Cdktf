using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbAccount
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeouts")]
    public class DataAzurermCosmosdbAccountTimeouts : azurerm.DataAzurermCosmosdbAccount.IDataAzurermCosmosdbAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#read DataAzurermCosmosdbAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
