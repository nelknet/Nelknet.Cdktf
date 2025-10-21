using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraKeyspace
{
    [JsiiByValue(fqn: "azurerm.cosmosdbCassandraKeyspace.CosmosdbCassandraKeyspaceAutoscaleSettings")]
    public class CosmosdbCassandraKeyspaceAutoscaleSettings : azurerm.CosmosdbCassandraKeyspace.ICosmosdbCassandraKeyspaceAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#max_throughput CosmosdbCassandraKeyspace#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
