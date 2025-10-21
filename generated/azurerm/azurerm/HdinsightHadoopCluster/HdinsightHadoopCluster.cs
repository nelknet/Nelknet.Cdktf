using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster azurerm_hdinsight_hadoop_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterConfig\"}}]")]
    public class HdinsightHadoopCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster azurerm_hdinsight_hadoop_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HdinsightHadoopCluster(Constructs.Construct scope, string id, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHadoopCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHadoopCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a HdinsightHadoopCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HdinsightHadoopCluster to import.</param>
        /// <param name="importFromId">The id of the existing HdinsightHadoopCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HdinsightHadoopCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HdinsightHadoopCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HdinsightHadoopCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HdinsightHadoopCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComponentVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion\"}}]")]
        public virtual void PutComponentVersion(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComputeIsolation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComputeIsolation\"}}]")]
        public virtual void PutComputeIsolation(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComputeIsolation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComputeIsolation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiskEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterDiskEncryption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiskEncryption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterDiskEncryption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterDiskEncryption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterDiskEncryption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterExtension\"}}]")]
        public virtual void PutExtension(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterExtension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterExtension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGateway", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterGateway\"}}]")]
        public virtual void PutGateway(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterGateway @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterGateway)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetastores", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastores\"}}]")]
        public virtual void PutMetastores(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastores @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastores)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMonitor\"}}]")]
        public virtual void PutMonitor(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMonitor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMonitor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterNetwork\"}}]")]
        public virtual void PutNetwork(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateLinkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfiguration\"}}]")]
        public virtual void PutPrivateLinkConfiguration(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRoles\"}}]")]
        public virtual void PutRoles(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurityProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterSecurityProfile\"}}]")]
        public virtual void PutSecurityProfile(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterSecurityProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterSecurityProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccountGen2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2\"}}]")]
        public virtual void PutStorageAccountGen2(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccountGen2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccountGen2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComputeIsolation")]
        public virtual void ResetComputeIsolation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskEncryption")]
        public virtual void ResetDiskEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtension")]
        public virtual void ResetExtension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetastores")]
        public virtual void ResetMetastores()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitor")]
        public virtual void ResetMonitor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateLinkConfiguration")]
        public virtual void ResetPrivateLinkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityProfile")]
        public virtual void ResetSecurityProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccount")]
        public virtual void ResetStorageAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccountGen2")]
        public virtual void ResetStorageAccountGen2()
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

        [JsiiMethod(name: "resetTlsMinVersion")]
        public virtual void ResetTlsMinVersion()
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
        = GetStaticProperty<string>(typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster))!;

        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersionOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComponentVersionOutputReference ComponentVersion
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComponentVersionOutputReference>()!;
        }

        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComputeIsolationOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComputeIsolationOutputReference ComputeIsolation
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComputeIsolationOutputReference>()!;
        }

        [JsiiProperty(name: "diskEncryption", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterDiskEncryptionList\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterDiskEncryptionList DiskEncryption
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterDiskEncryptionList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterExtensionOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterExtensionOutputReference Extension
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterExtensionOutputReference>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterGatewayOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterGatewayOutputReference Gateway
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "httpsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterMetastoresOutputReference Metastores
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterMetastoresOutputReference>()!;
        }

        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMonitorOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterMonitorOutputReference Monitor
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterMonitorOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterNetworkOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterNetworkOutputReference Network
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfigurationOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfigurationOutputReference PrivateLinkConfiguration
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesOutputReference Roles
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesOutputReference>()!;
        }

        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterSecurityProfileOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterSecurityProfileOutputReference SecurityProfile
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterSecurityProfileOutputReference>()!;
        }

        [JsiiProperty(name: "sshEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountList\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountList>()!;
        }

        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2OutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2OutputReference StorageAccountGen2
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2OutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentVersionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion? ComponentVersionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeIsolationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComputeIsolation\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComputeIsolation? ComputeIsolationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComputeIsolation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiskEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterExtension\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterExtension? ExtensionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterExtension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterGateway\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterGateway? GatewayInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterGateway?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "metastoresInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastores? MetastoresInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastores?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMonitor\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMonitor? MonitorInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMonitor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterNetwork\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterNetwork? NetworkInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateLinkConfigurationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfiguration? PrivateLinkConfigurationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles? RolesInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityProfileInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterSecurityProfile\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterSecurityProfile? SecurityProfileInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterSecurityProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountGen2Input", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccountGen2? StorageAccountGen2Input
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccountGen2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsMinVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsMinVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterVersion
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

        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsMinVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
