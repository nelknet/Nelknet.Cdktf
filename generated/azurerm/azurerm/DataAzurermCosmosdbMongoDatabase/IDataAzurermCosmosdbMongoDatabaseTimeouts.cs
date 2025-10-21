using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbMongoDatabase
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCosmosdbMongoDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabaseTimeouts")]
    public interface IDataAzurermCosmosdbMongoDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#read DataAzurermCosmosdbMongoDatabase#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCosmosdbMongoDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCosmosdbMongoDatabase.IDataAzurermCosmosdbMongoDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#read DataAzurermCosmosdbMongoDatabase#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
