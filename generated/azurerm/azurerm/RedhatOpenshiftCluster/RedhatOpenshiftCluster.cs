using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster azurerm_redhat_openshift_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterConfig\"}}]")]
    public class RedhatOpenshiftCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster azurerm_redhat_openshift_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RedhatOpenshiftCluster(Constructs.Construct scope, string id, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedhatOpenshiftCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedhatOpenshiftCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a RedhatOpenshiftCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the RedhatOpenshiftCluster to import.</param>
        /// <param name="importFromId">The id of the existing RedhatOpenshiftCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the RedhatOpenshiftCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the RedhatOpenshiftCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing RedhatOpenshiftCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the RedhatOpenshiftCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApiServerProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfile\"}}]")]
        public virtual void PutApiServerProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClusterProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfile\"}}]")]
        public virtual void PutClusterProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIngressProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile\"}}]")]
        public virtual void PutIngressProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMainProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterMainProfile\"}}]")]
        public virtual void PutMainProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfile\"}}]")]
        public virtual void PutNetworkProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServicePrincipal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipal\"}}]")]
        public virtual void PutServicePrincipal(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfile\"}}]")]
        public virtual void PutWorkerProfile(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster))!;

        [JsiiProperty(name: "apiServerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfileOutputReference ApiServerProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfileOutputReference>()!;
        }

        [JsiiProperty(name: "clusterProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfileOutputReference ClusterProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfileOutputReference>()!;
        }

        [JsiiProperty(name: "consoleUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsoleUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ingressProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfileOutputReference IngressProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfileOutputReference>()!;
        }

        [JsiiProperty(name: "mainProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterMainProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterMainProfileOutputReference MainProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterMainProfileOutputReference>()!;
        }

        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileOutputReference NetworkProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileOutputReference>()!;
        }

        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipalOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipalOutputReference ServicePrincipal
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipalOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfileOutputReference\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfileOutputReference WorkerProfile
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiServerProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile? ApiServerProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile? ClusterProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile? IngressProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mainProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterMainProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile? MainProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile? NetworkProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipal\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal? ServicePrincipalInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerProfileInput", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile? WorkerProfileInput
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
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
