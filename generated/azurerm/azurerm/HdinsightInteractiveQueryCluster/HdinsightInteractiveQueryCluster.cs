using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster azurerm_hdinsight_interactive_query_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterConfig\"}}]")]
    public class HdinsightInteractiveQueryCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster azurerm_hdinsight_interactive_query_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HdinsightInteractiveQueryCluster(Constructs.Construct scope, string id, azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightInteractiveQueryCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightInteractiveQueryCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a HdinsightInteractiveQueryCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the HdinsightInteractiveQueryCluster to import.</param>
        /// <param name="importFromId">The id of the existing HdinsightInteractiveQueryCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the HdinsightInteractiveQueryCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the HdinsightInteractiveQueryCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing HdinsightInteractiveQueryCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the HdinsightInteractiveQueryCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComponentVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersion\"}}]")]
        public virtual void PutComponentVersion(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComputeIsolation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolation\"}}]")]
        public virtual void PutComputeIsolation(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiskEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiskEncryption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterDiskEncryption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterDiskEncryption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterDiskEncryption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtension\"}}]")]
        public virtual void PutExtension(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGateway", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGateway\"}}]")]
        public virtual void PutGateway(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetastores", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores\"}}]")]
        public virtual void PutMetastores(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitor\"}}]")]
        public virtual void PutMonitor(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetwork\"}}]")]
        public virtual void PutNetwork(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateLinkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfiguration\"}}]")]
        public virtual void PutPrivateLinkConfiguration(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRoles\"}}]")]
        public virtual void PutRoles(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurityProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfile\"}}]")]
        public virtual void PutSecurityProfile(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccountGen2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2\"}}]")]
        public virtual void PutStorageAccountGen2(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster))!;

        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersionOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersionOutputReference ComponentVersion
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersionOutputReference>()!;
        }

        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolationOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolationOutputReference ComputeIsolation
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolationOutputReference>()!;
        }

        [JsiiProperty(name: "diskEncryption", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryptionList\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryptionList DiskEncryption
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryptionList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtensionOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtensionOutputReference Extension
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtensionOutputReference>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGatewayOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGatewayOutputReference Gateway
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "httpsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresOutputReference Metastores
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresOutputReference>()!;
        }

        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitorOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitorOutputReference Monitor
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitorOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetworkOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetworkOutputReference Network
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfigurationOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfigurationOutputReference PrivateLinkConfiguration
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesOutputReference Roles
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesOutputReference>()!;
        }

        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfileOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfileOutputReference SecurityProfile
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfileOutputReference>()!;
        }

        [JsiiProperty(name: "sshEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountList\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountList>()!;
        }

        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2OutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2OutputReference StorageAccountGen2
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2OutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentVersionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersion\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion? ComponentVersionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeIsolationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolation\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation? ComputeIsolationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "extensionInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtension\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension? ExtensionInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGateway\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway? GatewayInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway?>();
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
        [JsiiProperty(name: "metastoresInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores? MetastoresInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitor\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor? MonitorInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetwork\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork? NetworkInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateLinkConfigurationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration? PrivateLinkConfigurationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles? RolesInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityProfileInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfile\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile? SecurityProfileInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountGen2Input", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2? StorageAccountGen2Input
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeouts\"}]}}", isOptional: true)]
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
