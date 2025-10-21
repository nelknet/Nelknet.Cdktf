using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    [JsiiInterface(nativeType: typeof(ICosmosdbCassandraTableSchema), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema")]
    public interface ICosmosdbCassandraTableSchema
    {
        /// <summary>column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#column CosmosdbCassandraTable#column}
        /// </remarks>
        [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumn\"},\"kind\":\"array\"}}]}}")]
        object Column
        {
            get;
        }

        /// <summary>partition_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#partition_key CosmosdbCassandraTable#partition_key}
        /// </remarks>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey\"},\"kind\":\"array\"}}]}}")]
        object PartitionKey
        {
            get;
        }

        /// <summary>cluster_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#cluster_key CosmosdbCassandraTable#cluster_key}
        /// </remarks>
        [JsiiProperty(name: "clusterKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClusterKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbCassandraTableSchema), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>column block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#column CosmosdbCassandraTable#column}
            /// </remarks>
            [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumn\"},\"kind\":\"array\"}}]}}")]
            public object Column
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>partition_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#partition_key CosmosdbCassandraTable#partition_key}
            /// </remarks>
            [JsiiProperty(name: "partitionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey\"},\"kind\":\"array\"}}]}}")]
            public object PartitionKey
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>cluster_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#cluster_key CosmosdbCassandraTable#cluster_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClusterKey
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
