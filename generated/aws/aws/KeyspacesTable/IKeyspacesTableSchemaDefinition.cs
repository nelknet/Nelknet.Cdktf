using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiInterface(nativeType: typeof(IKeyspacesTableSchemaDefinition), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableSchemaDefinition")]
    public interface IKeyspacesTableSchemaDefinition
    {
        /// <summary>column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#column KeyspacesTable#column}
        /// </remarks>
        [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionColumn\"},\"kind\":\"array\"}}]}}")]
        object Column
        {
            get;
        }

        /// <summary>partition_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#partition_key KeyspacesTable#partition_key}
        /// </remarks>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKey\"},\"kind\":\"array\"}}]}}")]
        object PartitionKey
        {
            get;
        }

        /// <summary>clustering_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#clustering_key KeyspacesTable#clustering_key}
        /// </remarks>
        [JsiiProperty(name: "clusteringKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClusteringKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>static_column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#static_column KeyspacesTable#static_column}
        /// </remarks>
        [JsiiProperty(name: "staticColumn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StaticColumn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesTableSchemaDefinition), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableSchemaDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesTable.IKeyspacesTableSchemaDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>column block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#column KeyspacesTable#column}
            /// </remarks>
            [JsiiProperty(name: "column", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionColumn\"},\"kind\":\"array\"}}]}}")]
            public object Column
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>partition_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#partition_key KeyspacesTable#partition_key}
            /// </remarks>
            [JsiiProperty(name: "partitionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKey\"},\"kind\":\"array\"}}]}}")]
            public object PartitionKey
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>clustering_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#clustering_key KeyspacesTable#clustering_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusteringKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClusteringKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>static_column block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#static_column KeyspacesTable#static_column}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticColumn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StaticColumn
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
