using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaOutputReference), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbCassandraTableSchemaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbCassandraTableSchemaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbCassandraTableSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbCassandraTableSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClusterKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClusterKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaClusterKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putColumn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaColumn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPartitionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPartitionKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchemaPartitionKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterKey")]
        public virtual void ResetClusterKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clusterKey", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKeyList\"}")]
        public virtual azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKeyList ClusterKey
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKeyList>()!;
        }

        [JsiiProperty(name: "column", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumnList\"}")]
        public virtual azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumnList Column
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumnList>()!;
        }

        [JsiiProperty(name: "partitionKey", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKeyList\"}")]
        public virtual azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKeyList PartitionKey
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKeyList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaClusterKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClusterKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ColumnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaPartitionKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PartitionKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema\"}", isOptional: true)]
        public virtual azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}
