using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    [JsiiInterface(nativeType: typeof(ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex")]
    public interface ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#order CosmosdbGremlinGraph#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}")]
        string Order
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#path CosmosdbGremlinGraph#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyCompositeIndexIndex")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicyCompositeIndexIndex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#order CosmosdbGremlinGraph#order}.</summary>
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}")]
            public string Order
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#path CosmosdbGremlinGraph#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
