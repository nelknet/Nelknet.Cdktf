using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoCollection
{
    [JsiiInterface(nativeType: typeof(ICosmosdbMongoCollectionAutoscaleSettings), fullyQualifiedName: "azurerm.cosmosdbMongoCollection.CosmosdbMongoCollectionAutoscaleSettings")]
    public interface ICosmosdbMongoCollectionAutoscaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#max_throughput CosmosdbMongoCollection#max_throughput}.</summary>
        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxThroughput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbMongoCollectionAutoscaleSettings), fullyQualifiedName: "azurerm.cosmosdbMongoCollection.CosmosdbMongoCollectionAutoscaleSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbMongoCollection.ICosmosdbMongoCollectionAutoscaleSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#max_throughput CosmosdbMongoCollection#max_throughput}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxThroughput
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
