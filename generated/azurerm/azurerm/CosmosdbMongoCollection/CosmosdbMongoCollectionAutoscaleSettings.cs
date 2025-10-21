using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoCollection
{
    [JsiiByValue(fqn: "azurerm.cosmosdbMongoCollection.CosmosdbMongoCollectionAutoscaleSettings")]
    public class CosmosdbMongoCollectionAutoscaleSettings : azurerm.CosmosdbMongoCollection.ICosmosdbMongoCollectionAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#max_throughput CosmosdbMongoCollection#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
