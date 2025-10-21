using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoDatabase
{
    [JsiiByValue(fqn: "azurerm.cosmosdbMongoDatabase.CosmosdbMongoDatabaseAutoscaleSettings")]
    public class CosmosdbMongoDatabaseAutoscaleSettings : azurerm.CosmosdbMongoDatabase.ICosmosdbMongoDatabaseAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#max_throughput CosmosdbMongoDatabase#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
