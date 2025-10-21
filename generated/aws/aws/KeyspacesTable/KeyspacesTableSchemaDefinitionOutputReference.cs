using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiClass(nativeType: typeof(aws.KeyspacesTable.KeyspacesTableSchemaDefinitionOutputReference), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableSchemaDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyspacesTableSchemaDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyspacesTableSchemaDefinitionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyspacesTableSchemaDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyspacesTableSchemaDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClusteringKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClusteringKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putColumn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionColumn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionColumn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionColumn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionColumn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPartitionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPartitionKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStaticColumn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStaticColumn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionStaticColumn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionStaticColumn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionStaticColumn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusteringKey")]
        public virtual void ResetClusteringKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticColumn")]
        public virtual void ResetStaticColumn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clusteringKey", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKeyList\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableSchemaDefinitionClusteringKeyList ClusteringKey
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableSchemaDefinitionClusteringKeyList>()!;
        }

        [JsiiProperty(name: "column", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionColumnList\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableSchemaDefinitionColumnList Column
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableSchemaDefinitionColumnList>()!;
        }

        [JsiiProperty(name: "partitionKey", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKeyList\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableSchemaDefinitionPartitionKeyList PartitionKey
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableSchemaDefinitionPartitionKeyList>()!;
        }

        [JsiiProperty(name: "staticColumn", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumnList\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableSchemaDefinitionStaticColumnList StaticColumn
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableSchemaDefinitionStaticColumnList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusteringKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClusteringKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ColumnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PartitionKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "staticColumnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StaticColumnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinition\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableSchemaDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableSchemaDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
