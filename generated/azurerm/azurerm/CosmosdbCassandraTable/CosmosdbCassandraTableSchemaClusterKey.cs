using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey")]
    public class CosmosdbCassandraTableSchemaClusterKey : azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#order_by CosmosdbCassandraTable#order_by}.</summary>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
        public string OrderBy
        {
            get;
            set;
        }
    }
}
