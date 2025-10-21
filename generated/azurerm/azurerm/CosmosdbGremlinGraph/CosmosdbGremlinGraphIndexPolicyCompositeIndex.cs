using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndex")]
    public class CosmosdbGremlinGraphIndexPolicyCompositeIndex : azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndex
    {
        private object _index;

        /// <summary>index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#index CosmosdbGremlinGraph#index}
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex\"},\"kind\":\"array\"}}]}}")]
        public object Index
        {
            get => _index;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _index = value;
            }
        }
    }
}
