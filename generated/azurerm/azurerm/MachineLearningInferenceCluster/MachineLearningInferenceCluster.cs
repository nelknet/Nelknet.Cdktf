using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningInferenceCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster azurerm_machine_learning_inference_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster), fullyQualifiedName: "azurerm.machineLearningInferenceCluster.MachineLearningInferenceCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterConfig\"}}]")]
    public class MachineLearningInferenceCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster azurerm_machine_learning_inference_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MachineLearningInferenceCluster(Constructs.Construct scope, string id, azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningInferenceCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningInferenceCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MachineLearningInferenceCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MachineLearningInferenceCluster to import.</param>
        /// <param name="importFromId">The id of the existing MachineLearningInferenceCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MachineLearningInferenceCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MachineLearningInferenceCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MachineLearningInferenceCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MachineLearningInferenceCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterSsl\"}}]")]
        public virtual void PutSsl(azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterSsl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterSsl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterPurpose")]
        public virtual void ResetClusterPurpose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsl")]
        public virtual void ResetSsl()
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
        = GetStaticProperty<string>(typeof(azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterIdentityOutputReference\"}")]
        public virtual azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterSslOutputReference\"}")]
        public virtual azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterSslOutputReference Ssl
        {
            get => GetInstanceProperty<azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterSslOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPurposeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterPurposeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterIdentity\"}", isOptional: true)]
        public virtual azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KubernetesClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "machineLearningWorkspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MachineLearningWorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslInput", typeJson: "{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterSsl\"}", isOptional: true)]
        public virtual azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterSsl? SslInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterSsl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterPurpose", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPurpose
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kubernetesClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "machineLearningWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MachineLearningWorkspaceId
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
