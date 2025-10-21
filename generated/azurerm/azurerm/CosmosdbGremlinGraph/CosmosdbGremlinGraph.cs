using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph azurerm_cosmosdb_gremlin_graph}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraph", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConfig\"}}]")]
    public class CosmosdbGremlinGraph : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph azurerm_cosmosdb_gremlin_graph} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CosmosdbGremlinGraph(Constructs.Construct scope, string id, azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbGremlinGraph(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbGremlinGraph(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CosmosdbGremlinGraph resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CosmosdbGremlinGraph to import.</param>
        /// <param name="importFromId">The id of the existing CosmosdbGremlinGraph that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CosmosdbGremlinGraph to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CosmosdbGremlinGraph to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CosmosdbGremlinGraph that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CosmosdbGremlinGraph to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoscaleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphAutoscaleSettings\"}}]")]
        public virtual void PutAutoscaleSettings(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphAutoscaleSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphAutoscaleSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConflictResolutionPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicy\"}}]")]
        public virtual void PutConflictResolutionPolicy(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConflictResolutionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConflictResolutionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndexPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicy\"}}]")]
        public virtual void PutIndexPolicy(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUniqueKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUniqueKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphUniqueKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphUniqueKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphUniqueKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnalyticalStorageTtl")]
        public virtual void ResetAnalyticalStorageTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscaleSettings")]
        public virtual void ResetAutoscaleSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConflictResolutionPolicy")]
        public virtual void ResetConflictResolutionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTtl")]
        public virtual void ResetDefaultTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexPolicy")]
        public virtual void ResetIndexPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitionKeyVersion")]
        public virtual void ResetPartitionKeyVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThroughput")]
        public virtual void ResetThroughput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUniqueKey")]
        public virtual void ResetUniqueKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph))!;

        [JsiiProperty(name: "autoscaleSettings", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphAutoscaleSettingsOutputReference\"}")]
        public virtual azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphAutoscaleSettingsOutputReference AutoscaleSettings
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphAutoscaleSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "conflictResolutionPolicy", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicyOutputReference\"}")]
        public virtual azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicyOutputReference ConflictResolutionPolicy
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "indexPolicy", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyOutputReference\"}")]
        public virtual azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyOutputReference IndexPolicy
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphTimeoutsOutputReference\"}")]
        public virtual azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueKey", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKeyList\"}")]
        public virtual azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKeyList UniqueKey
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKeyList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticalStorageTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AnalyticalStorageTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscaleSettingsInput", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphAutoscaleSettings\"}", isOptional: true)]
        public virtual azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphAutoscaleSettings? AutoscaleSettingsInput
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphAutoscaleSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionPolicyInput", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicy\"}", isOptional: true)]
        public virtual azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConflictResolutionPolicy? ConflictResolutionPolicyInput
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConflictResolutionPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexPolicyInput", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicy\"}", isOptional: true)]
        public virtual azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicy? IndexPolicyInput
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphIndexPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartitionKeyPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartitionKeyVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throughputInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThroughputInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uniqueKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UniqueKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "analyticalStorageTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AnalyticalStorageTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartitionKeyPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partitionKeyVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartitionKeyVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Throughput
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
