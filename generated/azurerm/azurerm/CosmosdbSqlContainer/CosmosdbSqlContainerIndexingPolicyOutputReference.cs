using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyOutputReference), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbSqlContainerIndexingPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbSqlContainerIndexingPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CosmosdbSqlContainerIndexingPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbSqlContainerIndexingPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompositeIndex", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndex\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCompositeIndex(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExcludedPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExcludedPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyExcludedPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyExcludedPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyExcludedPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIncludedPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyIncludedPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIncludedPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyIncludedPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyIncludedPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyIncludedPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpatialIndex", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndex\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSpatialIndex(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompositeIndex")]
        public virtual void ResetCompositeIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludedPath")]
        public virtual void ResetExcludedPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludedPath")]
        public virtual void ResetIncludedPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexingMode")]
        public virtual void ResetIndexingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpatialIndex")]
        public virtual void ResetSpatialIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "compositeIndex", typeJson: "{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndexList\"}")]
        public virtual azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndexList CompositeIndex
        {
            get => GetInstanceProperty<azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndexList>()!;
        }

        [JsiiProperty(name: "excludedPath", typeJson: "{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPathList\"}")]
        public virtual azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPathList ExcludedPath
        {
            get => GetInstanceProperty<azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPathList>()!;
        }

        [JsiiProperty(name: "includedPath", typeJson: "{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyIncludedPathList\"}")]
        public virtual azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyIncludedPathList IncludedPath
        {
            get => GetInstanceProperty<azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyIncludedPathList>()!;
        }

        [JsiiProperty(name: "spatialIndex", typeJson: "{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndexList\"}")]
        public virtual azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndexList SpatialIndex
        {
            get => GetInstanceProperty<azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndexList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compositeIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CompositeIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExcludedPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includedPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyIncludedPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IncludedPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spatialIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SpatialIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "indexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicy\"}", isOptional: true)]
        public virtual azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
