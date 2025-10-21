using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinDatabase
{
    [JsiiByValue(fqn: "azurerm.cosmosdbGremlinDatabase.CosmosdbGremlinDatabaseAutoscaleSettings")]
    public class CosmosdbGremlinDatabaseAutoscaleSettings : azurerm.CosmosdbGremlinDatabase.ICosmosdbGremlinDatabaseAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#max_throughput CosmosdbGremlinDatabase#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
