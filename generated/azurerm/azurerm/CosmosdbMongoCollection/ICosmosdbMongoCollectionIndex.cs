using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoCollection
{
    [JsiiInterface(nativeType: typeof(ICosmosdbMongoCollectionIndex), fullyQualifiedName: "azurerm.cosmosdbMongoCollection.CosmosdbMongoCollectionIndex")]
    public interface ICosmosdbMongoCollectionIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#keys CosmosdbMongoCollection#keys}.</summary>
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Keys
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#unique CosmosdbMongoCollection#unique}.</summary>
        [JsiiProperty(name: "unique", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Unique
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbMongoCollectionIndex), fullyQualifiedName: "azurerm.cosmosdbMongoCollection.CosmosdbMongoCollectionIndex")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbMongoCollection.ICosmosdbMongoCollectionIndex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#keys CosmosdbMongoCollection#keys}.</summary>
            [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Keys
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#unique CosmosdbMongoCollection#unique}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unique", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Unique
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
