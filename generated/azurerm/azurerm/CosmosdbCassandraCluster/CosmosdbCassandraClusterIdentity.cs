using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbCassandraCluster.CosmosdbCassandraClusterIdentity")]
    public class CosmosdbCassandraClusterIdentity : azurerm.CosmosdbCassandraCluster.ICosmosdbCassandraClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#type CosmosdbCassandraCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
