using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbAccount.CosmosdbAccountAnalyticalStorage")]
    public class CosmosdbAccountAnalyticalStorage : azurerm.CosmosdbAccount.ICosmosdbAccountAnalyticalStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#schema_type CosmosdbAccount#schema_type}.</summary>
        [JsiiProperty(name: "schemaType", typeJson: "{\"primitive\":\"string\"}")]
        public string SchemaType
        {
            get;
            set;
        }
    }
}
