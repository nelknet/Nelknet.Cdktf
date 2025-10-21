using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTableSchemaDefinition")]
    public class KeyspacesTableSchemaDefinition : aws.KeyspacesTable.IKeyspacesTableSchemaDefinition
    {
        private object _column;

        /// <summary>column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#column KeyspacesTable#column}
        /// </remarks>
        [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionColumn\"},\"kind\":\"array\"}}]}}")]
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
                        case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionColumn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionColumn).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionColumn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _column = value;
            }
        }

        private object _partitionKey;

        /// <summary>partition_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#partition_key KeyspacesTable#partition_key}
        /// </remarks>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKey\"},\"kind\":\"array\"}}]}}")]
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
                        case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _partitionKey = value;
            }
        }

        private object? _clusteringKey;

        /// <summary>clustering_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#clustering_key KeyspacesTable#clustering_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusteringKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClusteringKey
        {
            get => _clusteringKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clusteringKey = value;
            }
        }

        private object? _staticColumn;

        /// <summary>static_column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#static_column KeyspacesTable#static_column}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticColumn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StaticColumn
        {
            get => _staticColumn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionStaticColumn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionStaticColumn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _staticColumn = value;
            }
        }
    }
}
