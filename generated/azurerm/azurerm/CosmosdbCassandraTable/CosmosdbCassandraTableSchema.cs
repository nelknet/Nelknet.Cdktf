using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema")]
    public class CosmosdbCassandraTableSchema : azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema
    {
        private object _column;

        /// <summary>column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#column CosmosdbCassandraTable#column}
        /// </remarks>
        [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumn\"},\"kind\":\"array\"}}]}}")]
        public object Column
        {
            get => _column;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _column = value;
            }
        }

        private object _partitionKey;

        /// <summary>partition_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#partition_key CosmosdbCassandraTable#partition_key}
        /// </remarks>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey\"},\"kind\":\"array\"}}]}}")]
        public object PartitionKey
        {
            get => _partitionKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _partitionKey = value;
            }
        }

        private object? _clusterKey;

        /// <summary>cluster_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#cluster_key CosmosdbCassandraTable#cluster_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClusterKey
        {
            get => _clusterKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clusterKey = value;
            }
        }
    }
}
