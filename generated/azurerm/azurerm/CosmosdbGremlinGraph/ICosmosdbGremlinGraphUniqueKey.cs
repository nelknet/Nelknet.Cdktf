using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    [JsiiInterface(nativeType: typeof(ICosmosdbGremlinGraphUniqueKey), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKey")]
    public interface ICosmosdbGremlinGraphUniqueKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#paths CosmosdbGremlinGraph#paths}.</summary>
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Paths
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbGremlinGraphUniqueKey), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphUniqueKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#paths CosmosdbGremlinGraph#paths}.</summary>
            [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Paths
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
