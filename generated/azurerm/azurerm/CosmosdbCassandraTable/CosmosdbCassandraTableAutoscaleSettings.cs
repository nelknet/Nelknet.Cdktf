using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    [JsiiByValue(fqn: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettings")]
    public class CosmosdbCassandraTableAutoscaleSettings : azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#max_throughput CosmosdbCassandraTable#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
