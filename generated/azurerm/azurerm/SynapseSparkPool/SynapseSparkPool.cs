using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool azurerm_synapse_spark_pool}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SynapseSparkPool.SynapseSparkPool), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolConfig\"}}]")]
    public class SynapseSparkPool : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool azurerm_synapse_spark_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SynapseSparkPool(Constructs.Construct scope, string id, azurerm.SynapseSparkPool.ISynapseSparkPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SynapseSparkPool.ISynapseSparkPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SynapseSparkPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SynapseSparkPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SynapseSparkPool resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SynapseSparkPool to import.</param>
        /// <param name="importFromId">The id of the existing SynapseSparkPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SynapseSparkPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SynapseSparkPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SynapseSparkPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SynapseSparkPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SynapseSparkPool.SynapseSparkPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoPause", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoPause\"}}]")]
        public virtual void PutAutoPause(azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoScale\"}}]")]
        public virtual void PutAutoScale(azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLibraryRequirement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement\"}}]")]
        public virtual void PutLibraryRequirement(azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSparkConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolSparkConfig\"}}]")]
        public virtual void PutSparkConfig(azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SynapseSparkPool.ISynapseSparkPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SynapseSparkPool.ISynapseSparkPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoPause")]
        public virtual void ResetAutoPause()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoScale")]
        public virtual void ResetAutoScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheSize")]
        public virtual void ResetCacheSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeIsolationEnabled")]
        public virtual void ResetComputeIsolationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamicExecutorAllocationEnabled")]
        public virtual void ResetDynamicExecutorAllocationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLibraryRequirement")]
        public virtual void ResetLibraryRequirement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxExecutors")]
        public virtual void ResetMaxExecutors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinExecutors")]
        public virtual void ResetMinExecutors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeCount")]
        public virtual void ResetNodeCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionLevelPackagesEnabled")]
        public virtual void ResetSessionLevelPackagesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSparkConfig")]
        public virtual void ResetSparkConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSparkEventsFolder")]
        public virtual void ResetSparkEventsFolder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSparkLogFolder")]
        public virtual void ResetSparkLogFolder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.SynapseSparkPool.SynapseSparkPool))!;

        [JsiiProperty(name: "autoPause", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoPauseOutputReference\"}")]
        public virtual azurerm.SynapseSparkPool.SynapseSparkPoolAutoPauseOutputReference AutoPause
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.SynapseSparkPoolAutoPauseOutputReference>()!;
        }

        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoScaleOutputReference\"}")]
        public virtual azurerm.SynapseSparkPool.SynapseSparkPoolAutoScaleOutputReference AutoScale
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.SynapseSparkPoolAutoScaleOutputReference>()!;
        }

        [JsiiProperty(name: "libraryRequirement", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirementOutputReference\"}")]
        public virtual azurerm.SynapseSparkPool.SynapseSparkPoolLibraryRequirementOutputReference LibraryRequirement
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.SynapseSparkPoolLibraryRequirementOutputReference>()!;
        }

        [JsiiProperty(name: "sparkConfig", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolSparkConfigOutputReference\"}")]
        public virtual azurerm.SynapseSparkPool.SynapseSparkPoolSparkConfigOutputReference SparkConfig
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.SynapseSparkPoolSparkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolTimeoutsOutputReference\"}")]
        public virtual azurerm.SynapseSparkPool.SynapseSparkPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.SynapseSparkPoolTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoPauseInput", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoPause\"}", isOptional: true)]
        public virtual azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause? AutoPauseInput
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScaleInput", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolAutoScale\"}", isOptional: true)]
        public virtual azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale? AutoScaleInput
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CacheSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeIsolationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ComputeIsolationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamicExecutorAllocationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DynamicExecutorAllocationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "libraryRequirementInput", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement\"}", isOptional: true)]
        public virtual azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement? LibraryRequirementInput
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxExecutorsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxExecutorsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minExecutorsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinExecutorsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeSizeFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeSizeFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionLevelPackagesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SessionLevelPackagesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkConfigInput", typeJson: "{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolSparkConfig\"}", isOptional: true)]
        public virtual azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig? SparkConfigInput
        {
            get => GetInstanceProperty<azurerm.SynapseSparkPool.ISynapseSparkPoolSparkConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkEventsFolderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparkEventsFolderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkLogFolderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparkLogFolderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparkVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "synapseWorkspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SynapseWorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.synapseSparkPool.SynapseSparkPoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cacheSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeIsolationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ComputeIsolationEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "dynamicExecutorAllocationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DynamicExecutorAllocationEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxExecutors
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinExecutors
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeSizeFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeSizeFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionLevelPackagesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SessionLevelPackagesEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "sparkEventsFolder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkEventsFolder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparkLogFolder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkLogFolder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "synapseWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SynapseWorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
