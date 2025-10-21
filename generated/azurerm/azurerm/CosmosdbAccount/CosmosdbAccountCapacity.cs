using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbAccount.CosmosdbAccountCapacity")]
    public class CosmosdbAccountCapacity : azurerm.CosmosdbAccount.ICosmosdbAccountCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#total_throughput_limit CosmosdbAccount#total_throughput_limit}.</summary>
        [JsiiProperty(name: "totalThroughputLimit", typeJson: "{\"primitive\":\"number\"}")]
        public double TotalThroughputLimit
        {
            get;
            set;
        }
    }
}
