using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbTable
{
    [JsiiByValue(fqn: "azurerm.cosmosdbTable.CosmosdbTableAutoscaleSettings")]
    public class CosmosdbTableAutoscaleSettings : azurerm.CosmosdbTable.ICosmosdbTableAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#max_throughput CosmosdbTable#max_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThroughput
        {
            get;
            set;
        }
    }
}
