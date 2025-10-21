using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    [JsiiInterface(nativeType: typeof(ICosmosdbCassandraTableSchemaClusterKey), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey")]
    public interface ICosmosdbCassandraTableSchemaClusterKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#name CosmosdbCassandraTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#order_by CosmosdbCassandraTable#order_by}.</summary>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
        string OrderBy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbCassandraTableSchemaClusterKey), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#order_by CosmosdbCassandraTable#order_by}.</summary>
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
            public string OrderBy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
