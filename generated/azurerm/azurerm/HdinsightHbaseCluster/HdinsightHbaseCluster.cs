using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster azurerm_hdinsight_hbase_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterConfig\"}}]")]
    public class HdinsightHbaseCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster azurerm_hdinsight_hbase_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HdinsightHbaseCluster(Constructs.Construct scope, string id, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHbaseCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHbaseCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a HdinsightHbaseCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HdinsightHbaseCluster to import.</param>
        /// <param name="importFromId">The id of the existing HdinsightHbaseCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HdinsightHbaseCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HdinsightHbaseCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HdinsightHbaseCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HdinsightHbaseCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComponentVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComponentVersion\"}}]")]
        public virtual void PutComponentVersion(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComponentVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComponentVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComputeIsolation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolation\"}}]")]
        public virtual void PutComputeIsolation(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComputeIsolation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComputeIsolation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiskEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterDiskEncryption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiskEncryption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterDiskEncryption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterDiskEncryption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterDiskEncryption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterExtension\"}}]")]
        public virtual void PutExtension(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterExtension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterExtension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGateway", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterGateway\"}}]")]
        public virtual void PutGateway(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterGateway @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterGateway)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetastores", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastores\"}}]")]
        public virtual void PutMetastores(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMonitor\"}}]")]
        public virtual void PutMonitor(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMonitor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMonitor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterNetwork\"}}]")]
        public virtual void PutNetwork(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateLinkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfiguration\"}}]")]
        public virtual void PutPrivateLinkConfiguration(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRoles\"}}]")]
        public virtual void PutRoles(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurityProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterSecurityProfile\"}}]")]
        public virtual void PutSecurityProfile(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterSecurityProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterSecurityProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccountGen2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2\"}}]")]
        public virtual void PutStorageAccountGen2(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccountGen2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccountGen2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster))!;

        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComponentVersionOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterComponentVersionOutputReference ComponentVersion
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterComponentVersionOutputReference>()!;
        }

        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolationOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolationOutputReference ComputeIsolation
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolationOutputReference>()!;
        }

        [JsiiProperty(name: "diskEncryption", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterDiskEncryptionList\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterDiskEncryptionList DiskEncryption
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterDiskEncryptionList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterExtensionOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterExtensionOutputReference Extension
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterExtensionOutputReference>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterGatewayOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterGatewayOutputReference Gateway
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "httpsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOutputReference Metastores
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOutputReference>()!;
        }

        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMonitorOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMonitorOutputReference Monitor
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMonitorOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterNetworkOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterNetworkOutputReference Network
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationOutputReference PrivateLinkConfiguration
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesOutputReference Roles
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesOutputReference>()!;
        }

        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterSecurityProfileOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterSecurityProfileOutputReference SecurityProfile
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterSecurityProfileOutputReference>()!;
        }

        [JsiiProperty(name: "sshEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountList\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountList>()!;
        }

        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2OutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2OutputReference StorageAccountGen2
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2OutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentVersionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComponentVersion\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComponentVersion? ComponentVersionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComponentVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeIsolationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolation\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComputeIsolation? ComputeIsolationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComputeIsolation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiskEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterExtension\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterExtension? ExtensionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterExtension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterGateway\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterGateway? GatewayInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterGateway?>();
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
        [JsiiProperty(name: "metastoresInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores? MetastoresInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMonitor\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMonitor? MonitorInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMonitor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterNetwork\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterNetwork? NetworkInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateLinkConfigurationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfiguration? PrivateLinkConfigurationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles? RolesInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityProfileInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterSecurityProfile\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterSecurityProfile? SecurityProfileInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterSecurityProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountGen2Input", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccountGen2? StorageAccountGen2Input
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccountGen2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterTimeouts\"}]}}", isOptional: true)]
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
