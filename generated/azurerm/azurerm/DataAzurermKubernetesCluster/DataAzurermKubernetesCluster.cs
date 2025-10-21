using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster azurerm_kubernetes_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster), fullyQualifiedName: "azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterConfig\"}}]")]
    public class DataAzurermKubernetesCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster azurerm_kubernetes_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermKubernetesCluster(Constructs.Construct scope, string id, azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKubernetesCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKubernetesCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermKubernetesCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermKubernetesCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermKubernetesCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermKubernetesCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermKubernetesCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermKubernetesCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermKubernetesCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster))!;

        [JsiiProperty(name: "aciConnectorLinux", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterAciConnectorLinuxList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAciConnectorLinuxList AciConnectorLinux
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAciConnectorLinuxList>()!;
        }

        [JsiiProperty(name: "agentPoolProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileList AgentPoolProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileList>()!;
        }

        [JsiiProperty(name: "apiServerAuthorizedIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApiServerAuthorizedIpRanges
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "azureActiveDirectoryRoleBasedAccessControl", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlList AzureActiveDirectoryRoleBasedAccessControl
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlList>()!;
        }

        [JsiiProperty(name: "azurePolicyEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AzurePolicyEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "currentKubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentKubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskEncryptionSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpApplicationRoutingEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HttpApplicationRoutingEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "httpApplicationRoutingZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpApplicationRoutingZoneName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterIdentityList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterIdentityList>()!;
        }

        [JsiiProperty(name: "ingressApplicationGateway", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterIngressApplicationGatewayList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterIngressApplicationGatewayList IngressApplicationGateway
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterIngressApplicationGatewayList>()!;
        }

        [JsiiProperty(name: "keyManagementService", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterKeyManagementServiceList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKeyManagementServiceList KeyManagementService
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKeyManagementServiceList>()!;
        }

        [JsiiProperty(name: "keyVaultSecretsProvider", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterKeyVaultSecretsProviderList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKeyVaultSecretsProviderList KeyVaultSecretsProvider
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKeyVaultSecretsProviderList>()!;
        }

        [JsiiProperty(name: "kubeAdminConfig", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeAdminConfigList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeAdminConfigList KubeAdminConfig
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeAdminConfigList>()!;
        }

        [JsiiProperty(name: "kubeAdminConfigRaw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeAdminConfigRaw
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeConfigList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeConfigList KubeConfig
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeConfigList>()!;
        }

        [JsiiProperty(name: "kubeConfigRaw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeConfigRaw
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeletIdentity", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeletIdentityList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeletIdentityList KubeletIdentity
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterKubeletIdentityList>()!;
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linuxProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterLinuxProfileList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterLinuxProfileList LinuxProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterLinuxProfileList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "microsoftDefender", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterMicrosoftDefenderList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterMicrosoftDefenderList MicrosoftDefender
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterMicrosoftDefenderList>()!;
        }

        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterNetworkProfileList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterNetworkProfileList NetworkProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterNetworkProfileList>()!;
        }

        [JsiiProperty(name: "nodeResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeResourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oidcIssuerEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable OidcIssuerEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "oidcIssuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OidcIssuerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "omsAgent", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterOmsAgentList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterOmsAgentList OmsAgent
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterOmsAgentList>()!;
        }

        [JsiiProperty(name: "openServiceMeshEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable OpenServiceMeshEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "privateClusterEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PrivateClusterEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "privateFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleBasedAccessControlEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RoleBasedAccessControlEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "serviceMeshProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterServiceMeshProfileList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterServiceMeshProfileList ServiceMeshProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterServiceMeshProfileList>()!;
        }

        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterServicePrincipalList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterServicePrincipalList ServicePrincipal
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterServicePrincipalList>()!;
        }

        [JsiiProperty(name: "storageProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterStorageProfileList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterStorageProfileList StorageProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterStorageProfileList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "windowsProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterWindowsProfileList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterWindowsProfileList WindowsProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterWindowsProfileList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
