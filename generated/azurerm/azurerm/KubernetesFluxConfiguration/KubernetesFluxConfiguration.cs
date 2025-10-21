using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFluxConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration azurerm_kubernetes_flux_configuration}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration), fullyQualifiedName: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationConfig\"}}]")]
    public class KubernetesFluxConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration azurerm_kubernetes_flux_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesFluxConfiguration(Constructs.Construct scope, string id, azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesFluxConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesFluxConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KubernetesFluxConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KubernetesFluxConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing KubernetesFluxConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KubernetesFluxConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KubernetesFluxConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KubernetesFluxConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KubernetesFluxConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorage\"}}]")]
        public virtual void PutBlobStorage(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBucket\"}}]")]
        public virtual void PutBucket(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitRepository", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationGitRepository\"}}]")]
        public virtual void PutGitRepository(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationGitRepository @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationGitRepository)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKustomizations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKustomizations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlobStorage")]
        public virtual void ResetBlobStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContinuousReconciliationEnabled")]
        public virtual void ResetContinuousReconciliationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitRepository")]
        public virtual void ResetGitRepository()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScope")]
        public virtual void ResetScope()
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
        = GetStaticProperty<string>(typeof(azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration))!;

        [JsiiProperty(name: "blobStorage", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorageOutputReference\"}")]
        public virtual azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorageOutputReference BlobStorage
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorageOutputReference>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBucketOutputReference\"}")]
        public virtual azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationBucketOutputReference Bucket
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationBucketOutputReference>()!;
        }

        [JsiiProperty(name: "gitRepository", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationGitRepositoryOutputReference\"}")]
        public virtual azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationGitRepositoryOutputReference GitRepository
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationGitRepositoryOutputReference>()!;
        }

        [JsiiProperty(name: "kustomizations", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsList\"}")]
        public virtual azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsList Kustomizations
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationTimeoutsOutputReference\"}")]
        public virtual azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blobStorageInput", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorage\"}", isOptional: true)]
        public virtual azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBlobStorage? BlobStorageInput
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationBucket\"}", isOptional: true)]
        public virtual azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBucket? BucketInput
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationBucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "continuousReconciliationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ContinuousReconciliationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitRepositoryInput", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationGitRepository\"}", isOptional: true)]
        public virtual azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationGitRepository? GitRepositoryInput
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationGitRepository?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kustomizationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KustomizationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "continuousReconciliationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ContinuousReconciliationEnabled
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
