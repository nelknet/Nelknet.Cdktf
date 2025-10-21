using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbMongoDatabase
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabaseTimeouts")]
    public class DataAzurermCosmosdbMongoDatabaseTimeouts : azurerm.DataAzurermCosmosdbMongoDatabase.IDataAzurermCosmosdbMongoDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#read DataAzurermCosmosdbMongoDatabase#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
