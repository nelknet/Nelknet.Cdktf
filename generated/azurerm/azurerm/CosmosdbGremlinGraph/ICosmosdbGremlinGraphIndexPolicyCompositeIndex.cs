using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    [JsiiInterface(nativeType: typeof(ICosmosdbGremlinGraphIndexPolicyCompositeIndex), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndex")]
    public interface ICosmosdbGremlinGraphIndexPolicyCompositeIndex
    {
        /// <summary>index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#index CosmosdbGremlinGraph#index}
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex\"},\"kind\":\"array\"}}]}}")]
        object Index
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbGremlinGraphIndexPolicyCompositeIndex), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndex")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>index block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#index CosmosdbGremlinGraph#index}
            /// </remarks>
            [JsiiProperty(name: "index", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex\"},\"kind\":\"array\"}}]}}")]
            public object Index
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
