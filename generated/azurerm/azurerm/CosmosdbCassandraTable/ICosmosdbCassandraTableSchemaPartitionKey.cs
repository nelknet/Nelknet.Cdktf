using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    [JsiiInterface(nativeType: typeof(ICosmosdbCassandraTableSchemaPartitionKey), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey")]
    public interface ICosmosdbCassandraTableSchemaPartitionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbCassandraTableSchemaPartitionKey), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
