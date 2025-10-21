using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex")]
    public class CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex : azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#order CosmosdbGremlinGraph#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}")]
        public string Order
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#path CosmosdbGremlinGraph#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
