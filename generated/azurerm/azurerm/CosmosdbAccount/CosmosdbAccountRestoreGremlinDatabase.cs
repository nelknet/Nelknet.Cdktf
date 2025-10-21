using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbAccount.CosmosdbAccountRestoreGremlinDatabase")]
    public class CosmosdbAccountRestoreGremlinDatabase : azurerm.CosmosdbAccount.ICosmosdbAccountRestoreGremlinDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#name CosmosdbAccount#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#graph_names CosmosdbAccount#graph_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "graphNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GraphNames
        {
            get;
            set;
        }
    }
}
