using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumn")]
    public class CosmosdbCassandraTableSchemaColumn : azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#type CosmosdbCassandraTable#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
