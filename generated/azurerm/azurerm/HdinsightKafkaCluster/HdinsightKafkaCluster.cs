using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster azurerm_hdinsight_kafka_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterConfig\"}}]")]
    public class HdinsightKafkaCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster azurerm_hdinsight_kafka_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HdinsightKafkaCluster(Constructs.Construct scope, string id, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightKafkaCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightKafkaCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a HdinsightKafkaCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HdinsightKafkaCluster to import.</param>
        /// <param name="importFromId">The id of the existing HdinsightKafkaCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HdinsightKafkaCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HdinsightKafkaCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HdinsightKafkaCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HdinsightKafkaCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComponentVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion\"}}]")]
        public virtual void PutComponentVersion(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComputeIsolation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolation\"}}]")]
        public virtual void PutComputeIsolation(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiskEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiskEncryption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterDiskEncryption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterDiskEncryption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterDiskEncryption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterExtension\"}}]")]
        public virtual void PutExtension(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGateway", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterGateway\"}}]")]
        public virtual void PutGateway(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetastores", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores\"}}]")]
        public virtual void PutMetastores(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMonitor\"}}]")]
        public virtual void PutMonitor(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterNetwork\"}}]")]
        public virtual void PutNetwork(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateLinkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration\"}}]")]
        public virtual void PutPrivateLinkConfiguration(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestProxy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxy\"}}]")]
        public virtual void PutRestProxy(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles\"}}]")]
        public virtual void PutRoles(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurityProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfile\"}}]")]
        public virtual void PutSecurityProfile(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccountGen2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2\"}}]")]
        public virtual void PutStorageAccountGen2(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetEncryptionInTransitEnabled")]
        public virtual void ResetEncryptionInTransitEnabled()
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

        [JsiiMethod(name: "resetRestProxy")]
        public virtual void ResetRestProxy()
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
        = GetStaticProperty<string>(typeof(azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster))!;

        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersionOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterComponentVersionOutputReference ComponentVersion
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterComponentVersionOutputReference>()!;
        }

        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolationOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolationOutputReference ComputeIsolation
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolationOutputReference>()!;
        }

        [JsiiProperty(name: "diskEncryption", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryptionList\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryptionList DiskEncryption
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryptionList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterExtensionOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterExtensionOutputReference Extension
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterExtensionOutputReference>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterGatewayOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterGatewayOutputReference Gateway
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "httpsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaRestProxyEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaRestProxyEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOutputReference Metastores
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOutputReference>()!;
        }

        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMonitorOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMonitorOutputReference Monitor
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMonitorOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterNetworkOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterNetworkOutputReference Network
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationOutputReference PrivateLinkConfiguration
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "restProxy", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxyOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRestProxyOutputReference RestProxy
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRestProxyOutputReference>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesOutputReference Roles
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesOutputReference>()!;
        }

        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfileOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfileOutputReference SecurityProfile
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfileOutputReference>()!;
        }

        [JsiiProperty(name: "sshEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountList\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountList>()!;
        }

        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2OutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2OutputReference StorageAccountGen2
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2OutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentVersionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion? ComponentVersionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeIsolationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolation\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation? ComputeIsolationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComputeIsolation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiskEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransitEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptionInTransitEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterExtension\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension? ExtensionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterExtension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterGateway\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway? GatewayInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterGateway?>();
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
        [JsiiProperty(name: "metastoresInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores? MetastoresInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMonitor\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor? MonitorInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMonitor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterNetwork\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork? NetworkInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateLinkConfigurationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration? PrivateLinkConfigurationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restProxyInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxy\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy? RestProxyInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles? RolesInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityProfileInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfile\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile? SecurityProfileInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountGen2Input", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2? StorageAccountGen2Input
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterStorageAccountGen2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "encryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EncryptionInTransitEnabled
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
