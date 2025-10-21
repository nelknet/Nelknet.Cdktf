using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiByValue(fqn: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerAutoscaleSettings")]
    public class CosmosdbSqlContainerAutoscaleSettings : azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#max_throughput CosmosdbSqlContainer#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
